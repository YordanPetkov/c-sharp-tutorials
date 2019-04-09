using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal1 = new Animal("Miki", Sound: "Piew", Speed: 5, Food: "Weed");
            Animal myAnimal2 = new Animal();
            Dog myDog1 = new Dog("Sharo", "Bau Bau", 25, "Meat");
            Dog myDog2 = new Dog();
            Cat myCat1 = new Cat("Jada", "Miewww",  9,  "Cat Food");
            Cat myCat2 = new Cat("Jessa");

            myAnimal1.Discription();
            myAnimal1.Welcome();

            myAnimal2.Discription();
            myAnimal2.Welcome();

            myDog1.Discription();
            myDog1.Welcome();

            myDog2.Discription();
            myDog2.Welcome();

            myCat1.Discription();
            myCat1.Welcome();

            myCat2.Discription();
            myCat2.Welcome();

        }
    }
}
