# デリゲート
メソッドを変数に入れて扱える。複数のメソッドをまとめて呼び出すこともできる。
→ 例：ボタンクリックのイベントに複数の処理を登録する。

## デリゲートのうれしさ
- メソッドをパラメータとして渡せる。→ 実行するメソッドの動的決定が可能。
- 1つのイベントに複数のメソッドを登録でいる。→ イベント駆動プログラミングが簡単になる。
- 型安全。コンパイル時にメソッドとデリゲートの戻り値・引数の型と個数が一致することが確認される。

💡 メソッドを箱に入れて、扱えるのが便利。

## デリゲートの書き方
### Action・Funcで定義する


 Action・Funcの他にも...

### メソッドシグネチャで定義する
ジェネリックでは使えない、`ref`・`out` が使える。
引数名を明示して引数の意味を表現できる。（⚠️ 引数名が違っても型と個数が同じなら登録はできる。）

```cs
internal class TryDelegate
{
    public delegate void PerformCalculation(ref int result, int x, int y);

    public static void Run()
    {
        // 定義したデリゲートを型として、メソッドを変数に入れて扱える。
        var add = new PerformCalculation((ref int result, int x, int y) => result = x + y);
        var sub = new PerformCalculation((ref int result, int x, int y) => result = x - y);

        int result = 0;
        add(ref result, 1, 2);
        Console.WriteLine(result); // 3

        sub(ref result, 1, 2);
        Console.WriteLine(result); // -1
    }
}
```
<<<<<<< Updated upstream
=======

Action
- デリゲートの型定義が不要。→ 簡潔になる。型定義が各所に散乱するのを防ぐ。
- 標準APIと相性が良い。
  ```cs
    // 例：Foreachにそのまま渡せる。
    list.Foreach(Action<T> action);
  ```
>>>>>>> Stashed changes
