// The Expectation is that you write your own code based
// on what you have learned in the class, it can be what you want
// If you are havind trouble thinging of something, write conditionals
// with the topic of PowerUps, what happens if the powerUp is good or bad.
using System;

public class program
{

    public void Main()
    {

        //used to show how many soldier are left, used as a string for alt responses
        string soundOff = "1B";

        //Different responses for the amount of soldiers left in the squad
        switch(soundOff){

            case "1A":
                Console.WriteLine("Only me here sir, maybe we should get out of here? No? Alright?");
            break;

            case "1B":
                Console.WriteLine("I think the others didn't make it, I'm not sure that we can keep going on with just us sir");
            break;

            case "2A":
                Console.WriteLine("Two of us left, maybe we should fall back");
            break;

            case "2B":
                Console.WriteLine("Damn it we lost both Jamie and Tim, we can't take many more engagement before the worst happens");
            break;

            case "3A":
                Console.WriteLine("Three of us left, only lose one in that last fight.");
                Console.WriteLine("Poor Tim, two weeks out from retirement too");
            break;

            case "3B":
                Console.WriteLine("We lost Jamie, but other than that we are still good");
            break;

            case "4A":
                Console.WriteLine("Still got all four sir, let's try to keep it that way alright? I hate writing reports");
            break;

            case "4B":
                Console.WriteLine("Uhhhhh let me check sir... 1,2,3,4 ... yeah we are all still here");
            break;

        }

    }

}
