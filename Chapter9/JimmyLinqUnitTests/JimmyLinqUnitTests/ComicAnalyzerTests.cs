namespace JimmyLinqUnitTests {
  using JimmyLinq;
  using System.Collections.Generic;
  using System.Linq;
  [TestClass]
  public class ComicAnalyzerTests {
    IEnumerable<Comic> testComics = new[] {
      new Comic() {Issue = 1, Name = "Issue 1" },
      new Comic() {Issue = 2, Name = "Issue 2" },
      new Comic() {Issue = 3, Name = "Issue 3" },
      };

    [TestMethod]
    public void Comic_Analyzer_Should_Group_Comics() {
      var prices = new Dictionary<int, decimal>() {
        {1, 20M },
        {2, 10M },
        {3, 100M }
      };

      var groups = ComicAnalyzer.GroupComicsByPrice(testComics, prices);
      Assert.AreEqual(2, groups.Count());
      Assert.AreEqual(PriceRange.Cheap, groups.First().Key);
      Assert.AreEqual(2, groups.First().First().Issue);
      Assert.AreEqual("Issue 2", groups.First().First().Name);
    }
  }
}