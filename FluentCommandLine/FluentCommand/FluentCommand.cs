using FluentCommandLine.Abstraction.Interfaces;
using FluentCommandLine.Abstraction;
using System.CommandLine;

namespace FluentCommandLine;

/// <summary>
/// Wrapper for <see cref="Command"/> that uses fluent APIs.
/// </summary>
public sealed partial class FluentCommand : FluentCommandBase<Command>,
    ICommandHasToSetHandler, ICommandHasToSetName, ICommandCanSetProperties
{
    private FluentCommand()
        : base(null!)
    {
    }

    /// <summary>
    /// Creates a new instance of <see cref="FluentCommand"/>.
    /// </summary>
    /// <returns>The new instance as <see cref="ICommandHasToSetName"/>.</returns>
    public static ICommandHasToSetName Create() => new FluentCommand();

    /// <inheritdoc />
    public Command GetCommand()
    {
        return _wrapped;
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

    /// <inheritdoc cref="ICommandHasToSetName.SetName(string)" />
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

    /// <inheritdoc cref="ICommandCanSetProperties.SetHandlerInvokeSelfHelp()"/>
    public override ICommandCanSetProperties SetHandlerInvokeSelfHelp()
    {
        base.SetHandlerInvokeSelfHelp();
        return this;
    }

    /// <inheritdoc cref="ICommandHasToSetHandler.NoHandler()" />
    public override ICommandCanSetProperties NoHandler()
    {
        base.NoHandler();
        return this;
    }
}
