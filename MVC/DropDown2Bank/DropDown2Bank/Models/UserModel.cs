using Microsoft.AspNetCore.Http.Connections;

namespace DropDown2Bank.Models
{
    public class UserModel
    {
        public int Accountno { get; set; }
        public int Amount { get; set; }
        public transtype GetTranstype { get; set; }
    }
    public enum transtype
    {
        deposit,withdrawl
    }
}
