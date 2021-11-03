using System;

namespace RxTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer<string> source = null;
            var root = new Observable<string>(o =>
            {
                source = o;
            });

            var second = new Observable<string>(o =>
            {
                root.Subscribe(new Observer<string>(s =>
                {
                    Console.WriteLine($"'{s}'が流れてきます。");
                    o.onNext(s + s);

                }));
            });

            var third = new Observable<string>(o =>
            {
                second.Subscribe(new Observer<string>(s =>
                {
                    if (s == "ふがふが")
                    {
                        Console.WriteLine("'ふがふが'は先に流しません");
                    }
                    else
                    {
                        o.onNext(s);
                    }
                }));
            });

            third.Subscribe(new Observer<string>(s =>
            {
                Console.WriteLine($"値:{s}");
            }));

            source.onNext("テスト");
        }
    }
}
