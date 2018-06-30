using System;
using System.Collections.Generic;

// Collection
// - List
// - HashSet
    // ・not having order
// - Dictionary

class MyApp {

  static void Main() {
    HashSet<int> answers = new HashSet<int>() { 3, 5, 8, 5 };
    answers.Add(10); // 3, 5, 8, 10
    answers.Remove(3); // 5, 8, 10
    Console.WriteLine(answers.Contains(3)); // false
    foreach (var answer in answers) {
      Console.WriteLine(answer);
    }
  }

}
