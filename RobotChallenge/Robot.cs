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
				_position.X = (value.X <= _maxX && value.X >= 0) ? value.X : _position.X;
				_position.Y = (value.Y <= _maxY && value.Y >= 0) ? value.Y : _position.Y;
			}
		}
	}
}

