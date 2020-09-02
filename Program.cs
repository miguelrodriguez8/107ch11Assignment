using System;
using System.Collections.Generic;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello You!");

            Program p = new Program();
            p.VariableTest();

            List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 123, 567, 123, 78, 16, 723, 10, 135, 2, 46, 78 };
            p.Exce1(nums);
        }
    
       void Exce1 (List<int> numbers)
       {
           // 1- Find the Total Sum of the numbers in the List
           int total =0;

            for(int i = 0; i < numbers.Count ; i++) 
            
                if(numbers[i] %2 == 0 )
                {
                    System.Console.WriteLine(numbers[i] + " ");
                }
            
       




           foreach(int n in numbers)  // for (int i = 0; i <= nums; i = i + 2)
           {
               //total = total + n;
               total += n;
           }

           System.Console.WriteLine("opt 1 result: " + total);

           // 2- Print even numbers only

        

          System.Console.WriteLine("Numbers :");



           // % = modulus (mod operator)
            
    

       }
       // protectionLevel returnType name(params) {}
       void VariableTest()
       {
           int age = 34;
           if(age < 60)
           {
               Console.WriteLine("You are young!");
           }
           else 
           {
               Console.WriteLine("You are getting old");
           }

           // variable declarations
           // this is called Strong typing
           string name = "Miguel"; // only use double quote
           float height = 8293.89f; //specified by an f at the end of the number
           decimal price = 12.99m;  //specified by an m at the end of the number (money)
           bool found = false;
           string lastName = "Rodriguez";

           for(int i = 0; i < 10; i++)
           {
               // skip 3
               if (i != 3 && i != 7)  //if i is not equal than 3 and i is not equal than 7
               {
                   System.Console.WriteLine(i);
               }
               
           }

           //Arrays
           string[] names = new string[20];

           //Lists
           List<string> colors = new List<string>();
           colors.Add("Red"); //just like push in js
           colors.Add("Blue"); 
           colors.Add("Pink"); 
           colors.Add("Yellow"); 
           colors.Add("Green");  

           // iterates over the list
           for (int i = 0; i < colors.Count; i++) 
           {
               System.Console.WriteLine(colors[i]);
           }

            // another option to iterate lists
           foreach(string color in colors)        //foreach(int n )
           {
               System.Console.WriteLine(color);
           }
       }
     
    }
}
