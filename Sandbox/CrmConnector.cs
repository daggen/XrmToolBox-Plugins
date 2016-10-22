using System;
using System.ServiceModel.Description;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using Microsoft.Xrm.Tooling.Connector;

namespace Sandbox
{
    public class CrmConnector
    {
        private readonly SecurityTokenResponse organizationTokenResponse;
        private readonly IServiceManagement<IOrganizationService> orgServiceManagement;

        public CrmConnector(string userName, string password, string organizationUrl)
        {
            var credentials = new ClientCredentials();
            credentials.UserName.UserName = userName;
            credentials.UserName.Password = password;

            var authCredentials = new AuthenticationCredentials
            {
                ClientCredentials = credentials,
                SupportingCredentials = new AuthenticationCredentials
                {
                    ClientCredentials = DeviceIdManager.LoadOrRegisterDevice()
                }
            };

            orgServiceManagement =
                ServiceConfigurationFactory.CreateManagement<IOrganizationService>(new Uri(organizationUrl));
            var tokenCredentials = orgServiceManagement.Authenticate(authCredentials);
            organizationTokenResponse = tokenCredentials.SecurityTokenResponse;
        }

        public OrganizationServiceProxy GetOrganizationServiceProxy()
        {
            var service = new OrganizationServiceProxy(orgServiceManagement, organizationTokenResponse);
            service.EnableProxyTypes();

            return service;
        }
    }
}