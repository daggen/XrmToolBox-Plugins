using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Sandbox
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            var con = new CrmConnector("admin@daggen1610.onmicrosoft.com",
                "Password1",
                "https://daggen1610.api.crm4.dynamics.com/XRMServices/2011/Organization.svc");

            var Service = con.GetOrganizationServiceProxy();

            var qErole = new QueryExpression("role");
            qErole.ColumnSet.AddColumns("name", "parentroleid", "businessunitid");

            var s = Service.RetrieveMultiple(qErole).Entities
                .GroupBy(e => e.Attributes["name"].ToString(),
                    e => new { e.Id, IsParent = !e.Contains("parentroleid"), BusinessUnit = (EntityReference) e.Attributes["businessunitid"] },
                    (name, ids) => new tempClass
                    {
                        Role = name,
                        Id = ids.First(l => l.IsParent).Id,
                        Ids = ids.ToDictionary(l => l.BusinessUnit.Id, l => l.Id)
                    }).ToList();
        }

        [TestMethod]
        public void TestSomehtingElse()
        {
            var counter = new Dictionary<string, int>
                    {
                        { "Success", 0},
                        { "Failed", 0},
                        { "Ignored", 0}
                    };

            counter["Success"]++;

            Assert.AreEqual(1, counter["Success"]);
            Assert.AreEqual(0, counter["Failed"]);
        }
    }


    class tempClass
    {
            public string Role { get; set; }
            public Guid Id { get; set; }
            public Dictionary<Guid, Guid> Ids { get; set; }
    }

}
