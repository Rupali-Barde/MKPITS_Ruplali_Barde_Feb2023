namespace SignUp_Form.Models
{
    public class UserModel1
    {
        public string UserName { get; set; }
        public string Gender { get; set; }

        public  bool Dotnet { get; set; }

        public bool Java { get; set; }  
        public city SelectCity { get; set; }
    }

    public enum city
    {
        Nagpur, Mumabi, Pune, Amarawati
    }
}

