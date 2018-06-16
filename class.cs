using System;

// Class
// - 変数（フィールド）
// - メソッド

class User {
  public string name = "me";
  public void SayHi() {
    // Console.WriteLine($"hi {this.name}");
    Console.WriteLine($"hi {name}");
  }
}

class MyApp {
  
  // そのクラスのインスタンスを呼び出すときには、そのクラスの型のインスタンスとして呼び出します。
  //  Userクラスなら、User型のインスタンスとして呼び出すことになります。
  static void Main() {
    User user = new User(); // インスタンス
    Console.WriteLine(user.name); // me
    user.SayHi(); // hi! me
    user.name = "taguchi";
    user.SayHi(); // hi! taguchi
  }

}
