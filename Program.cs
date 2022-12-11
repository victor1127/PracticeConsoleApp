




Console.WriteLine("Enter as many names as you want:");
Console.WriteLine("Hit enter when done");

List<string>names=new List<string>();
string input = "start";

while (input != string.Empty)
{
    Console.Write("Enter a name: dsgsdgsdf");
    input = Console.ReadLine()!.ToLower();
    names.Add(input);
}

Console.Clear();
Console.WriteLine("You have entered dasfgsdfgsdfgdf:");

foreach(var name in names)
{
    Console.WriteLine(name);
}

Console.ReadKey();


public class Animal
{
    public virtual string MakeASound()
    {
        return "The animal make a sound";
    }

}

public class Dog: Animal
{
    public override string MakeASound()
    {
        return "The dog makes wowo wow ";
    }

}

public class Cat: Animal
{
    public override string MakeASound()
    {
        return "The cat makes mew mew ";
    }

}