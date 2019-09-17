using System;
using System.Collections.Generic;

namespace Daggen.SecurityRole.Model
{
    public class Actor
    {
        public string Name { get; set; }
        public bool IsDisabled { get; set; }
        public string BusinessUnitName { get; set; }
        public Guid BusinessUnit { get; set; }
        public Guid Id { get; set; }
        public List<SecurityRole> SecurityRoles { get; }

        public ActorType Type { get; set; }

        public Actor()
        {
            SecurityRoles = new List<SecurityRole>();
        }

        public override string ToString()
        {
            return Name + ";" + IsDisabled + ";" + BusinessUnitName;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj != null && (GetType() == obj.GetType() && ((Actor) obj).Id.Equals(Id));
        }
    }

    public enum ActorType
    {
        User,
        Team
    }

}
