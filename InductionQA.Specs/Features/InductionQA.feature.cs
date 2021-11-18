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
namespace InductionQA.Specs.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Induction QA Automation", SourceFile="Features\\InductionQA.feature", SourceLine=0)]
    public partial class InductionQAAutomationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "InductionQA.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Induction QA Automation", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void BuyingTicketAirForLondon(string day, string vip, string finalValue, string initialValue, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("day", day);
            argumentsOfScenario.Add("vip", vip);
            argumentsOfScenario.Add("finalValue", finalValue);
            argumentsOfScenario.Add("initialValue", initialValue);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Buying ticket air for London", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
 testRunner.Given("i want go to London", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.And(string.Format("be a day of {0}", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 7
 testRunner.And(string.Format("{0} vip customer {1}", vip, initialValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
 testRunner.When("i do the payment", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.Then(string.Format("i will pay {0}", finalValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buying ticket air for London, Variant 0", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void BuyingTicketAirForLondon_Variant0()
        {
#line 4
this.BuyingTicketAirForLondon("0", "i am", "80", "100", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buying ticket air for London, Variant 1", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void BuyingTicketAirForLondon_Variant1()
        {
#line 4
this.BuyingTicketAirForLondon("0", "i am not", "100", "100", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buying ticket air for London, Variant 2", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void BuyingTicketAirForLondon_Variant2()
        {
#line 4
this.BuyingTicketAirForLondon("1", "i am", "16", "20", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buying ticket air for London, Variant 3", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void BuyingTicketAirForLondon_Variant3()
        {
#line 4
this.BuyingTicketAirForLondon("1", "i am not", "20", "20", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buying ticket air for London, Variant 4", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void BuyingTicketAirForLondon_Variant4()
        {
#line 4
this.BuyingTicketAirForLondon("2", "i am", "16", "20", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buying ticket air for London, Variant 5", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void BuyingTicketAirForLondon_Variant5()
        {
#line 4
this.BuyingTicketAirForLondon("2", "i am not", "20", "20", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buying ticket air for London, Variant 6", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void BuyingTicketAirForLondon_Variant6()
        {
#line 4
this.BuyingTicketAirForLondon("3", "i am", "16", "20", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buying ticket air for London, Variant 7", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void BuyingTicketAirForLondon_Variant7()
        {
#line 4
this.BuyingTicketAirForLondon("3", "i am not", "20", "20", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buying ticket air for London, Variant 8", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void BuyingTicketAirForLondon_Variant8()
        {
#line 4
this.BuyingTicketAirForLondon("4", "i am", "40", "50", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buying ticket air for London, Variant 9", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void BuyingTicketAirForLondon_Variant9()
        {
#line 4
this.BuyingTicketAirForLondon("4", "i am not", "50", "50", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buying ticket air for London, Variant 10", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void BuyingTicketAirForLondon_Variant10()
        {
#line 4
this.BuyingTicketAirForLondon("5", "i am", "40", "50", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buying ticket air for London, Variant 11", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void BuyingTicketAirForLondon_Variant11()
        {
#line 4
this.BuyingTicketAirForLondon("5", "i am not", "50", "50", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buying ticket air for London, Variant 12", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void BuyingTicketAirForLondon_Variant12()
        {
#line 4
this.BuyingTicketAirForLondon("6", "i am", "80", "100", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Buying ticket air for London, Variant 13", new string[] {
                "mytag"}, SourceLine=12)]
        public virtual void BuyingTicketAirForLondon_Variant13()
        {
#line 4
this.BuyingTicketAirForLondon("6", "i am not", "100", "100", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion