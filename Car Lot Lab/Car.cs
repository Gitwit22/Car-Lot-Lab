using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Car_Lot_Lab
{

    
    //initializing get set
    //capitol letters in the main class variables. why
    public class Car
    {

        
       public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
       

        //initializing variables

        public Car() 
        {
            Make = "";
            Model = "";
            Year = 0;
            Price = 0;


          
        }

        public Car(string make, string model, int year, decimal price)
        {
            Make = make;
            Model = model;
            Year = year;
            Price = price;
        }



        public override string ToString()
        {
            return $"{Make} {Model} ({Year}), Price: {Price:C}";
        }




    }

    }




