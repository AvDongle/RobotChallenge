using System;
using System.Windows;
using NUnit.Framework;

namespace RobotChallenge
{
	[TestFixture]
	public class NUnitTestClass
	{
		Robot myRobot;

		[SetUp]
		public void Setup()
		{
			myRobot = new Robot ();
		}

		[Test]
		public void RobotDefault()
		{
			Assert.IsNotNull (myRobot);
		}

		[Test]
		public void RobotPositionField()
		{
			Assert.AreEqual (0,myRobot.Position.X);
			Assert.AreEqual (0,myRobot.Position.Y);
		}

		[Test]
		public void RobotMaxFieldsConstructor()
		{
			Assert.AreEqual (5, myRobot._maxX);
			Assert.AreEqual (5, myRobot._maxY);
		}

		[Test]
		public void RobotPositionProperty()
		{
			myRobot.Position = new Point (5, 5);
			Assert.AreEqual (5, myRobot.Position.X);
			Assert.AreEqual (5,myRobot.Position.Y);
			myRobot.Position = new Point (0, 0);
			Assert.AreEqual (0, myRobot.Position.X);
			Assert.AreEqual (0, myRobot.Position.Y);
			myRobot.Position = new Point (-1, -1);
			Assert.AreEqual (0, myRobot.Position.X);
			Assert.AreEqual (0, myRobot.Position.Y);
			myRobot.Position = new Point (6, 5);
			Assert.AreEqual (0, myRobot.Position.X);
			Assert.AreEqual (5, myRobot.Position.Y);
		}

	}
}
