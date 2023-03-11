using System.CommandLine;

namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods responsible for setting the properties of a <see cref="Command"/>.
/// </summary>
public partial interface ICommandCanSetProperties : ICommandBaseCanSetProperties
{
    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new <paramref name="description"/>.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetDescription(string)"/>
    new ICommandCanSetProperties SetDescription(string description);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new value.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHidden(bool)"/>
    new ICommandCanSetProperties SetHidden(bool isHidden);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the added <paramref name="alias"/>.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddAlias(string)"/>
    new ICommandCanSetProperties AddAlias(string alias);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the added <paramref name="argument"/>.</returns>
    /// <inheritdoc cref="Command.AddArgument(Argument)"/>
    new ICommandCanSetProperties AddArgument(Argument argument);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the added <paramref name="option"/>.</returns>
    /// <inheritdoc cref="Command.AddOption(Option)"/>
    new ICommandCanSetProperties AddOption(Option option);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the added global <paramref name="option"/>.</returns>
    /// <inheritdoc cref="Command.AddGlobalOption(Option)"/>
    new ICommandCanSetProperties AddGlobalOption(Option option);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the added <paramref name="command"/>.</returns>
    /// <inheritdoc cref="Command.AddCommand(Command)"/>
    new ICommandCanSetProperties AddCommand(Command command);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new value.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.DoTreatUnmatchedTokensAsErrors(bool)"/>
    new ICommandCanSetProperties DoTreatUnmatchedTokensAsErrors(bool treatUnmatchedTokensAsErrors);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandlerInvokeSelfHelp()" />
    new ICommandCanSetProperties SetHandlerInvokeSelfHelp();

    /// <summary>
    /// Gets the <see cref="Command"/> created by the wrapper.
    /// </summary>
    /// <returns>The <see cref="Command"/> created by the wrapper.</returns>
    Command GetCommand();
}
