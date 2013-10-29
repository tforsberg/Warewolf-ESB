﻿using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Dev2.DynamicServices;
using Dev2.Runtime.ESB.Management.Services;
using Dev2.Runtime.ServiceModel.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace Dev2.Tests.Runtime.Services
{
    [TestClass]
    [ExcludeFromCodeCoverage]
    public class GetDatabaseColumnsForTableTests
    {
        #region Static Class Init

        static string _testDir;

        [ClassInitialize]
        public static void MyClassInit(TestContext context)
        {
            _testDir = context.DeploymentDirectory;
        }

        #endregion

        

        #region Execute

        [TestMethod]
        [Description("Service should never get null values")]
        [Owner("Huggs")]
        [ExpectedException(typeof(InvalidDataContractException))]
        public void GetDatabaseColumnsForTable_UnitTest_ExecuteWithNullValues_ExpectedInvalidDataContractException()
        {
            var esb = new GetDatabaseColumnsForTable();
            var actual = esb.Execute(null, null);
            Assert.AreEqual(string.Empty, actual);
        }

        [TestMethod]
        [Description("Service should never get null values")]
        [Owner("Huggs")]
        public void GetDatabaseColumnsForTable_UnitTest_ExecuteWithNoDatabaseInValues_ExpectedHasErrors()
        {
            var esb = new GetDatabaseColumnsForTable();
            var actual = esb.Execute(new Dictionary<string, string> { { "Database", null } }, null);
            Assert.IsNotNull(actual);
            var result = JsonConvert.DeserializeObject<DbColumnList>(actual);
            Assert.IsTrue(result.HasErrors);
            Assert.AreEqual("No database set.", result.Errors);
        }
        
        [TestMethod]
        [Description("Service should never get null values")]
        [Owner("Huggs")]
        public void GetDatabaseColumnsForTable_UnitTest_ExecuteWithNullDatabase_ExpectedHasErrors()
        {

            var esb = new GetDatabaseColumnsForTable();
            var actual = esb.Execute(new Dictionary<string, string> { { "Database", null } }, null);
            Assert.IsNotNull(actual);
            var result = JsonConvert.DeserializeObject<DbColumnList>(actual);
            Assert.IsTrue(result.HasErrors);
            Assert.AreEqual("No database set.", result.Errors);
        }

        [TestMethod]
        [Description("Service should never get null values")]
        [Owner("Huggs")]
        public void GetDatabaseColumnsForTable_UnitTest_ExecuteWithBlankDatabase_ExpectedHasErrors()
        {
            var esb = new GetDatabaseColumnsForTable();
            var actual = esb.Execute(new Dictionary<string, string> { { "Database", "" } }, null);
            Assert.IsNotNull(actual);
            var result = JsonConvert.DeserializeObject<DbColumnList>(actual);
            Assert.IsTrue(result.HasErrors);
            Assert.AreEqual("No database set.", result.Errors);
        }

        [TestMethod]
        [Description("Service should never get null values")]
        [Owner("Huggs")]
        public void GetDatabaseColumnsForTable_UnitTest_ExecuteWithNoTableNameInValues_ExpectedHasErrors()
        {

            var esb = new GetDatabaseColumnsForTable();
            var actual = esb.Execute(new Dictionary<string, string> { { "Database", "Test" }, { "Something", null } }, null);
            Assert.IsNotNull(actual);
            var result = JsonConvert.DeserializeObject<DbColumnList>(actual);
            Assert.IsTrue(result.HasErrors);
            Assert.AreEqual("No table name set.", result.Errors);
        }
        
        [TestMethod]
        [Description("Service should never get null values")]
        [Owner("Huggs")]
        public void GetDatabaseColumnsForTable_UnitTest_ExecuteWithNullTableNameExpectedHasErrors()
        {

            var esb = new GetDatabaseColumnsForTable();
            var actual = esb.Execute(new Dictionary<string, string> { { "Database", "Test" }, { "TableName", null } }, null);
            Assert.IsNotNull(actual);
            var result = JsonConvert.DeserializeObject<DbColumnList>(actual);
            Assert.IsTrue(result.HasErrors);
            Assert.AreEqual("No table name set.", result.Errors);
        }

        [TestMethod]
        [Description("Service should never get null values")]
        [Owner("Huggs")]
        public void GetDatabaseColumnsForTable_UnitTest_ExecuteWithBlankTableName_ExpectedHasErrors()
        {
            var esb = new GetDatabaseColumnsForTable();
            var actual = esb.Execute(new Dictionary<string, string> { { "Database", "Test" }, { "TableName", "" } }, null);
            Assert.IsNotNull(actual);
            var result = JsonConvert.DeserializeObject<DbColumnList>(actual);
            Assert.IsTrue(result.HasErrors);
            Assert.AreEqual("No table name set.", result.Errors);
        }
        #endregion

        #region HandlesType

        [TestMethod]
        [Owner("Huggs")]
        public void GetDatabaseColumnsForTable_UnitTest_HandlesType_ExpectedReturnsGetDatabaseColumnsForTableService()
        {
            var esb = new GetDatabaseColumnsForTable();
            var result = esb.HandlesType();
            Assert.AreEqual("GetDatabaseColumnsForTableService", result);
        }

        #endregion

        #region CreateServiceEntry

        [TestMethod]
        [Description("Service should never get null values")]
        [Owner("Huggs")]
        public void GetDatabaseColumnsForTable_UnitTest_CreateServiceEntry_ExpectedReturnsDynamicService()
        {
            var esb = new GetDatabaseColumnsForTable();
            var result = esb.CreateServiceEntry();
            Assert.AreEqual(esb.HandlesType(), result.Name);
            Assert.AreEqual("<DataList><Database/><TableName/><Dev2System.ManagmentServicePayload ColumnIODirection=\"Both\"></Dev2System.ManagmentServicePayload></DataList>", result.DataListSpecification);
            Assert.AreEqual(1, result.Actions.Count);

            var serviceAction = result.Actions[0];
            Assert.AreEqual(esb.HandlesType(), serviceAction.Name);
            Assert.AreEqual(enActionType.InvokeManagementDynamicService, serviceAction.ActionType);
            Assert.AreEqual(esb.HandlesType(), serviceAction.SourceMethod);
        }

        #endregion
    }
}