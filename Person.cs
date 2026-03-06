namespace knightmoves;

public class Person{
   public string FirstName { get; set; };
   public string LastName { get; set; };
   public int Age { get; set; };

   //Add your code here
   public Constructor1(string firstName, string lastName, int age){
      firstName = FirstName;
      lastName = LastName;
      age = Age;
   }
   public Constructor1(string firstName, string lastName){
      this.firstName = FirstName;
      this.lastName = LastName;
   }
}






