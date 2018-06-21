using System;

class User {
  private string name = "me!";
  // プロパティ
  public string Name {
    get { return this.name; } // getter
    set {
      if (value != "") {
        this.name = value;
      }
    } // setter. we can set various function to setter concerning value.
  }
  // public string Name { get; set; } = "me!";
}

class MyApp {

  static void Main() {
    User user = new User();
    Console.WriteLine(user.Name);
    user.Name = "taguchi";
    Console.WriteLine(user.Name);
    user.Name = "";
    Console.WriteLine(user.Name);
  }

}
