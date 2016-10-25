using System;
using System.Windows;
using NUnit.Framework;
using System.Collections.Generic;

namespace RobotChallenge
{
	[TestFixture]
	public class CommandTestClass
	{
		CommandProcessor _processor = new CommandProcessor();
		Robot myRobot;

		[SetUp]
		public void Setup()
		{
			myRobot = new Robot ();
		}

		[Test]
		public void CommandProcessPrePlaced()
		{
			_processor.Process ("MOVE", myRobot);
			Assert.AreEqual (Direction.NORTH, myRobot.Faced);
			Assert.AreEqual (-1, myRobot.Position.X);
			Assert.AreEqual (-1, myRobot.Position.Y);
		}

		[Test]
		public void CommandProcess()
		{
			_processor.Process("PLACE 0,0,NORTH", myRobot);
			Assert.True (myRobot.IsPlaced);
			Assert.AreEqual (new Point (0, 0), myRobot.Position);

			_processor.Process ("MOVE", myRobot);
			Assert.AreEqual (Direction.NORTH, myRobot.Faced);
			Assert.AreEqual (0, myRobot.Position.X);
			Assert.AreEqual (1, myRobot.Position.Y);

			_processor.Process ("LEFT", myRobot);
			Assert.AreEqual (Direction.WEST, myRobot.Faced);
			_processor.Process ("RIGHT", myRobot);
			Assert.AreEqual (Direction.NORTH, myRobot.Faced);
			_processor.Process ("RIGHT", myRobot);
			Assert.AreEqual (Direction.EAST, myRobot.Faced);
			_processor.Process ("LEFT", myRobot);
			Assert.AreEqual (Direction.NORTH, myRobot.Faced);

			_processor.Process ("REPORT", myRobot);
			StringAssert.AreEqualIgnoringCase ("0,1, NORTH", _processor.Report.testmessage);


		}			
	}
}
