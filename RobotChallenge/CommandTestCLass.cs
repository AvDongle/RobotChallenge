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
		Robot myRobot = new Robot();

		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void CommandProcess()
		{
			_processor.Process ("MOVE", myRobot);
			Assert.AreEqual (Direction.NORTH, myRobot.Faced);
			Assert.AreEqual (-1, myRobot.Position.X);
			Assert.AreEqual (-1, myRobot.Position.Y);

			_processor.Process("PLACE 0,0,NORTH", myRobot);
			Assert.True (myRobot.IsPlaced);
			Assert.AreEqual (new Point (0, 0), myRobot.Position);

			_processor.Process ("MOVE", myRobot);
			Assert.AreEqual (Direction.NORTH, myRobot.Faced);
			Assert.AreEqual (0, myRobot.Position.X);
			Assert.AreEqual (1, myRobot.Position.Y);


		}			
	}
}
