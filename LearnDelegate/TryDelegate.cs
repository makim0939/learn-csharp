using System;

namespace LearnDelegate
{
    public static class TryDelegate
    {

        // デリゲートの定義。
        // クラスのメンバとして、もしくはクラスの外で定義できる。
        // 引数と戻り値の型が一致するメソッドを登録できる。
        public delegate int PerformCalculation(int x, int y);

        public static void Run()
        {
            // 定義したデリゲートを型として、メソッドを変数に入れて扱える。
            var add = new PerformCalculation((int x, int y) => x + y);
            var sub = new PerformCalculation((int x, int y) => x - y);

            Console.WriteLine(add(1, 2)); // 3
            Console.WriteLine(sub(1, 2)); // -1
        }
    }
}
