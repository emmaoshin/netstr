﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Netstr.Tests.NIPs
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class NIP_62Feature : object, Xunit.IClassFixture<NIP_62Feature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "62.feature"
#line hidden
        
        public NIP_62Feature(NIP_62Feature.FixtureData fixtureData, Netstr_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "NIPs", "NIP-62", "\tNostr-native way to request a complete reset of a key\'s fingerprint on the web. " +
                    "\r\n\tThis procedure is legally binding in some jurisdictions, and thus, supporters" +
                    " of this NIP should truly delete events from their database.", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
#line hidden
#line 6
 testRunner.Given("a relay is running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table127 = new TechTalk.SpecFlow.Table(new string[] {
                        "PublicKey",
                        "PrivateKey"});
            table127.AddRow(new string[] {
                        "5758137ec7f38f3d6c3ef103e28cd9312652285dab3497fe5e5f6c5c0ef45e75",
                        "512a14752ed58380496920da432f1c0cdad952cd4afda3d9bfa51c2051f91b02"});
#line 7
 testRunner.And("Alice is connected to relay", ((string)(null)), table127, "And ");
#line hidden
            TechTalk.SpecFlow.Table table128 = new TechTalk.SpecFlow.Table(new string[] {
                        "PublicKey",
                        "PrivateKey"});
            table128.AddRow(new string[] {
                        "5bc683a5d12133a96ac5502c15fe1c2287986cff7baf6283600360e6bb01f627",
                        "3551fc7617f76632e4542992c0bc01fecb224de639c4b6a1e0956946e8bb8a29"});
#line 10
 testRunner.And("Bob is connected to relay", ((string)(null)), table128, "And ");
#line hidden
            TechTalk.SpecFlow.Table table129 = new TechTalk.SpecFlow.Table(new string[] {
                        "PublicKey",
                        "PrivateKey"});
            table129.AddRow(new string[] {
                        "fe8d7a5726ea97ce6140f9fb06b1fe7d3259bcbf8de42c2a5d2ec9f8f0e2f614",
                        "f77f81a6a223eb15f81fee569161a4f729401a9cbc31bb69fef6a949b9d3c23a"});
#line 13
 testRunner.And("Charlie is connected to relay", ((string)(null)), table129, "And ");
#line hidden
        }
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Request to Vanish deletes user\'s data")]
        [Xunit.TraitAttribute("FeatureTitle", "NIP-62")]
        [Xunit.TraitAttribute("Description", "Request to Vanish deletes user\'s data")]
        public void RequestToVanishDeletesUsersData()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Request to Vanish deletes user\'s data", "\tOnly requestor\'s data is deleted, including GiftWraps where they are tagged\r\n\tOn" +
                    "ly events from before the request\'s createdAt timestamp is deleted\r\n\tNo-one else" +
                    "\'s events are deleted", tagsOfScenario, argumentsOfScenario, featureTags);
#line 17
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table130 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id",
                            "Content",
                            "Kind",
                            "Tags",
                            "CreatedAt"});
                table130.AddRow(new string[] {
                            "1e4ef30065360dd8ba6a4b74c99b6d70447946fa17e31e2960f12d3d7a9fb643",
                            "Hello",
                            "1",
                            "",
                            "1728905459"});
                table130.AddRow(new string[] {
                            "bb5d31b0522faee9582dfede36a042a3209dc297f34c4850f2de3bbef05ad957",
                            "Hello Later",
                            "1",
                            "",
                            "1728905481"});
                table130.AddRow(new string[] {
                            "5c19b5808ee4ad3d31e4129cc112679147e28f3d88e24683a3afa327ba0a2ee8",
                            "DM",
                            "1059",
                            "[[\"p\",\"5758137ec7f38f3d6c3ef103e28cd9312652285dab3497fe5e5f6c5c0ef45e75\"]]",
                            "1728905459"});
                table130.AddRow(new string[] {
                            "78a1df26e6e30633663934dfb6da696184497ee98964aeae87292aae54bf166f",
                            "DM Late",
                            "1059",
                            "[[\"p\",\"5758137ec7f38f3d6c3ef103e28cd9312652285dab3497fe5e5f6c5c0ef45e75\"]]",
                            "1728905480"});
#line 21
 testRunner.When("Bob publishes events", ((string)(null)), table130, "When ");
#line hidden
                TechTalk.SpecFlow.Table table131 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id",
                            "Content",
                            "Kind",
                            "Tags",
                            "CreatedAt"});
                table131.AddRow(new string[] {
                            "ff1092c354d94060a185f8b5e4349499079872babe27b882fd4632efcdd001c2",
                            "Hello",
                            "1",
                            "",
                            "1728905459"});
                table131.AddRow(new string[] {
                            "f45c291b8c4e3a164e68932f251e50b4182f4dfe2eca76081a7ca2d759568dfd",
                            "Hello Later",
                            "1",
                            "",
                            "1728905480"});
                table131.AddRow(new string[] {
                            "9766e0efe45ecd90c508e66a8dd3eee3a7f16be33af87aded9fc779f40237d0e",
                            "I\'m outta here",
                            "62",
                            "[[\"relay\",\"ALL_RELAYS\"]]",
                            "1728905470"});
