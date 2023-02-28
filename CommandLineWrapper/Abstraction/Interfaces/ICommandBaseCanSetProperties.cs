using System.CommandLine;

namespace CommandLineWrapper.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods responsible for setting the properties of a <see cref="Command"/>.
/// </summary>
public partial interface ICommandBaseCanSetProperties : IIdentifierSymbolCanSetProperties
{
    /// <returns>An <see cref="ICommandBaseCanSetProperties"/> with the new <paramref name="description"/>.</returns>
    /// <inheritdoc cref="IIdentifierSymbolCanSetProperties.SetDescription(string)"/>
    new ICommandBaseCanSetProperties SetDescription(string description);

    /// <returns>An <see cref="ICommandBaseCanSetProperties"/> with the new value.</returns>
    /// <inheritdoc cref="IIdentifierSymbolCanSetProperties.SetHidden(bool)"/>
    new ICommandBaseCanSetProperties SetHidden(bool isHidden);

    /// <returns>An <see cref="ICommandBaseCanSetProperties"/> with the added <paramref name="alias"/>.</returns>
    /// <inheritdoc cref="IIdentifierSymbolCanSetProperties.AddAlias(string)"/>
    new ICommandBaseCanSetProperties AddAlias(string alias);

    /// <returns>An <see cref="ICommandBaseCanSetProperties"/> with the added <paramref name="argument"/>.</returns>
    /// <inheritdoc cref="Command.AddArgument(Argument)"/>
    ICommandBaseCanSetProperties AddArgument(Argument argument);

    /// <returns>An <see cref="ICommandBaseCanSetProperties"/> with the added <paramref name="option"/>.</returns>
    /// <inheritdoc cref="Command.AddOption(Option)"/>
    ICommandBaseCanSetProperties AddOption(Option option);

    /// <returns>An <see cref="ICommandBaseCanSetProperties"/> with the added global <paramref name="option"/>.</returns>
    /// <inheritdoc cref="Command.AddGlobalOption(Option)"/>
    ICommandBaseCanSetProperties AddGlobalOption(Option option);

    /// <returns>An <see cref="ICommandBaseCanSetProperties"/> with the added <paramref name="command"/>.</returns>
    /// <inheritdoc cref="Command.AddCommand(Command)"/>
    ICommandBaseCanSetProperties AddCommand(Command command);

    /// <summary>
    /// Sets a value that indicates whether unmatched tokens should be treated as errors. For example,
    /// if set to <see langword="true"/> and an extra command or argument is provided, validation will fail.
    /// </summary>
    /// <param name="treatUnmatchedTokensAsErrors">The value that indicates whether unmatched tokens should be treated as errors</param>
    /// <returns>An <see cref="ICommandBaseCanSetProperties"/> with the new value.</returns>
    ICommandBaseCanSetProperties DoTreatUnmatchedTokensAsErrors(bool treatUnmatchedTokensAsErrors);
}
