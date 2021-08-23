using System;

class MainClass {
  public static void Main (string[] args) {
    int i = 0;
    for (i = 0; i < 1000000; i++)
    {
      Console.WriteLine("Hello girl or boy ! Choose a first number for your calculation :");
      string firstNumber = Console.ReadLine();
      float firstIntNumber = Convert.ToInt32(firstNumber);

      Console.WriteLine("Good ! Now choose a second number for your calculation :");
      string secondNumber = Console.ReadLine();
      float secondIntNumber = Convert.ToInt32(secondNumber);

      Console.WriteLine("Perfect ! Now choose an operation (Add, Substract, Multiply, Divide or Modulo) :");
      string operation = Console.ReadLine();

      if (operation == "Add")
      {
        float result = Add(firstIntNumber, secondIntNumber);
        Console.WriteLine("The result of your operation is " + result + " !\n");
      } 
      else if (operation == "Substract")
      {
        float result = Substract(firstIntNumber, secondIntNumber);
        Console.WriteLine("The result of your operation is " + result + " !\n");
      }
      else if (operation == "Multiply")
      {
        float result = Multiply(firstIntNumber, secondIntNumber);
        Console.WriteLine("The result of your operation is " + result + " !\n");
      }
      else if (operation == "Divide")
      {
        float result = Divide(firstIntNumber, secondIntNumber);
        Console.WriteLine("The result of your operation is " + result + " !\n");
      }
      else if (operation == "Modulo")
      {
        float result = Modulo(firstIntNumber, secondIntNumber);
        Console.WriteLine("The result of your operation is " + result + " !\n");
      }
      else
      {
        Console.WriteLine("You chose a wrong operation ! This will restart !\n");
      }
    }
  }

  public static float Add (float firstIntNumber, float secondIntNumber) {
    return firstIntNumber + secondIntNumber;
  }

  public static float Substract (float firstIntNumber, float secondIntNumber) {
    return firstIntNumber - secondIntNumber;
  }

  public static float Multiply (float firstIntNumber, float secondIntNumber) {
    return firstIntNumber * secondIntNumber;
  }

  public static float Divide (float firstIntNumber, float secondIntNumber) {
    return firstIntNumber / secondIntNumber;
  }

  public static float Modulo (float firstIntNumber, float secondIntNumber) {
    return firstIntNumber % secondIntNumber;
  }
}