namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines a fluent method responsible for setting the name of a <see cref="System.CommandLine.Command"/>.
/// </summary>
public interface ICommandHasToSetName : ICommandBaseHasToSetName
{
    /// <returns>An <see cref="ICommandCanSetProperties"/> with the given name.</returns>
    /// <inheritdoc cref="ICommandBaseHasToSetName.SetName(string)"/>
    new ICommandCanSetProperties SetName(string name);
}
