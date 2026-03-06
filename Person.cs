namespace knightmoves;

public class Person{
   public string FirstName;
   public string LastName;
   public int Age;

   //Add your code here
   public Constructor1(string firstName, string lastName, int age){
      firstName = FirstName;
      lastName = LastName;
      age = Age;
      return $"Hello {firstName} {lastName}! You said you're {age}?";
   }
   public Constructor2(string firstName, string lastName){
      firstName = FirstName;
      lastName = LastName;
      return $"The name's {lastName}, {firstName} {lastName}.";
   }
}

