# デリゲート
<<<<<<< HEAD
メソッドを変数に入れて扱える。複数のメソッドをまとめて呼び出すこともできる。
→ 例：ボタンクリックのイベントに複数の処理を登録する。

## デリゲートのうれしさ
- メソッドをパラメータとして渡せる。→ 実行するメソッドの動的決定が可能。
- 1つのイベントに複数のメソッドを登録でいる。→ イベント駆動プログラミングが簡単になる。
- 型安全。コンパイル時にメソッドシグネチャとデリゲートシグネチャが一致することが確認される。

## デリゲートの書き方
```cs
internal class TryDelegate
{
    public delegate void Greet(string message);

    public static void Run()
    {
        // 単一のメソッドを呼び出すデリゲート
        Greet greetSingle = (string message) => Console.WriteLine($"Hello {message}");

        // マルチキャストデリゲート
        Greet greetMulti = (string message) => Console.WriteLine($"Hello {message}");
        greetMulti += (string message) => Console.WriteLine($"こんにちは {message}");
        greetMulti += (string message) => Console.WriteLine($"Hola {message}");

        greetMulti("たかし");
    }
}

```
=======

## デリゲートの意義
- メソッドをパラメータとして渡せる。→ 実行するメソッドの動的決定が可能。
- 1つのイベントで複数メソッドを呼び出すなど、まとめて連結可能。
- 型安全。コンパイル時にメソッドシグネチャとデリゲートシグネチャが一致することが確認される。
>>>>>>> parent of f2e5057 (Revert "VSCodeでのビルドとデリゲートの学習成果を格納")
