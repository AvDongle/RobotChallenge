using System;
using System.Windows;
using NUnit.Framework;
using System.Collections.Generic;

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

			myRobot.PlaceRobot (new Point (0, 0), Direction.NORTH);
			move.Execute (myRobot);
			Assert.AreEqual (new Point (0, 1), myRobot.Position);
		}

		[Test]
		public void PlaceExecute()
		{
			place.Execute (myRobot, "0,0,NPORTH");
			Assert.False (myRobot.IsPlaced);

			place.Execute (myRobot, "a,0,NORTH");
			Assert.False (myRobot.IsPlaced);

			place.Execute (myRobot, "Curve Tomorrow");
			Assert.False (myRobot.IsPlaced);

			place.Execute (myRobot, "Curve Tomorrow Today");
			Assert.False (myRobot.IsPlaced);

			place.Execute (myRobot, "0,0,NORTH");
			Assert.True (myRobot.IsPlaced);
			Assert.AreEqual (new Point (0, 0), myRobot.Position);

			place.Execute (myRobot, "5,5,South");
			Assert.AreEqual (new Point (5, 5), myRobot.Position);
			Assert.AreEqual (Direction.SOUTH, myRobot.Faced);

			place.Execute (myRobot, "5,6,east");
			Assert.AreEqual (new Point (5, 5), myRobot.Position);
			Assert.AreEqual (Direction.SOUTH, myRobot.Faced);

			place.Execute (myRobot, "5,4,east");
			Assert.AreEqual (new Point (5, 4), myRobot.Position);
			Assert.AreEqual (Direction.EAST, myRobot.Faced);
		}
			
	}
}
