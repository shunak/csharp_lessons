using System;

// delegate
メソッドを割り当てることができる変数


delegate void MyDelegate();

class MyApp {

  // static void SayHi() {
  //   Console.WriteLine("hi!");
  // }
  static void SayHi() => Console.WriteLine("hi!");
  static void SayHello() => Console.WriteLine("hello!");

  static void Main() {

    MyDelegate ShowMessage;

    ShowMessage = SayHi;
    ShowMessage += SayHello;

    ShowMessage();

  }

}
