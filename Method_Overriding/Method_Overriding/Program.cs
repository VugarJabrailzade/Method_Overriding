using System;
using System.Reflection.Emit;


namespace Overriding
{
     sealed class  Person 
    {
        public string  Name { get; set; }
        public string SurName { get; set; }
        public string Age { get; set; }
        public string Weight { get; set; }
        public string Height { get; set; }

        public Person(string name, string surname, string age, string weight, string height)
        {
            Name = name;
            SurName = surname;
            Age = age;
            Weight = weight;
            Height = height;

        }
        public override string ToString()
        {
            return "Person:" + Name + " " + SurName + " " + Age + " " + Weight + " " + Height;
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Vugar","Jabrailzade","25","70kg","178sm");


            Console.WriteLine(person);




        }
    }






}