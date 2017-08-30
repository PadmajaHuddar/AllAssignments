using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionLoopsDay3
{
    class ElectricityBill
    {
        public void billCalculate()
        {
            try
            {
                decimal charge = 0,surcharge=0, rate=0, total=0;
                Console.Write("Enter the customer:");
                int custId = Int32.Parse(Console.ReadLine());
                Console.Write("Enter the name:");
                string name = Console.ReadLine();
                Console.Write("Enter the Unit of electricity consumed:");
                decimal consumption = Convert.ToDecimal(Console.ReadLine());
                if(consumption<=199)
                {
                    rate = 1.2M;
                    charge = decimal.Multiply(consumption, 1.2M );
                }
                else
                if (consumption >= 199 && consumption<400)
                {
                    rate = 1.5M;
                    charge = decimal.Multiply(consumption, 1.5M);
                }
                else
                if (consumption >= 400 && consumption < 600)
                {
                    rate = 1.8M;
                    charge = decimal.Multiply(consumption, 1.8M);
                }
                else
                {
                    rate = 2M;
                    charge = decimal.Multiply(consumption, 2M);
                }

                if (charge >= 400)
                {
                    surcharge = decimal.Multiply(charge, 0.15M);
                    total = charge + surcharge;
                }
                else
                if(charge<100)
                {
                    charge = 100;
                    total = 100;
                }
                else
                {
                    total = charge;
                }
                display(custId,name,consumption,rate,charge,surcharge,total);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input");
                Console.ReadLine();
            }
           
        }
        public void display(int custId,string name,decimal consumption,decimal rate,decimal charge,decimal surcharge,decimal total)
        {
            Console.WriteLine(" Customer IDNO :{0} \n Customer Name :{1} \n unit Consumed: {2} \n Amount Charges @Rs. {3} per unit : {4} \n Surchage Amount : {5} \n Net Amount Paid By the Customer : {6}", custId, name,consumption, rate, charge, surcharge, total);
            Console.ReadLine();
        }
    }
}
