using System;

namespace RobotChallenge
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Robot myRobot = new Robot ();
			CommandProcessor processor = new CommandProcessor ();
			string menu = "Welcome to Weyland Industries\n" +
			              "Control Utility for Robotic Vehicle Execution\n" +
			              "C.U.R.V.E\n" +
				"Please Enter a Command (enter to exit)\n" +
			              "PLACE X,Y,F\n" +
			              "MOVE\n" +
			              "LEFT/RIGHT\n" +
			              "REPORT\n" +
			              "LOAD FILENAME\n" +
			              "RUN";
						
			string input;

			Console.WriteLine (menu);
			while (true) {
				input = Console.ReadLine ();
				if (input == "")
					break;
				if (input.ToLower() == "menu" )
					Console.WriteLine (menu);
				else
					processor.Process (input, myRobot);
			}
		}
	}
}
