using System;
using System.Collections.Generic;
using System.Linq;
using Daggen.SecurityRole.Model;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Daggen.SecurityRole
{
    public class ReportService
    {

        public Func<IOrganizationService> ServiceFunc { get; set; }

        public List<Model.SecurityRole> GetRoles()
        {
            var service = ServiceFunc.Invoke();

            var qErole = new QueryExpression("role");
            qErole.ColumnSet.AddColumns("name", "businessunitid", "parentrootroleid");
            qErole.AddOrder("parentrootroleid", OrderType.Ascending);

            return service.RetrieveAll(qErole)
                .Select(e => {
                    return new
                    {
                        rootid = e.GetAttributeValue<EntityReference>("parentrootroleid").Id,
                        name = e.GetAttributeValue<string>("name"),
                        businessUnitId = e.GetAttributeValue<EntityReference>("businessunitid").Id,
                        securityRoleId = e.Id
                    };
                })
                .GroupBy(r => {
                    return r.rootid;
                })
                .Select(rolesWithSameParent => {
                    return new Model.SecurityRole
                    {
                        Role = rolesWithSameParent.First().name,
                        Id = rolesWithSameParent.Key,
                        Ids = rolesWithSameParent.ToDictionary(l => l.businessUnitId,
                            l => l.securityRoleId)
                    };
                }).ToList();
        }

        public List<Actor> GetActors()
        {
            var qEsystemuser = new QueryExpression("systemuser");
            qEsystemuser.ColumnSet.AddColumns("systemuserid", "businessunitid", "fullname", "isdisabled");
            var service = ServiceFunc.Invoke();

            var list = service.RetrieveAll(qEsystemuser).Select(e => new Actor()
            {
                Name = e.GetAttributeValue<string>("fullname"),
                IsDisabled = e.GetAttributeValue<bool>("isdisabled"),
                BusinessUnitName = e.GetAttributeValue<EntityReference>("businessunitid").Name,
                BusinessUnit = e.GetAttributeValue<EntityReference>("businessunitid").Id,
                Id = e.Id,
                Type = ActorType.User
            }).ToList();

            var qEteam = new QueryExpression("team");
            qEteam.ColumnSet.AddColumns("name", "businessunitid");
            qEteam.Criteria.AddCondition("teamtype", ConditionOperator.Equal, 0);
            list.AddRange(service.RetrieveAll(qEteam).Select(e => new Actor
            {
                Name = e.GetAttributeValue<string>("name"),
                IsDisabled = false,
                BusinessUnitName = e.GetAttributeValue<EntityReference>("businessunitid").Name,
                BusinessUnit = e.GetAttributeValue<EntityReference>("businessunitid").Id,
                Id = e.Id,
                Type = ActorType.Team
            }));

            return list;
        }

        public IEnumerable<ActorInRole> GetActorsInSecurityRoles()
        {
            var service = ServiceFunc.Invoke();

            var qEsystemuserroles = new QueryExpression("systemuserroles");
            qEsystemuserroles.ColumnSet.AddColumns("roleid", "systemuserid");
            var list = service.RetrieveAll(qEsystemuserroles)
                .Select(e => new ActorInRole
                {
                    Actor = e.GetAttributeValue<Guid>("systemuserid"),
                    Role = e.GetAttributeValue<Guid>("roleid")
                }).ToList();

            var qEteamroles = new QueryExpression("teamroles");
            qEteamroles.ColumnSet.AddColumns("roleid", "teamid");
            list.AddRange(service.RetrieveAll(qEteamroles)
                .Select(e => new ActorInRole
                {
                    Actor = e.GetAttributeValue<Guid>("teamid"),
                    Role = e.GetAttributeValue<Guid>("roleid")
                }));

            return list;
        }
    }
}
