﻿
using Microsoft.Extensions.Options;
using Netstr.Options;

namespace Netstr.RelayInformation
{
    public interface IRelayInformationService
    {
        RelayInformationModel GetDocument();
    }

    public class RelayInformationService : IRelayInformationService
    {
        private readonly IOptions<RelayInformationOptions> options;
        private readonly IOptions<LimitsOptions> limits;

        public RelayInformationService(IOptions<RelayInformationOptions> options, IOptions<LimitsOptions> limits)
        {
            this.options = options;
            this.limits = limits;
        }

        public RelayInformationModel GetDocument()
        {
            var version = GetType().Assembly.GetName().Version?.ToString();
            var opts = this.options.Value;

            return new RelayInformationModel
            {
                Name = opts.Description ?? RelayInformationDefaults.Name,
                Description = opts.Description ?? RelayInformationDefaults.Description,
                PublicKey = opts.PublicKey,
                Contact = opts.Contact,
                SupportedNips = opts.SupportedNips ?? [],
                Software = RelayInformationDefaults.Software,
                SoftwareVersion = version,
                Limits = new()
                {
                    MinPowDifficulty = this.limits.Value.MinPowDifficulty
                }
            };
        }
    }
}
