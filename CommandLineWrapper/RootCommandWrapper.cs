using CommandLineWrapper.Abstraction;
using CommandLineWrapper.Abstraction.Interfaces;
using System.CommandLine;

namespace CommandLineWrapper;

/// <summary>
/// Wrapper for <see cref="RootCommand"/> that uses fluent APIs.
/// </summary>
public sealed partial class RootCommandWrapper : CommandWrapperBase<RootCommand>,
    IRootCommandCanSetProperties
{
    private RootCommandWrapper()
        : base(new RootCommand(RootCommand.ExecutableName))
    {
    }

    /// <summary>
    /// Creates a new instance of <see cref="RootCommandWrapper"/>.
    /// </summary>
    /// <returns>The new instance as <see cref="IRootCommandCanSetProperties"/>.</returns>
    public static IRootCommandCanSetProperties Create() => new RootCommandWrapper();

    /// <inheritdoc />
    public RootCommand GetRootCommand()
    {
        return _command;
    }

    /// <inheritdoc cref="IRootCommandCanSetProperties.AddAlias(string)"/>
    public override IRootCommandCanSetProperties AddAlias(string alias)
    {
        base.AddAlias(alias);
        return this;
    }

    /// <inheritdoc cref="IRootCommandCanSetProperties.AddArgument(Argument)"/>
    public override IRootCommandCanSetProperties AddArgument(Argument argument)
    {
        base.AddArgument(argument);
        return this;
    }

    /// <inheritdoc cref="IRootCommandCanSetProperties.AddCommand(Command)"/>
    public override IRootCommandCanSetProperties AddCommand(Command command)
    {
        base.AddCommand(command);
        return this;
    }

    /// <inheritdoc cref="IRootCommandCanSetProperties.AddGlobalOption(Option)"/>
    public override IRootCommandCanSetProperties AddGlobalOption(Option option)
    {
        base.AddGlobalOption(option);
        return this;
    }

    /// <inheritdoc cref="IRootCommandCanSetProperties.AddOption(Option)"/>
    public override IRootCommandCanSetProperties AddOption(Option option)
    {
        base.AddOption(option);
        return this;
    }

    /// <inheritdoc cref="IRootCommandCanSetProperties.DoTreatUnmatchedTokensAsErrors(bool)"/>
    public override IRootCommandCanSetProperties DoTreatUnmatchedTokensAsErrors(bool treatUnmatchedTokensAsErrors)
    {
        base.DoTreatUnmatchedTokensAsErrors(treatUnmatchedTokensAsErrors);
        return this;
    }

    /// <inheritdoc cref="IRootCommandCanSetProperties.SetDescription(string)"/>
    public override IRootCommandCanSetProperties SetDescription(string description)
    {
        base.SetDescription(description);
        return this;
    }

    /// <inheritdoc cref="IRootCommandCanSetProperties.SetHidden(bool)"/>
    public override IRootCommandCanSetProperties SetHidden(bool isHidden)
    {
        base.SetHidden(isHidden);
        return this;
    }
}
