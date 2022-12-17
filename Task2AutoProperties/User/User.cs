public class User{
    public string Username;
    public string Password;

    public void Introduce(){
        Console.WriteLine( $"I am {Username}");
    }

     public void Login(string username, string password){
      
        if(Username==username && Password==password){
            Console.WriteLine("Welcome"); 
        }
        else{
           Console.WriteLine("Wrong password"); 
        }
    }
}