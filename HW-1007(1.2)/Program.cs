using System;

    public class Program{
        public static void Main(string[] args){
            double input,change,thousand,fiveHundred,hundred,fifty,twenty,ten,two,one,fiftysatang,twentyfivesatang;
        {
                Console.WriteLine("Please input money: ");
               if (!double.TryParse(Console.ReadLine(),out input)) {
                throw new Exception("!!! Please Write Only Number !!!");
                }
        }
            double money=input;

            thousand = money / 1000;            change = money  % 1000;
            fiveHundred = change / 500;         change = change % 500;
            hundred = change / 100;             change = change % 100;
            fifty = change / 50;                change = change % 50;
            twenty = change / 20;               change = change % 20;
            ten = change / 10;                  change = change % 10;
            two = change / 2;                   change = change % 2;
            one = change / 1;                   change = change % 1;
            fiftysatang = change / 0.5;         change = change % 0.5;
            twentyfivesatang = change / 0.25;   change = change % 0.25;

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("|1000 Baht :{0}|", Math.Floor(thousand));
            Console.WriteLine("|500 Baht  :{0}|", Math.Floor(fiveHundred));
            Console.WriteLine("|100 Baht  :{0}|", Math.Floor(hundred));
            Console.WriteLine("|50 Baht   :{0}|", Math.Floor(fifty));
            Console.WriteLine("|20 Baht   :{0}|", Math.Floor(twenty));
            Console.WriteLine("|10 Baht   :{0}|", Math.Floor(ten));
            Console.WriteLine("|2 Baht    :{0}|", Math.Floor(two));
            Console.WriteLine("|1 Baht    :{0}|", Math.Floor(one));
            Console.WriteLine("|0.50 St.  :{0}|", Math.Floor(fiftysatang));
            Console.WriteLine("|0.25 St.  :{0}|", Math.Round(twentyfivesatang));
            Console.WriteLine("-------------------------------------");
        }
    }