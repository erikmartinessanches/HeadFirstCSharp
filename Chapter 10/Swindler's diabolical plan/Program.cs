namespace Swindler_s_diabolical_plan {
   internal class Program {
      static void Main(string[] args) {
         /*Normally, we would need to close StreamWriter, but when we wrap the 
          stream code in a 'using' statement, it automatically closes the stream.
         C# automatically calls the Dispose() method on the object being used
         (the object pointed to by sw), when done running that code block. Every
         Stream has a Dispose() that closes the stream. */
         using (var sw = new StreamWriter("secret_plan.txt")) {
            sw.WriteLine("How I'll defeat Captain Amazing");

            sw.WriteLine("Another genius secret plan by The Swindler");

            sw.WriteLine("I'll unleash my army of clones upon the citizens of Objectville.");
            string location = "the mall";

            for (int number = 1; number <= 5; number++) {
               sw.WriteLine("Clone #{0} attacks {1}", number, location);
               location = (location == "the mall") ? "downtown" : "the mall";
            }
         }

         //Reading files example on p. 607, 4th ed.
         //To obtain the user's Documents folder, we could do something like
         //var folder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
         //Not all streams implement IDisposable, so all streams should always be
         //declared inside a using statement to make sure it's closed hjhk.
         using (var reader = new StreamReader("secret_plan.txt")) {
            //Reading file.
            while (!reader.EndOfStream) {
               var lineFromThePlan = reader.ReadLine();
               //We could optionally write this to another file using another writer here.
               Console.WriteLine(lineFromThePlan);
            }
            /*Chaining Streams, for example using a CryptoStream before a Filestream 
             * writes encrypted files.*/
         }
      }
   }
}