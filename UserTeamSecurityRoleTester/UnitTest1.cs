using System;
using Daggen.SecurityRole;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Xrm.Tooling.Connector;

namespace UserTeamSecurityRoleTester
{
    [TestClass]
    public class UnitTest1
    {

        private CrmServiceClient Connect()
        {
            var connectionString = "AuthType=Office365;Url=https://jonathanscircus.crm4.dynamics.com/;UserName=jonathan.daugaard@acando.com;Password=rd0rr5SO";
            return new CrmServiceClient(connectionString);
        }
        [TestMethod]
        public void ConnectToCRM()
        {
            var service = Connect();
            var org = service.Execute(new WhoAmIRequest()) as WhoAmIResponse;
            Assert.IsNotNull(org.OrganizationId);
        }

        [TestMethod]
        public void TestGetRoles()
        {
            using (var service = Connect()) {
                var rService = new ReportService()
                {
                    ServiceFunc = () => service
                };

                var roles = rService.GetRoles();
                Assert.AreEqual(55, roles.Count);
            }
        }
    }
}
