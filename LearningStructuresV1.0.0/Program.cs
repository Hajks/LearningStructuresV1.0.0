using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningStructuresV1._0._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Canine spot = new Canine("Burek", "mops");
            Canine bob = spot;
            bob.Name = "Szarik";
            bob.Breed = "beagle";
            spot.Speak();

            Dog jake = new Dog("Tofik", "pudel");
            Dog betty = jake; //diffrence between object and structure is this one. Here we created jake copy with betty parametrs. Now if we change fields like name and breed it will be changed only for betty, not for jake.
            betty.Name = "Becia";
            betty.Breed = "pitbul";
            jake.Speak();
            Console.ReadKey();
        }
    }
}
