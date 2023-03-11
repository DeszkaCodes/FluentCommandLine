//using FluentCommandLine;
//using System.CommandLine;
//using System.Resources;

using FluentCommandLine;
using System.CommandLine;

Option<bool> showLicenseOption = FluentOption<bool>.Create()
    .HasNoArgument()
    .SetAliases(new string[] { "--license", "-l" })
    .SetDescription("Shows license")
    .GetOption();

Action<bool> aboutCommandHandler = (licenseOptionValue) =>
{
    if (licenseOptionValue)
    {
        Console.WriteLine("MIT");
        return;
    }

    Console.WriteLine("A package.");
};

Command aboutCommand = FluentCommand.Create()
    .SetHandler(aboutCommandHandler, showLicenseOption)
    .SetName("about")
    .SetDescription("Sums up the package and its uses.")
    .AddOption(showLicenseOption)
    .GetCommand();

RootCommand rootCommand = FluentRootCommand.Create()
    .SetHandlerInvokeSelfHelp()
    .UseExecutableName()
    .SetDescription("Showcase of the FluentCommandLine package")
    .AddCommand(aboutCommand)
    .GetRootCommand();

await rootCommand.InvokeAsync(args);