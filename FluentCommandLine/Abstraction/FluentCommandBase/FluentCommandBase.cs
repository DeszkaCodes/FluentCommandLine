using FluentCommandLine.Abstraction.Interfaces;
using System.CommandLine.Completions;
using System.Collections;
using System.CommandLine;

namespace FluentCommandLine.Abstraction;

/// <summary>
/// Defines a base for a <see cref="Command"/> wrapper.
/// </summary>
/// <typeparam name="T">The <see cref="Type"/> that inherits <see cref="Command"/>.</typeparam>
public abstract partial class FluentCommandBase<T> : FluentIdentifierSymbolBase<T>,
    ICommandBaseCanSetName, ICommandBaseCanSetProperties
    where T : Command
{
    private protected FluentCommandBase(T command)
        :base(command)
    {
    }

    /// <inheritdoc cref="Command.Children"/>
    public IEnumerable<Symbol> Children => _wrapped.Children;

    /// <inheritdoc cref="IdentifierSymbol.Aliases" />
    public IReadOnlyCollection<string> Aliases => _wrapped.Aliases;

    /// <inheritdoc cref="Command.Arguments"/>
    public IReadOnlyList<Argument> Arguments => _wrapped.Arguments;

    /// <inheritdoc cref="Command.Options"/>
    public IReadOnlyList<Option> Options => _wrapped.Options;

    /// <inheritdoc cref="Command.Subcommands"/>
    public IReadOnlyList<Command> Subcommands => _wrapped.Subcommands;

    /// <inheritdoc cref="Command.GetEnumerator"/>
    public IEnumerator GetEnumerator() => _wrapped.GetEnumerator();

    /// <inheritdoc cref="Command.GetCompletions(CompletionContext)"/>
    public IEnumerable<CompletionItem> GetCompletions(CompletionContext context) => _wrapped.GetCompletions(context);

    /// <inheritdoc cref="ICommandBaseCanSetName.SetName(string)"/>
    public override ICommandBaseCanSetProperties SetName(string name)
    {
        base.SetName(name);
        return this;
    }

    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetDescription(string)"/>
    public override  ICommandBaseCanSetProperties SetDescription(string description)
    {
        base.SetDescription(description);
        return this;
    }

    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddAlias(string)"/>
    public override ICommandBaseCanSetProperties AddAlias(string alias)
    {
        base.AddAlias(alias);
        return this;
    }

    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHidden(bool)"/>
    public override ICommandBaseCanSetProperties SetHidden(bool isHidden)
    {
        base.SetHidden(isHidden);
        return this;
    }

    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddArgument(Argument)"/>
    public virtual ICommandBaseCanSetProperties AddArgument(Argument argument)
    {
        _wrapped.AddArgument(argument);
        return this;
    }

    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddOption(Option)"/>
    public virtual ICommandBaseCanSetProperties AddOption(Option option)
    {
        _wrapped.AddOption(option);
        return this;
    }

    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddGlobalOption(Option)"/>
    public virtual ICommandBaseCanSetProperties AddGlobalOption(Option option)
    {
        _wrapped.AddGlobalOption(option);
        return this;
    }

    /// <inheritdoc cref="ICommandBaseCanSetProperties.AddCommand(Command)"/>
    public virtual ICommandBaseCanSetProperties AddCommand(Command command)
    {
        _wrapped.AddCommand(command);
        return this;
    }

    /// <inheritdoc cref="ICommandBaseCanSetProperties.DoTreatUnmatchedTokensAsErrors(bool)"/>
    public virtual ICommandBaseCanSetProperties DoTreatUnmatchedTokensAsErrors(bool treatUnmatchedTokensAsErrors)
    {
        _wrapped.TreatUnmatchedTokensAsErrors = treatUnmatchedTokensAsErrors;
        return this;
    }

    /// <inheritdoc />
    public virtual ICommandBaseCanSetProperties SetHandlerInvokeSelfHelp()
    {
        Action callHelp = () => _wrapped.Invoke("--help");

        _wrapped.SetHandler(callHelp);
        return this;
    }
}
