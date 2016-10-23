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
	}
}
