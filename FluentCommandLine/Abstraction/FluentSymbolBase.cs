using FluentCommandLine.Abstraction.Interfaces;

namespace FluentCommandLine.Abstraction;

/// <summary>
/// Defines a base for a <see cref="System.CommandLine.Symbol"/> wrapper.
/// </summary>
public abstract class FluentSymbolBase : ISymbolCanSetName, ISymbolCanSetProperties
{
    /// <inheritdoc />
    public abstract ISymbolCanSetProperties SetName(string name);

    /// <inheritdoc />
    public abstract ISymbolCanSetProperties SetDescription(string description);

    /// <inheritdoc />
    public abstract ISymbolCanSetProperties SetHidden(bool isHidden);
}
