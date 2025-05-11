using System;

class Program
{
    static void Main()
    {
        // aFriend変数をstring型で定義
        string aFriend = "Kang";

        // aFriend変数を使用して何か処理を実行
        Console.WriteLine($"Hello, {aFriend}!");

        Console.WriteLine("Hello " + aFriend);
        Console.WriteLine($"Hello {aFriend}");
        string firstFriend = "NaNa";
        string secondFriend = "RUBY";
        Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
    }
}
