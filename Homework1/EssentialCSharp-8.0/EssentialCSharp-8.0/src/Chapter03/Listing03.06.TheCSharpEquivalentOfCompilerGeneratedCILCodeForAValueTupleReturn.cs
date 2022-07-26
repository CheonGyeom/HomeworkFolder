namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_06
{
    namespace Chapter03
    {
        [return: System.Runtime.CompilerServices.TupleElementNames(new string[] { "First", "Second" })]
        public System.ValueTuple<string, string> ParseNames(string fullName)
        {
            // ...
        }

    }

    public class Program
    {
        (string First, string Second, string Third) namedFruits = ("apple", "orange", "banana");

        namedFruits.First = "Eat";
    }
}
