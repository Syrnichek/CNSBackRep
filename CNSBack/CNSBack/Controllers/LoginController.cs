using CNSBack.Exceptions;
using CNSBack.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CNSBack.Controllers
{
    public class LoginController :Controller
    {
        private readonly ILoginService _loginService;
        
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        
        [HttpGet]
        [Route("api/employeeManage/employeeReg")]
        public IActionResult EmployeeReg(string firstName, string lastName, int positionId, DateTime birthDate, int roleId, string login, string password)
        {
            try
            {
                _loginService.EmployeeReg(firstName, lastName, positionId, birthDate, roleId, login, password);
                return Ok();
            }
            catch (UserAlreadyExistsException ex)
            {
                return StatusCode(420, "Пользователь уже существует");
            }
        }
    }
}