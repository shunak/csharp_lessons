using System;

delegate void MyDelegate();

class MyApp {

  // static void SayHi() => Console.WriteLine("hi!");
  // static void SayHello() => Console.WriteLine("hello!");

  static void Main() {

    MyDelegate ShowMessage;

    // 匿名メソッド
    ShowMessage = delegate {
      Console.WriteLine("hi!");
    };
    // ラムダ式: 引数 => 処理
    // ShowMessage += () => {
    //   Console.WriteLine("hello!");
    // };
    ShowMessage += () => Console.WriteLine("hello!");

    ShowMessage();

  }

}
