using System;

namespace LearnDelegate
{
    public static class TryDelegate
    {

        // デリゲートの定義。
        // クラスのメンバとして、もしくはクラスの外で定義できる。
        // 戻り値、引数の型と個数が一致するメソッドを登録できる。
        // refパラメータを使って結果を参照で返す例
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
}
