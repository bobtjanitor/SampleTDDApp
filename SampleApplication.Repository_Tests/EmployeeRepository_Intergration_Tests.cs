using System.Linq;
using NUnit.Framework;
using SampleApplication.Repository;

namespace SampleApplication.Repository_Tests
{
    [TestFixture]
    public class EmployeeRepository_Intergration_Tests
    {
        public EmployeeRepository target;
        public string City;
        public string State;

        [SetUp]
        public void Setup()
        {
            target = new EmployeeRepository();
            State = "Washington";
            City = "Seattle";
        }

        [Test]
        public void Getting_Employees_From_Specified_City_And_State_OnlyReturns_Employees_From_There_Test()
        {
            var actaul = target.GetEmployeeByCityState(City, State);
            var filtered = actaul.Where(x => x.City == City && x.State == State).ToList();
            Assert.AreEqual(actaul.Count, filtered.Count);
        }

        [Test]
        public void Getting_Employees_From_Specified_City_And_State_Returns_Employees_Test()
        {
            var actaul = target.GetEmployeeByCityState(City, State);            
            Assert.Greater(actaul.Count, 0);
        }

        [Test]
        public void ReturnsEmployeesCity_Test()
        {
            var actaul = target.GetEmployeeByCityState(City, State);
            Assert.AreEqual(City, actaul[0].City);
        }

        [Test]
        public void ReturnsEmployeesState_Test()
        {
            var actaul = target.GetEmployeeByCityState(City, State);
            Assert.AreEqual(State, actaul[0].State);
        }

        [Test]
        public void ReturnsEmployeesName_Test()
        {
            var actual = target.GetEmployeeByCityState(City, State);
            Assert.AreNotEqual(null, actual[0].FirstName);
        }
    }
}