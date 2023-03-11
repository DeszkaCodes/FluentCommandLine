namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods for adding a handler to the <see cref="System.CommandLine.Command"/>
/// </summary>
public partial interface ICommandHasToSetHandler : ICommandBaseHasToSetHandler
{
    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with no handler.</returns>
    /// <inheritdoc cref="ICommandBaseHasToSetHandler.NoHandler()"/>
    new ICommandCanSetProperties NoHandler();

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseHasToSetHandler.SetHandlerInvokeSelfHelp()" />
    new ICommandCanSetProperties SetHandlerInvokeSelfHelp();
}
