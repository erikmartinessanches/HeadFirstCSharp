namespace ExtentionMethodsExample {
   sealed class OrdinaryHuman //Sealed, so we can't inherit from it.
    {
      private int age;
      int weight;
      public OrdinaryHuman(int weight) {
         this.weight = weight;
      }
      public void GoToWork() { /* code to go to work */ }
      public void PayBills() { /* code to pay bills */ }
   }
}
