namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines a fluent method responsible for setting the name of a <see cref="System.CommandLine.Symbol"/>.
/// </summary>
public interface ISymbolCanSetName
{
    /// <summary>
    /// Sets the name of the symbol.
    /// </summary>
    /// <param name="name">The name of the symbol.</param>
    /// <returns>An <see cref="ISymbolCanSetProperties"/> with the given name.</returns>
    ISymbolCanSetProperties SetName(string name);
}
