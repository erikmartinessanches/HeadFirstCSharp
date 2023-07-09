namespace ExploreFuncAndAction {
   internal class Program {
      static void Main(string[] args) {
         Func<int, string> timesFour = (int i) => $"-> {i * 4} <-";

         int lineNumber = 1;
         Action<string> writeLine = (string s) => Console.WriteLine($"Line {lineNumber} is {s}");

         Enumerable.Range(1, 5).Select(timesFour).ToList().ForEach(writeLine);
      }
   }
}