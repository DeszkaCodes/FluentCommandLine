using FluentCommandLine;
using System.CommandLine;

Command subcommand = CommandWrapper.Create()
    .SetName("subtest")
    .AddAlias("subcommandtest")
    .SetDescription("This is a subcommand test.")
    .SetHandler(() => Console.WriteLine("Subcommand was called."))
    .GetCommand();

RootCommand rootCommand = RootCommandWrapper.Create()
    .SetDescription("This is a test command.")
    .AddAlias("tc")
    .AddCommand(subcommand)
    .SetHandler(() => Console.WriteLine("Root was called."))
    .GetRootCommand();

await rootCommand.InvokeAsync(args);