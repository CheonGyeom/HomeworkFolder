namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter01.Listing01_14
{
    public class HeyYou
    {
        public static void Main()
        {
            string firstName;
            string lastName;

            System.Console.WriteLine("Hey you!");

            System.Console.Write("Enter your first name: ");
            firstName = System.Console.ReadLine(); //�ش� �� �б�, �� �Ҵ��ϱ� (��ǲ�ʵ� ����)

            System.Console.Write("Enter your last name: ");
            lastName = System.Console.ReadLine();
        }
    }
}