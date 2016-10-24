using System;
using System.Windows;

namespace RobotChallenge
{
	public class Robot
	{
		private Point _position = new Point (-1, -1);
		public int _maxX, _maxY;
		private Direction _faced = 0;

		public Robot () : this (5, 5)
		{
		}

		public Robot(int MaxX, int MaxY)
		{
			_maxX = MaxX;
			_maxY = MaxY;
		}

		public void PlaceRobot(Point startXY, Direction startDir )
		{
			Position = startXY;
			_faced = startDir;
		}

		public void Left()
		{
			Faced = (Faced - 1 < 0) ? (Direction)((Enum.GetValues(typeof(Direction))).Length -1) : (Faced - 1);
		}

		public void Right()
		{
			Faced = ((int)Faced + 1 > Enum.GetValues(typeof(Direction)).Length) ? (Direction) 0 : (Faced + 1);
		}

		public Point Position
		{
			get {
				return _position;
			}
			set {
				if (value.X <= _maxX && value.X >= 0 && value.Y <= _maxY && value.Y >= 0 ) {
					_position.X = value.X;
					_position.Y = value.Y;
				}
			}
		}

		public bool IsPlaced 
		{
			get {
				return _position != new Point(-1,-1);
			}
		}

		public Direction Faced {
			get {
				return _faced;
			}
			set {
				_faced = value;
			}
		}
	}
}

