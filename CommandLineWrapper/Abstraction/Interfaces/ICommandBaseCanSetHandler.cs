namespace CommandLineWrapper.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods responsible for setting a handler of a <see cref="System.CommandLine.Command"/>.
/// </summary>
public partial interface ICommandBaseCanSetHandler
{
    /// <summary>
    /// Sets the command's handler to <see langword="null"/>.
    /// </summary>
    /// <returns>An <see cref="ICommandBaseCanSetProperties"/> without a handler.</returns>
    ICommandBaseCanSetProperties NoHandler();
}
