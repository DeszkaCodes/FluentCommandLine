namespace FluentCommandLine.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods for adding a handler to the <see cref="System.CommandLine.RootCommand"/>
/// </summary>
public partial interface IRootCommandHasToSetHandler : ICommandBaseHasToSetHandler
{
    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with no handler.</returns>
    /// <inheritdoc cref="ICommandBaseHasToSetHandler.NoHandler()"/>
    new IRootCommandCanSetProperties NoHandler();

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseHasToSetHandler.SetHandlerInvokeSelfHelp()" />
    new IRootCommandCanSetProperties SetHandlerInvokeSelfHelp();
}
