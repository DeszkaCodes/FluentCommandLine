using CommandLineWrapper.Abstraction.Interfaces;
using System.CommandLine;

namespace CommandLineWrapper.Abstraction;

/// <summary>
/// Defines a base for a <see cref="Command"/> wrapper.
/// </summary>
public abstract class CommandWrapperBase : IdentifierSymbolWrapperBase,
    ICommandCanSetName, ICommandCanSetProperties
{
    /// <inheritdoc cref="ICommandCanSetName.SetName(string)"/>
    public override abstract ICommandCanSetProperties SetName(string name);

    /// <inheritdoc cref="ICommandCanSetProperties.SetDescription(string)"/>
    public override abstract ICommandCanSetProperties SetDescription(string description);

    /// <inheritdoc cref="ICommandCanSetProperties.AddAlias(string)"/>
    public override abstract ICommandCanSetProperties AddAlias(string alias);

    /// <inheritdoc cref="ICommandCanSetProperties.SetHidden(bool)"/>
    public override abstract ICommandCanSetProperties SetHidden(bool isHidden);

    /// <inheritdoc cref="ICommandCanSetProperties.AddArgument(Argument)"/>
    public abstract ICommandCanSetProperties AddArgument(Argument argument);

    /// <inheritdoc cref="ICommandCanSetProperties.AddOption(Option)"/>
    public abstract ICommandCanSetProperties AddOption(Option option);

    /// <inheritdoc cref="ICommandCanSetProperties.AddGlobalOption(Option)"/>
    public abstract ICommandCanSetProperties AddGlobalOption(Option option);

    /// <inheritdoc cref="ICommandCanSetProperties.AddCommand(Command)"/>
    public abstract ICommandCanSetProperties AddCommand(Command subcommand);

    /// <inheritdoc cref="ICommandCanSetProperties.DoTreatUnmatchedTokensAsErrors(bool)"/>
    public abstract ICommandCanSetProperties DoTreatUnmatchedTokensAsErrors(bool treatUnmatchedTokensAsErrors);

    /// <inheritdoc cref="ICommandCanSetProperties.ToCommand"/>
    public abstract Command ToCommand();
}
