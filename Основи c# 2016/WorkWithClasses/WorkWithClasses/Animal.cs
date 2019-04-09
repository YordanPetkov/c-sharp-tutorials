using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithClasses
{
    class Animal
    {
        private string species;
        private string name;
        private string sound;
        private double speed;
        private string food;

        public string GetSpecies()
        {
            return species;
        }

        public void SetSpecies(string value)
        {
            species = value;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string value)
        {
            name = value;
        }

        public string GetSound()
        {
            return sound;
        }

        public void SetSound(string value)
        {
            sound = value;
        }

        public double GetSpeed()
        {
            return speed;
        }

        public void SetSpeed(double value)
        {
            speed = value;
        }

        public string GetFood()
        {
            return food;
        }

        public void SetFood(string value)
        {
            food = value;
        }

        public Animal(string Name = "No Name",
            string Sound = "No Sound",
            double Speed = 0.00,
            string Food = "No Food")
        {
            SetName(Name);
            SetSound(Sound);
            if(Speed <= 150 && Speed >= 0)SetSpeed(Speed);
            else SetSpeed(0.00);
            SetFood(Food);
            SetSpecies("Animal");
        }

        public void Discription()
        {
            Console.WriteLine("{0} says {1} , run with {2}H/KM and like to eat {3}",
                GetName(),
                GetSound(),
                GetSpeed(),
                GetFood());
        }

        public virtual void Welcome()
        {
            Console.WriteLine("Hi i'm from class {0} and i'm {1}",
                "Animal",
                GetSpecies());
        }

    }
}
