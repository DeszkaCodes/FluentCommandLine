using FluentCommandLine.Abstraction.Interfaces;

namespace FluentCommandLine.Abstraction;

/// <summary>
/// Defines a base for an <see cref="System.CommandLine.IdentifierSymbol"/> wrapper.
/// </summary>
public abstract class IdentifierSymbolWrapperBase : SymbolWrapperBase,
    IIdentifierSymbolCanSetName, IIdentifierSymbolCanSetProperties
{
    /// <inheritdoc cref="IIdentifierSymbolCanSetName.SetName(string)"/>
    public override abstract IIdentifierSymbolCanSetProperties SetName(string name);

    /// <inheritdoc cref="IIdentifierSymbolCanSetProperties.SetDescription(string)"/>
    public override abstract IIdentifierSymbolCanSetProperties SetDescription(string description);

    /// <inheritdoc cref="IIdentifierSymbolCanSetProperties.AddAlias(string)"/>
    public abstract IIdentifierSymbolCanSetProperties AddAlias(string alias);

    /// <inheritdoc cref="IIdentifierSymbolCanSetProperties.SetHidden(bool)"/>
    public override abstract IIdentifierSymbolCanSetProperties SetHidden(bool isHidden);
}
