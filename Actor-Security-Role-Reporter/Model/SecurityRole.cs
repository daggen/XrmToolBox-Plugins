using System;
using System.Collections.Generic;

namespace Daggen.SecurityRole.Model
{
    public class SecurityRole
    {
        public string Role { get; set; }
        public List<Guid> Ids { get; set; }

        public List<Actor> Actors{ get; }

        public SecurityRole()
        {
            Actors = new List<Actor>();
        }
        public override int GetHashCode()
        {
            return Role.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return obj != null 
                && GetType() == obj.GetType() 
                && ((SecurityRole) obj).Role.Equals(Role);
        }
    }
}
