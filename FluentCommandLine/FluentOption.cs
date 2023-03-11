using FluentCommandLine.Abstraction;
using FluentCommandLine.Abstraction.Interfaces;
using System.CommandLine;
using System.CommandLine.Parsing;

namespace FluentCommandLine;

/// <summary>
/// Wrapper for <see cref="Option{T}"/> that uses fluent APIs.
/// </summary>
/// <typeparam name="T">The <see cref="Type"/> that the option's arguments are expected to be parsed as.</typeparam>
public sealed class FluentOption<T> : FluentIdentifierSymbolBase<Option<T>>,
    IOptionHasToSetArgument<T>, IOptionHasToSetName<T>, IOptionCanSetProperties<T>
{
    private readonly struct ConstructorData
    {
        private enum ConstructorType
        {
            NoArgument,
            GetDefaultValue,
            AddParseArgument
        }

        private readonly ConstructorType Type { get; }

        private readonly Func<T> GetDefaultValue { get; } = null!;
        private readonly ParseArgument<T> ParseArgument { get; } = null!;
        private readonly bool ParseArgumentIsDefault { get; }

        public ConstructorData(Func<T> getDefaultValue)
        : this(ConstructorType.GetDefaultValue)
        {
            GetDefaultValue = getDefaultValue;
        }

        public ConstructorData(ParseArgument<T> parseArgument, bool isDefault)
            : this(ConstructorType.AddParseArgument)
        {
            ParseArgument = parseArgument;
            ParseArgumentIsDefault = isDefault;
        }

        public ConstructorData()
            : this(ConstructorType.NoArgument)
        { }

        private ConstructorData(ConstructorType type)
        {
            Type = type;
        }

        public Option<T> Construct(string[] alias)
        {
            return Type switch
            {
                ConstructorType.NoArgument => new(alias),
                ConstructorType.GetDefaultValue => new(alias, GetDefaultValue),
                ConstructorType.AddParseArgument => new(alias, ParseArgument, ParseArgumentIsDefault),
                _ => throw new NotImplementedException()
            };
        }
    }

    private ConstructorData _constructorData;

    private FluentOption()
        : base(null!)
    { }

    /// <summary>
    /// Creates a new instance of <see cref="FluentOption{T}"/>.
    /// </summary>
    /// <returns>The new instance as <see cref="IOptionHasToSetArgumen{T}"/>.</returns>
    public static IOptionHasToSetArgument<T> Create() => new FluentOption<T>();

    /// <inheritdoc/>
    public Option<T> GetOption() => _wrapped;

    ///<inheritdoc />
    public IOptionHasToSetName<T> AddDefaultValue(Func<T> getDefaultValue)
    {
        _constructorData = new(getDefaultValue);
        return this;
    }

    ///<inheritdoc />
    public IOptionHasToSetName<T> AddParseArgument(ParseArgument<T> parseArgument, bool isDefault)
    {
        _constructorData = new(parseArgument, isDefault);
        return this;
    }

    ///<inheritdoc />
    public IOptionHasToSetName<T> HasNoArgument()
    {
        _constructorData = new();
        return this;
    }

    ///<inheritdoc />
    public override IOptionCanSetProperties<T> SetName(string name)
    {
        return SetAliases(new string[] { name });
    }

    ///<inheritdoc />
    public IOptionCanSetProperties<T> SetAliases(string[] aliases)
    {
        _wrapped = _constructorData.Construct(aliases);
        return this;
    }

    /// <inheritdoc />
    public override IOptionCanSetProperties<T> SetDescription(string description)
    {
        base.SetDescription(description);
        return this;
    }

    /// <inheritdoc />
    public override IOptionCanSetProperties<T> SetHidden(bool isHidden)
    {
        base.SetHidden(isHidden);
        return this;
    }

    /// <inheritdoc />
    public override IOptionCanSetProperties<T> AddAlias(string alias)
    {
        base.AddAlias(alias);
        return this;
    }

    /// <inheritdoc />
    public IOptionCanSetProperties<T> SetArity(ArgumentArity arity)
    {
        _wrapped.Arity = arity;
        return this;
    }

    /// <inheritdoc />
    public IOptionCanSetProperties<T> AddValidator(ValidateSymbolResult<OptionResult> validate)
    {
        _wrapped.AddValidator(validate);
        return this;
    }

    /// <inheritdoc />
    public IOptionCanSetProperties<T> SetDefaultValue(object? value)
    {
        _wrapped.SetDefaultValue(value);
        return this;
    }

    /// <inheritdoc />
    public IOptionCanSetProperties<T> SetDefaultValueFactory(Func<object?> getDefaultValue)
    {
        _wrapped.SetDefaultValueFactory(getDefaultValue);
        return this;
    }

    /// <inheritdoc />
    public IOptionCanSetProperties<T> SetAllowMultipleArgumentsPerToken(bool allowMultipleArgumentsPerToken)
    {
        _wrapped.AllowMultipleArgumentsPerToken = allowMultipleArgumentsPerToken;
        return this;
    }

    /// <inheritdoc />
    public IOptionCanSetProperties<T> SetRequired(bool isRequired)
    {
        _wrapped.IsRequired = isRequired;
        return this;
    }
}
