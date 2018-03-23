using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SampleApplication.Data;
using SampleApplication.Objects.Dtos;

namespace SampleApplication.Data_Tests
{
    [TestFixture]
    public class Getting_Emplyees_ByCity_State_Tests
    {
        public string City;
        public string State;
        public IList<EmployeeDto> Actual;
        public EmployeeRepository Target;

        [OneTimeSetUp]
        public void SetUp()
        {
            City = "Denver";
            State = "Co";
            Target = new EmployeeRepository();
            Actual = Target.GetEmployeeByCityState(City, State);
        }

        [Test]
        public void All_Employees_Are_From_Expected_State_Test()
        {
            Assert.IsTrue(Actual.All(x=>x.State==State));
        }

        [Test]
        public void Has_Results_Test()
        {
            Assert.IsTrue(Actual.Any());
        }
    }
}
