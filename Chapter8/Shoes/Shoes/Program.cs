namespace Shoes;

internal class Program {
    private static ShoeCloset shoeCloset = new();

    private static void Main(string[] args) {
        while (true) {
            shoeCloset.PrintShoes();
            Console.Write("Press 'a' to add or 'r' to remove a shoe. ");
            var key = Console.ReadKey().KeyChar;
            switch (key) {
                case 'a':
                case 'A':
                    shoeCloset.AddShoe();
                    break;
                case 'r':
                case 'R':
                    shoeCloset.RemoveShoe();
                    break;
                default: return;
            }
        }
    }
}