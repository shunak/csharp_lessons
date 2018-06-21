// About indexer
// like an array,  we can use index for class instances


using System;

// インデクサ

class Team {
  private string[] members = new string[3];
  public string this[int i] {
    get { return this.members[i]; }
    set { this.members[i] = value; }
  }
}

class MyApp {

  static void Main() {
    Team giants = new Team();
    giants[0] = "taguchi";
    giants[1] = "fkoji";
    giants[2] = "dotinstall";
    Console.WriteLine(giants[1]);
  }

}

