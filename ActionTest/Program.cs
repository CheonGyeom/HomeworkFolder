using System;

namespace Action1
{
    class Program
    {

        public static event Action myOwnAction;
        static void Main(string[] args)
        {
            while(true)
            {
                string s1 = Console.ReadLine();

                switch(s1)
                {
                    case "1":
                        myOwnAction += One;
                        break;
                    case "2":
                        myOwnAction += Two;
                        break;
                    case "3":
                        myOwnAction += Three;
                        break;
                    case "4":
                        myOwnAction?.Invoke();
                        break;
                }

                if (s1 == "n")
                {
                    break;
                }
            }

            Console.ReadKey();
        }

        static void One()
        {
            Console.WriteLine("Hi world");
        }

        static void Two()
        {
            Console.WriteLine("hello world");
        }

        static void Three()
        {
            Console.WriteLine("안녕");
        }

    }
}
