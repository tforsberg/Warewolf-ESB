﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18052
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Dev2.Activities.Specs.Toolbox.Data.DataSplit
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class DataSplitFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "DataSplit.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "DataSplit", "In order to split data\r\nAs a Warewolf user\r\nI want a tool that splits two or more" +
                    " pieces of data", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((TechTalk.SpecFlow.FeatureContext.Current != null) 
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "DataSplit")))
            {
                Dev2.Activities.Specs.Toolbox.Data.DataSplit.DataSplitFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
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
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split text to a recordset using Index")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitTextToARecordsetUsingIndex()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split text to a recordset using Index", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("A string to split with value \"abcde\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("assign to variable \"[[vowels(*).letters]]\" split type \"Index\" at \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "vowels().letters"});
            table1.AddRow(new string[] {
                        "a"});
            table1.AddRow(new string[] {
                        "b"});
            table1.AddRow(new string[] {
                        "c"});
            table1.AddRow(new string[] {
                        "d"});
            table1.AddRow(new string[] {
                        "e"});
#line 11
 testRunner.Then("the split result will be", ((string)(null)), table1, "Then ");
#line 18
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split characters using Index Going Backwards")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitCharactersUsingIndexGoingBackwards()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split characters using Index Going Backwards", ((string[])(null)));
#line 20
this.ScenarioSetup(scenarioInfo);
#line 21
 testRunner.Given("A string to split with value \"@!?><\":}{+_)(*&^~\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 22
 testRunner.And("assign to variable \"[[vowels(*).chars]]\" split type \"Index\" at \"7\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("the direction is \"Backward\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "vowels().chars"});
            table2.AddRow(new string[] {
                        "_)(*&^~"});
            table2.AddRow(new string[] {
                        "><\":}{+"});
            table2.AddRow(new string[] {
                        "@!?"});
#line 25
 testRunner.Then("the split result will be", ((string)(null)), table2, "Then ");
#line 30
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split characters using Index Going Forward")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitCharactersUsingIndexGoingForward()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split characters using Index Going Forward", ((string[])(null)));
#line 32
this.ScenarioSetup(scenarioInfo);
#line 33
 testRunner.Given("A string to split with value \"@!?><\":}{+_)(*&^~\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 34
 testRunner.And("assign to variable \"[[vowels(*).chars]]\" split type \"Index\" at \"7\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("the direction is \"Forward\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "vowels().chars"});
            table3.AddRow(new string[] {
                        "@!?><\":"});
            table3.AddRow(new string[] {
                        "}{+_)(*"});
            table3.AddRow(new string[] {
                        "&^~"});
#line 37
 testRunner.Then("the split result will be", ((string)(null)), table3, "Then ");
#line 42
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split text using All split types - Some with Include selected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitTextUsingAllSplitTypes_SomeWithIncludeSelected()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split text using All split types - Some with Include selected", ((string[])(null)));
#line 46
this.ScenarioSetup(scenarioInfo);
#line 47
 testRunner.Given("A string to split with value \"IndexTab\tChars,space end\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 48
 testRunner.And("assign to variable \"[[vowels(*).letters]]\" split type \"Index\" at \"5\" and Include " +
                    "\"Selected\" and Escape \'\\\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("assign to variable \"[[vowels(*).letters]]\" split type \"Tab\" at \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("assign to variable \"[[vowels(*).letters]]\" split type \"Chars\" at \"ars,\" and Inclu" +
                    "de \"Selected\" and Escape \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.And("assign to variable \"[[vowels(*).letters]]\" split type \"Space\" at \"1\" and Include " +
                    "\"unselected\" and Escape \'\\\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.And("assign to variable \"[[vowels(*).letters]]\" split type \"End\" at \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "vowels().letters"});
            table4.AddRow(new string[] {
                        "Index"});
            table4.AddRow(new string[] {
                        "Tab"});
            table4.AddRow(new string[] {
                        "Chars,"});
            table4.AddRow(new string[] {
                        "space"});
            table4.AddRow(new string[] {
                        "end"});
#line 54
 testRunner.Then("the split result will be", ((string)(null)), table4, "Then ");
#line 61
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split CSV file format into recordset - some fields blank")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitCSVFileFormatIntoRecordset_SomeFieldsBlank()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split CSV file format into recordset - some fields blank", ((string[])(null)));
#line 63
this.ScenarioSetup(scenarioInfo);
#line 64
 testRunner.Given("A file \"CSVExample.txt\" to split", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 65
 testRunner.And("assign to variable \"[[rec().id]]\" split type \"Chars\" at \",\" and Include \"unselect" +
                    "ed\" and Escape \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
 testRunner.And("assign to variable \"[[rec().name]]\" split type \"Chars\" at \",\" and Include \"unsele" +
                    "cted\" and Escape \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.And("assign to variable \"\" split type \"Chars\" at \",\" and Include \"unselected\" and Esca" +
                    "pe \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.And("assign to variable \"[[rec().phone]]\" split type \"New Line\" at \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "rec().id",
                        "rec().name",
                        "rec().phone"});
            table5.AddRow(new string[] {
                        "ID",
                        "NAME",
                        "PHONE"});
            table5.AddRow(new string[] {
                        "1",
                        "Barney",
                        "1234"});
            table5.AddRow(new string[] {
                        "2",
                        "Tshepo",
                        "5678"});
            table5.AddRow(new string[] {
                        "",
                        "",
                        ""});
            table5.AddRow(new string[] {
                        "3",
                        "Mo",
                        ""});
#line 70
 testRunner.Then("the split result will be", ((string)(null)), table5, "Then ");
#line 77
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split CSV file format into recordset - Skip blank rows selected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitCSVFileFormatIntoRecordset_SkipBlankRowsSelected()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split CSV file format into recordset - Skip blank rows selected", ((string[])(null)));
#line 79
this.ScenarioSetup(scenarioInfo);
#line 80
 testRunner.Given("A file \"CSVExample.txt\" to split", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 81
 testRunner.And("assign to variable \"[[rec().id]]\" split type \"Chars\" at \",\" and Include \"unselect" +
                    "ed\" and Escape \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("assign to variable \"[[rec().name]]\" split type \"Chars\" at \",\" and Include \"unsele" +
                    "cted\" and Escape \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("assign to variable \"\" split type \"Chars\" at \",\" and Include \"unselected\" and Esca" +
                    "pe \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.And("assign to variable \"[[rec().phone]]\" split type \"New Line\" at \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.And("Skip Blanks rows is \"enabled\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "rec().id",
                        "rec().name",
                        "rec().phone"});
            table6.AddRow(new string[] {
                        "ID",
                        "NAME",
                        "PHONE"});
            table6.AddRow(new string[] {
                        "1",
                        "Barney",
                        "1234"});
            table6.AddRow(new string[] {
                        "2",
                        "Tshepo",
                        "5678"});
            table6.AddRow(new string[] {
                        "3",
                        "Mo",
                        "01"});
#line 87
 testRunner.Then("the split result will be", ((string)(null)), table6, "Then ");
#line 93
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split blank text using All split types")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitBlankTextUsingAllSplitTypes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split blank text using All split types", ((string[])(null)));
#line 95
this.ScenarioSetup(scenarioInfo);
#line 96
 testRunner.Given("A string to split with value \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 97
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type \"Index\" at \"5\" and Include \"" +
                    "Selected\" and Escape \'\\\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type \"Tab\" at \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 99
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type \"Chars\" at \"ars,\" and Includ" +
                    "e \"selected\" and Escape \'\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type \"Space\" at \"\" and Include \"u" +
                    "nselected\" and Escape \'\\\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type \"End\" at \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type \"NewLine\" at \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "vowels().letters"});
#line 104
 testRunner.Then("the split result will be", ((string)(null)), table7, "Then ");
#line 106
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split text using Index where index > provided")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitTextUsingIndexWhereIndexProvided()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split text using Index where index > provided", ((string[])(null)));
#line 108
this.ScenarioSetup(scenarioInfo);
#line 109
 testRunner.Given("A string to split with value \"123\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 110
 testRunner.And("assign to variable \"[[var]]\" split type \"Index\" at \",\" and Include \"Selected\" and" +
                    " Escape \'\\\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type \"Space\" at \"\" and Include \"u" +
                    "nselected\" and Escape \'\\\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 114
 testRunner.Then("the split result for \"[[var]]\" will be \"123\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 115
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split text using Char and Escape character")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitTextUsingCharAndEscapeCharacter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split text using Char and Escape character", ((string[])(null)));
#line 117
this.ScenarioSetup(scenarioInfo);
#line 118
 testRunner.Given("A string to split with value \"123|,45,1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 119
 testRunner.And("assign to variable \"[[var]]\" split type \"Chars\" at \",\" and Include \"Unselected\" a" +
                    "nd Escape \'|\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 120
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 121
 testRunner.Then("the split result for \"[[var]]\" will be \"123|,45\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 122
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split blank text")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitBlankText()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split blank text", ((string[])(null)));
#line 124
this.ScenarioSetup(scenarioInfo);
#line 125
 testRunner.Given("A string to split with value \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 126
 testRunner.And("assign to variable \"[[vowels(*).letters]]\" split type \"Index\" at \"1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 127
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "vowels().letters"});
#line 128
 testRunner.Then("the split result will be", ((string)(null)), table8, "Then ");
#line 130
 testRunner.And("the execution has \"NO\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split text to a recordset using a negative Index")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitTextToARecordsetUsingANegativeIndex()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split text to a recordset using a negative Index", ((string[])(null)));
#line 132
this.ScenarioSetup(scenarioInfo);
#line 133
 testRunner.Given("A string to split with value \"abcde\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 134
 testRunner.And("assign to variable \"[[vowels(*).letters]]\" split type \"Index\" at \"-1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "vowels().letters"});
#line 136
 testRunner.Then("the split result will be", ((string)(null)), table9, "Then ");
#line 138
 testRunner.And("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split negative record index as Input")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitNegativeRecordIndexAsInput()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split negative record index as Input", ((string[])(null)));
#line 140
this.ScenarioSetup(scenarioInfo);
#line 141
 testRunner.Given("A string to split with value \"[[my(-1).var]]\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 142
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type \"Index\" at \"5\" and Include \"" +
                    "Selected\" and Escape \'\\\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 143
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 144
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split text into negative recordset index")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitTextIntoNegativeRecordsetIndex()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split text into negative recordset index", ((string[])(null)));
#line 146
this.ScenarioSetup(scenarioInfo);
#line 147
 testRunner.Given("A string to split with value \"abcd\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 148
 testRunner.And("assign to variable \"[[vowels(-1).letters]]\" split type \"Index\" at \"5\" and Include" +
                    " \"Selected\" and Escape \'\\\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 149
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 150
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split text into negative recordset index as the index to split at")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitTextIntoNegativeRecordsetIndexAsTheIndexToSplitAt()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split text into negative recordset index as the index to split at", ((string[])(null)));
#line 152
this.ScenarioSetup(scenarioInfo);
#line 153
 testRunner.Given("A string to split with value \"abcd\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 154
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type \"Index\" at \"[[my(-1).index]]" +
                    "\" and Include \"Selected\" and Escape \'\\\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 155
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 156
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Split text using a negative recordset index as escape character")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "DataSplit")]
        public virtual void SplitTextUsingANegativeRecordsetIndexAsEscapeCharacter()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Split text using a negative recordset index as escape character", ((string[])(null)));
#line 158
this.ScenarioSetup(scenarioInfo);
#line 159
 testRunner.Given("A string to split with value \"abcd\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 160
 testRunner.And("assign to variable \"[[vowels().letters]]\" split type \"Index\" at \"2\" and Include \"" +
                    "Selected\" and Escape \'[[my(-1).escape]]\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 161
 testRunner.When("the data split tool is executed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 162
 testRunner.Then("the execution has \"AN\" error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
