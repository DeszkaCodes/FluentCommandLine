using CommandLineWrapper;
using System.CommandLine;

RootCommand rootCommand = new("This is a test command.");

Command subcommand = CommandWrapper.Create()
    .SetName("subtest")
    .AddAlias("subcommandtest")
    .SetDescription("This is a subcommand test.")
    .GetCommand();

rootCommand.AddCommand(subcommand);

await rootCommand.InvokeAsync(args);