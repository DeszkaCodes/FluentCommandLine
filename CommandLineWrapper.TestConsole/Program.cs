using CommandLineWrapper;
using System.CommandLine;

Command subcommand = CommandWrapper.Create()
    .SetName("subtest")
    .AddAlias("subcommandtest")
    .SetDescription("This is a subcommand test.")
    .GetCommand();

RootCommand rootCommand = RootCommandWrapper.Create()
    .SetDescription("This is a test command.")
    .AddAlias("tc")
    .AddCommand(subcommand)
    .GetRootCommand();

await rootCommand.InvokeAsync(args);