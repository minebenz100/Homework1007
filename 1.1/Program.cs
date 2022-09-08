using System;

public class Program {

 public static Store Createstore(string name,
  double number,
  string owner_name,
  double registered_values) {
    return new Store(name,
    number,
    owner_name,
    registered_values);
 }
 public static void Main(string[] args) {
   Console.Write("Please input Name : ");
   string name = Console.ReadLine();
   Console.Write("Please input Number : ");
   double number = double.Parse(Console.ReadLine());
   Console.Write("Please input Owner_name : ");
   string owner_name = Console.ReadLine();
   Console.Write("Please input Registered_values : ");
   double registered_values = double.Parse(Console.ReadLine());
  Store myshop = Createstore(name,number,owner_name, registered_values);
  OUTPUT.printshop(myshop);
 }

}
