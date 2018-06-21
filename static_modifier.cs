using System;

// static

class User {
  private static int count = 0;
  public User() {
    User.count++;
  }
  public static void GetCount() {
    Console.WriteLine($"# of instances: {count}");
  }
}

class MyApp {

  static void Main() {
    User.GetCount(); // 0
    User user1 = new User();
    User user2 = new User();
    User user3 = new User();
    User.GetCount(); // 3
  }

}
