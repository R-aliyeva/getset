using System.ComponentModel.Design.Serialization;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bank bcard = new bank();
            bcard.Cardid = "123456";
            bcard.Cardname = "Kapital Bank";
            bcard.Cvv = "12";
           //card.Balance = 10;
            //bcard.Increasebalance(12);
            Console.WriteLine($"card name is {bcard.Cardname},card ID is {bcard.Cardid},card CVV is {bcard.Cvv},card balance is {bcard.Balance}");
        }
    }
}