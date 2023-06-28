namespace DropDownShop.Models
{
    public class UserShop
    {
        public string Customername { get; set; }
        public int Orderno { get; set; }
        public Prodname GetProdName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

       


    }
    public enum Prodname
    {
        Mouse,KeyBoard,CPU,Desktop
    }
}
