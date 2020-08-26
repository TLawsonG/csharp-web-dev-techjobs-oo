using System;
namespace TechJobsOO
{
    public class PositionType : JobField
    {/*
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public PositionType()
        {
            Id = nextId;
            nextId++;
        }*/

        public PositionType(string value) : base(value)
        {
           
        }
       /* public string ToString(string Value)
        {
            return Value;
        }*/
      
        // TODO: Add custom Equals(), GetHashCode(), and ToString() methods.
    }
}
