using FluentCommandLine.Abstraction.Interfaces;
using System.CommandLine;

namespace FluentCommandLine.Abstraction;

/// <summary>
/// Defines a base for a <see cref="Symbol"/> wrapper.
/// </summary>
/// <typeparam name="T">The <see cref="Type"/> that inherits <see cref="Symbol"/>.</typeparam>
public abstract class FluentSymbolBase<T> : ISymbolCanSetName, ISymbolCanSetProperties
    where T : Symbol
{
    /// <summary>
    /// The generic type that is being wrapped.
    /// </summary>
    internal protected readonly T _wrapped;

    private protected FluentSymbolBase(T wrapped)
    {
        _wrapped = wrapped;
    }

    /// <inheritdoc />
    public virtual ISymbolCanSetProperties SetName(string name)
    {
        _wrapped.Name = name;
        return this;
    }

    /// <inheritdoc />
    public virtual ISymbolCanSetProperties SetDescription(string description)
    {
        _wrapped.Description = description;
        return this;
    }

    /// <inheritdoc />
    public virtual ISymbolCanSetProperties SetHidden(bool isHidden)
    {
        _wrapped.IsHidden = isHidden;
        return this;
    }
}
