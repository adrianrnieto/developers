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
namespace ExchangeRateUpdater.Integration.Tests.Features.Api.ExchangeRates
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Xunit.TraitAttribute("Category", "ExchangeRates")]
    [Xunit.TraitAttribute("Category", "CzechNationalBankApi")]
    [Xunit.TraitAttribute("Category", "Cache")]
    public partial class GetFeature : object, Xunit.IClassFixture<GetFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "ExchangeRates",
                "CzechNationalBankApi",
                "Cache"};
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "Get.feature"
#line hidden
        
        public GetFeature(GetFeature.FixtureData fixtureData, ExchangeRateUpdater_Integration_Tests_XUnitAssemblyFixture assemblyFixture, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Api/ExchangeRates", "Get", null, ProgrammingLanguage.CSharp, featureTags);
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
        
        void System.IDisposable.Dispose()
        {
            this.TestTearDown();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Get all exchange rates retrieves a list of all exchange rates supported by the ap" +
            "plication")]
        [Xunit.TraitAttribute("FeatureTitle", "Get")]
        [Xunit.TraitAttribute("Description", "Get all exchange rates retrieves a list of all exchange rates supported by the ap" +
            "plication")]
        [Xunit.TraitAttribute("Category", "HappyPath")]
        public void GetAllExchangeRatesRetrievesAListOfAllExchangeRatesSupportedByTheApplication()
        {
            string[] tagsOfScenario = new string[] {
                    "HappyPath"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Get all exchange rates retrieves a list of all exchange rates supported by the ap" +
                    "plication", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 5
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 6
 testRunner.Given("Czech National Bank Api is able to retrieve the exchange rates", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.When("all exchange rates are requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.Then("HttpStatus 200 is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 9
 testRunner.And("a call to Czech National Bank Api to get the exchange rates is done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And("all Czech National Bank exchange rates are stored in cache", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And("response is", @"   {
     ""exchangeRates"": [
       {
         ""sourceCurrency"": {
           ""code"": ""EUR""
         },
         ""targetCurrency"": {
           ""code"": ""CZK""
         },
         ""value"": 25.005
       },
       {
         ""sourceCurrency"": {
           ""code"": ""JPY""
         },
         ""targetCurrency"": {
           ""code"": ""CZK""
         },
         ""value"": 0.15021
       },
       {
         ""sourceCurrency"": {
           ""code"": ""THB""
         },
         ""targetCurrency"": {
           ""code"": ""CZK""
         },
         ""value"": 0.63008
       },
       {
         ""sourceCurrency"": {
           ""code"": ""TRY""
         },
         ""targetCurrency"": {
           ""code"": ""CZK""
         },
         ""value"": 0.71979
       },
       {
         ""sourceCurrency"": {
           ""code"": ""USD""
         },
         ""targetCurrency"": {
           ""code"": ""CZK""
         },
         ""value"": 23.223
       }
     ]
   }", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Exchange rates are retrieved from cache the second time are requested")]
        [Xunit.TraitAttribute("FeatureTitle", "Get")]
        [Xunit.TraitAttribute("Description", "Exchange rates are retrieved from cache the second time are requested")]
        [Xunit.TraitAttribute("Category", "HappyPath")]
        public void ExchangeRatesAreRetrievedFromCacheTheSecondTimeAreRequested()
        {
            string[] tagsOfScenario = new string[] {
                    "HappyPath"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Exchange rates are retrieved from cache the second time are requested", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 65
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 66
 testRunner.Given("Czech National Bank Api is able to retrieve the exchange rates", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 67
 testRunner.When("all exchange rates are requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
    testRunner.When("all exchange rates are requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.Then("HttpStatus 200 is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 70
 testRunner.And("only one call to Czech National Bank Api to get the exchange rates is done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.And("all Czech National Bank exchange rates are stored in cache", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("response is", @"   {
     ""exchangeRates"": [
       {
         ""sourceCurrency"": {
           ""code"": ""EUR""
         },
         ""targetCurrency"": {
           ""code"": ""CZK""
         },
         ""value"": 25.005
       },
       {
         ""sourceCurrency"": {
           ""code"": ""JPY""
         },
         ""targetCurrency"": {
           ""code"": ""CZK""
         },
         ""value"": 0.15021
       },
       {
         ""sourceCurrency"": {
           ""code"": ""THB""
         },
         ""targetCurrency"": {
           ""code"": ""CZK""
         },
         ""value"": 0.63008
       },
       {
         ""sourceCurrency"": {
           ""code"": ""TRY""
         },
         ""targetCurrency"": {
           ""code"": ""CZK""
         },
         ""value"": 0.71979
       },
       {
         ""sourceCurrency"": {
           ""code"": ""USD""
         },
         ""targetCurrency"": {
           ""code"": ""CZK""
         },
         ""value"": 23.223
       }
     ]
   }", ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Internal Server Error is returned when Czech National Bank Api is down")]
        [Xunit.TraitAttribute("FeatureTitle", "Get")]
        [Xunit.TraitAttribute("Description", "Internal Server Error is returned when Czech National Bank Api is down")]
        [Xunit.TraitAttribute("Category", "UnhappyPath")]
        public void InternalServerErrorIsReturnedWhenCzechNationalBankApiIsDown()
        {
            string[] tagsOfScenario = new string[] {
                    "UnhappyPath"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Internal Server Error is returned when Czech National Bank Api is down", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 126
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 127
 testRunner.Given("Czech National Bank Api fails to retrieve the exchange rates", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 128
 testRunner.When("all exchange rates are requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 129
 testRunner.Then("HttpStatus 500 is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 130
 testRunner.Then("a call to Czech National Bank Api to get the exchange rates is done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 131
 testRunner.And("no Czech National Bank exchange rates are added to the cache", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Xunit.SkippableFactAttribute(DisplayName="Request Timeout is returned when Czech National Bank Api times out")]
        [Xunit.TraitAttribute("FeatureTitle", "Get")]
        [Xunit.TraitAttribute("Description", "Request Timeout is returned when Czech National Bank Api times out")]
        [Xunit.TraitAttribute("Category", "UnhappyPath")]
        public void RequestTimeoutIsReturnedWhenCzechNationalBankApiTimesOut()
        {
            string[] tagsOfScenario = new string[] {
                    "UnhappyPath"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Request Timeout is returned when Czech National Bank Api times out", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 134
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 135
 testRunner.Given("Czech National Bank Api times out when retrieving the exchange rates", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 136
 testRunner.When("all exchange rates are requested", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 137
 testRunner.Then("HttpStatus 408 is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 138
 testRunner.Then("a call to Czech National Bank Api to get the exchange rates is done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 139
 testRunner.And("no Czech National Bank exchange rates are added to the cache", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
                GetFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                GetFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion