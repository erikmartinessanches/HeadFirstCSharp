namespace Shoes;

internal class ShoeCloset {
    private readonly List<Shoe> shoes = new();

    public void PrintShoes() {
        if (shoes.Count == 0) {
            Console.WriteLine("The closet is empty.");
        }
        else {
            Console.WriteLine("The closet contains: ");
            var i = 1;
            foreach (var shoe in shoes)
                Console.WriteLine($"Shoe number {i++}: {shoe.Description}.");
        }
    }

    public void AddShoe() {
        Console.WriteLine("\nAdd a shoe to the closet.");
        for (var i = 0; i < 6; i++)
            //In {(Style)i} the Style enum's ToSting() is implicitly called by the interpolated string.
            Console.WriteLine($"Press {i} to add style {(Style)i}");
        Console.Write("Enter a shoe style: ");
        if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out var style)) {
            Console.Write("\nEnter the shoe color: ");
            var color = Console.ReadLine();
            Shoe shoe = new((Style)style, color);
            shoes.Add(shoe);
        }
    }

    public void RemoveShoe() {
        Console.Write("\nEnter shoe numer to remove: ");
        if (int.TryParse(Console.ReadKey().KeyChar.ToString(),
                out var shoeNumberToRemove) && shoeNumberToRemove >= 1 &&
            shoeNumberToRemove <= shoes.Count) {
            Console.WriteLine(
                $"Removing {shoes[shoeNumberToRemove - 1].Description}");
            shoes.RemoveAt(shoeNumberToRemove - 1);
        }
    }
}