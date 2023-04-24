using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp27;

namespace WindowsFormsApp27
{
    abstract class Movie_Ticket
    {
        public string Movie_Name { get; set; }
        public string Theater_Name { get; set; }
        public string Show_Time { get; set; }
        public int No_Of_Seats { get; set; }
        public float Ticket_Price { get; set; }
        public abstract string Calculate_Ticket_Price();
    }
    class Online_Booking : Movie_Ticket
    {
        public float discount { get; set; }

        public Online_Booking(string Movie_Name, string Theater_Name,string Show_Time,int No_Of_Seats,float Ticket_Price) 
        { 
            Movie_Name = this.Movie_Name;
            Theater_Name = this.Theater_Name;
            Show_Time = this.Show_Time;
            No_Of_Seats = this.No_Of_Seats;
            Ticket_Price = this.Ticket_Price;   
        }

        public override string Calculate_Ticket_Price()
        {
            discount = 0.1f;
            float tp = No_Of_Seats * Ticket_Price + discount;
            return ("Total Price :" + tp.ToString());
        }
    }
    class BoxOffice : Movie_Ticket
    {
        public float Booking_Amount { get; set; }
        public BoxOffice(string Movie_Name, string Theater_Name, string Show_Time, int No_Of_Seats, float Ticket_Price)
        {
            Movie_Name = this.Movie_Name;
            Theater_Name = this.Theater_Name;
            Show_Time = this.Show_Time;
            No_Of_Seats = this.No_Of_Seats;
            Ticket_Price = this.Ticket_Price;
        }
        public override string Calculate_Ticket_Price()
        {
            Booking_Amount = 20;
            float tp = No_Of_Seats * Ticket_Price + Booking_Amount;
            return ("Total Price :" + tp.ToString());

        }
    }
}


