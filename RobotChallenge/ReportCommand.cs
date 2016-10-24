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
			Console.WriteLine (robot.Report());
		}
	}
}

