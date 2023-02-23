using System.CommandLine;

namespace CommandLineWrapper;

/// <summary>
/// Wrapper for <see cref="Command"/> that can be converted into <see cref="Command"/>.
/// </summary>
public sealed class CommandWrapper
{
    /// <summary>
    /// Name of the <see cref="Command"/>.
    /// </summary>
    private readonly string _name;
    /// <summary>
    /// Description of the <see cref="Command"/>.
    /// </summary>
    private string? _description;

    private readonly IList<Command> _commands;

    /// <summary>
    /// Initializes a <see langword="new"/> instance of <see cref="CommandWrapper"/> with the given <paramref name="name"/> and <paramref name="description"/>.
    /// </summary>
    /// <param name="name">Name of the <see cref="Command"/>.</param>
    /// <param name="description">Description of the <see cref="Command"/>.</param>
    private CommandWrapper(string name)
    {
        _name = name;
        _commands = new List<Command>();
    }

    /// <summary>
    /// Creates a <see langword="new"/> instance of <see cref="CommandWrapper"/> with the given <paramref name="name"/>
    /// that can be later converted into <see cref="Command"/>.
    /// </summary>
    /// <param name="name">Name of the <see cref="Command"/>.</param>
    /// <returns>A <see langword="new"/> instance <see cref="CommandWrapper"/> with the given <paramref name="name"/>.</returns>
    public static CommandWrapper Create(string name)
        => new(name);
    /// <summary>
    /// Sets the description for the <see cref="Command"/>.
    /// </summary>
    /// <param name="description">The description that will be set.</param>
    /// <returns>The <see cref="CommandWrapper"/> with its description set.</returns>
    public CommandWrapper SetDescription(string description)
    {
        _description = description;
        return this;
    }
}
