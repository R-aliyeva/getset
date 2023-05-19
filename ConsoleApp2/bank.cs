using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class bank
    {
        private string name;
        private string cardid;
        private string cardname;
        private string cvv;
        private decimal balance;

        public string Name { get;set; }
        public string Cardid
        {
            get
            {
                return cardid;
            }
            set
            {
                if (value.Length == 16)
                {

                }
                else 
                {
                    Console.WriteLine("cardid must be 16 numbers");
                }
            }
        }     
        public string Cardname { get;set; }
        public string Cvv {
            get
            { 
                return cvv;
            }
            set
            {
                bool kontrol=false;
                if (value.Length == 3)
                {

                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayimi = char.IsNumber(value[i]);
                        if (sayimi)
                        {
                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }


                }
                else {
                    Console.WriteLine("cvv must be 3 numbers only");
                }
                if (kontrol)
                {

                }
                else
                {
                    Console.WriteLine("cvv must be only numbers");
                }

            }
               

            }
                }
       //ublic int Balance { get; set; }
        //public void Increasebalance(decimal bl)
        //{ 
        //    balance += bl;

        //}





    }
}
