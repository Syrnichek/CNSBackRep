namespace CNSBack.Interfaces
{
    public interface ILoginService
    {
        public void EmployeeReg(string firstName, string lastName, int positionId, DateTime birthDate, int roleId);
    }
}