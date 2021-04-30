using CommandLine;
using CommandLine.Text;
using System;
using System.Collections.Generic;
using System.Threading;

namespace comPort
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new CommandLine.Parser(with => with.HelpWriter = null);
            var parserResult = parser.ParseArguments<Options>(args);
            parserResult
              .WithParsed<Options>(options => Run(options))
              .WithNotParsed(errs => DisplayHelp(parserResult, errs));

        }

        static void DisplayHelp<T>(ParserResult<T> result, IEnumerable<Error> errs)
        {
            var helpText = HelpText.AutoBuild(result, h =>
            {
                h.AdditionalNewLineAfterOption = false;
                //h.Heading = "Myapp 2.0.0-beta"; //change header
                h.Copyright = "Copyright (c) 2019 TC-Soft.PL"; //change copyright text
                return HelpText.DefaultParsingErrorsHandler(result, h);
            }, e => e);
            Console.WriteLine(helpText);
        }
        private static void Run(Options options)
        {
            Console.WriteLine("Hello World!");
            Thread.Sleep(3000);
        }
    }
}
