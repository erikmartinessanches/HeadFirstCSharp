using System.Text;

namespace SleuthItOutMemoryStream {
   internal class Program {
      static void Main(string[] args) {
         using (var ms = new MemoryStream()) {//outer using
            using (var sw = new StreamWriter(ms)) { //Inner using
               /*Some Streams don't write all data until they are closed via 
                Dispose() or going out of a using statement (same effect). We
               therefore have to read via MemoryStream AFTER StreamWriter is 
               closed. MemoryStream stays open in the outer using until we read
               with it. The inner using statement closes StreamWriter before 
               MemoryStream reads. 
               
               Stream objects often have buffered data in memory, data waiting
               to be written. Flush() optionally ampties all of that data 
               without closing the stream.*/
               sw.WriteLine("The value is {0:0.00}", 123.45678);
            }
            Console.WriteLine(Encoding.UTF8.GetString(ms.ToArray()));
         }
      }
   }
}