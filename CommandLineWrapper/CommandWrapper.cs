using CommandLineWrapper.Abstraction;
using CommandLineWrapper.Abstraction.Interfaces;
using System.CommandLine;

namespace CommandLineWrapper;

public sealed class CommandWrapper : CommandWrapperBase,
    ICommandCanSetName, ICommandCanSetProperties
{
    private readonly Command _command;

    private CommandWrapper()
    {
        const string DefaultCommandName = "DefaultCommandName";

        _command = new Command(DefaultCommandName);
    }

    /// <summary>
    /// Creates a new instance of <see cref="CommandWrapper"/>.
    /// </summary>
    /// <returns>The new instance as <see cref="ICommandCanSetName"/>.</returns>
    public static ICommandCanSetName Create() => new CommandWrapper();

    /// <inheritdoc />
    public Command GetCommand()
    {
        return _command;
    }

    /// <inheritdoc />
    public override ICommandCanSetProperties AddAlias(string alias)
    {
        _command.AddAlias(alias);
        return this;
    }

    /// <inheritdoc />
    public override ICommandCanSetProperties AddArgument(Argument argument)
    {
        _command.AddArgument(argument);
        return this;
    }

    /// <inheritdoc />
    public override ICommandCanSetProperties AddCommand(Command command)
    {
        _command.AddCommand(command);
        return this;
    }

    /// <inheritdoc />
    public override ICommandCanSetProperties AddGlobalOption(Option option)
    {
        _command.AddGlobalOption(option);
        return this;
    }

    /// <inheritdoc />
    public override ICommandCanSetProperties AddOption(Option option)
    {
        _command.AddOption(option);
        return this;
    }

    /// <inheritdoc />
    public override ICommandCanSetProperties DoTreatUnmatchedTokensAsErrors(bool treatUnmatchedTokensAsErrors)
    {
        _command.TreatUnmatchedTokensAsErrors = treatUnmatchedTokensAsErrors;
        return this;
    }

    /// <inheritdoc />
    public override ICommandCanSetProperties SetHidden(bool isHidden)
    {
        _command.IsHidden = isHidden;
        return this;
    }

    /// <inheritdoc />
    public override ICommandCanSetProperties SetName(string name)
    {
        _command.Name = name;
        return this;
    }

    /// <inheritdoc />
    public override ICommandCanSetProperties SetDescription(string description)
    {
        _command.Description = description;
        return this;
    }
}
