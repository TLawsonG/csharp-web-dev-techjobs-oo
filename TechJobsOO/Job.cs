using System;
using System.Security.Cryptography.X509Certificates;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        public Job()
        {
            Id = nextId;
            nextId++;
        }

        public Job(string name,Employer empName,Location empLoc,PositionType jType,CoreCompetency jobCC) : this()
        {
            Name = name;
            EmployerName = empName;
            EmployerLocation = empLoc;
            JobType = jType;
            JobCoreCompetency = jobCC;
        }

        // TODO: Add the two necessary constructors.
        // override object.Equals
        public override bool Equals(object obj)
        {
        
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            // TODO: write your implementation of Equals() here
            return base.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            return base.GetHashCode();
        }
        // TODO: Generate Equals() and GetHashCode() methods.
        public override string ToString()
        {   if (Name == "")
            {
                Name = "Data not available";
            }
            if (EmployerName.Value == "" || EmployerName.Value == null)
            {
                EmployerName.Value = "Data not available";
            }
            if (EmployerLocation.Value == "" || null == EmployerLocation.Value)
            {
                EmployerLocation.Value = "Data not available";
            }
            if (JobType.Value == "" || null == JobType.Value)
            {
                JobType.Value = "Data not available";
            }
            if (JobCoreCompetency.Value == "" || null == JobCoreCompetency.Value)
            {
                JobCoreCompetency.Value = "Data not available";
            }
            return "\n" + $"ID:__{Id}__" + "\n" + $"Name:__{Name}__" + "\n" + $"Employer:__{EmployerName.Value}__" + "\n" + $"Location:__{EmployerLocation.Value}__" + "\n" + $"Position Type:__{JobType.Value}__" + "\n" + $"Core Competency:__{JobCoreCompetency.Value}__" + "\n";
        }
    }

}
