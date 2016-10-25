using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;

namespace RobotChallenge
{
	public class CommandProcessor
	{
		private MoveCommand _move = new MoveCommand();
		private PlaceCommand _place = new PlaceCommand();
		private ReportCommand _report = new ReportCommand();
		private TurnCommand _turn = new TurnCommand();

		public List<string> _commands = new List<string>();

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
			
		public void Load(string filename = @"C:\Users\AvDongle\Documents\Curve Tomorrow\test.txt")
		{
			try{
				_commands = new List<string>();
				using (var reader = new StreamReader (filename)) {
					string line;
					while ((line = reader.ReadLine ()) != null) {
						_commands.Add (line);
					}
				}
			}
			catch (Exception e){
				Console.Error.WriteLine ("Error loading file: {0}", e.Message);
			}
		}

		public ReportCommand Report {
			get {
				return _report;
			}
		}
	}
}

