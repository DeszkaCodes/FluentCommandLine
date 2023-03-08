using System.CommandLine.Parsing;
using System.CommandLine;

namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods for setting the properties of an <see cref="Option{T}"/>
/// </summary>
/// <typeparam name="T">The <see cref="System.Type"/> that the option's arguments are expected to be parsed as.</typeparam>
public interface IOptionCanSetProperties<T> : IIdentifierSymbolCanSetProperties
{
    /// <returns>An <see cref="IOptionCanSetProperties{T}"/> with the new description.</returns>
    /// <inheritdoc cref="ISymbolCanSetProperties.SetDescription(string)"/>
    new IOptionCanSetProperties<T> SetDescription(string description);

    /// <returns>An <see cref="IOptionCanSetProperties{T}"/> with the new value.</returns>
    /// <inheritdoc cref="ISymbolCanSetProperties.SetHidden(bool)"/>
    new IOptionCanSetProperties<T> SetHidden(bool isHidden);

    /// <returns>An <see cref="IOptionCanSetProperties{T}"/> with the added alias.</returns>
    /// <inheritdoc cref="IIdentifierSymbolCanSetProperties.AddAlias(string)"/>
    new IOptionCanSetProperties<T> AddAlias(string alias);

    /// <summary>
    /// Sets the arity of the option.
    /// </summary>
    /// <param name="arity">The arity of the option.</param>
    /// <returns>An <see cref="IOptionCanSetProperties{T}"/> with the added arity.</returns>
    IOptionCanSetProperties<T> SetArity(ArgumentArity arity);

    /// <returns>An <see cref="IOptionCanSetProperties{T}"/> with the added validator.</returns>
    /// <inheritdoc cref="Option.AddValidator(ValidateSymbolResult{OptionResult})" />
    IOptionCanSetProperties<T> AddValidator(ValidateSymbolResult<OptionResult> validate);

    /// <returns>An <see cref="IOptionCanSetProperties{T}"/> with the default value set.</returns>
    /// <inheritdoc cref="Option.SetDefaultValue(object?)"/>
    IOptionCanSetProperties<T> SetDefaultValue(object? value);

    /// <returns>An <see cref="IOptionCanSetProperties{T}"/> with the default value factory set.</returns>
    /// <inheritdoc cref="Option.SetDefaultValueFactory(Func{object?})"/>
    IOptionCanSetProperties<T> SetDefaultValueFactory(Func<object?> getDefaultValue);

    /// <summary>
    /// Sets a value that indicates whether multiple argument tokens are allowed for each option identifier token.
    /// </summary>
    /// <example>
    /// If set to <see langword="true"/>, the following command line is valid for passing multiple arguments:
    /// <code>
    /// > --opt 1 2 3
    /// </code>
    /// The following is equivalent and is always valid:
    /// <code>
    /// > --opt 1 --opt 2 --opt 3
    /// </code>
    /// </example>
    /// <returns>An <see cref="IOptionCanSetProperties{T}"/> with the AllowMultipleArgumentsPerToken value set.</returns>
    IOptionCanSetProperties<T> SetAllowMultipleArgumentsPerToken(bool allowMultipleArgumentsPerToken);

    /// <summary>
    /// Indicates whether the option is required when its parent command is invoked.
    /// </summary>
    /// <remarks>When an option is required and its parent command is invoked without it, an error results.</remarks>    /// <param name="isRequired"></param>
    /// <returns>An <see cref="IOptionCanSetProperties{T}"/> with the IsRequired field set to the value.</returns>
    IOptionCanSetProperties<T> SetRequired(bool isRequired);

    /// <summary>
    /// Gets the <see cref="Option{T}"/> created by the wrapper.
    /// </summary>
    /// <returns>The <see cref="Option{T}"/> created by the wrapper.</returns>
    Option<T> GetOption();
}
