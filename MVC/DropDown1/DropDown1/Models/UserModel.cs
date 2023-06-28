namespace DropDown1.Models
{
    public class UserModel
    {
        public TeaType SelectTeaType { get; set; }
    }

    public enum TeaType
    {
        Tea,Coffee,GreenTea,BlackTea
    }
}
