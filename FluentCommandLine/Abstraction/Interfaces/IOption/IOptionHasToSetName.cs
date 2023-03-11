namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods for setting the name of an <see cref="System.CommandLine.Option{T}"/>
/// </summary>
/// <typeparam name="T">The <see cref="System.Type"/> that the option's arguments are expected to be parsed as.</typeparam>
public interface IOptionHasToSetName<T> : IIdentifierSymbolHasToSetName
{
    /// <returns>An <see cref="IOptionCanSetProperties{T}"/> with the given name.</returns>
    /// <inheritdoc cref="IIdentifierSymbolHasToSetName.SetName(string)"/>
    new IOptionCanSetProperties<T> SetName(string name);

    /// <summary>
    /// Sets the aliases of the identifier symbol.
    /// </summary>
    /// <param name="aliases">The aliases of the identifier symbol.</param>
    /// <returns>An <see cref="IOptionCanSetProperties{T}"/> with the given aliases.</returns>
    IOptionCanSetProperties<T> SetAliases(string[] aliases);
}