#line 27
 testRunner.When("Alice publishes events", ((string)(null)), table131, "When ");
#line hidden
                TechTalk.SpecFlow.Table table132 = new TechTalk.SpecFlow.Table(new string[] {
                            "Authors"});
                table132.AddRow(new string[] {
                            "5758137ec7f38f3d6c3ef103e28cd9312652285dab3497fe5e5f6c5c0ef45e75,5bc683a5d12133a9" +
                                "6ac5502c15fe1c2287986cff7baf6283600360e6bb01f627"});
#line 32
 testRunner.And("Charlie sends a subscription request abcd", ((string)(null)), table132, "And ");
#line hidden
                TechTalk.SpecFlow.Table table133 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "Id",
                            "EventId"});
                table133.AddRow(new string[] {
                            "EVENT",
                            "abcd",
                            "bb5d31b0522faee9582dfede36a042a3209dc297f34c4850f2de3bbef05ad957"});
                table133.AddRow(new string[] {
                            "EVENT",
                            "abcd",
                            "78a1df26e6e30633663934dfb6da696184497ee98964aeae87292aae54bf166f"});
                table133.AddRow(new string[] {
                            "EVENT",
                            "abcd",
                            "f45c291b8c4e3a164e68932f251e50b4182f4dfe2eca76081a7ca2d759568dfd"});
                table133.AddRow(new string[] {
                            "EVENT",
                            "abcd",
                            "9766e0efe45ecd90c508e66a8dd3eee3a7f16be33af87aded9fc779f40237d0e"});
                table133.AddRow(new string[] {
                            "EVENT",
                            "abcd",
                            "1e4ef30065360dd8ba6a4b74c99b6d70447946fa17e31e2960f12d3d7a9fb643"});
                table133.AddRow(new string[] {
                            "EOSE",
                            "abcd",
                            ""});
#line 35
 testRunner.Then("Charlie receives messages", ((string)(null)), table133, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Old events published after Request to Vanish are rejected")]
        [Xunit.TraitAttribute("FeatureTitle", "NIP-62")]
        [Xunit.TraitAttribute("Description", "Old events published after Request to Vanish are rejected")]
        public void OldEventsPublishedAfterRequestToVanishAreRejected()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Old events published after Request to Vanish are rejected", "\tAfter Request to Vanish events older than it cannot be re-published. Newer ones " +
                    "can be published normally.", tagsOfScenario, argumentsOfScenario, featureTags);
#line 44
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table134 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id",
                            "Content",
                            "Kind",
                            "Tags",
                            "CreatedAt"});
                table134.AddRow(new string[] {
                            "ff1092c354d94060a185f8b5e4349499079872babe27b882fd4632efcdd001c2",
                            "Hello",
                            "1",
                            "",
                            "1728905459"});
                table134.AddRow(new string[] {
                            "9766e0efe45ecd90c508e66a8dd3eee3a7f16be33af87aded9fc779f40237d0e",
                            "I\'m outta here",
                            "62",
                            "[[\"relay\",\"ALL_RELAYS\"]]",
                            "1728905470"});
                table134.AddRow(new string[] {
                            "ff1092c354d94060a185f8b5e4349499079872babe27b882fd4632efcdd001c2",
                            "Hello",
                            "1",
                            "",
                            "1728905459"});
                table134.AddRow(new string[] {
                            "f45c291b8c4e3a164e68932f251e50b4182f4dfe2eca76081a7ca2d759568dfd",
                            "Hello Later",
                            "1",
                            "",
                            "1728905480"});
#line 46
 testRunner.When("Alice publishes events", ((string)(null)), table134, "When ");
#line hidden
                TechTalk.SpecFlow.Table table135 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "EventId",
                            "Success"});
                table135.AddRow(new string[] {
                            "OK",
                            "ff1092c354d94060a185f8b5e4349499079872babe27b882fd4632efcdd001c2",
                            "true"});
                table135.AddRow(new string[] {
                            "OK",
                            "9766e0efe45ecd90c508e66a8dd3eee3a7f16be33af87aded9fc779f40237d0e",
                            "true"});
                table135.AddRow(new string[] {
                            "OK",
                            "ff1092c354d94060a185f8b5e4349499079872babe27b882fd4632efcdd001c2",
                            "false"});
                table135.AddRow(new string[] {
                            "OK",
                            "f45c291b8c4e3a164e68932f251e50b4182f4dfe2eca76081a7ca2d759568dfd",
                            "true"});
