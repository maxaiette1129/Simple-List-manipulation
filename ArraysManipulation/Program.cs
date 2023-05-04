namespace ArraysManipulation
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            List<string> password = new List<string>();
            string uname;
            string upassword;

            Console.WriteLine("Enter username: ");
            names.Add(Console.ReadLine());
            Console.WriteLine("Enter password: ");
            password.Add(Console.ReadLine());

            Console.WriteLine("Enter Username");
            uname = Console.ReadLine();
            Console.WriteLine("Enter Password");
            upassword = Console.ReadLine();

            if(names.Contains(uname) && password[names.IndexOf(uname)] == upassword) 
            {
                Console.WriteLine("Login");
            }
            else 
            {
                Console.WriteLine("Error");
            }
            
            
            

            
        }
    }
}