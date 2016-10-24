using System;
using System.Windows;
using NUnit.Framework;

namespace RobotChallenge
{
	[TestFixture]
	public class CommandTestClass
	{
		Robot myRobot;
		MoveCommand move;
		ReportCommand report;
		PlaceCommand place;

		[SetUp]
		public void Setup()
		{
			myRobot = new Robot ();
			move = new MoveCommand ();
			report = new ReportCommand ();
			place = new PlaceCommand ();
		}

		[Test]
		public void CommandDefault()
		{
			Assert.NotNull (move);
			Assert.NotNull (report);
			Assert.NotNull (place);
		}

		[Test]
		public void MoveExecute()
		{
			move.Execute (myRobot);
			Assert.AreEqual (Direction.NORTH, myRobot.Faced);
			Assert.AreEqual (-1, myRobot.Position.X);
			Assert.AreEqual (-1, myRobot.Position.Y);
			myRobot.Move ();
			Assert.AreEqual (-1, myRobot.Position.X);
			Assert.AreEqual (-1, myRobot.Position.Y);

			myRobot.PlaceRobot (new Point (0, 0), Direction.NORTH);
			move.Execute (myRobot);
			Assert.AreEqual (new Point (0, 1), myRobot.Position);
		}

			
	}
}