#line 52
 testRunner.Then("Alice receives messages", ((string)(null)), table135, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Deleting Request to Vanish is rejected")]
        [Xunit.TraitAttribute("FeatureTitle", "NIP-62")]
        [Xunit.TraitAttribute("Description", "Deleting Request to Vanish is rejected")]
        public void DeletingRequestToVanishIsRejected()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Deleting Request to Vanish is rejected", "\tPublishing a deletion request event (Kind 5) against a request to vanish has no " +
                    "effect. \r\n\tClients and relays are not obliged to support \"unrequest vanish\" func" +
                    "tionality.", tagsOfScenario, argumentsOfScenario, featureTags);
#line 59
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table136 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id",
                            "Content",
                            "Kind",
                            "Tags",
                            "CreatedAt"});
                table136.AddRow(new string[] {
                            "9766e0efe45ecd90c508e66a8dd3eee3a7f16be33af87aded9fc779f40237d0e",
                            "I\'m outta here",
                            "62",
                            "[[\"relay\",\"ALL_RELAYS\"]]",
                            "1728905470"});
                table136.AddRow(new string[] {
                            "bb8db141cc129fd5fbc792f871bca9f14a04cfb80607feacd19698b4a7dd878a",
                            "",
                            "5",
                            "[[\"e\", \"9766e0efe45ecd90c508e66a8dd3eee3a7f16be33af87aded9fc779f40237d0e\"]]",
                            "1728905471"});
#line 62
 testRunner.When("Alice publishes events", ((string)(null)), table136, "When ");
#line hidden
                TechTalk.SpecFlow.Table table137 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "EventId",
                            "Success"});
                table137.AddRow(new string[] {
                            "OK",
                            "9766e0efe45ecd90c508e66a8dd3eee3a7f16be33af87aded9fc779f40237d0e",
                            "true"});
                table137.AddRow(new string[] {
                            "OK",
                            "bb8db141cc129fd5fbc792f871bca9f14a04cfb80607feacd19698b4a7dd878a",
                            "false"});
#line 66
 testRunner.Then("Alice receives messages", ((string)(null)), table137, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Older Request to Vanish does nothing, newer deletes newer events")]
        [Xunit.TraitAttribute("FeatureTitle", "NIP-62")]
        [Xunit.TraitAttribute("Description", "Older Request to Vanish does nothing, newer deletes newer events")]
        public void OlderRequestToVanishDoesNothingNewerDeletesNewerEvents()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Older Request to Vanish does nothing, newer deletes newer events", "\tFirst vanish request works as expected. \r\n\tSecond (older) one should be ignored " +
                    "and old events should still be rejetected.\r\n\tThird (newer) is accepted and its C" +
                    "reatedAt is used to reject old events.\r\n\tNewer events are still accepted.", tagsOfScenario, argumentsOfScenario, featureTags);
#line 71
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table138 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id",
                            "Content",
                            "Kind",
                            "Tags",
                            "CreatedAt"});
                table138.AddRow(new string[] {
                            "ff1092c354d94060a185f8b5e4349499079872babe27b882fd4632efcdd001c2",
                            "Hello",
                            "1",
                            "",
                            "1728905459"});
                table138.AddRow(new string[] {
                            "f45c291b8c4e3a164e68932f251e50b4182f4dfe2eca76081a7ca2d759568dfd",
                            "Hello Later",
                            "1",
                            "",
                            "1728905480"});
                table138.AddRow(new string[] {
                            "9766e0efe45ecd90c508e66a8dd3eee3a7f16be33af87aded9fc779f40237d0e",
                            "I\'m outta here",
                            "62",
                            "[[\"relay\",\"ALL_RELAYS\"]]",
                            "1728905470"});
                table138.AddRow(new string[] {
                            "2f965ea6c9d085a2c0a55b90e6b38ba8d3f64cc022bd0117fc529037bce93cc9",
                            "I\'m outta here sooner",
                            "62",
                            "[[\"relay\",\"ALL_RELAYS\"]]",
                            "1728905460"});
                table138.AddRow(new string[] {
                            "8ac0adbfb1340ac100e13f756dcd47e1ac23b84264147924c854351b8ddd1173",
                            "Hello",
                            "1",
                            "",
                            "1728905465"});
                table138.AddRow(new string[] {
                            "e2ccbd594526fe5c81144dc9d0ed1164757e21da3b6ce82486fa4bba81a86590",
                            "I\'m outta here later",
                            "62",
                            "[[\"relay\",\"ALL_RELAYS\"]]",
                            "1728905490"});
                table138.AddRow(new string[] {
                            "f45c291b8c4e3a164e68932f251e50b4182f4dfe2eca76081a7ca2d759568dfd",
                            "Hello Later",
                            "1",
                            "",
                            "1728905480"});
                table138.AddRow(new string[] {
                            "e4262ef3899cb75be630c2940897226d8dca15e81cc4588ed812c86e8bcdabbc",
                            "Hello",
                            "1",
                            "",
                            "1728905495"});
