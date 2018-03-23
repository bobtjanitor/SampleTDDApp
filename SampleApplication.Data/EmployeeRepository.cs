using System.Collections.Generic;
using SampleApplication.Objects.Dtos;
using SampleApplication.Objects.RepositoryInterfaces;

namespace SampleApplication.Data
{
    public class EmployeeRepository : RepoBase, IEmployeeRepository
    {
        public IList<EmployeeDto> GetEmployeeByCityState(string city, string state)
        {
            var employees = Context
                .Sql("select Id, FirstName,LastName,City,State from Employees where city=@city and State=@state")
                .Parameter("city", city).Parameter("state", state).QueryMany<EmployeeDto>();


            return employees;
        }

        public bool UpdateEmployee(EmployeeDto updateEmployee)
        {
            var result = Context.Update("Emplyees")
                .Column("FirstName", updateEmployee.FirstName)
                .Column("LastName", updateEmployee.LastName)
                .Column("City", updateEmployee.City)
                .Column("State", updateEmployee.State)
                .Where("Id", updateEmployee.Id).Execute();
            return result > 0;
        }
    }
}