using System;

// イベント
// イベントは何かが起きたときに何らかの通知をするための仕組み

delegate void MyEventHandler();

class MyButton {
  public event MyEventHandler MyEvent;
  public void OnClicked() {
    if (MyEvent != null) {
      MyEvent();
    }
  }
}

class MyApp {

  static void Main() {
    MyButton btn = new MyButton();
    btn.MyEvent += () => Console.WriteLine("Button Clicked!");
    btn.OnClicked();
  }

}
