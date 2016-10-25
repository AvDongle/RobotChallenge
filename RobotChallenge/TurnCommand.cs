using System;

namespace RobotChallenge
{
	public class TurnCommand:AbstractCommand
	{
		public TurnCommand ()
		{
		}

		public override void Execute(Robot robot, string text)
		{
			if (robot.IsPlaced) {
				if (text.ToUpper () == "LEFT")
					robot.Left ();
				else
					robot.Right ();
			}
		}
	}
}

