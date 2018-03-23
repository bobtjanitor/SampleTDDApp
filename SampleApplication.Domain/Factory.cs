using SampleApplication.Data;
using SampleApplication.Objects.RepositoryInterfaces;

namespace SampleApplication.Domain
{
    public static class Factory
    {
        public static IEmployeeRepository GetEmployeeRepository()
        {
            return new EmployeeRepository();
        }
    }
}
