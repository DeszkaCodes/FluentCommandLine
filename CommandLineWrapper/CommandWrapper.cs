using System.CommandLine;

namespace CommandLineWrapper;

/// <summary>
/// Wrapper for the <see cref="Command"/> class.
/// </summary>
public sealed class CommandWrapper
{
    /// <summary>
    /// Name of the command.
    /// </summary>
    private readonly string _name;
    /// <summary>
    /// Description of the command.
    /// </summary>
    private string? _description;

    /// <summary>
    /// List of subcommands.
    /// </summary>
    private List<Command>? _subcommands;

    /// <summary>
    /// List of subcommands.
    /// </summary>
    public IReadOnlyList<Command> Subcommands => _subcommands is not null ? _subcommands : Array.Empty<Command>();

    /// <summary>
    /// Initializes a <see langword="new"/> instance of <see cref="CommandWrapper"/> with the given <paramref name="name"/> and <paramref name="description"/>.
    /// </summary>
    /// <param name="name">Name of the command.</param>
    private CommandWrapper(string name)
    {
        _name = name;
        _subcommands = new List<Command>();
    }

    /// <summary>
    /// Creates a <see langword="new"/> instance of <see cref="CommandWrapper"/> with the given <paramref name="name"/>
    /// that can be later converted into <see cref="Command"/>.
    /// </summary>
    /// <param name="name">Name of the command.</param>
    /// <returns>A <see langword="new"/> instance <see cref="CommandWrapper"/> with the given <paramref name="name"/>.</returns>
    public static CommandWrapper Create(string name)
        => new(name);
    /// <summary>
    /// Sets the description for the command.
    /// </summary>
    /// <param name="description">The description that will be set.</param>
    /// <returns>The <see cref="CommandWrapper"/> with its description set.</returns>
    public CommandWrapper SetDescription(string description)
    {
        _description = description;
        return this;
    }

    /// <summary>
    /// Adds a subcommand to the command.
    /// </summary>
    /// <param name="subCommand">The subcommand to add to the command.</param>
    /// <returns>The <see cref="CommandWrapper"/> with the <paramref name="subCommand"/> added.</returns>
    public CommandWrapper AddSubCommand(Command subCommand)
    {
        (_subcommands ??= new()).Add(subCommand);
        return this;
    }
}
