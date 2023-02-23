using CommandLineWrapper;
using System.CommandLine;

RootCommand rootCommand = new("This is a test command.");

rootCommand.AddCommand(CommandWrapper.CreateCommand("subcommand")
    .SetDescription("This is a subcommand")
    .ToCommand());

await rootCommand.InvokeAsync(args);