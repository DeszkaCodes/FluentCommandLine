namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods for setting the <see cref="IOptionCanSetParseArgument{T}"/>
/// properties of an <see cref="System.CommandLine.Option{T}"/>
/// </summary>
/// <typeparam name="T">The <see cref="System.Type"/> that the option's arguments are expected to be parsed as.</typeparam>
public interface IOptionCanSetParseArgument<T>
{
    /// <summary>
    /// Sets a value that indicates whether the argument is default or not.
    /// </summary>
    /// <param name="isDefault">The value that will be set.</param>
    /// <returns>An <see cref="IOptionComplete{T}"/> with it's value set.</returns>
    IOptionHasToSetName<T> SetDefault(bool isDefault);
}
