using System;

namespace DAT.Model
{
    public class Id : IEquatable<Id>
    {
        private int id;

        public Id()
        {
            id = IdUtils.Generate();
        }

        public bool Equals(Id other)
        {
            return other.id == this.id;
        }

        public static implicit operator int(Id id) => id.id;
    }
}
