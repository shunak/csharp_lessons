//  メンバ（変数とメソッド）は継承されますが、constructorは継承されません。

// どうするかなのですが、AdminUser() で string name を渡してあげつつ、その name を親クラスのコンストラクタに渡したいので、
// base() という特殊なキーワードを使ってあげて…、base() と書くと親クラスのコンストラクタとなるので、そちらに name を渡してあげましょう。

// それから親クラスのメソッドを実は上書きすることもできたりします。
// 親クラスのメソッドを上書きするときには親クラスには virtual、子クラスには override とつけてあげてください。

using System;

// 継承
// User -> AdminUser

class User {
  public string name;
  public User(string name) {
    this.name = name;
  }
  public virtual void SayHi() {
    Console.WriteLine($"hi {name}");
  }
}

class AdminUser: User {
  public AdminUser(string name): base(name) {
  }
  public void SayHello() {
    Console.WriteLine($"hello {name}");
  }
  public override void SayHi() { // override
    Console.WriteLine($"[admin] hi {name}");
  }
}

class MyApp {

  static void Main() {
    User tom = new User("Tom");
    tom.SayHi();
    AdminUser bob = new AdminUser("Bob");
    bob.SayHi();
    bob.SayHello();
  }

}
