namespace WebApplication5.Models
{
    public class Employee
    {
        public int empid;
        public string name;
        public int age;
        public string address;
        public string designation;
        //Constructor
        public Employee(int a, string b, int c,string d,string e)
        {
            empid = a;
            name = b;
            age = c;
            address = d;
            designation = e;
        }

        //Creating property named empid, name, age, address, companyname
       public int Empid
        {
            get
            {
                return empid;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
        }
        public string Address
        {

            get
            {
                return address;
            }
        }
        public string Designation
        {
            get
            {
                return designation;
            }
        }




    }
}
