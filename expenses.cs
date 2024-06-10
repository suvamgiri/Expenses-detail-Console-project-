using System;
using System.Collections.Generic;
class Expences{
  public int date;
  public string desctiption;
  public double amount;
  public Expences(int date, string desctiption, double amount){
    this.date=date;
    this.desctiption=desctiption;
    this.amount=amount;
  }
}
class Program {
  public static void Main (string[] args) {
List<Expences> expences=new List<Expences>();
    Console.WriteLine("enter the date");
    int date=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter the desctiption");
    string desctiption=Console.ReadLine();
    Console.WriteLine("enter the amount");
    double amount=Convert.ToDouble(Console.ReadLine());
expences.Add(new Expences(date,desctiption,amount));
    
     
    bool invalid = true;
    while(invalid != false){
      detail();
    Console.WriteLine("enter the number : ");
    int num=Convert.ToInt32(Console.ReadLine());
    switch(num){
    case 1:
      see(expences);
      break;
    case 2:
      add(expences);
      break;
    case 3:
      remove(expences);
      break;
    case 4:
    exit(expences);
      invalid = false;
      break;
    }

      }
  }
  public static void detail(){
    Console.WriteLine(" 1: See");
    Console.WriteLine(" 2: Add");
    Console.WriteLine(" 3: Delete");
    Console.WriteLine(" 4: Exit");
  }
  public static void see(List<Expences>expences){    
    foreach(Expences b in expences){
      Console.Write(b.date + " ");
      Console.Write(b.desctiption + " ");
      Console.Write(b.amount + "");
    }
  }
  public static void add(List<Expences>expences){
    Console.WriteLine("enter the date");
    int date=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("enter the desctiption");
    string desctiption=Console.ReadLine();
    Console.WriteLine("enter the amount");
    double amount=Convert.ToDouble(Console.ReadLine());
    expences.Add(new Expences(date,desctiption,amount));
  }
  
    // ... previous code ...
    public static void remove(List<Expences>expences){
      foreach(Expences b in expences){
          Console.WriteLine(b.date);

      }
        Console.Write("enter the date which you need to delete : ");
        int date1=Convert.ToInt32(Console.ReadLine());
        // Find the Expences object with the matching date
        Expences expenseToRemove = expences.Find(e => e.date == date1);
        if(expenseToRemove != null){ 
          expences.Remove(expenseToRemove);
        } else {
          Console.WriteLine("No expense found with that date.");
        }
    }

  
  public static void exit(List<Expences>expences){
    Console.WriteLine("thankyou ");
    
  }
}
