using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using SampleApplication.Data;
using SampleApplication.Objects.Dtos;

namespace SampleApplication.Data_Tests
{
    [TestFixture]
    public class Updating_Employee_Tests
    {
        public EmployeeDto Expeected;
        public EmployeeDto Actual;
        public EmployeeDto Revert;
        public EmployeeRepository Target;

        [OneTimeSetUp]
        public void SetUp()
        {
            Expeected = new EmployeeDto(){Id = 1, City= "Boise", FirstName = "Joe", LastName = "Tester", State = "ID"};
            Target = new EmployeeRepository();
            //Revert = Target.
            Target.UpdateEmployee(Expeected);
            //Actual = Target.get

        }

        [OneTimeTearDown]
        public void Teardown()
        {
            Target.UpdateEmployee(Revert);
        }
    }

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
        public void All_Employees_Are_From_Expected_City_Test()
        {
            Assert.IsTrue(Actual.All(x => x.City == City));
        }

        [Test]
        public void Has_Results_Test()
        {
            Assert.IsTrue(Actual.Any());
        }
    }
}
