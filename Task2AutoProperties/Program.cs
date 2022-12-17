User user = new User();
System.Console.Write("Username : ");
user.Username=Convert.ToString(Console.ReadLine());
System.Console.Write("Password : ");
user.Password=Convert.ToString(Console.ReadLine());

user.Introduce();
System.Console.Write("username : ");
 string username=Convert.ToString(Console.ReadLine());
 System.Console.Write("password : ");
 string password=Convert.ToString(Console.ReadLine());
user.Login(username, password);