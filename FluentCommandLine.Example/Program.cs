//using FluentCommandLine;
//using System.CommandLine;
//using System.Resources;

using FluentCommandLine;
using System.CommandLine;

Command aboutCommand = FluentCommand.Create()
    .SetName("about")
    .SetDescription("Sums up the package and its uses.")
    .SetHandler(() => Console.WriteLine("Template text."))
    .GetCommand();

RootCommand rootCommand = FluentRootCommand.Create()
    .SetDescription("Showcase of the FluentCommandLine package")
    .SetHandlerInvokeSelfHelp()
    .AddCommand(aboutCommand)
    .GetRootCommand();

await rootCommand.InvokeAsync(args);