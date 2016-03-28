﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.0.0.0
//      SpecFlow Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.FAQ.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class FAQFeature : Xunit.IClassFixture<FAQFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "FAQ.feature"
#line hidden
        
        public FAQFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "FAQ", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(FAQFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "FAQ")]
        [Xunit.TraitAttribute("Description", "FAQ_UC1_Add new questions")]
        [Xunit.TraitAttribute("Category", "InDesign")]
        public virtual void FAQ_UC1_AddNewQuestions()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("FAQ_UC1_Add new questions", new string[] {
                        "InDesign"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Under item path",
                        "Template ID",
                        "Item name",
                        "Question",
                        "Answer"});
            table1.AddRow(new string[] {
                        "/sitecore/content/Habitat/Global/FAQ",
                        "BFDC1F27-3D2D-495F-89A3-0951F882420B",
                        "FAQ3",
                        "Who is Kostas?",
                        "Kostas is kov@sitecore.net"});
            table1.AddRow(new string[] {
                        "/sitecore/content/Habitat/Global/FAQ",
                        "BFDC1F27-3D2D-495F-89A3-0951F882420B",
                        "FAQ4",
                        "What is DST?",
                        "DST is Demo Solution Team"});
#line 6
 testRunner.Given("New FAQ questions were created and added", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path",
                        "move item name"});
            table2.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/FAQ/FAQ Group",
                        "FAQ3"});
            table2.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/FAQ/FAQ Group",
                        "FAQ4"});
#line 10
 testRunner.When("User moves following items to selected in multilist field and saves changes", ((string)(null)), table2, "When ");
#line 14
 testRunner.And("User navigates to FAQ page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Answer"});
            table3.AddRow(new string[] {
                        "Who is Kostas?",
                        "Kostas is kov@sitecore.net"});
            table3.AddRow(new string[] {
                        "What is DST?",
                        "DST is Demo Solution Team"});
#line 15
 testRunner.Then("Following questions with answers should be present on FAQ page", ((string)(null)), table3, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "FAQ")]
        [Xunit.TraitAttribute("Description", "FAQ_UC2_Add new group")]
        [Xunit.TraitAttribute("Category", "InDesign")]
        public virtual void FAQ_UC2_AddNewGroup()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("FAQ_UC2_Add new group", new string[] {
                        "InDesign"});
#line 22
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Under item path",
                        "Template ID",
                        "Item name",
                        "Question",
                        "Answer"});
            table4.AddRow(new string[] {
                        "/sitecore/content/Habitat/Global/FAQ",
                        "BFDC1F27-3D2D-495F-89A3-0951F882420B",
                        "FAQ5",
                        "Who is MAN UTD fan?",
                        "Kostas is MAN UTD fan"});
#line 23
 testRunner.Given("New FAQ questions were created and added", ((string)(null)), table4, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "Under item path",
                        "Template ID",
                        "Item name"});
            table5.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/FAQ",
                        "BA1EB1BD-E705-4BE6-A432-06B7F1B2F2CC",
                        "FAQ Group 2"});
#line 26
 testRunner.When("New FAQ group was created", ((string)(null)), table5, "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path",
                        "move item name"});
            table6.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/FAQ/FAQ Group 2",
                        "FAQ5"});
#line 29
 testRunner.And("User moves following items to selected in multilist field and saves changes", ((string)(null)), table6, "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path",
                        "Control",
                        "Data Source"});
            table7.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/FAQ/",
                        "FAQ Accordion",
                        "/sitecore/content/Habitat/Home/Modules/Feature/FAQ/FAQ Group 2"});
#line 32
 testRunner.And("User defines final layout on page", ((string)(null)), table7, "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Answer"});
            table8.AddRow(new string[] {
                        "Who is MAN UTD fan?",
                        "Kostas is MAN UTD fan"});
#line 35
 testRunner.Then("Following questions with answers should be present on FAQ page", ((string)(null)), table8, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "FAQ")]
        [Xunit.TraitAttribute("Description", "FAQ_UC3_No questions available on page")]
        [Xunit.TraitAttribute("Category", "InDesign")]
        public virtual void FAQ_UC3_NoQuestionsAvailableOnPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("FAQ_UC3_No questions available on page", new string[] {
                        "InDesign"});
#line 41
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Under item path",
                        "Template ID",
                        "Item name"});
            table9.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/FAQ",
                        "BA1EB1BD-E705-4BE6-A432-06B7F1B2F2CC",
                        "FAQ Group 3"});
#line 42
 testRunner.Given("New FAQ group was created", ((string)(null)), table9, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "Item path",
                        "Control",
                        "Data Source"});
            table10.AddRow(new string[] {
                        "/sitecore/content/Habitat/Home/Modules/Feature/FAQ/",
                        "FAQ Accordion",
                        "/sitecore/content/Habitat/Home/Modules/Feature/FAQ/FAQ Group 2"});
#line 45
 testRunner.When("User defines final layout on page", ((string)(null)), table10, "When ");
#line hidden
            TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                        "Question",
                        "Answer"});
            table11.AddRow(new string[] {
                        "Who is MAN UTD fan?",
                        "Kostas is MAN UTD fan"});
            table11.AddRow(new string[] {
                        "Who is Kostas?",
                        "Kostas is kov@sitecore.net"});
            table11.AddRow(new string[] {
                        "What is DST?",
                        "DST is Demo Solution Team"});
#line 48
 testRunner.Then("Following questions with answers should not be present on FAQ page", ((string)(null)), table11, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                FAQFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                FAQFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
