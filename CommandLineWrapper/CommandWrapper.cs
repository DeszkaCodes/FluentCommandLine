using System.CommandLine;

namespace CommandLineWrapper;

/// <summary>
/// Wrapper for the <see cref="Command"/> class.
/// </summary>
public sealed class CommandWrapper
{
    private readonly string _name;
    private string? _description;

    private List<Command>? _subcommands;

    /// <summary>
    /// Represents all of the options for the command, including global options that have been applied to any of the command's ancestors.
    /// </summary>
    public IReadOnlyList<Command> Subcommands => _subcommands is not null ? _subcommands : Array.Empty<Command>();

    /// <summary>
    /// Represents all of the subcommands for the command.
    /// </summary>
    private CommandWrapper(string name)
    {
        _name = name;
    }

    /// <summary>
    /// Creates a <see langword="new"/> instance of <see cref="CommandWrapper"/> with the given <paramref name="name"/>
    /// that can be later converted into <see cref="Command"/>.
    /// </summary>
    /// <param name="name">Name of the command.</param>
    /// <returns>A <see langword="new"/> instance <see cref="CommandWrapper"/> with the given <paramref name="name"/>.</returns>
    public static CommandWrapper CreateCommand(string name)
        => new(name);
    /// <summary>
    /// Sets the description for the command.
    /// </summary>
    /// <param name="description">The text to set as description</param>
    /// <returns>The <see cref="CommandWrapper"/> with its description set.</returns>
    public CommandWrapper SetDescription(string description)
    {
        _description = description;
        return this;
    }

    /// <summary>
    /// Adds a subcommand to the command.
    /// </summary>
    /// <remarks>Commands can be nested to an arbitrary depth.</remarks>
    /// <param name="subcommand">The subcommand to add to the command.</param>
    /// <returns>The <see cref="CommandWrapper"/> with the <paramref name="subcommand"/> added.</returns>
    public CommandWrapper AddCommand(Command subcommand)
    {
        (_subcommands ??= new()).Add(subcommand);
        return this;
    }
}
