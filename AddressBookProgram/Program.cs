namespace AddressBookProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            Console.WriteLine("Enter your First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter your State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter your ZipCode");
            string zipcode = Console.ReadLine();
            Console.WriteLine("Enter your Email_Id");
            string emailId = Console.ReadLine();
            Console.WriteLine("Enter your Phone_Number");
            string phoneNo = Console.ReadLine();
            Console.WriteLine($"\n First Name : {firstName}\n Last Name : {lastName}\n Address : {address}\n State : {state}\n ZipCode : {zipcode} \n Email ID : {emailId} \n Phone Number : {phoneNo}");
        }
    }
}