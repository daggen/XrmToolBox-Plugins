using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;

namespace Daggen.SecurityRole
{
    public static class CrmServiceUtils
    {
        public static EntityCollection RetrieveAll(this IOrganizationService service, QueryExpression query)
        {
            query.PageInfo = new PagingInfo();
            var pageNumber = 1;
            var finalCollection = new EntityCollection();
            var results = new EntityCollection();
            do
            {
                query.PageInfo.Count = 5000;
                query.PageInfo.PagingCookie = pageNumber == 1 ? null : results.PagingCookie;

                query.PageInfo.PageNumber = pageNumber++;
                results = service.RetrieveMultiple(query);
                finalCollection.Entities.AddRange(results.Entities);
            } while (results.MoreRecords);

            return finalCollection;
        }

        public static Entity GetRelatedTo(this IOrganizationService service, Entity from, string attributeName, ColumnSet columnSet)
        {
            if (!(from[attributeName] is EntityReference reference))
            {
                throw new ArgumentException("attributeName must be of type Lookup");
            }

            return service.Retrieve(reference.LogicalName, reference.Id, columnSet);
        }

        public static T GetAttributeOrDefualt<T>(this Entity entity, string attributeName, T defaultValue)
        {
            if (entity.Attributes.TryGetValue(attributeName, out object value))
            {
                return (T)value;
            }
            else
            {
                return defaultValue;
            }
        }

        public static Entity Retrieve(this IOrganizationService service, EntityReference entityReference, ColumnSet columnSet)
        {
            return service.Retrieve(entityReference.LogicalName, entityReference.Id, columnSet);
        }
    }
}