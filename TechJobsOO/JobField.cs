using System;
using System.Collections.Generic;
using System.Text;

namespace TechJobsOO
{
    public abstract class JobField
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; } = "";

        protected JobField()
        {
            Id = nextId;
            nextId++;
        }

        protected JobField(string value)
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is JobField job && Id == job.Id;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
