// クラスに対して特定の機能を実装するよう約束させるためのインターフェースという仕組みについて見ていきましょう。
// インターフェースに含めるメソッドは抽象メソッドになるので、こちらに実装の中身を書く必要はありません。
// また自動的にアクセス修飾子は public になるので、ここには何もつけなくていいということも覚えておきましょう。
// なおインターフェースの中のメソッドは抽象メソッドなのですが、こちらで実装するときに override のキーワードはいらないので、注意しておいてください。

using System;

// interface

interface ISharable {
  void Share();
}

class User: ISharable {
  // public void Share() {
  //   Console.WriteLine("now sharing...");
  // }
}

class MyApp {

  static void Main() {
    User user = new User();
    user.Share();
  }

}
