namespace DelegatesChefExample {
   internal class Program {
      static void Main(string[] args) {
         Adrian adrian = new();
         Harper harper = new();

         GetSecretIngredient addIngredientMethod = null;

         while (true) {
            Console.WriteLine("Enter A for Adrian, H for Harper, or an amount: ");
            var line = Console.ReadLine();
            switch (line) {
               case "A":
                  Console.WriteLine("Selected Adrian");
                  addIngredientMethod = adrian.MySecretIngredientMethod;
                  break;
               case "H":
                  Console.WriteLine("Selected Harper");
                  addIngredientMethod = harper.HarpersSecretIngredientMethod;
                  break;
               default:
                  if (addIngredientMethod is null)
                     Console.WriteLine("Please select a chef.");
                  else if (int.TryParse(line, out int amount))
                     Console.WriteLine(addIngredientMethod(amount));
                  else
                     return;
                  break;
            }
         }
      }
   }

   class Adrian {
      //Other objects can use this property to get a reference to
      //AdriansSecretIngredient method. The property returns a delegate reference
      //to an even private method.
      public GetSecretIngredient MySecretIngredientMethod {
         get {
            return AddAdriansSecretIngredient;
         }
      }
      private string AddAdriansSecretIngredient(int amount) {
         return $"{amount} ounces of cloves";
      }
   }

   class Harper {
      public GetSecretIngredient HarpersSecretIngredientMethod {
         get {
            return AddHarpersSecretIngredient;
         }
      }
      private int total = 20;
      private string AddHarpersSecretIngredient(int amount) {
         if (total - amount < 0)
            return $"I don't have {amount} cans of sardines!";
         else {
            total -= amount;
            return $"{amount} cans of sardines";
         }
      }
   }
}