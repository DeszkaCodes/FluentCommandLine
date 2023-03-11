using System.CommandLine;
using System.CommandLine.Parsing;

namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods for setting the properties of an <see cref="System.CommandLine.Option{T}"/>
/// </summary>
/// <typeparam name="T">The <see cref="Type"/> that the argument is expected to be parsed as.</typeparam>
public interface IArgumentCanSetProperties<T> : ISymbolCanSetProperties
{
    /// <returns>An <see cref="IArgumentCanSetProperties{T}"/> with its value set.</returns>
    /// <inheritdoc cref="ISymbolCanSetProperties.SetHidden(bool)"/>
    new IArgumentCanSetProperties<T> SetHidden(bool isHidden);

    /// <returns>An <see cref="IArgumentCanSetProperties{T}"/> with its description set.</returns>
    /// <inheritdoc cref="ISymbolCanSetProperties.SetDescription(string)"/>
    new IArgumentCanSetProperties<T> SetDescription(string description);

    /// <summary>
    /// Sets the arity of the argument.
    /// </summary>
    /// <returns>An <see cref="IArgumentCanSetProperties{T}"/> with its arity set.</returns>
    IArgumentCanSetProperties<T> SetArity(ArgumentArity arity);

    /// <summary>
    /// Sets the name used in help output to describe the argument. 
    /// </summary>
    /// <returns>An <see cref="IArgumentCanSetProperties{T}"/> with its help name set.</returns>
    IArgumentCanSetProperties<T> SetHelpName(string helpName);

    /// <returns>An <see cref="IArgumentCanSetProperties{T}"/> with the validator added.</returns>
    /// <inheritdoc cref="Argument.AddValidator(ValidateSymbolResult{ArgumentResult})"/>
    IArgumentCanSetProperties<T> AddValidator(ValidateSymbolResult<ArgumentResult> validate);

    /// <returns>An <see cref="IArgumentCanSetProperties{T}"/> with its default value set.</returns>
    /// <inheritdoc cref="Argument.SetDefaultValue(object?)"/>
    IArgumentCanSetProperties<T> SetDefaultValue(object? value);

    /// <returns>An <see cref="IArgumentCanSetProperties{T}"/> with its default value factory.</returns>
    /// <inheritdoc cref="SetDefaultValueFactory(Func{object?})"/>
    IArgumentCanSetProperties<T> SetDefaultValueFactory(Func<object?> getDefaultValue);

    /// <returns>An <see cref="IArgumentCanSetProperties{T}"/> with its default value factory.</returns>
    /// <inheritdoc cref="SetDefaultValueFactory(Func{ArgumentResult, object?})"/>
    IArgumentCanSetProperties<T> SetDefaultValueFactory(Func<ArgumentResult, object?> getDefaultValue);

    /// <summary>
    /// Returns the wrapped <see cref="Argument{T}"/>.
    /// </summary>
    /// <returns>Returns the wrapped <see cref="Argument{T}"/>.</returns>
    Argument<T> GetArgument();
}
