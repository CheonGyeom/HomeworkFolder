namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter02.Listing02_16
{
    public class PalindromeLength
    {
        public static void Main()
        {
            string palindrome;

            System.Console.Write("Enter a palindrome: ");
            palindrome = System.Console.ReadLine();

            System.Console.WriteLine(
                $"The palindrome \"{palindrome}\" is"
                + $" {palindrome.Length} characters.");
        }
    }
}
//Length = 스트링이 몇 글자인지 출력해주는 애