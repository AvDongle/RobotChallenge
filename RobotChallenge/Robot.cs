using System;
using System.Windows;

namespace RobotChallenge
{
	public class Robot
	{
		private Point _position = new Point(0,0);

		public Robot ()
		{
		}

		public Point Position {
			get {
				return _position;
			}
			set {
				_position = value;
			}
		}
	}
}

