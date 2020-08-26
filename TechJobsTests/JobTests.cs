using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;
using System;


namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    { //Job job1;
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job12 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(/*job12.Id != job2.Id &&*/ job12.Id+1 == job2.Id);
            //Assert.IsFalse(true);
            //System.Diagnostics.Debug.WriteLine(job1.Id);
            //System.Diagnostics.Debug.WriteLine(job2.Id);
        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
             Job job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job3.Name == "Product tester");
            Assert.IsTrue(job3.EmployerName.Value == "ACME");
            Assert.IsTrue(job3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job3.JobType.Value == "Quality control");
            Assert.IsTrue(job3.JobCoreCompetency.Value == "Persistence");
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job5 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(job4.Equals(job5));
        }
        [TestMethod]
        public void TestToString()
        {
            Job job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            System.Diagnostics.Debug.WriteLine(job4.ToString());
            string Confused = job4.ToString();
            char First = Confused[0];
            char Last = Confused[Confused.Length - 1];
            char NewLine = '\n';
            Assert.IsTrue(First == Last);
            //Assert.IsTrue(Last == NewLine);
        }
        [TestMethod]
        public void TestToString2()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job1.ToString() == "\n" + $"ID:__{job1.Id}__" + "\n" + $"Name:__{job1.Name}__" + "\n" + $"Employer:__{job1.EmployerName.Value}__" + "\n" + $"Location:__{job1.EmployerLocation.Value}__" + "\n" + $"Position Type:__{job1.JobType.Value}__" + "\n" + $"Core Competency:__{job1.JobCoreCompetency.Value}__" + "\n");
        }
        [TestMethod]
        public void TestToString3()
        {
            Job job1 = new Job("Product tester",new  Employer("ACME"), new Location(""), new PositionType(""), new CoreCompetency("Persistence"));
            string Empty = "Data not available";
            Assert.IsTrue(job1.ToString() == "\n" + $"ID:__{job1.Id}__" + "\n" + $"Name:__{job1.Name}__" + "\n" + $"Employer:__{job1.EmployerName.Value}__" + "\n" + $"Location:__{Empty}__" + "\n" + $"Position Type:__{Empty}__" + "\n" + $"Core Competency:__{job1.JobCoreCompetency.Value}__" + "\n");
        }
        }
    
}
