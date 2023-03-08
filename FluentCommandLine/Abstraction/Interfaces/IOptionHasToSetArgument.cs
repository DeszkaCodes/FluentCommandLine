using System.CommandLine.Parsing;
using System.CommandLine;

namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods for setting the argument of an <see cref="Option{T}"/>
/// </summary>
/// <typeparam name="T">The <see cref="Type"/> that the option's arguments are expected to be parsed as.</typeparam>
public interface IOptionHasToSetArgument<T>
{
    /// <summary>
    /// Sets argument parsing to the <see cref="Option{T}"/>.
    /// </summary>
    /// <returns>An <see cref="IOptionHasToSetName{T}"/> with the added <see cref="ParseArgument{T}"/>.</returns>
    IOptionHasToSetName<T> AddParseArgument(ParseArgument<T> parseArgument, bool isDefault);

    /// <summary>
    /// Adds a function that gets the default value of the <see cref="Option{Task}"/>
    /// </summary>
    /// <returns>An <see cref="IOptionHasToSetName{T}"/> with the added <see cref="Func{T}"/>.</returns>
    IOptionHasToSetName<T> AddDefaultValue(Func<T> getDefaultValue);

    /// <summary>
    /// Returns an <see cref="IOptionHasToSetName{T}"/> without an argument.
    /// </summary>
    /// <returns>An <see cref="IOptionHasToSetName{T}"/> with no arguments.</returns>
    IOptionHasToSetName<T> HasNoArgument();
}
