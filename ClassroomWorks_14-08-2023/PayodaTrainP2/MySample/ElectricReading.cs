using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySample
{
    class ElectricReading
    {
        private int consumernumber;
        int previousreading, currentreading;
        private string consumername, consumertype;
        private readonly int _subsidy;
       public ElectricReading(int consumernumber, int previousreading, int currentreading, string consumername, string consumertype)
        {
            Consumernumber = consumernumber;
            Previousreading = previousreading;
            Currentreading = currentreading;
            Consumername = consumername;
            Consumertype = consumertype;
            _subsidy = 50;


        }
        public int Consumernumber
        {
            get=> consumernumber; set => consumernumber = value;
        }
        public string Consumername
        {
            get=> consumername;  set=> consumername = value;
        }

        public int Previousreading
        {
            get=> previousreading; set => previousreading = value;
        }

        public int Currentreading
        {
            get => currentreading;  set => currentreading = value;
        }

        public  string Consumertype
        {
            get=> consumertype; set => consumertype = value;    
        }
        public int Subsidy => _subsidy; 

        public static void hello()
        {
            ElectricReading n = new ElectricReading(123, 800, 8000, "Parithi", "Domestic");
            n.consumernumber = 5;
           
        }
      
        public int CalculateBill()
        {
            
            int billamount = 0;
            int consumption = Currentreading - Previousreading;

            if (consumertype.Equals("Domestic"))
            {
                
                if (consumption <= 100)
                {
                    billamount = 0;
                }
                else if (consumption > 100 && consumption <= 200)
                {
                    billamount = (consumption - 100) * 2;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    billamount = (consumption - 100) * 5;
                }
                else if (consumption > 500)
                {
                    billamount = (consumption - 100) * 10;
                }
            }
            else if(consumertype.Equals("Commercial"))
            {
                if (consumption <= 100)
                {
                    billamount = 10;
                }
                else if (consumption > 100 && consumption <= 200)
                {
                    billamount = (consumption - 100) * 20;
                }
                else if (consumption > 200 && consumption <= 500)
                {
                    billamount = (consumption - 100) * 50;
                }
                else if (consumption > 500)
                {
                    billamount = (consumption - 100) * 100;
                }
            }
            return billamount;
        }
      

    }
}
