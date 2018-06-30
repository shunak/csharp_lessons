sing System;
using System.Collections.Generic;

// Collection
// - List
// - HashSet
// - Dictionary

class MyApp {

  static void Main() {
    Dictionary<string, int> users = new Dictionary<string, int>() { // keytype string valuetype int
      {"foo", 50},
      {"baa", 80},
    };
    users.Add("hoge", 40);
    Console.WriteLine(users["baa"]); // 80
    users["foo"] = 60;
    foreach (KeyValuePair<string, int> user in users) {
      Console.WriteLine($"{user.Key}: {user.Value}");
    }
  }

}
