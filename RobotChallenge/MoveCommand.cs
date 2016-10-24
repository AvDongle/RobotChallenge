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
			robot.Move ();
		}
	}
}

