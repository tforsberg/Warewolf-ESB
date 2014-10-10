﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34209
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Dev2.Studio.UI.Specs.ExplorerUISpecs
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UITesting.CodedUITestAttribute()]
    public partial class ExplorerUISpecsFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ExplorerUISpecs.feature"
#line hidden
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "ExplorerUISpecs", "In order to work with versions\r\nI want to know that versioning is working in the " +
                    "system\r\nSo that I can rollback, rename and delete with comfort.", ProgrammingLanguage.CSharp, ((string[])(null)));
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
                        && (TechTalk.SpecFlow.FeatureContext.Current.FeatureInfo.Title != "ExplorerUISpecs")))
            {
                Dev2.Studio.UI.Specs.ExplorerUISpecs.ExplorerUISpecsFeature.FeatureSetup(null);
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
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("CreateNewVersionANDRenameANDMakeOldVersionCurrentANDCheckDeployANDDeleteANDConfir" +
            "mReadOnlyANDHide")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ExplorerUISpecs")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("ExplorerUISpecs")]
        public virtual void CreateNewVersionANDRenameANDMakeOldVersionCurrentANDCheckDeployANDDeleteANDConfirmReadOnlyANDHide()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("CreateNewVersionANDRenameANDMakeOldVersionCurrentANDCheckDeployANDDeleteANDConfir" +
                    "mReadOnlyANDHide", new string[] {
                        "ExplorerUISpecs"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I have Warewolf running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And("all tabs are closed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("I click \"EXPLORERFILTERCLEARBUTTON\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("I click \"EXPLORER,UI_localhost_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
 testRunner.And("I click \"EXPLORERFOLDERS,UI_Examples_AutoID,UI_Recordset - Records Length_AutoID\"" +
                    "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
 testRunner.And("I double click \"EXPLORERFOLDERS,UI_Examples_AutoID,UI_Recordset - Records Length_" +
                    "AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
 testRunner.Then("\"WORKFLOWDESIGNER,Recordset - Records Length(FlowchartDesigner),Length1(RecordsLe" +
                    "ngthDesigner)\" is visible within \"2\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 16
 testRunner.When("I send \"{DELETE}\" to \"WORKFLOWDESIGNER,Recordset - Records Length(FlowchartDesign" +
                    "er),Length1(RecordsLengthDesigner)\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 17
 testRunner.And("I click \"RIBBONSAVE\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 18
 testRunner.And("I right click \"EXPLORERFOLDERS,UI_Examples_AutoID,UI_Recordset - Records Length_A" +
                    "utoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 19
 testRunner.And("I click \"UI_ToggleVersionHistoryContextMenuItem_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 20
 testRunner.And("\"EXPLORERFOLDERS,UI_Examples_AutoID,UI_Recordset - Records Length_AutoID,v.1*\" is" +
                    " visible within \"2\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
 testRunner.And("I right click \"EXPLORERFOLDERS,UI_Examples_AutoID,UI_Recordset - Records Length_A" +
                    "utoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
 testRunner.And("I click \"UI_RenameContextMenuItem_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.And("I type \"Recordset - Records Length RENAME\" in \"EXPLORERFOLDERS,UI_Examples_AutoID" +
                    ",UI_Recordset - Records Length_AutoID,UI_RenameTexbox_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 25
 testRunner.And("I send \"{ENTER}\" to \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
 testRunner.Then("\"EXPLORERFOLDERS,UI_Examples_AutoID,UI_Recordset - Records Length RENAME_AutoID\" " +
                    "is visible within \"1\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 27
 testRunner.And("\"EXPLORERFOLDERS,UI_Examples_AutoID,UI_Recordset - Records Length RENAME_AutoID,v" +
                    ".2*\" is visible within \"1\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.And("I right click \"EXPLORERFOLDERS,UI_Examples_AutoID,UI_Recordset - Records Length R" +
                    "ENAME_AutoID,v.1*\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
 testRunner.When("I click \"UI_RollbackContextMenuItem_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 31
 testRunner.And("I click \"UI_MessageBox_AutoID,UI_YesButton_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.Then("\"WORKFLOWDESIGNER,Recordset - Records Length(FlowchartDesigner),Length1(RecordsLe" +
                    "ngthDesigner)\" is visible within \"2\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 33
 testRunner.And("\"EXPLORERFOLDERS,UI_Examples_AutoID,UI_Recordset - Records Length_AutoID,v.3*\" is" +
                    " visible within \"1\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 35
 testRunner.And("I click \"RIBBONDEPLOY\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 36
 testRunner.Then("\"DEPLOYSOURCE,UI_SourceServer_UI_localhost_AutoID_AutoID,UI_SourceServer_UI_Examp" +
                    "les_AutoID_AutoID,UI_SourceServer_UI_Recordset - Records Length_AutoID_AutoID,v." +
                    "1*\" is invisible within \"3\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 37
 testRunner.And("all tabs are closed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.When("I right click \"EXPLORERFOLDERS,UI_Examples_AutoID,UI_Recordset - Records Length_A" +
                    "utoID,v.3*\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
 testRunner.And("I click \"UI_DeleteVersionContextMenuItem_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("I click \"UI_MessageBox_AutoID,UI_YesButton_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.Then("\"EXPLORERFOLDERS,UI_Examples_AutoID,UI_Recordset - Records Length_AutoID,v.3*\" is" +
                    " invisible within \"1\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
 testRunner.When("I double click \"EXPLORERFOLDERS,UI_Examples_AutoID,UI_Recordset - Records Length_" +
                    "AutoID,v.2*\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 45
 testRunner.Then("\"WORKFLOWDESIGNER,Recordset - Records Length(FlowchartDesigner)\" is visible withi" +
                    "n \"2\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 46
 testRunner.Then("\"RIBBONSAVE\" is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 47
 testRunner.Then("\"RIBBONDEBUG\" is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 49
 testRunner.And("I right click \"EXPLORERFOLDERS,UI_Examples_AutoID,UI_Recordset - Records Length_A" +
                    "utoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 50
 testRunner.And("I click \"UI_ToggleVersionHistoryContextMenuItem_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 51
 testRunner.Then("\"EXPLORERFOLDERS,UI_Examples_AutoID,UI_Recordset - Records Length_AutoID,v.2*\" is" +
                    " invisible within \"1\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 52
 testRunner.And("I close Studio", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 53
 testRunner.And("I close Server", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Saving A Workflow In NewFolder Is Saved And Delete Rename Works As Expected")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "ExplorerUISpecs")]
        public virtual void SavingAWorkflowInNewFolderIsSavedAndDeleteRenameWorksAsExpected()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Saving A Workflow In NewFolder Is Saved And Delete Rename Works As Expected", ((string[])(null)));
#line 73
this.ScenarioSetup(scenarioInfo);
#line 74
 testRunner.Given("I have Warewolf running", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 75
 testRunner.And("all tabs are closed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("I click \"EXPLORERFILTERCLEARBUTTON\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And("I click \"EXPLORER,UI_localhost_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("I click \"RIBBONNEWENDPOINT\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.And("I click \"RIBBONSAVE\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("\"WebBrowserWindow\" is visible within \"3\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("I send \"{TAB}{TAB}{Enter}\" to \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
 testRunner.And("I send \"UIFolder\" to \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 85
 testRunner.And("I click point \"304,305\" on \"WebBrowserWindow\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.And("I send \"{TAB}{TAB}{TAB}\" to \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 87
 testRunner.And("I send \"S1\" to \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.And("I click point \"400,415\" on \"WebBrowserWindow\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 89
 testRunner.And("\"EXPLORERFOLDERS,UI_UIFolder_AutoID,UI_S1_AutoID\" is visible within \"3\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 90
 testRunner.And("I click \"EXPLORERFOLDERS,UI_UIFolder_AutoID,UI_S1_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
 testRunner.And("I right click \"EXPLORERFOLDERS,UI_UIFolder_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
 testRunner.And("I click \"UI_RenameContextMenuItem_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.And("I type \"RENAME\" in \"EXPLORERFOLDERS,UI_UIFolder_AutoID,UI_RenameTexbox_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 95
 testRunner.And("I send \"{ENTER}\" to \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
 testRunner.Given("I click \"EXPLORERFOLDERS,UI_RENAME_AutoID,UI_S1_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 98
 testRunner.Then("\"EXPLORERFOLDERS,UI_RENAME_AutoID\" is visible within \"5\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
 testRunner.Then("\"EXPLORERFOLDERS,UI_RENAME_AutoID,UI_S1_AutoID\" is visible within \"1\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 101
 testRunner.And("I right click \"EXPLORERFOLDERS,UI_RENAME_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 102
 testRunner.And("I click \"UI_DeleteContextMenuItem_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 103
 testRunner.And("I click \"UI_MessageBox_AutoID,UI_YesButton_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 104
 testRunner.When("I send \"RENAME\" to \"EXPLORERFILTER\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 105
 testRunner.Given("\"EXPLORERFOLDERS,UI_RENAME_AutoID\" is invisible within \"5\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 106
 testRunner.And("I click \"RIBBONNEWENDPOINT\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
 testRunner.And("I click \"RIBBONSAVE\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
 testRunner.And("\"WebBrowserWindow\" is visible within \"3\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
 testRunner.And("I send \"{TAB}{TAB}{Enter}\" to \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 112
 testRunner.And("I send \"UIFolderFilter\" to \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
 testRunner.And("I click point \"304,305\" on \"WebBrowserWindow\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
 testRunner.And("I send \"{TAB}{TAB}{TAB}\" to \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
 testRunner.And("I send \"FilterTest\" to \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 116
 testRunner.And("I click point \"400,415\" on \"WebBrowserWindow\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
 testRunner.And("I click \"EXPLORERFILTERCLEARBUTTON\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 119
 testRunner.When("I send \"UIFolderFilter\" to \"EXPLORERFILTER\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 120
 testRunner.And("I right click \"EXPLORERFOLDERS,UI_UIFolderFilter_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 121
 testRunner.And("I click \"UI_RenameContextMenuItem_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 122
 testRunner.And("I type \"RENAME1\" in \"EXPLORERFOLDERS,UI_UIFolderFilter_AutoID,UI_RenameTexbox_Aut" +
                    "oID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 123
 testRunner.And("I send \"{ENTER}\" to \"\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 124
 testRunner.Given("I click \"EXPLORERFOLDERS,UI_RENAME1_AutoID,UI_FilterTest_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 126
 testRunner.Then("\"EXPLORERFOLDERS,UI_RENAME1_AutoID\" is visible within \"5\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 127
 testRunner.Then("\"EXPLORERFOLDERS,UI_RENAME1_AutoID,UI_FilterTest_AutoID\" is visible within \"1\" se" +
                    "conds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 129
 testRunner.And("I click \"EXPLORERFILTERCLEARBUTTON\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 130
 testRunner.Then("\"EXPLORERFOLDERS,UI_RENAME1_AutoID\" is visible within \"5\" seconds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 131
 testRunner.Then("\"EXPLORERFOLDERS,UI_RENAME1_AutoID,UI_FilterTest_AutoID\" is visible within \"1\" se" +
                    "conds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 132
 testRunner.When("I send \"RENAME1\" to \"EXPLORERFILTER\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 134
 testRunner.And("I right click \"EXPLORERFOLDERS,UI_RENAME1_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 135
 testRunner.And("I click \"UI_DeleteContextMenuItem_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 136
 testRunner.And("I click \"UI_MessageBox_AutoID,UI_YesButton_AutoID\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 138
 testRunner.Then("\"EXPLORERFOLDERS,UI_RENAME1_AutoID,UI_FilterTest_AtoID\" is invisible within \"1\" s" +
                    "econds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 139
 testRunner.Then("\"EXPLORERFOLDERS,UI_RENAME1_AutoID,UI_FilterTest_AtoID\" is invisible within \"1\" s" +
                    "econds", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
