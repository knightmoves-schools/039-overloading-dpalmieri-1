namespace knightmoves;

public class Person{
   public string FirstName;
   public string LastName;
   public int Age;

   //Add your code here
   public Constructor1(string firstName, string lastName){
      this.firstName = FirstName;
      this.lastName = LastName;
   }
    public Constructor1(string firstName, string lastName, int age){
      firstName = FirstName;
      lastName = LastName;
      age = Age;
   }

   public void Display() {
      return $"{firstName}, {lastName}, {age}";
   }

   public static void Test(){
      Constructor1 test1 = new Constructor1("Alex", " Blex");
      Constructor1 test2 = new Constructor1("Mua", 22);

      test1.Display();
      test2.Display();
   }
}










