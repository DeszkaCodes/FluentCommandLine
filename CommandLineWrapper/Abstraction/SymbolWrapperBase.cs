using CommandLineWrapper.Abstraction.Interfaces;
using System.CommandLine;

namespace CommandLineWrapper.Abstraction;

/// <summary>
/// Defines a base for a simple wrapper symbol class.
/// </summary>
/// <typeparam name="T">The <see cref="Type"/> underlying type of the wrapper.</typeparam>
public abstract class SymbolWrapperBase<T> : ISymbolWrapper<T> where T : Symbol
{
    protected readonly string _name;
    protected string? _description;
    protected bool _isHidden;

    public string Name => _name;
    public string? Description => _description;
    public bool IsHidden => _isHidden;

    protected SymbolWrapperBase(string name)
    {
        _name = name;
    }

    public abstract T ToCorrespondingType();
}
