public class Person{
public string Name;
public string Age;
public float Height;
public byte Weight;

public void Walk(){
    System.Console.WriteLine($"{Name} don't walk.");
}
public void Talk(){
    System.Console.WriteLine($"{Name} is talking");
}
public void Eat(){
    System.Console.WriteLine($"{Name} don't eat.");
}
public void Sleep(){
    System.Console.WriteLine($"{Name} don't sleep.");
}

}