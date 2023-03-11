namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods for adding a handler to the <see cref="System.CommandLine.Command"/>
/// </summary>
public partial interface ICommandBaseHasToSetHandler
{
    /// <summary>
    /// Sets the handler of the command to null.
    /// </summary>
    /// <returns>An <see cref="ICommandBaseCanSetProperties"/> with no handler.</returns>
    ICommandBaseCanSetProperties NoHandler();
}
