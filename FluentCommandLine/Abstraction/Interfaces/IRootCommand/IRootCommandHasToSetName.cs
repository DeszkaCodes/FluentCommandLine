namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines a fluent method responsible for setting the name of a <see cref="System.CommandLine.RootCommand"/>.
/// </summary>
public interface IRootCommandHasToSetName : ICommandBaseHasToSetName
{
    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the given name.</returns>
    /// <inheritdoc cref="IIdentifierSymbolHasToSetName.SetName(string)"/>
    new IRootCommandCanSetProperties SetName(string name);

    /// <summary>
    /// Sets the name of the root command to the name of the executable.
    /// </summary>
    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the given name.</returns>
    IRootCommandCanSetProperties UseExecutableName();
}
