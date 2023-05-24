using CNSBack.Exceptions;
using CNSBack.Interfaces;
using CNSBack.Models;
using Microsoft.EntityFrameworkCore;

namespace CNSBack.Services
{
    public class LoginService : ILoginService
    {
        public void EmployeeReg(string firstName, string lastName, int positionId, DateTime birthDate, int roleId, string login, string password)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
 
            var options = optionsBuilder.Options;

            using (ApplicationContext applicationContext = new ApplicationContext(options))
            {
                if (applicationContext.employee.FirstOrDefault(e => e.firstname == firstName && e.lastname == lastName) != null)
                {
                    throw new UserAlreadyExistsException("User already exists");
                }

                EmployeeModel user = new EmployeeModel {
                    firstname = firstName, 
                    lastname = lastName, 
                    positionid = positionId, 
                    birthdate = birthDate, 
                    roleid = roleId,
                    login = login,
                    password = password
                };
                applicationContext.employee.Add(user);
                applicationContext.SaveChanges();
            }
        }
    }
}