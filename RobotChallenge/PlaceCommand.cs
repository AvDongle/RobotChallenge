using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;

namespace RobotChallenge
{
	public class PlaceCommand:AbstractCommand
	{
		public PlaceCommand ()
		{
		}

		public override void Execute(Robot robot, string text)
		{
			var args = text.Split(',').ToList();
			Point pt = new Point (-1, -1);
			Direction Faced = Direction.NORTH;
			bool inputfailed = false;

			if (args.Count == 3) {
				try{
					pt = new Point(int.Parse(args[0]), int.Parse(args[1]));
				}
				catch (FormatException) {
					inputfailed = true;
				}
				try{
					Faced = (Direction) Enum.Parse(typeof(Direction), args[2].ToUpper());        
				}
				catch (ArgumentException) {
					inputfailed = true;
				}
				if (!inputfailed)
					robot.PlaceRobot (pt,Faced);
			}
		}
	}
}

