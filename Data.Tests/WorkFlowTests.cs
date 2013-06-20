using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Data.Tests
{
    [TestClass]
    public class WorkFlowTests
    {
        [TestMethod]
        public void TestSavePerson()
        {
            var workflow = new Workflow();            
            var person = new Person();

            Assert.IsTrue(workflow.SavePerson(new Person() { Name = "Kevin", Age = 26 }));
        }

        [TestMethod]
        public void TestFindPerson()
        {
            var workflow = new Workflow();

            Assert.IsNull(workflow.FindPerson("Aliababa"));
        }

        [TestMethod]
        public void TestSavedPersonShouldBeReturnedWithGetPerson()
        {
            var workflow = new Workflow();            
            workflow.SavePerson(new Person() { Name = "Alibaba", Age = 46 });
            var person = workflow.FindPerson("Alibaba");

            Assert.IsNotNull(person);
            Assert.AreEqual("Alibaba", person.Name);
            Assert.AreEqual(46, person.Age);
        }

        [TestMethod]
        public void TestRemovePerson()
        {
            var workflow = new Workflow();
            workflow.RemovePerson("Kevin");
        }

        [TestMethod]
        public void TestRemovedPersonsShouldNoLongerBeFindable()
        {
            var workflow = new Workflow();
            
            workflow.SavePerson(new Person() { Name = "Levi"});
            workflow.RemovePerson("Levi");

            Assert.IsNull(workflow.FindPerson("Levi"));
        }

        [TestMethod]
        public void TestFindAllPeople()
        {
            var workflow = new Workflow();

            workflow.SavePerson(new Person() { Name = "Bubba" });

            Assert.AreNotEqual(0, workflow.FindAllPeople().Count);
        }
    }
}
