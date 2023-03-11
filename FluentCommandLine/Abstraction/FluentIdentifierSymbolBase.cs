using FluentCommandLine.Abstraction.Interfaces;

namespace FluentCommandLine.Abstraction;

/// <summary>
/// Defines a base for an <see cref="IdentifierSymbol"/> wrapper.
/// </summary>
/// <typeparam name="T">The <see cref="Type"/> that inherits <see cref="IdentifierSymbol"/>.</typeparam>
public abstract class FluentIdentifierSymbolBase<T> : FluentSymbolBase<T>,
    IIdentifierSymbolCanSetName, IIdentifierSymbolCanSetProperties
    where T : IdentifierSymbol
{
    private protected FluentIdentifierSymbolBase(T identifierSymbol)
        : base(identifierSymbol)
    {
    }

    /// <inheritdoc cref="IIdentifierSymbolCanSetName.SetName(string)"/>
    public override abstract IIdentifierSymbolCanSetProperties SetName(string name);

    /// <inheritdoc cref="IIdentifierSymbolCanSetProperties.SetDescription(string)"/>
    public override abstract IIdentifierSymbolCanSetProperties SetDescription(string description);

    /// <inheritdoc cref="IIdentifierSymbolCanSetProperties.AddAlias(string)"/>
    public abstract IIdentifierSymbolCanSetProperties AddAlias(string alias);

    /// <inheritdoc cref="IIdentifierSymbolCanSetProperties.SetHidden(bool)"/>
    public override abstract IIdentifierSymbolCanSetProperties SetHidden(bool isHidden);
}
