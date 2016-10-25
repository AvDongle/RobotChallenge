using System;

namespace RobotChallenge
{
	public class MoveCommand : AbstractCommand
	{
		public MoveCommand ()
		{
		}

		public override void Execute(Robot robot)
		{
			if (robot.IsPlaced)
				robot.Move ();
			else
				Console.WriteLine ("Robot not Placed");
		}
	}
}

