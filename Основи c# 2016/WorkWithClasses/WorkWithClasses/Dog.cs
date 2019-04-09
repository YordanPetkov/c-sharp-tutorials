using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithClasses
{
    class Dog : Animal
    {
        public Dog(string Name = "No Name",
            string Sound = "Woof Woof",
            double Speed = 0.00,
            string Food = "Bone") : base(Name,Sound,Speed,Food)
        {
            SetSpecies("Dog");
        }

        public override void Welcome()
        {
            base.Welcome();
            Console.WriteLine("{0} says {1}",
                GetName(),
                GetSound());
        }
    }
}
