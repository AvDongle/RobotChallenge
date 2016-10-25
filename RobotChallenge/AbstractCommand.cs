using System;

namespace RobotChallenge
{
	public abstract class AbstractCommand
	{
		public AbstractCommand (){}
		public virtual void Execute(Robot robot){}
		public virtual void Execute(Robot robot, string text){}
	}
}

