using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Comics {
  internal class Comic {
    public string Name { get; set; }
    public int Issue { get; set; }

    public override string ToString() => $"{Name} (Issue #{Issue})";

    public static readonly IEnumerable<Comic> Catalog =
      new List<Comic> {
        new() { Name = "Johnny America vs. the Pinko", Issue = 6 },
        new() { Name = "Rock and Roll (limited edition)", Issue = 19 },
        new() { Name = "Woman’s Work", Issue = 36 },
        new() { Name = "Hippie Madness (misprinted)", Issue = 57 },
        new() { Name = "Revenge of the New Wave Freak (damaged)", Issue = 68 },
        new() { Name = "Black Monday", Issue = 74 },
        new() { Name = "Tribal Tattoo Madness", Issue = 83 },
        new() { Name = "The Death of the Object", Issue = 97 }
      };

    /*IReadOnlyDictionary<T,S> includes only the methods to read values (so
     * that thye are not accidentaly changed). */
    public static readonly IReadOnlyDictionary<int, decimal> Prices =
      new Dictionary<int, decimal> {
        { 6, 3600M },
        { 19, 500M },
        { 36, 650M },
        { 57, 13525M },
        { 68, 250M },
        { 74, 75M },
        { 83, 25.75M },
        { 97, 35.25M }
      };
  }
}