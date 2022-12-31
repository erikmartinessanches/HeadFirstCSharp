using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes
{
    internal class ShoeCloset
    {
        private readonly List<Shoe> shoes = new List<Shoe>();

        public void PrintShoes()
        {
            if (shoes.Count == 0)
            {
                Console.WriteLine("The closet is empty.");
            }
            else
            {
                Console.WriteLine("The closet contains: ");
                int i = 1;
                foreach (Shoe shoe in shoes)
                {
                    Console.WriteLine($"Shoe number {i}: {shoe.Description}.");
                }
            }
        }
        public void AddShoe()
        {
            Console.WriteLine("Add a shoe to the closet.");
            for (int i = 0; i < 6; i++)
            {
                //In {(Style)i} the Style enum's ToSting() is implicitly called by the interpolated string.
                Console.WriteLine($"Press {i} to add style {(Style)i}");
            }
        }
    }
}
