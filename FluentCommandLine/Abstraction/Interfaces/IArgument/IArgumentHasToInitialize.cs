using System.CommandLine.Parsing;

namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods for initializing an <see cref="System.CommandLine.Argument{T}"/>.
/// </summary>
/// <typeparam name="T">The <see cref="Type"/> that the arguments is expected to be parsed as.</typeparam>
public interface IArgumentHasToInitialize<T>
{
    /// <summary>
    /// Creates an argument without anything set.
    /// </summary>
    /// <returns>An <see cref="IArgumentHasToSetName{T}"/> without setting anything.</returns>
    IArgumentHasToSetName<T> NonInitialized();

    /// <summary>
    /// Creates an argument with a default value factory.
    /// </summary>
    /// <returns>An <see cref="IArgumentHasToSetName{T}"/> with a default value factory.</returns>
    /// <inheritdoc cref="System.CommandLine.Argument{T}.Argument(Func{T})"/>
    IArgumentHasToSetName<T> HasDefaultValue(Func<T> getDefaultValue);

    /// <summary>
    /// Creates an argument with a custom parser.
    /// </summary>
    /// <returns>An <see cref="IArgumentHasToSetName{T}"/> with a custom parser.</returns>
    /// <inheritdoc cref="System.CommandLine.Argument{T}.Argument(ParseArgument{T}, bool)"/>
    IArgumentHasToSetName<T> HasParseArgument(ParseArgument<T> parse, bool isDefault = false);
}
