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
            qErole.ColumnSet.AddColumns("name", "parentroleid", "businessunitid", "parentrootroleid");

            return service.RetrieveAll(qErole).Entities
                .GroupBy(e => e.GetAttributeValue<EntityReference>("parentrootroleid").Id)
                .Select(rolesWithSameParent => new Model.SecurityRole
                {
                    Role = rolesWithSameParent.First(x => !x.Contains("parentroleid"))
                        .GetAttributeValue<string>("name"),
                    Id = rolesWithSameParent.First(x => !x.Contains("parentroleid"))
                        .Id,
                    Ids = rolesWithSameParent.ToDictionary(l => l.GetAttributeValue<EntityReference>("businessunitid").Id,
                        l => l.Id)
                }).ToList();
        }

        public List<Actor> GetActors()
        {
            var qEsystemuser = new QueryExpression("systemuser");
            qEsystemuser.ColumnSet.AddColumns("systemuserid", "businessunitid", "fullname", "isdisabled");
            var service = ServiceFunc.Invoke();

            var list = service.RetrieveAll(qEsystemuser).Entities.Select(e => new Actor()
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
            list.AddRange(service.RetrieveAll(qEteam).Entities.Select(e => new Actor
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
            var list = service.RetrieveAll(qEsystemuserroles).Entities
                .Select(e => new ActorInRole
                {
                    Actor = e.GetAttributeValue<Guid>("systemuserid"),
                    Role = e.GetAttributeValue<Guid>("roleid")
                }).ToList();

            var qEteamroles = new QueryExpression("teamroles");
            qEteamroles.ColumnSet.AddColumns("roleid", "teamid");
            list.AddRange(service.RetrieveAll(qEteamroles).Entities
                .Select(e => new ActorInRole
                {
                    Actor = e.GetAttributeValue<Guid>("teamid"),
                    Role = e.GetAttributeValue<Guid>("roleid")
                }));

            return list;
        }
    }
}
