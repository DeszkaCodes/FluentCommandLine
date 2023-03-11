namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods for setting the name of an <see cref="System.CommandLine.Option{T}"/>
/// </summary>
/// <typeparam name="T">The <see cref="Type"/> that the argument is expected to be parsed as.</typeparam>
public interface IArgumentHasToSetName<T> : ISymbolHasToSetName
{
    /// <returns>An <see cref="IArgumentCanSetProperties{T}"/> with its name set.</returns>
    /// <inheritdoc cref="ISymbolHasToSetName.SetName(string)"/>
    new IArgumentCanSetProperties<T> SetName(string name);

    /// <summary>
    /// Continues the creation without giving a name to the argument.
    /// </summary>
    /// <returns>An <see cref="IArgumentCanSetProperties{T}"/> with its name set.</returns>
    IArgumentCanSetProperties<T> WithoutName();
}
