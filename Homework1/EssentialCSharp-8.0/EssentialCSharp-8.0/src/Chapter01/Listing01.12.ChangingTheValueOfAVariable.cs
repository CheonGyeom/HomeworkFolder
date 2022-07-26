namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_12
{
    public class MiracleMax
    {
        public static void Main()
        {
            string valerie;
            string miracleMax = "Have fun storming the castle!"; //선언과 동시에 할당 가능

            valerie = "Think it will work?";

            System.Console.WriteLine(miracleMax);
            System.Console.WriteLine(valerie);

            miracleMax = "It would take a miracle.";
            System.Console.WriteLine(miracleMax);
        }
    }
}
