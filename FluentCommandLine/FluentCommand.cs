using FluentCommandLine.Abstraction;
using FluentCommandLine.Abstraction.Interfaces;
using System.CommandLine;
using System.CommandLine.Binding;
using System.CommandLine.Invocation;

namespace FluentCommandLine;

/// <summary>
/// Wrapper for <see cref="Command"/> that uses fluent APIs.
/// </summary>
public sealed partial class FluentCommand : FluentCommandBase<Command>,
    ICommandCanSetName, ICommandCanSetProperties
{
    private const string DefaultCommandName = "unknown";

    private FluentCommand()
        : base(new Command(DefaultCommandName))
    {
    }

    /// <summary>
    /// Creates a new instance of <see cref="FluentCommand"/>.
    /// </summary>
    /// <returns>The new instance as <see cref="ICommandCanSetName"/>.</returns>
    public static ICommandCanSetName Create() => new FluentCommand();

    /// <inheritdoc />
    public Command GetCommand()
    {
        return _command;
    }

    /// <inheritdoc cref="ICommandCanSetProperties.AddAlias(string)" />
    public override ICommandCanSetProperties AddAlias(string alias)
    {
        base.AddAlias(alias);
        return this;
    }

    /// <inheritdoc cref="Command.AddArgument(Argument)" />
    public override ICommandCanSetProperties AddArgument(Argument argument)
    {
        base.AddArgument(argument);
        return this;
    }

    /// <inheritdoc cref="ICommandCanSetProperties.AddCommand(Command)" />
    public override ICommandCanSetProperties AddCommand(Command command)
    {
        base.AddCommand(command);
        return this;
    }

    /// <inheritdoc cref="ICommandCanSetProperties.AddGlobalOption(Option)" />
    public override ICommandCanSetProperties AddGlobalOption(Option option)
    {
        base.AddGlobalOption(option);
        return this;
    }

    /// <inheritdoc cref="ICommandCanSetProperties.AddOption(Option)" />
    public override ICommandCanSetProperties AddOption(Option option)
    {
        base.AddOption(option);
        return this;
    }

    /// <inheritdoc cref="ICommandCanSetProperties.DoTreatUnmatchedTokensAsErrors(bool)" />
    public override ICommandCanSetProperties DoTreatUnmatchedTokensAsErrors(bool treatUnmatchedTokensAsErrors)
    {
        base.DoTreatUnmatchedTokensAsErrors(treatUnmatchedTokensAsErrors);
        return this;
    }

    /// <inheritdoc cref="ICommandCanSetProperties.SetHidden(bool)" />
    public override ICommandCanSetProperties SetHidden(bool isHidden)
    {
        base.SetHidden(isHidden);
        return this;
    }

    /// <inheritdoc cref="ICommandCanSetName.SetName(string)" />
    public override ICommandCanSetProperties SetName(string name)
    {
        base.SetName(name);
        return this;
    }

    /// <inheritdoc cref="ICommandCanSetProperties.SetDescription(string)" />
    public override ICommandCanSetProperties SetDescription(string description)
    {
        base.SetDescription(description);
        return this;
    }
}
