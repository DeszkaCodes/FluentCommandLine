using FluentCommandLine.Abstraction.Interfaces;
using System.CommandLine;

namespace FluentCommandLine.Abstraction;

/// <summary>
/// Defines a base for an <see cref="IdentifierSymbol"/> wrapper.
/// </summary>
/// <typeparam name="T">The <see cref="Type"/> that inherits <see cref="IdentifierSymbol"/>.</typeparam>
public abstract class FluentIdentifierSymbolBase<T> : FluentSymbolBase<T>,
    IIdentifierSymbolHasToSetName, IIdentifierSymbolCanSetProperties
    where T : IdentifierSymbol
{
    private protected FluentIdentifierSymbolBase(T identifierSymbol)
        : base(identifierSymbol)
    {
    }

    /// <inheritdoc cref="IIdentifierSymbolHasToSetName.SetName(string)"/>
    public override IIdentifierSymbolCanSetProperties SetName(string name)
    {
        base.SetName(name);
        return this;
    }

    /// <inheritdoc cref="IIdentifierSymbolCanSetProperties.SetDescription(string)"/>
    public override IIdentifierSymbolCanSetProperties SetDescription(string description)
    {
        base.SetDescription(description);
        return this;
    }

    /// <inheritdoc cref="IIdentifierSymbolCanSetProperties.SetHidden(bool)"/>
    public override IIdentifierSymbolCanSetProperties SetHidden(bool isHidden)
    {
        base.SetHidden(isHidden);
        return this;
    }

    /// <inheritdoc cref="IIdentifierSymbolCanSetProperties.AddAlias(string)"/>
    public virtual IIdentifierSymbolCanSetProperties AddAlias(string alias)
    {
        _wrapped.AddAlias(alias);
        return this;
    }
}
