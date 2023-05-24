namespace CNSBack.Models
{
    public class EmployeeModel
    {
        public int employeeid { get; set; }
        
        public string firstname { get; set; }
        
        public string lastname { get; set; }
        
        public int positionid { get; set; }
        
        public DateTime birthdate { get; set; }
        
        public int roleid { get; set; }
        
        public string login { get; set; }

        public string password { get; set; }
    }
}