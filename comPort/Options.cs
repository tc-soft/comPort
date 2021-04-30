using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace comPort
{
    class Options
    {
		[Option("baud", Default = 9600, HelpText = "Baud rate of COM port.")]
		public int Baud { get; set; }

		[Option("data", Default = 8, HelpText = "Data bits of COM port (5-9).")]
		public int Data { get; set; }

		[Option("parity", Default = false, HelpText = "Parity bit of COM port.")]
		public bool Parity { get; set; }

		[Option("stop", Default = 1, HelpText = "Stop bits of COM port.")]
		public int Stop { get; set; }

		[Option("command", Required = true, HelpText = "Command to send.")]
		public string Command { get; set; }



		[Option("file", Required = true, HelpText = "The path of a file to data output.")]
		public string OutputFile { get; set; }


	}
}
