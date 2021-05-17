namespace csday1.Models
{
  // Access Modifier (Public, Internal, Private, Protected)
  // Public: can be accessed from outside the namespace,
  // Private: can only be accessed from within the class,
  // *Internal: can be accessed by anything inside the same namespace,
  // *Protected: can only be accessed by children that inherit the class


  // default access modifier is Internal
  public class User
  {
    // AccessModifier, DataType, Name
    public string Name { get; set; }
    public int Age { get; private set; }

    // method signature (access modifier, return type, name)
    // VOID means 'nothing'
    public void Birthday()
    {
      Age++;
      //   if (Age > 100)
      //   {
      //     return "Happy Birthday, ya ol fart";
      //   }
      //   return "Happy Birthday";
    }





    public User(string name, int age)
    {
      Name = name;
      Age = age;
    }
  }
}