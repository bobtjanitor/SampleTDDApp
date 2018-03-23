using NUnit.Framework;
using SampleApplication.Domain;
using SampleApplication.Objects.RepositoryInterfaces;

namespace SampleApplication.Domain_Tests.UnitTest
{
    [TestFixture]
    public class Factory_Tests
    {
        [Test]
        public void Get_Employee_Repository_Test()
        {
            Assert.IsInstanceOf<IEmployeeRepository>(Factory.GetEmployeeRepository());
        }    
    }
}