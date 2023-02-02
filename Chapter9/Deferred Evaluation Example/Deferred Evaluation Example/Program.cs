// p 545, 4th ed.
/*Usually, LINQ queries do not do any enumerating or looping until my
 code executes a statement that uses the result of the query. 

  It's also possible to perform immediate execution on a LINQ query by calling
a LINQ method that needs to enumerate the entire list (such as ToList() because 
the ToList needs to access every element in the collection in order to transfrom
it into a list).
 */
namespace Deferred_Evaluation_Example {
  class PrintWhenGetting {
    private int instanceNumber;
    public int InstanceNumber {
      get { 
        Console.WriteLine($"Getting #{instanceNumber}");
        return instanceNumber;
        } 
      set { instanceNumber = value; } }
  }
  internal class Program {
    static void Main(string[] args) {
      var listOfObjects = new List<PrintWhenGetting>();
      for (int i = 1; i < 5; i++) {
        listOfObjects.Add(new PrintWhenGetting() {InstanceNumber = i} );
      }

      Console.WriteLine("Set up the query.");
      var result = 
        from o in listOfObjects
        select o.InstanceNumber;

      //var immediate = result.ToList();

      Console.WriteLine("Run the foreach");
       //Loop over 'immediate' instead, to see LINQ "immediaate execution".
      foreach (var number in result) {
        Console.WriteLine($"Writing #{number}");
      }
    }
  }
}