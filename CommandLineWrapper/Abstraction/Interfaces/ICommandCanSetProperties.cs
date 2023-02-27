using System.CommandLine;

namespace CommandLineWrapper.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods responsible for setting the properties of a <see cref="Command"/>.
/// </summary>
public partial interface ICommandCanSetProperties : IIdentifierSymbolCanSetProperties
{
    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new <paramref name="description"/>.</returns>
    /// <inheritdoc cref="IIdentifierSymbolCanSetProperties.SetDescription(string)"/>
    new ICommandCanSetProperties SetDescription(string description);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new value.</returns>
    /// <inheritdoc cref="IIdentifierSymbolCanSetProperties.SetHidden(bool)"/>
    new ICommandCanSetProperties SetHidden(bool isHidden);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the added <paramref name="alias"/>.</returns>
    /// <inheritdoc cref="IIdentifierSymbolCanSetProperties.AddAlias(string)"/>
    new ICommandCanSetProperties AddAlias(string alias);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the added <paramref name="argument"/>.</returns>
    /// <inheritdoc cref="Command.AddArgument(Argument)"/>
    ICommandCanSetProperties AddArgument(Argument argument);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the added <paramref name="option"/>.</returns>
    /// <inheritdoc cref="Command.AddOption(Option)"/>
    ICommandCanSetProperties AddOption(Option option);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the added global <paramref name="option"/>.</returns>
    /// <inheritdoc cref="Command.AddGlobalOption(Option)"/>
    ICommandCanSetProperties AddGlobalOption(Option option);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the added <paramref name="command"/>.</returns>
    /// <inheritdoc cref="Command.AddCommand(Command)"/>
    ICommandCanSetProperties AddCommand(Command command);

    /// <summary>
    /// Sets a value that indicates whether unmatched tokens should be treated as errors. For example,
    /// if set to <see langword="true"/> and an extra command or argument is provided, validation will fail.
    /// </summary>
    /// <param name="treatUnmatchedTokensAsErrors">The value that indicates whether unmatched tokens should be treated as errors</param>
    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new value.</returns>
    ICommandCanSetProperties DoTreatUnmatchedTokensAsErrors(bool treatUnmatchedTokensAsErrors);

    /// <summary>
    /// Returns the <see cref="Command"/> created by the wrapper.
    /// </summary>
    /// <returns>The <see cref="Command"/> created by the wrapper.</returns>
    Command ToCommand();
}
