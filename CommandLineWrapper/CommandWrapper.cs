﻿using CommandLineWrapper.Abstraction;
using CommandLineWrapper.Abstraction.Interfaces;
using System.CommandLine;

namespace CommandLineWrapper;

public sealed class CommandWrapper : CommandWrapperBase<Command>,
    ICommandCanSetName, ICommandCanSetProperties
{
    const string DefaultCommandName = "unknown";

    private CommandWrapper()
        : base(new Command(DefaultCommandName))
    {
    }

    /// <summary>
    /// Creates a new instance of <see cref="CommandWrapper"/>.
    /// </summary>
    /// <returns>The new instance as <see cref="ICommandCanSetName"/>.</returns>
    public static ICommandCanSetName Create() => new CommandWrapper();

    /// <inheritdoc />
    public Command GetCommand()
    {
        return _command;
    }

    /// <inheritdoc cref="ICommandCanSetProperties.AddAlias(string)" />
    public override ICommandCanSetProperties AddAlias(string alias)
    {
        base.AddAlias(alias);
        return this;
    }

    /// <inheritdoc cref="Command.AddArgument(Argument)" />
    public override ICommandCanSetProperties AddArgument(Argument argument)
    {
        base.AddArgument(argument);
        return this;
    }

    /// <inheritdoc cref="ICommandCanSetProperties.AddCommand(Command)" />
    public override ICommandCanSetProperties AddCommand(Command command)
    {
        base.AddCommand(command);
        return this;
    }

    /// <inheritdoc cref="ICommandCanSetProperties.AddGlobalOption(Option)" />
    public override ICommandCanSetProperties AddGlobalOption(Option option)
    {
        base.AddGlobalOption(option);
        return this;
    }

    /// <inheritdoc cref="ICommandCanSetProperties.AddOption(Option)" />
    public override ICommandCanSetProperties AddOption(Option option)
    {
        base.AddOption(option);
        return this;
    }

    /// <inheritdoc cref="ICommandCanSetProperties.DoTreatUnmatchedTokensAsErrors(bool)" />
    public override ICommandCanSetProperties DoTreatUnmatchedTokensAsErrors(bool treatUnmatchedTokensAsErrors)
    {
        base.DoTreatUnmatchedTokensAsErrors(treatUnmatchedTokensAsErrors);
        return this;
    }

    /// <inheritdoc cref="ICommandCanSetProperties.SetHidden(bool)" />
    public override ICommandCanSetProperties SetHidden(bool isHidden)
    {
        base.SetHidden(isHidden);
        return this;
    }

    /// <inheritdoc cref="ICommandCanSetName.SetName(string)" />
    public override ICommandCanSetProperties SetName(string name)
    {
        base.SetName(name);
        return this;
    }

    /// <inheritdoc cref="ICommandCanSetProperties.SetDescription(string)" />
    public override ICommandCanSetProperties SetDescription(string description)
    {
        base.SetDescription(description);
        return this;
    }
}
