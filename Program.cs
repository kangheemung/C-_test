using System;

class Program
{
    static void Main()
    {
        string aFriend = "Kang";
        
        Console.WriteLine($"Hello, {aFriend}!");
        Console.WriteLine("Hello " + aFriend);
        Console.WriteLine($"Hello {aFriend}");

        string firstFriend = "NaNa";
        string secondFriend = "RUBY";
        Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
        
        Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
        Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

        string sayHello = "Hello World!";
        Console.WriteLine(sayHello);
        sayHello = sayHello.Replace("Hello", "Greetings");
        Console.WriteLine(sayHello);
        Console.WriteLine(sayHello.ToUpper());
        Console.WriteLine(sayHello.ToLower());

        string songLyrics = "You say goodbye, and I say hello";
        Console.WriteLine(songLyrics.Contains("goodbye"));
        Console.WriteLine(songLyrics.Contains("greetings"));

        string greeting = "      Hello World_kangs!       ";
        Console.WriteLine($"[{greeting}]");

        string trimmedGreeting = greeting.TrimStart();
        Console.WriteLine($"[{trimmedGreeting}]");

        trimmedGreeting = greeting.TrimEnd();
        Console.WriteLine($"[{trimmedGreeting}]");

        trimmedGreeting = greeting.Trim();
        Console.WriteLine($"[{trimmedGreeting}]");

        // New code from the Kadai class starts here
        string sentence = "You say goodbye, I say hello";

        if (sentence.StartsWith("You"))
        {
            Console.WriteLine("Sentence starts with 'You'.");
        }
        else
        {
            Console.WriteLine("Sentence does not start with 'You'.");
        }

        if (sentence.StartsWith("goodbye"))
        {
            Console.WriteLine("Sentence starts with 'goodbye'.");
        }
        else
        {
            Console.WriteLine("Sentence does not start with 'goodbye'.");
        }

        if (sentence.EndsWith("hello"))
        {
            Console.WriteLine("Sentence ends with 'hello'.");
        }
        else
        {
            Console.WriteLine("Sentence does not end with 'hello'.");
        }

        if (sentence.EndsWith("goodbye"))
        {
            Console.WriteLine("Sentence ends with 'goodbye'.");
        }
        else
        {
            Console.WriteLine("Sentence does not end with 'goodbye'.");
        }
    }
//課題
//StartsWith と EndsWith の 2 つの同様のメソッドがあり、文字列内の部分文字列も検索します。 これらのメソッドは、文字列の先頭または末尾に部分文字列を検索します。 Containsの代わりに StartsWith と EndsWith を使用するように前のサンプルを変更してみてください。 文字列の先頭に "You" または "goodbye" を検索します。 文字列の末尾に "hello" または "goodbye" を検索します。
class Kadai
{
    static void body()
    {
        string sentence = "You say goodbye, I say hello";

        // 文の先頭が "You" で始まるかチェック
        if (sentence.StartsWith("You"))
        {
            Console.WriteLine("文の先頭に 'You' が含まれています。");
        }
        else
        {
            Console.WriteLine("文の先頭に 'You' が含まれていません。");
        }

        // 文の先頭が "goodbye" で始まるかチェック
        if (sentence.StartsWith("goodbye"))
        {
            Console.WriteLine("文の先頭に 'goodbye' が含まれています。");
        }
        else
        {
            Console.WriteLine("文の先頭に 'goodbye' が含まれていません。");
        }

        // 文の末尾が "hello" で終わるかチェック
        if (sentence.EndsWith("hello"))
        {
            Console.WriteLine("文の末尾に 'hello' が含まれています。");
        }
        else
        {
            Console.WriteLine("文の末尾に 'hello' が含まれていません。");
        }

        // 文の末尾が "goodbye" で終わるかチェック
        if (sentence.EndsWith("goodbye"))
        {
            Console.WriteLine("文の末尾に 'goodbye' が含まれています。");
        }
        else
        {
            Console.WriteLine("文の末尾に 'goodbye' が含まれていません。");
        }
    }
}

}
