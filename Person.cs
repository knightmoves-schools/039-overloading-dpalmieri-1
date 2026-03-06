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
   }
   public Constructor2(string firstName, string lastName){
      this.firstName = FirstName;
      this.lastName = LastName;
   }
   public string Sentence(){
      return $"{firstName} {lastName}, you're {age}";
   }
}



