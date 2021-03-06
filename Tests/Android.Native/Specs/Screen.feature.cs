﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.3.0
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34014
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Tests.Android.Native.Specs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.3.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Screen actions")]
    [NUnit.Framework.CategoryAttribute("android")]
    public partial class ScreenActionsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Screen.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Screen actions", "  In order to use the app\r\nAs a user\r\nI want to be launch and close the app", ProgrammingLanguage.CSharp, new string[] {
                        "android"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
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
        
        public virtual void FeatureBackground()
        {
#line 7
#line 8
testRunner.Given("I launch the \"Api Demo App\" mobile application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Launching the app should be on main screen")]
        public virtual void LaunchingTheAppShouldBeOnMainScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Launching the app should be on main screen", ((string[])(null)));
#line 10
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 11
testRunner.Then("I should be on the \"Main\" screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Closing the app")]
        public virtual void ClosingTheApp()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Closing the app", ((string[])(null)));
#line 13
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 14
testRunner.When("I close the mobile application", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Rotate screen to proper orientation")]
        [NUnit.Framework.IgnoreAttribute()]
        [NUnit.Framework.TestCaseAttribute("landsape", null)]
        [NUnit.Framework.TestCaseAttribute("portrait", null)]
        public virtual void RotateScreenToProperOrientation(string orientation, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "ignore"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Rotate screen to proper orientation", @__tags);
#line 19
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 20
testRunner.Given("I wait for \"3\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
testRunner.When(string.Format("I rotate the screen to {0} orientation", orientation), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 22
testRunner.Then(string.Format("the screen should be on {0} orientation", orientation), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to App screen")]
        public virtual void NavigateToAppScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to App screen", ((string[])(null)));
#line 29
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 30
testRunner.When("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
testRunner.Then("I should be on the \"App\" screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to back to Main screen")]
        public virtual void NavigateToBackToMainScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to back to Main screen", ((string[])(null)));
#line 33
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 34
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 35
testRunner.When("I go back", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 36
testRunner.Then("I should be on the \"Main\" screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should not be on Activity screen")]
        public virtual void ShouldNotBeOnActivityScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should not be on Activity screen", ((string[])(null)));
#line 38
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 39
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 40
testRunner.Then("I should not be on the \"Activity\" screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to Activity screen")]
        public virtual void NavigateToActivityScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to Activity screen", ((string[])(null)));
#line 42
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 43
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 44
testRunner.When("I tap the \"Activity\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
testRunner.Then("I should be on the \"Activity\" screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to Custom Title screen")]
        public virtual void NavigateToCustomTitleScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to Custom Title screen", ((string[])(null)));
#line 47
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 48
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 49
testRunner.And("I tap the \"Activity\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
testRunner.When("I tap the \"Custom Title\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 51
testRunner.Then("I should be on the \"Custom Title\" screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to Animation screen")]
        public virtual void NavigateToAnimationScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to Animation screen", ((string[])(null)));
#line 53
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 54
testRunner.Given("I tap the \"Animation\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 55
testRunner.Then("I should be on the \"Animation\" screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to Default Layout Animations screen")]
        public virtual void NavigateToDefaultLayoutAnimationsScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to Default Layout Animations screen", ((string[])(null)));
#line 57
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 58
testRunner.Given("I tap the \"Animation\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 59
testRunner.When("I tap the \"Default Layout Animations\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 60
testRunner.Then("I should be on the \"Default Layout Animations\" screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to Fragment Screen")]
        public virtual void NavigateToFragmentScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to Fragment Screen", ((string[])(null)));
#line 62
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 63
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 64
testRunner.When("I tap the \"Fragment\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 65
testRunner.Then("I should be on the \"Fragment\" screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to Context Menu Screen")]
        public virtual void NavigateToContextMenuScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to Context Menu Screen", ((string[])(null)));
#line 67
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 68
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 69
testRunner.And("I tap the \"Fragment\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
testRunner.When("I tap the \"Context Menu\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 71
testRunner.Then("I should be on the \"Context Menu\" screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to the Long Screen")]
        public virtual void NavigateToTheLongScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to the Long Screen", ((string[])(null)));
#line 73
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 74
testRunner.Given("I scroll the screen down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 75
testRunner.And("I tap the \"Views\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
testRunner.And("I scroll the screen down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
testRunner.And("I tap the \"Layouts\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
testRunner.And("I tap the \"Scroll View\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
testRunner.When("I tap the \"Long\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
testRunner.Then("I should be on the \"Long\" screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to Quick Contact Demo Screen")]
        public virtual void NavigateToQuickContactDemoScreen()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to Quick Contact Demo Screen", ((string[])(null)));
#line 82
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 83
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 84
testRunner.And("I tap the \"Activity\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
testRunner.And("I scroll the screen down", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
testRunner.When("I tap the \"Quick Contacts Demo\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 87
testRunner.Then("I should be on the \"Quick Contacts Demo\" screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should see the following elements")]
        public virtual void ShouldSeeTheFollowingElements()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should see the following elements", ((string[])(null)));
#line 89
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 90
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Element"});
            table1.AddRow(new string[] {
                        "Activity"});
            table1.AddRow(new string[] {
                        "Fragment"});
            table1.AddRow(new string[] {
                        "Notification"});
#line 91
testRunner.Then("I should see the following elements", ((string)(null)), table1, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should not have the following elements present")]
        public virtual void ShouldNotHaveTheFollowingElementsPresent()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should not have the following elements present", ((string[])(null)));
#line 97
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 98
testRunner.Given("I tap the \"App\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 99
testRunner.When("I tap the \"Activity\" button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "Element"});
            table2.AddRow(new string[] {
                        "Quick Contacts Demo"});
#line 100
testRunner.Then("the following elements should not be present", ((string)(null)), table2, "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should see element Button equals text")]
        public virtual void ShouldSeeElementButtonEqualsText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should see element Button equals text", ((string[])(null)));
#line 104
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 105
testRunner.Then("I should see the text of element \"Animation\" equals \"Animation\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should see element Button starts with text")]
        public virtual void ShouldSeeElementButtonStartsWithText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should see element Button starts with text", ((string[])(null)));
#line 107
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 108
testRunner.Then("I should see the text of element \"Animation\" starts with \"Ani\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should see element Button containing text")]
        public virtual void ShouldSeeElementButtonContainingText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should see element Button containing text", ((string[])(null)));
#line 110
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 111
testRunner.Then("I should see the text of element \"Animation\" containing \"mation\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Should see element Button matching text")]
        public virtual void ShouldSeeElementButtonMatchingText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Should see element Button matching text", ((string[])(null)));
#line 113
this.ScenarioSetup(scenarioInfo);
#line 7
this.FeatureBackground();
#line 114
testRunner.Then("I should see the text of element \"Animation\" matching {tion$}", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
