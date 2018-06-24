using System;

// generalization data type of class
// we can use free data type (ex string, int, double) at class method argument.


// Generic

// class MyInteger {
//   public void GetThree(int x) {
//     Console.WriteLine(x);
//     Console.WriteLine(x);
//     Console.WriteLine(x);
//   }
// }

class MyData<T> {
  public void GetThree(T x) {
    Console.WriteLine(x);
    Console.WriteLine(x);
    Console.WriteLine(x);
  }
}

class MyApp {

  static void Main() {
    // MyInteger mi = new MyInteger();
    // mi.GetThree(55);
    MyData<string> s = new MyData<string>();
    s.GetThree("hello");
    MyData<double> d = new MyData<double>();
    d.GetThree(23.3);
  }

}
