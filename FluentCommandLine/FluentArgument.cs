using FluentCommandLine.Abstraction;
using FluentCommandLine.Abstraction.Interfaces;
using System.CommandLine;
using System.CommandLine.Binding;
using System.CommandLine.Completions;
using System.CommandLine.Parsing;

namespace FluentCommandLine;

/// <summary>
/// Wrapper for <see cref="Argument{T}"/> that uses fluent APIs.
/// </summary>
/// <typeparam name="T">The <see cref="Type"/> that the argument is expected to be parsed as.</typeparam>
public sealed class FluentArgument<T> : FluentSymbolBase<Argument<T>>,
    IArgumentHasToInitialize<T>, IArgumentHasToSetName<T>, IArgumentCanSetProperties<T>
{
    private FluentArgument()
        : base(null!)
    {
    }

    /// <summary>
    /// Creates a new instance of <see cref="FluentArgument{T}"/>.
    /// </summary>
    /// <returns>The new instance as <see cref="IArgumentHasToInitialize{T}"/>.</returns>
    public static IArgumentHasToInitialize<T> Create() => new FluentArgument<T>();

    /// <inheritdoc />
    public Argument<T> GetArgument() => _wrapped;

    /// <inheritdoc cref="Argument.HasDefaultValue"/>
    public bool IsDefaultValueSet => _wrapped.HasDefaultValue;

    /// <inheritdoc cref="Argument{T}.ValueType"/>
    public Type ValueType => _wrapped.ValueType;

    /// <inheritdoc cref="Argument.Completions"/>
    public CompletionSourceList Completions => _wrapped.Completions;

    /// <inheritdoc cref="Argument.GetDefaultValue"/>
    public object? GetDefaultValue() => _wrapped.GetDefaultValue();

    /// <inheritdoc cref="Argument.GetCompletions(CompletionContext)"/>
    public IEnumerable<CompletionItem> GetCompletions(CompletionContext context) => _wrapped.GetCompletions(context);

    /// <inheritdoc />
    public IArgumentHasToSetName<T> HasDefaultValue(Func<T> getDefaultValue)
    {
        _wrapped = new(getDefaultValue);
        return this;
    }

    /// <inheritdoc />
    public IArgumentHasToSetName<T> HasParseArgument(ParseArgument<T> parse, bool isDefault = false)
    {
        _wrapped = new(parse, isDefault);
        return this;
    }

    /// <inheritdoc />
    public IArgumentHasToSetName<T> NonInitialized()
    {
        _wrapped = new();
        return this;
    }

    /// <inheritdoc />
    public IArgumentCanSetProperties<T> AddValidator(ValidateSymbolResult<ArgumentResult> validate)
    {
        _wrapped.AddValidator(validate);
        return this;
    }

    /// <inheritdoc />
    public IArgumentCanSetProperties<T> SetArity(ArgumentArity arity)
    {
        _wrapped.Arity = arity;
        return this;
    }

    /// <inheritdoc />
    public IArgumentCanSetProperties<T> SetDefaultValue(object? value)
    {
        _wrapped.SetDefaultValue(value);
        return this;
    }

    /// <inheritdoc />
    public IArgumentCanSetProperties<T> SetDefaultValueFactory(Func<object?> getDefaultValue)
    {
        _wrapped.SetDefaultValueFactory(getDefaultValue);
        return this;
    }

    /// <inheritdoc />
    public IArgumentCanSetProperties<T> SetDefaultValueFactory(Func<ArgumentResult, object?> getDefaultValue)
    {
        _wrapped.SetDefaultValueFactory(getDefaultValue);
        return this;
    }

    /// <inheritdoc />
    public IArgumentCanSetProperties<T> SetHelpName(string helpName)
    {
        _wrapped.HelpName = helpName;
        return this;
    }

    /// <inheritdoc />
    public IArgumentCanSetProperties<T> WithoutName()
    {
        return this;
    }

    /// <inheritdoc />
    public override IArgumentCanSetProperties<T> SetName(string name)
    {
        base.SetName(name);
        return this;
    }

    /// <inheritdoc />
    public override IArgumentCanSetProperties<T> SetDescription(string description)
    {
        base.SetDescription(description);
        return this;
    }

    /// <inheritdoc />
    public override IArgumentCanSetProperties<T> SetHidden(bool isHidden)
    {
        base.SetHidden(isHidden);
        return this;
    }
}
