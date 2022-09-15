using System;
					
public class Program
{
	public GameStates gameStates;
	
	public void Main()
	{
		gameStates = new GameStates();
		gameStates.currentState = GameStates.States.Ending;
		gameStates.CheckState();

		switch (week) {
   		case 55:
    		printf("Fifty five weeks since they last came");
    	break;
    	case 56:
    		printf("Fifty six weeks since they last came");
    	break;
    	case 57:
			printf("Fifty seven weeks since they last came");
    	break;
    	case 58:
    		printf("Fifty eight weeks since they last came");
    	break;
    	case 59:
      		printf("Fifty nine weeks since they last came");
    	break;
    	case 60:
			printf("sixty weeks until since they last came");
    	break;
    	case 0:
    		printf("HERE THEY COME");
    	break;
		

				switch (week) {
   		case 55:
    		printf("Fifty five weeks since they last came");
    	break;
    	case 56:
    		printf("Fifty six weeks since they last came");
    	break;
    	case 57:
			printf("Fifty seven weeks since they last came");
    	break;
    	case 58:
    		printf("Fifty eight weeks since they last came");
    	break;
    	case 59:
      		printf("Fifty nine weeks since they last came");
    	break;
    	case 60:
			printf("sixty weeks until since they last came");
    	break;
    	default:
    		printf("HERE THEY COME");
    	break;
  		}
  }
	}
}

public class GameStates {
	
	public enum States {
		Starting,
		Playing,
		Ending
	}
	
	public States currentState = States.Starting;
	
	public void CheckState () {
		switch (currentState) {
			case States.Starting:
				Console.WriteLine("Starting");
				break;
			case States.Playing:
				Console.WriteLine("Playing");
				break;
			case States.Ending:
				Console.WriteLine("Ending");
				break;
		}
	}
}