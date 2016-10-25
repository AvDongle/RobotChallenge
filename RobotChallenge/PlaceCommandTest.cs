using System;
using System.Windows;
using NUnit.Framework;
using System.Collections.Generic;

namespace RobotChallenge
{
	[TestFixture]
	public class PlaceCommandTest
	{
		Robot myRobot;
		PlaceCommand place;

		[SetUp]
		public void Setup()
		{
			myRobot = new Robot ();
			place = new PlaceCommand ();
		}

		[Test]
		public void PlaceInputTest()
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
		}

		[Test]
		public void PlaceBoundaryTest()
		{
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

