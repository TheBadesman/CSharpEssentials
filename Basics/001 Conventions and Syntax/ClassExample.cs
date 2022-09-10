//Use this file to store your work to demonstrate your understanding of operators
//Make sure your work is different from the instructors examples or your peers
using System;

public class ClassExample
{
    
}

public class ClassWithVariables
{
    public int number = 2;
    public string userName = "Bob";
    public string kingKiller = "The king killer was beaten, but his return has already been fortold";
}

public class ClassWithFunctions
{

    public ClassWithVariables strings;

    public void RunFunction()
    {
        Console.WriteLine("Running Function");
    }

    public void BetterFunction()
    {
        Console.WriteLine(strings.kingKiller);
    }
}   
