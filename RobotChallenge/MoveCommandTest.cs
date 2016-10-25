using System;
using System.Windows;
using NUnit.Framework;
using System.Collections.Generic;

namespace RobotChallenge
{
	[TestFixture]
	public class MoveCommandTest
	{
		Robot myRobot;
		MoveCommand move;

		[SetUp]
		public void Setup()
		{
			myRobot = new Robot ();
			move = new MoveCommand ();
		}

		[Test]
		public void MoveExecute()
		{
			move.Execute (myRobot);
			Assert.AreEqual (Direction.NORTH, myRobot.Faced);
			Assert.AreEqual (-1, myRobot.Position.X);
			Assert.AreEqual (-1, myRobot.Position.Y);

			myRobot.PlaceRobot (new Point (0, 0), Direction.NORTH);
			move.Execute (myRobot);
			Assert.AreEqual (new Point (0, 1), myRobot.Position);
		}
	}
}

