using AmazingExtensions;

namespace HumanExtensions {
   internal class Program {
      static void Main(string[] args) {
         string message = "Vela, Juno, Help!";
         message.IsDistressCall();
      }
   }
}

namespace AmazingExtensions {
   public static class ExtendAHuman {
      public static bool IsDistressCall(this string s) { //We're extending the string class.
         if (s.Contains("Help!")) {
            return true;
         }
         else {
            return false;
         }
      }
   }

}