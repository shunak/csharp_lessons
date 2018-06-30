using System;
using System.Collections.Generic;

// Collection
// - List
// - HashSet
// - Dictionary

class MyApp {

  static void Main() {
    // List<int> scores = new List<int>();
    // scores.Add(30);
    // scores.Add(80);
    // scores.Add(60);
    List<int> scores = new List<int>() { 30, 80 , 60 };
    scores[1] = 100;
    Console.WriteLine(scores.Count);
    foreach (var score in scores) {
      Console.WriteLine(score);
    }
  }

}
