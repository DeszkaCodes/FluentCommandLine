using System.CommandLine;

namespace CommandLineWrapper.Abstraction.Interfaces;

/// <summary>
/// Defines method for a simple symbol wrapper.
/// </summary>
/// <typeparam name="T">The <see cref="Type"/> underlying type of the wrapper.</typeparam>
internal interface ISymbolWrapper<T> where T : Symbol
{
    /// <summary>
    /// Gets the name of the symbol.
    /// </summary>
    string Name { get; }
    /// <summary>
    /// Gets the description of the symbol.
    /// </summary>
    string? Description { get; }
    /// <summary>
    /// Gets a value indicating whether the symbol is hidden.
    /// </summary>
    bool IsHidden { get; }

    /// <summary>
    /// Converts the wrapper into a <typeparamref name="T"/>.
    /// </summary>
    /// <returns>The <typeparamref name="T"/> from the settings of the wrapper.</returns>
    T ToCorrespondingType();
}
