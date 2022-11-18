using BlazorDapperApp.Models;

namespace BlazorDapperApp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IDbService _dbService;

        public EmployeeService(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<bool> CreateEmployee(Employee employee)
        {
            var result = await _dbService.EditData("Insert into public.employee (name,age,address,mobile_number) values (@Name,@Age,@Address,@MobileNumber)", employee);
            return true;
        }

        public async Task<bool> DeleteEmployee(int id)
        {
            var result = await _dbService.EditData("Delete from public.employee where id=@id", new { id });
            return true;
        }

        public async Task<Employee> GetEmployee(int id)
        {
            var employee = await _dbService.GetAsync<Employee>("Select * from public.employee where id=@id", new{ id });
            return employee;
        }

        public async Task<List<Employee>> GetEmployeeList()
        {
            var employeeList = await _dbService.GetAll<Employee>("Select * from public.employee", new { });
            return employeeList;
        }

        public async Task<Employee> UpdateEmployee(Employee employee)
        {
            var updateEmployee = await _dbService.EditData("Update public.employee set name=@Name, age=@Age, address=@Address, mobile_number=@MobileNumber where id=@Id", employee);
            return employee;
        }
    }
}
