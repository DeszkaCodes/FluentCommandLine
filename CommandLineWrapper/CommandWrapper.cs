using System.CommandLine;

namespace CommandLineWrapper;

/// <summary>
/// Wrapper for <see cref="Command"/> that can be converted into <see cref="Command"/>.
/// </summary>
internal sealed class CommandWrapper
{
    /// <summary>
    /// Name of the <see cref="Command"/>.
    /// </summary>
    private readonly string _name;
    /// <summary>
    /// Description of the <see cref="Command"/>.
    /// </summary>
    private readonly string? _description;

    /// <summary>
    /// Initializes a <see langword="new"/> instance of <see cref="CommandWrapper"/> with the given <paramref name="name"/> and <paramref name="description"/>.
    /// </summary>
    /// <param name="name">Name of the <see cref="Command"/>.</param>
    /// <param name="description">Description of the <see cref="Command"/>.</param>
    private CommandWrapper(string name, string? description = null)
    {
        _name = name;
        _description = description;
    }

    /// <summary>
    /// Creates a <see langword="new"/> instance of <see cref="CommandWrapper"/> with the given <paramref name="name"/>
    /// that can be later converted into <see cref="Command"/>.
    /// </summary>
    /// <param name="name">Name of the <see cref="Command"/>.</param>
    /// <returns>A <see langword="new"/> instance <see cref="CommandWrapper"/> with the given <paramref name="name"/>.</returns>
    public static CommandWrapper Create(string name)
        => new(name, null);
}
