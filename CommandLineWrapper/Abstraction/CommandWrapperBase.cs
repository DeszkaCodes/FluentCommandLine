using CommandLineWrapper.Abstraction.Interfaces;
using System.Collections;
using System.CommandLine;
using System.CommandLine.Completions;

namespace CommandLineWrapper.Abstraction;

/// <summary>
/// Defines a base for a <see cref="Command"/> wrapper.
/// </summary>
public abstract class CommandWrapperBase<T> : IdentifierSymbolWrapperBase,
    ICommandBaseCanSetName, ICommandBaseCanSetProperties
    where T : Command
{
    private protected readonly T _command;

    private protected CommandWrapperBase(T command)
    {
        _command = command;
    }

    /// <inheritdoc cref="Command.Children"/>
    public IEnumerable<Symbol> Children => _command.Children;

    /// <inheritdoc cref="Command.Arguments"/>
    public IReadOnlyList<Argument> Arguments => _command.Arguments;

    /// <inheritdoc cref="Command.Options"/>
    public IReadOnlyList<Option> Options => _command.Options;

    /// <inheritdoc cref="Command.Subcommands"/>
    public IReadOnlyList<Command> Subcommands => _command.Subcommands;

    /// <inheritdoc cref="Command.GetEnumerator"/>
    public IEnumerator GetEnumerator() => _command.GetEnumerator();

    /// <inheritdoc cref="Command.GetCompletions(CompletionContext)"/>
    public IEnumerable<CompletionItem> GetCompletions(CompletionContext context) => _command.GetCompletions(context);

    /// <inheritdoc cref="ICommandBaseCanSetName.SetName(string)"/>
    public override ICommandBaseCanSetProperties SetName(string name)
    {
        _command.Name = name;
        return this;
    }

    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetDescription(string)"/>
    public override  ICommandBaseCanSetProperties SetDescription(string description)
    {
        _command.Description = description;
        return this;
    }

    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddAlias(string)"/>
    public override  ICommandBaseCanSetProperties AddAlias(string alias)
    {
        _command.AddAlias(alias);
        return this;
    }

    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHidden(bool)"/>
    public override  ICommandBaseCanSetProperties SetHidden(bool isHidden)
    {
        _command.IsHidden = isHidden;
        return this;
    }

    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddArgument(Argument)"/>
    public virtual ICommandBaseCanSetProperties AddArgument(Argument argument)
    {
        _command.AddArgument(argument);
        return this;
    }

    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddOption(Option)"/>
    public virtual ICommandBaseCanSetProperties AddOption(Option option)
    {
        _command.AddOption(option);
        return this;
    }

    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddGlobalOption(Option)"/>
    public virtual ICommandBaseCanSetProperties AddGlobalOption(Option option)
    {
        _command.AddGlobalOption(option);
        return this;
    }

    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddCommand(Command)"/>
    public virtual ICommandBaseCanSetProperties AddCommand(Command command)
    {
        _command.AddCommand(command);
        return this;
    }

    /// <inheritdoc cref="ICommandBaseCanSetProperties.DoTreatUnmatchedTokensAsErrors(bool)"/>
    public virtual ICommandBaseCanSetProperties DoTreatUnmatchedTokensAsErrors(bool treatUnmatchedTokensAsErrors)
    {
        _command.TreatUnmatchedTokensAsErrors = treatUnmatchedTokensAsErrors;
        return this;
    }
}
