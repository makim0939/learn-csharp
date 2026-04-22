using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LearnDelegate
{
    internal class DeclareDelegate
    {
        public delegate void Notify(string message);

        public static void Run()
        {
            // メソッドグループでデリゲートインスタンスを作成する。
            var notifyMethod = new Notify(NotifyMethod);

            // ラムダ式でデリゲートインスタンスを作成する。
            var notifyLamda = (string message) => Console.WriteLine(message);

            // 使うかわからないけど、匿名関数でインスタンス作成もできる。
            var notifyNew = new Notify(NotifyMethod);
            var notifyAnonymous = delegate (string message) { Console.WriteLine(message);};
        }

        public static void NotifyMethod(string a)
        {
            Console.WriteLine(a);
        }
    }
}
