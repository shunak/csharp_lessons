using System;

// 例外

class MyException: Exception {
  public MyException(string msg): base(msg) {

  }
}

class MyApp {

  static void Div(int a, int b) {
    try {
      if (b < 0) {
        // 例外
        throw new MyException("not minus!");
      }
      Console.WriteLine(a / b);
    } catch (DivideByZeroException e) {
      Console.WriteLine(e.Message);
    } catch (MyException e) {
      Console.WriteLine(e.Message);
    } finally {
      Console.WriteLine(" -- end -- ");
    }
  }

  static void Main() {
    Div(10, 0);
    Div(10, -3);
  }

}
