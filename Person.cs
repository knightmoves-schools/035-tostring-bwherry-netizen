namespace knightmoves;

public class Person {
   private abstract string firstName.ToString();
   private abstract string lastName.ToString();
   private abstract int age.ToString();

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


