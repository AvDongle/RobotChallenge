using System;
using System.Linq;

namespace RobotChallenge
{
	public class CommandProcessor
	{
		private MoveCommand _move = new MoveCommand();
		private PlaceCommand _place = new PlaceCommand();
		private ReportCommand _report = new ReportCommand();
		private TurnCommand _turn = new TurnCommand();

		public CommandProcessor ()
		{
		}

		public void Process(string text, Robot robot)
		{
			var data = text.Split(' ').ToList();
			switch (data [0].ToUpper()) 
			{
			case "MOVE":
				_move.Execute (robot);
				break;
			case "LEFT":
				_turn.Execute (robot, "LEFT");
				break;
			case "RIGHT":
				_turn.Execute (robot, "RIGHT");
				break;
			case "PLACE":
				_place.Execute (robot, data [1]);
				break;
			case "REPORT":
				_report.Execute (robot);
				break;
			default:
				Console.WriteLine ("No {0} Command found", data [0]);
				break;
			}
		}


		public ReportCommand Report {
			get {
				return _report;
			}
		}
	}
}

