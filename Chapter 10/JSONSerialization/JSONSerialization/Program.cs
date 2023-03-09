using System.Text.Json;

namespace JSONSerialization {
   internal class Program {
      static void Main(string[] args) {
         var guys = new List<Guy>() { new Guy() { Name="Juno", Clothes = new Outfit() { Top="Space t-shirt", Bottom="Space pants" }, Hair=new HairStyle() { Color=HairColor.Blue, Length=3.5f } },
            new Guy() { Name="Lupus", Clothes = new Outfit() { Top="Collar", Bottom="Tank" }, Hair=new HairStyle() { Color=HairColor.White, Length=1.5f } }
            };

         //Now serializing guys.
         var jsonString = JsonSerializer.Serialize(guys);
         /*Enums are ancoded as integer values in jsonString. */
         Console.WriteLine(jsonString);

         /*Deserializing jsonString into new objects on the heap.*/
         var copyOfGuys = JsonSerializer.Deserialize<List<Guy>>(jsonString);
         foreach (var guy in copyOfGuys) {
            Console.WriteLine($"This guy was deserialized: {guy}");
         }

         //Deserialising JSON into a Stack of Dude objects.
         var dudes = JsonSerializer.Deserialize<Stack<Dude>>(jsonString);
         while (dudes.Count > 0) {
            var dude = dudes.Pop();
            Console.WriteLine($"The next dude: {dude.Name} with {dude.Hair}.");
         }

         Console.WriteLine("Unicode supports right-to-left languages, for example שלום");
      }

      class Guy {
         public string Name { get; set; }
         public HairStyle Hair { get; set; }
         public Outfit Clothes { get; set; }
         public override string ToString() => $"{Name} with {Hair} wearing {Clothes}";
      }
      class Outfit {
         public string Top { get; set; }
         public string Bottom { get; set; }
         public override string ToString() => $"{Top} and {Bottom}";
      }
      enum HairColor {
         Auburn, Black, Blonde, Blue, Brown, Gray, Platinum, Purple, Red, White
      }
      class HairStyle {
         public HairColor Color { get; set; }
         public float Length { get; set; }
         public override string ToString() => $"{Length:0.0} inch {Color} hair";
      }
      class Dude {
         public string Name { get; set; }
         public HairStyle Hair { get; set; }
      }
   }
}