using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithClasses
{
    class Cat : Animal
    {
        public Cat(string Name = "No Name",
            string Sound = "Miau",
            double Speed = 0.00,
            string Food = "Mouse") : base(Name, Sound, Speed, Food)
        {
            SetSpecies("Cat");
        }

        public override void Welcome()
        {
            base.Welcome();
            Console.WriteLine("{0} i like to eat {1}.",
                GetSound(),
                GetFood());
        }
    }
}
