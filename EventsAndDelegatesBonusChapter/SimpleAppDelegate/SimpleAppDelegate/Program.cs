namespace SimpleAppDelegate {
   internal class Program {
      delegate string IntToString(int i); //Declaring a delegate.

      //The function which we want to call from main. We'll use the delegate
      //above to declare a variable that references this method:
      public static string AddNumberSign(int i) => $"#{i}";

      static void Main(string[] args) {
         IntToString methodRef = AddNumberSign; //Using delegate to create a method reference.
         Console.WriteLine(methodRef(12345));

         //Poiting the same delegate above to another method:
         methodRef = PlusOne;
         Console.WriteLine(methodRef(12345));
      }

      //We can point thhe same delegate above to another method:
      public static string PlusOne(int i) => $"{i} plus one equals {i + 1}";
   }
}