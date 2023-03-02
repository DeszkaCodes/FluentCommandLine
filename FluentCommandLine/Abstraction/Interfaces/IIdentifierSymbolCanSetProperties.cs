namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods responsible for setting the properties of a <see cref="System.CommandLine.IdentifierSymbol"/>.
/// </summary>
public interface IIdentifierSymbolCanSetProperties : ISymbolCanSetProperties
{
    /// <returns>An <see cref="IIdentifierSymbolCanSetProperties"/> with the new description.</returns>
    /// <inheritdoc cref="ISymbolCanSetProperties.SetDescription(string)"/>
    new IIdentifierSymbolCanSetProperties SetDescription(string description);

    /// <returns>An <see cref="IIdentifierSymbolCanSetProperties"/> with the new value.</returns>
    /// <inheritdoc cref="ISymbolCanSetProperties.SetHidden(bool)"/>
    new IIdentifierSymbolCanSetProperties SetHidden(bool isHidden);

    /// <summary>
    /// Adds an alias. Multiple aliases can be added, most often used to provide a shorthand alternative.
    /// </summary>
    /// <param name="alias">The alias to add.</param>
    /// <returns>An <see cref="IIdentifierSymbolCanSetProperties"/> with the added alias.</returns>
    IIdentifierSymbolCanSetProperties AddAlias(string alias);
}
