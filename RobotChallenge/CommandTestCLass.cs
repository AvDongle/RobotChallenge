using System;
using System.Windows;
using NUnit.Framework;
using System.Collections.Generic;

namespace RobotChallenge
{
	[TestFixture]
	public class CommandTestClass
	{
		CommandProcessor _processor;
		Robot myRobot;

		[SetUp]
		public void Setup()
		{
			myRobot = new Robot ();
			_processor = new CommandProcessor ();

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

		[Test]
		public void CommandLoad()
		{
			_processor.Load ();
			StringAssert.AreEqualIgnoringCase ("PLACE 0,0,NORTH", _processor._commands [0]);
			_processor.Process (_processor._commands [0], myRobot);
			Assert.True (myRobot.IsPlaced);
		}

		[Test]
		public void CommandLoadProcesss()
		{
			_processor.Load(@"C:\Users\AvDongle\Documents\CurveTomorrow\test2.txt");
			Assert.AreEqual (4, _processor._commands.Count);
		}

		[Test]
		public void CommandRun()
		{
			_processor.Load ();
			_processor.Run (myRobot);
			Assert.True (myRobot.IsPlaced);
			Assert.AreEqual (new Point (0, 1), myRobot.Position);
		}

		[Test]
		public void CommandRunErrortext()
		{
			_processor.Load(@"C:\Users\AvDongle\Documents\CurveTomorrow\test3.txt");
			_processor.Run (myRobot);
			Assert.False (myRobot.IsPlaced);

			_processor.Load(@"C:\Users\AvDongle\Documents\CurveTomorrow\test4.txt");
			_processor.Run (myRobot);
			Assert.True (myRobot.IsPlaced);
			Assert.AreEqual (Direction.EAST, myRobot.Faced);
			Assert.AreEqual (new Point (2, 1), myRobot.Position);
		}

		[Test]
		public void CommandRunNoFile()
		{
			_processor.Load(@"C:\Users\AvDongle\Documents\CurveTomorrow\test5.txt");
			_processor.Run (myRobot);
			Assert.False (myRobot.IsPlaced);
		}

	}
}
