namespace CommandLineWrapper.Abstraction.Interfaces;

/// <summary>
/// Defines a fluent method responsible for setting the name of a <see cref="System.CommandLine.IdentifierSymbol"/>.
/// </summary>
public interface IIdentifierSymbolCanSetName : ISymbolCanSetName
{
    /// <returns>An <see cref="IIdentifierSymbolCanSetProperties"/> with the given name.</returns>
    /// <inheritdoc cref="ISymbolCanSetName.SetName(string)"/>
    new IIdentifierSymbolCanSetProperties SetName(string name);
}
