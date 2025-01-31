﻿using Gherkin;
using Netstr.Messaging.Models;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;

namespace Netstr.Tests
{
    public static class WebSocketExtensions
    {
        public static async Task SendAsync(this WebSocket ws, object[] message, CancellationToken? cancellationToken = null)
        {
            var token = cancellationToken ?? CancellationToken.None;
            await ws.SendAsync(JsonSerializer.SerializeToUtf8Bytes(message), WebSocketMessageType.Text, true, token);
        }

        public static Task SendReqAsync(this WebSocket ws, string id, IEnumerable<SubscriptionFilterRequest> filters, CancellationToken? cancellationToken = null)
        {
            return ws.SendAsync([
                "REQ",
                id,
                ..filters
            ], cancellationToken);
        }


        public static Task SendCountAsync(this WebSocket ws, string id, IEnumerable<SubscriptionFilterRequest> filters, CancellationToken? cancellationToken = null)
        {
            return ws.SendAsync([
                "COUNT",
                id,
                ..filters
            ], cancellationToken);
        }

        public static Task SendEventAsync(this WebSocket ws, Event e, CancellationToken? cancellationToken = null)
        {
            return ws.SendAsync([
                "EVENT",
                e
            ], cancellationToken);
        }

        public static Task SendAuthAsync(this WebSocket ws, Event e, CancellationToken? cancellationToken = null)
        {
            return ws.SendAsync([
                "AUTH",
                e
            ], cancellationToken);
        }

        public static Task SendCloseAsync(this WebSocket ws, string id, CancellationToken? cancellationToken = null)
        {
            return ws.SendAsync([
                "CLOSE",
                id
            ], cancellationToken);
        }

        public static Task SendNegentropyOpenAsync(this WebSocket ws, string id, SubscriptionFilterRequest filter, string msg, CancellationToken? cancellationToken = null)
        {
            return ws.SendAsync([
                "NEG-OPEN",
                id,
                filter,
                msg
            ], cancellationToken);
        }

        public static Task SendNegentropyMessageAsync(this WebSocket ws, string id, string msg, CancellationToken? cancellationToken = null)
        {
            return ws.SendAsync([
                "NEG-MSG",
                id,
                msg
            ], cancellationToken);
        }

        public static Task SendNegentropyCloseAsync(this WebSocket ws, string id, CancellationToken? cancellationToken = null)
        {
            return ws.SendAsync([
                "NEG-CLOSE",
                id,
            ], cancellationToken);
        }

        public static async Task ReceiveAsync(this WebSocket ws, Action<JsonElement[]> action, CancellationToken? cancellationToken = null)
        {
            var token = cancellationToken ?? CancellationToken.None;

            try
            {
                while (ws.State == WebSocketState.Open)
                {
                    var buffer = new ArraySegment<byte>(new byte[65536]);

                    using var stream = new MemoryStream();
                    using var reader = new StreamReader(stream, Encoding.UTF8);

                    while (true)
                    {
                        var result = await ws.ReceiveAsync(buffer, token);
                        stream.Write(buffer.Array, buffer.Offset, result.Count);
                        if (result.EndOfMessage) break;
                    }

                    stream.Seek(0, SeekOrigin.Begin);

                    var data = await reader.ReadToEndAsync();
                    var obj = JsonSerializer.Deserialize<JsonElement[]>(data);

                    if (obj == null)
                    {
                        throw new JsonException($"Couldn't deserialize response '{data}'");
                    }

                    action(obj);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public static Task<JsonElement[]> ReceiveOnceAsync(this WebSocket ws, CancellationToken? cancellationToken = null)
        {
            var cancellation = new CancellationTokenSource();
            var tcs = new TaskCompletionSource<JsonElement[]>();
            
            if (cancellationToken.HasValue)
            {
                cancellationToken.Value.Register(() => 
                {
                    if (tcs.TrySetException(new TaskCanceledException()))
                    {
                        cancellation.Cancel();
                    }
                });
            }

            _ = ws.ReceiveAsync(x =>
            {
                tcs.SetResult(x);
                cancellation.Cancel();
            }, cancellation.Token);

            return tcs.Task;
        }
    }
}
