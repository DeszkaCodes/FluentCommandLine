using System.CommandLine;

namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods responsible for setting the properties of a <see cref="RootCommand"/>.
/// </summary>
public partial interface IRootCommandCanSetProperties : ICommandBaseCanSetProperties
{
    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new <paramref name="description"/>.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetDescription(string)"/>
    new IRootCommandCanSetProperties SetDescription(string description);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new value.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHidden(bool)"/>
    new IRootCommandCanSetProperties SetHidden(bool isHidden);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the added <paramref name="alias"/>.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddAlias(string)"/>
    new IRootCommandCanSetProperties AddAlias(string alias);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the added <paramref name="argument"/>.</returns>
    /// <inheritdoc cref="Command.AddArgument(Argument)"/>
    new IRootCommandCanSetProperties AddArgument(Argument argument);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the added <paramref name="option"/>.</returns>
    /// <inheritdoc cref="Command.AddOption(Option)"/>
    new IRootCommandCanSetProperties AddOption(Option option);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the added global <paramref name="option"/>.</returns>
    /// <inheritdoc cref="Command.AddGlobalOption(Option)"/>
    new IRootCommandCanSetProperties AddGlobalOption(Option option);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the added <paramref name="command"/>.</returns>
    /// <inheritdoc cref="Command.AddCommand(Command)"/>
    new IRootCommandCanSetProperties AddCommand(Command command);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new value.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.DoTreatUnmatchedTokensAsErrors(bool)"/>
    new IRootCommandCanSetProperties DoTreatUnmatchedTokensAsErrors(bool treatUnmatchedTokensAsErrors);

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandlerInvokeSelfHelp()" />
    new IRootCommandCanSetProperties SetHandlerInvokeSelfHelp();

    /// <summary>
    /// Gets the <see cref="RootCommand"/> created by the wrapper.
    /// </summary>
    /// <returns>The <see cref="RootCommand"/> created by the wrapper.</returns>
    RootCommand GetRootCommand();
}
