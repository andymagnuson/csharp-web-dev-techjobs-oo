using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        Job job1; 
        Job job2; 
        [TestInitialize]

        public void CreateJobs()
        {
            job1 = new Job();
            job2  = new Job();
        }
        [TestMethod]
        public void TestMethod1()
        {
            System.Console.WriteLine(job1.Id);
            System.Console.WriteLine(job2.Id);
            Assert.IsFalse(job1.Id== job2.Id);
        }
    }
}
