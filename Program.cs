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
        public bool Talk
        {
            set
            {
                if (value == true)
                {
                    for (int i = 0; i <= 5; i++)
                    {
                        Console.Beep();
                    }
                }
                else
                {
                    Console.WriteLine("Yes Arshak talks not too much");
                }
            }
            get
            {
                return Talk;
            }
        }

        public void Walk(int distance)
        {
            this.Weigth--;
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
            Console.WriteLine($"My Name Is {human.Name} {human.LastName}");
            human.Weigth = 92;
            Console.WriteLine($"My Weigth is {human.Weigth}");
            human.Location = 10;
            //human.Tariq = new DateTime(1995,10, 2)  ;
            //nsole.WriteLine(human.Full_Name());
            human.Eat(1);
            Console.WriteLine($"I Have Eaten And My Weigth is {human.Weigth}");
            human.Walk(50);
            Console.WriteLine($"I Walked And My Weigth is {human.Weigth} Now");
            human.Runing(10);
            Console.WriteLine(human.Weigth);
            Console.WriteLine("If you agree that Arshak talks much whrite true else false");
            human.Talk = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(human.Talk);
            
            
        


          
        }
       
        }
       
    }

