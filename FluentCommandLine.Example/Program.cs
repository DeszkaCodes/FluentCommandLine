//using FluentCommandLine;
//using System.CommandLine;
//using System.Resources;

using FluentCommandLine;
using System.CommandLine;

Command aboutCommand = FluentCommand.Create()
    .SetHandler(() => Console.WriteLine("Template text."))
    .SetName("about")
    .SetDescription("Sums up the package and its uses.")
    .GetCommand();

RootCommand rootCommand = FluentRootCommand.Create()
    .SetHandlerInvokeSelfHelp()
    .UseExecutableName()
    .SetDescription("Showcase of the FluentCommandLine package")
    .AddCommand(aboutCommand)
    .GetRootCommand();

await rootCommand.InvokeAsync(args);