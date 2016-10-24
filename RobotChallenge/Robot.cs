using System;
using System.Windows;

namespace RobotChallenge
{
	public class Robot
	{
		private Point _position = new Point(0,0);
		public int _maxX, _maxY;

		public Robot () : this (5, 5)
		{
		}

		public Robot(int MaxX, int MaxY)
		{
			_maxX = MaxX;
			_maxY = MaxY;
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

