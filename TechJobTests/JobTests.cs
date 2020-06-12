using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        Job job1; 
        Job job2;
        Job job3;
        Job job4;
        Employer emp1;
        Location loc1;
        PositionType pos1;
        CoreCompetency core1;
        [TestInitialize]

        public void CreateJobs()
        {
            job1 = new Job();
            job2  = new Job();
            emp1 = new Employer("ACME");
            loc1 = new Location("Desert");
            pos1 = new PositionType("Quality control");
            core1 = new CoreCompetency("Persistence");
            job3 = new Job("Product tester", emp1, loc1, pos1, core1);
            job4 = new Job("Product tester", emp1, loc1, pos1, core1);
        }
        [TestMethod]
        public void TestBlankConstructor()
        {
            Assert.IsFalse(job1.Id== job2.Id);
        }

        [TestMethod]
        public void TestFullConstructor()
        {
            Assert.IsTrue(job3.Name == "Product tester");
            Assert.IsTrue(job3.EmployerName.Value == "ACME");
            Assert.IsTrue(job3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job3.JobType.Value == "Quality control");
            Assert.IsTrue(job3.JobCoreCompetency.Value == "Persistence");
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(job3.Equals(job4));
        }

        [TestMethod]

        public void TestToString()
        {
            Assert.AreEqual(job4.ToString(), "\nID: 16\nName: Product tester\nEmployer: ACME\nLocation: Desert\nPosition Type: Quality control\nCore Competency: Persistence");
        }
    }
}


