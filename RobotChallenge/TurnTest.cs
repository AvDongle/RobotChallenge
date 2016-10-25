using System;
using System.Windows;
using NUnit.Framework;
using System.Collections.Generic;

namespace RobotChallenge
{
	[TestFixture]
	public class TurnTestCLass
	{
		Robot myRobot;
		TurnCommand turn;

		[SetUp]
		public void Setup()
		{
			myRobot = new Robot ();
			turn = new TurnCommand ();
		}

		[Test]
		public void TurnExecute()
		{
			turn.Execute (myRobot, "LEFT");
			Assert.AreEqual (Direction.NORTH, myRobot.Faced);
			Assert.AreEqual (-1, myRobot.Position.X);
			Assert.AreEqual (-1, myRobot.Position.Y);

			myRobot.PlaceRobot (new Point (0, 0), Direction.NORTH);
			turn.Execute (myRobot, "LEFT");
			Assert.AreEqual (Direction.WEST, myRobot.Faced);

			turn.Execute (myRobot, "RIGHT");
			Assert.AreEqual (Direction.NORTH, myRobot.Faced);
		}
	}
}


