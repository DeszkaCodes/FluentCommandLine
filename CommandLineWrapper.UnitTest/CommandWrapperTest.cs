using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.CommandLine;
using System.CommandLine.Parsing;

namespace CommandLineWrapper.UnitTest;

[TestClass]
public sealed class CommandWrapperTest
{
    public static string CommandName = "TestCommand";
    public static string CommandDescription = "This is a command used for unit testing.";

    [TestMethod]
    public void TestCreateCommandMethod()
    {
        Command expected = new(CommandName);

        Command actual = CommandWrapper.CreateCommand(CommandName)
            .ToCommand();

        Assert.AreEqual(expected.Name, actual.Name);
    }

    [TestMethod]
    public void TestSetDescriptionMethod()
    {
        Command expected = new(CommandName, CommandDescription);

        Command actual = CommandWrapper.CreateCommand(CommandName)
            .SetDescription(CommandDescription)
            .ToCommand();

        Assert.AreEqual(expected.Description, actual.Description);
    }

    [TestMethod]
    public void TestAddAliasMethod()
    {
        const bool Expected = true;

        string[] aliases = { "testcommand", "tc", "testCommand", "test", "Tc", "tC", "TC" };

        Command expectedCommand = new(CommandName);

        CommandWrapper actualCommandWrapper = CommandWrapper.CreateCommand(CommandName);

        foreach (string alias in aliases)
        {
            expectedCommand.AddAlias(alias);
            actualCommandWrapper.AddAlias(alias);
        }

        Command actualCommand = actualCommandWrapper.ToCommand();

        bool actual = expectedCommand.Aliases.SequenceEqual(actualCommand.Aliases);

        Assert.AreEqual(Expected, actual);
    }

    [TestMethod]
    public void TestAddArgumentMethod()
    {
        const string ArgumentName = "TestArgument";
        const bool Expected = true;

        var arguments = new Argument[10];

        for (var i = 0; i < arguments.Length; i++)
        {
            Argument<int> argument = new(
                name: $"{ArgumentName}_i",
                getDefaultValue: () => i * i);

            arguments[i] = argument;
        }

        Command expectedCommand = new(CommandName);
        CommandWrapper actualCommandWrapper = CommandWrapper.CreateCommand(CommandName);

        foreach(Argument argument in arguments)
        {
            expectedCommand.AddArgument(argument);
            actualCommandWrapper.AddArgument(argument);
        }

        Command actualCommand = actualCommandWrapper.ToCommand();

        bool actual = expectedCommand.Arguments.SequenceEqual(actualCommand.Arguments);

        Assert.AreEqual(Expected, actual);
    }

    [TestMethod]
    public void TestAddOptionMethod()
    {
        const string ArgumentName = "TestArgument";
        const bool Expected = true;

        var options = new Option[10];

        for (var i = 0; i < options.Length; i++)
        {
            Option<bool> argument = new(
                name: $"{ArgumentName}_i",
                getDefaultValue: () => i % 2 == 0);

            options[i] = argument;
        }

        Command expectedCommand = new(CommandName);
        CommandWrapper actualCommandWrapper = CommandWrapper.CreateCommand(CommandName);

        foreach (Option option in options)
        {
            expectedCommand.AddOption(option);
            actualCommandWrapper.AddOption(option);
        }

        Command actualCommand = actualCommandWrapper.ToCommand();

        bool actual = expectedCommand.Options.SequenceEqual(actualCommand.Options);

        Assert.AreEqual(Expected, actual);
    }

    [TestMethod]
    public void TestAddGlobalOptionMethodForNoException()
    {
        const string ArgumentName = "TestArgument";
        bool hasException = false;

        Option<bool> argument = new(name: ArgumentName);

        try
        {
            Command testCommand = CommandWrapper.CreateCommand(CommandName)
                .AddGlobalOption(argument)
                .ToCommand();
        }catch(Exception)
        {
            hasException = true;
        }

        Assert.IsFalse(hasException);
    }

    [TestMethod]
    public void TestToCommand()
    {
        const string Alias = "TestAlias",
            ArgumentName = "TestArgument",
            OptionName = "TestOption";

        Argument<int> argument = new(ArgumentName);
        Option<bool> option = new(OptionName);

        Command expectedCommand = new(CommandName, CommandDescription);
        expectedCommand.AddAlias(Alias);
        expectedCommand.AddArgument(argument);
        expectedCommand.AddOption(option);
        expectedCommand.IsHidden = true;
        expectedCommand.TreatUnmatchedTokensAsErrors = false;

        Command actualCommand = CommandWrapper.CreateCommand(CommandName)
            .SetDescription(CommandDescription)
            .AddAlias(Alias)
            .AddArgument(argument)
            .AddOption(option)
            .IsHidden(true)
            .SetTreatUnmatchedTokensAsErrors(false)
            .ToCommand();

        bool doAliasesMatch = actualCommand.Aliases.SequenceEqual(expectedCommand.Aliases);
        bool doArgumentsMatch = actualCommand.Arguments.SequenceEqual(expectedCommand.Arguments);
        bool doOptionsMatch = actualCommand.Options.SequenceEqual(expectedCommand.Options);

        Assert.AreEqual(expectedCommand.Name, actualCommand.Name);
        Assert.AreEqual(expectedCommand.Description, actualCommand.Description);
        Assert.IsTrue(doAliasesMatch);
        Assert.IsTrue(doArgumentsMatch);
        Assert.IsTrue(doOptionsMatch);
        Assert.AreEqual(expectedCommand.IsHidden, actualCommand.IsHidden);
        Assert.AreEqual(expectedCommand.TreatUnmatchedTokensAsErrors, actualCommand.TreatUnmatchedTokensAsErrors);
    }
}
