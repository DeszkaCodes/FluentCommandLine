namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods for adding a handler to the <see cref="System.CommandLine.Command"/>
/// </summary>
public partial interface ICommandBaseHasToSetHandler
{
    /// <summary>
    /// Sets the handler of the command to null.
    /// </summary>
    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with no handler.</returns>
    ICommandBaseHasToSetName NoHandler();

    /// <summary>
    /// Sets the handler of the command to invoke the <c>--help</c> switch.
    /// </summary>
    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    ICommandBaseHasToSetName SetHandlerInvokeSelfHelp();
}
