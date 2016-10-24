using System;
using NUnit.Framework;

namespace RobotChallenge
{
	[TestFixture]
	public class NUnitTestClass
	{
		[Test]
		public void RobotDefault()
		{
			Robot myRobot = new Robot ();
			Assert.IsNotNull (myRobot);
		}

		[Test]
		public void RobotPositionField()
		{
			Robot myRobot = new Robot ();
			Assert.True (myRobot.Position.X == 0);
			Assert.True (myRobot.Position.Y == 0);
		}

		[Test]
		public void RobotMaxFieldsConstructor()
		{
			Robot myRobot = new Robot ();
			Assert.True (myRobot._maxX == 5);
			Assert.True (myRobot._maxY == 5);
		}
	}
}
