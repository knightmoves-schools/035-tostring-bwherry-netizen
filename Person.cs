namespace knightmoves;

public class Person {
   private string firstName.ToString();
   private string lastName.ToString();
   private int age.ToString();

   public Person(string firstName, string lastName, int age){
      this.firstName = firstName;
      this.lastName = lastName;
      this.age = age;
   }

 public override string? ToString()
 {
    return $"First name: {firstName}, Last name: {lastName}, Age: {age}";
 }

}