#line 76
 testRunner.When("Alice publishes events", ((string)(null)), table138, "When ");
#line hidden
                TechTalk.SpecFlow.Table table139 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "EventId",
                            "Success"});
                table139.AddRow(new string[] {
                            "OK",
                            "ff1092c354d94060a185f8b5e4349499079872babe27b882fd4632efcdd001c2",
                            "true"});
                table139.AddRow(new string[] {
                            "OK",
                            "f45c291b8c4e3a164e68932f251e50b4182f4dfe2eca76081a7ca2d759568dfd",
                            "true"});
                table139.AddRow(new string[] {
                            "OK",
                            "9766e0efe45ecd90c508e66a8dd3eee3a7f16be33af87aded9fc779f40237d0e",
                            "true"});
                table139.AddRow(new string[] {
                            "OK",
                            "2f965ea6c9d085a2c0a55b90e6b38ba8d3f64cc022bd0117fc529037bce93cc9",
                            "false"});
                table139.AddRow(new string[] {
                            "OK",
                            "8ac0adbfb1340ac100e13f756dcd47e1ac23b84264147924c854351b8ddd1173",
                            "false"});
                table139.AddRow(new string[] {
                            "OK",
                            "e2ccbd594526fe5c81144dc9d0ed1164757e21da3b6ce82486fa4bba81a86590",
                            "true"});
                table139.AddRow(new string[] {
                            "OK",
                            "f45c291b8c4e3a164e68932f251e50b4182f4dfe2eca76081a7ca2d759568dfd",
                            "false"});
                table139.AddRow(new string[] {
                            "OK",
                            "e4262ef3899cb75be630c2940897226d8dca15e81cc4588ed812c86e8bcdabbc",
                            "true"});
#line 86
 testRunner.Then("Alice receives messages", ((string)(null)), table139, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Request to Vanish is ignored when relay tag doesn\'t match current relay")]
        [Xunit.TraitAttribute("FeatureTitle", "NIP-62")]
        [Xunit.TraitAttribute("Description", "Request to Vanish is ignored when relay tag doesn\'t match current relay")]
        public void RequestToVanishIsIgnoredWhenRelayTagDoesntMatchCurrentRelay()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Request to Vanish is ignored when relay tag doesn\'t match current relay", "\tEvent is rejected for missing or incorrect relay tag.\r\n\tCorrect one assumes the " +
                    "connection is on ws://localhost/. Relay should be able to normalize its own URL " +
                    "and the one in tag (e.g. trim ws:// or wss://, trailing / etc)", tagsOfScenario, argumentsOfScenario, featureTags);
#line 97
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
this.FeatureBackground();
#line hidden
                TechTalk.SpecFlow.Table table140 = new TechTalk.SpecFlow.Table(new string[] {
                            "Id",
                            "Content",
                            "Kind",
                            "Tags",
                            "CreatedAt"});
                table140.AddRow(new string[] {
                            "95a19f740a0415634581033596cdc5596e43a41a9a73bf3775d37d32b6734b72",
                            "I\'m outta here",
                            "62",
                            "",
                            "1728905470"});
                table140.AddRow(new string[] {
                            "7fbc1941a2a9c07931ad62510283464ff69c8b2a386f47c129a6aecc4e350adc",
                            "I\'m outta here",
                            "62",
                            "[[\"relay\",\"blabla\"]]",
                            "1728905470"});
                table140.AddRow(new string[] {
                            "845c4d3df838caaf98e45c06578a2dea7c77d384e43bfc27d239b121e6320020",
                            "I\'m outta here",
                            "62",
                            "[[\"relay\",\"ws://localhost/\"]]",
                            "1728905470"});
#line 100
 testRunner.When("Alice publishes events", ((string)(null)), table140, "When ");
#line hidden
                TechTalk.SpecFlow.Table table141 = new TechTalk.SpecFlow.Table(new string[] {
                            "Type",
                            "EventId",
                            "Success"});
                table141.AddRow(new string[] {
                            "OK",
                            "95a19f740a0415634581033596cdc5596e43a41a9a73bf3775d37d32b6734b72",
                            "false"});
                table141.AddRow(new string[] {
                            "OK",
                            "7fbc1941a2a9c07931ad62510283464ff69c8b2a386f47c129a6aecc4e350adc",
                            "false"});
                table141.AddRow(new string[] {
                            "OK",
                            "845c4d3df838caaf98e45c06578a2dea7c77d384e43bfc27d239b121e6320020",
                            "true"});
#line 105
 testRunner.Then("Alice receives messages", ((string)(null)), table141, "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                NIP_62Feature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                NIP_62Feature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
