namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines a fluent method responsible for setting the name of a <see cref="System.CommandLine.Command"/>.
/// </summary>
public interface ICommandBaseCanSetName : IIdentifierSymbolCanSetName
{
    /// <returns>An <see cref="ICommandBaseCanSetProperties"/> with the given name.</returns>
    /// <inheritdoc cref="IIdentifierSymbolCanSetName.SetName(string)"/>
    new ICommandBaseCanSetProperties SetName(string name);
}
