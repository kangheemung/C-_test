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
        //文字の長さ表示Length
        Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
        Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

        //挨拶してみる。。＝W=
        string sayHello = "Hello World!";
        Console.WriteLine(sayHello);
        sayHello = sayHello.Replace("Hello", "Greetings");
        Console.WriteLine(sayHello);
        Console.WriteLine(sayHello.ToUpper());
Console.WriteLine(sayHello.ToLower());
    }
}
