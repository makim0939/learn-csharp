namespace LearnDelegate
{
    internal class ActionAndFunc
    {

        public static void Run()
        {
            // Actionには戻り値なしのメソッドを登録できる。
            Action<string> greet = (string name) => Console.WriteLine($"Hello, {name}!");
            greet("Takashi"); // Hello, Takashi! 

            // Funcには戻り値ありのメソッドを登録できる。
            // ジェネリックで指定した最後の型が戻り値の型となる。
            Func<int, int, bool> compare = (x, y) => x > y;
            Console.WriteLine(compare(3, 2)); // true
        }
    }
}