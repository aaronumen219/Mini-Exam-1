using System;

class MainClass {
  public static void Main (string[] args) {
      Console.WriteLine("Enter your name");
      string name = Console.ReadLine();
  
      Console.WriteLine ("Enter height in inches");
      double height = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine ("Enter weight in pounds");
      double weight = Convert.ToDouble(Console.ReadLine());

      double BMI = Convert.ToDouble((703 * weight)/(height * height));


      Console.WriteLine("Your BMI is " + BMI);

  if  (BMI < 18.5)
    {
  
      Console.WriteLine(name + ", you are Underweight");

    }
    else if (BMI >= 18.5 && BMI < 25)
    {
      Console.WriteLine(name + ", you are Normal or Healthy Weight");
    }
    else if (BMI >= 25 && BMI < 30)
    {
      Console.WriteLine(name + ", you are Overweight");
    }
    else
    {
      Console.WriteLine(name + ", you are Obese");
    }
  }
}