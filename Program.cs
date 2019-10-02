using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Person
{
    public class Person
    {

        public string Name { get; set; }
        public string LastName { get; set; } 
        public int Weigth { get; set; } 
        public int Tariq { get; set; } 
        public int  Location { get; set; }




        public void Walk(int distance)
        {
            this.Location--;
        }
        public void Eat(int weigth)
        {
            this.Weigth += weigth;
        }
        public string Full_Name()
        {
            return $"{this.Name } {this.LastName}";
        }
       public void Runing( int Kilometrs)
        {
           this.Weigth--;


        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person human = new Person();
            human.Name = "Arshak";
            human.LastName = "Lazaryan";
            human.Weigth = 92;
            human.Location = 10;
            //human.Tariq = new DateTime(1995,10, 2)  ;
            Console.WriteLine(human.Full_Name());
            human.Eat(10);
            Console.WriteLine(human.Weigth);
            human.Walk(25);
            Console.WriteLine(human.Weigth);
            human.Runing(10);
            Console.WriteLine(human.Weigth);

            
        


          
        }
       
        }
       
    }

