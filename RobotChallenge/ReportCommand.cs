using System;

namespace RobotChallenge
{
	public class ReportCommand: AbstractCommand
	{
		public ReportCommand ()
		{
		}

		public override void Execute(Robot robot)
		{
			if (robot.IsPlaced)
				Console.WriteLine (robot.Report ());
			else
				Console.WriteLine ("Robot not Placed");
		}
	}
}

