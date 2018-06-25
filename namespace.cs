// using System;
using ExampleNamespace;

// 名前空間

namespace ExampleNamespace {
  class User {
    public void SayHi() {
      // Console.WriteLine("hi!");
      System.Console.WriteLine("hi!");
    }
  }
}

class MyApp {

  static void Main() {
    // ExampleNamespace.User user = new ExampleNamespace.User();
    User user = new User();
    user.SayHi();
  }

}
