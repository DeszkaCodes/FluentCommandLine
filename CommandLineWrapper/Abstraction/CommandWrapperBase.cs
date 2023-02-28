using CommandLineWrapper.Abstraction.Interfaces;
using System.CommandLine;

namespace CommandLineWrapper.Abstraction;

/// <summary>
/// Defines a base for a <see cref="Command"/> wrapper.
/// </summary>
public abstract class CommandWrapperBase : IdentifierSymbolWrapperBase,
    ICommandBaseCanSetName, ICommandBaseCanSetProperties
{
    /// <inheritdoc cref="ICommandBaseCanSetName.SetName(string)"/>
    public override abstract ICommandBaseCanSetProperties SetName(string name);

    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetDescription(string)"/>
    public override abstract ICommandBaseCanSetProperties SetDescription(string description);

    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddAlias(string)"/>
    public override abstract ICommandBaseCanSetProperties AddAlias(string alias);

    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHidden(bool)"/>
    public override abstract ICommandBaseCanSetProperties SetHidden(bool isHidden);

    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddArgument(Argument)"/>
    public abstract ICommandBaseCanSetProperties AddArgument(Argument argument);

    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddOption(Option)"/>
    public abstract ICommandBaseCanSetProperties AddOption(Option option);

    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddGlobalOption(Option)"/>
    public abstract ICommandBaseCanSetProperties AddGlobalOption(Option option);

    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddCommand(Command)"/>
    public abstract ICommandBaseCanSetProperties AddCommand(Command subcommand);

    /// <inheritdoc cref="ICommandBaseCanSetProperties.DoTreatUnmatchedTokensAsErrors(bool)"/>
    public abstract ICommandBaseCanSetProperties DoTreatUnmatchedTokensAsErrors(bool treatUnmatchedTokensAsErrors);
}
