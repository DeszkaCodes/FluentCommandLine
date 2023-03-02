namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods responsible for setting the properties of a <see cref="System.CommandLine.Symbol"/>.
/// </summary>
public interface ISymbolCanSetProperties
{
    /// <summary>
    /// Sets a value indicating whether the symbol is hidden.
    /// </summary>
    /// <param name="isHidden">The new value indicating whether the symbol is hidden.</param>
    /// <returns>An <see cref="ISymbolCanSetProperties"/> with the new value.</returns>
    ISymbolCanSetProperties SetHidden(bool isHidden);

    /// <summary>
    /// Sets the description of the symbol.
    /// </summary>
    /// <param name="description">The new description of the symbol.</param>
    /// <returns>An <see cref="ISymbolCanSetProperties"/> with the new description.</returns>
    ISymbolCanSetProperties SetDescription(string description);
}
