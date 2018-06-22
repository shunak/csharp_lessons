using System;

// 抽象クラス
// 抽象クラスは他のクラス(具象クラス)に継承してもらうことを前提にしているクラスで、それ自身をインスタンス化することはできません。
// 抽象クラスを使うと、関連するクラスの共通部分だけを切り出して具象クラスのほうに実装を任せることができたりします。

// User -> Japanese, American

// abstract class User
abstract class User {
  public abstract void SayHi();
}

// Concrete Class Japanese
class Japanese: User {
  public override void SayHi() {
    Console.WriteLine("こんにちは！");
  }
}

// Concrete Class American
class American: User {
  public override void SayHi() {
    Console.WriteLine("hi!");
  }
}

class MyApp {

  static void Main() {
    Japanese aki = new Japanese();
    aki.SayHi();
    American tom = new American();
    tom.SayHi();
  }

}
