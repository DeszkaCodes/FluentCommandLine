using System.CommandLine;
using System.CommandLine.Binding;
using System.CommandLine.Invocation;

namespace CommandLineWrapper.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods responsible for setting a handler of a <see cref="Command"/>.
/// </summary>
public partial interface ICommandBaseCanSetHandler
{
    /// <inheritdoc cref="Handler.SetHandler(Command, Action{InvocationContext})"/>
    ICommandBaseCanSetProperties SetHandler(Action<InvocationContext> handle);

    /// <inheritdoc cref="Handler.SetHandler(Command, Action)"/>
    ICommandBaseCanSetProperties SetHandler(Action handle);

    /// <inheritdoc cref="Handler.SetHandler{T}(Command, Action{T}, IValueDescriptor{T})"/>
    ICommandBaseCanSetProperties SetHandler<T>(Action<T> handle, IValueDescriptor<T> symbol);

    /// <inheritdoc cref="Handler.SetHandler{T1, T2}(Command, Action{T1, T2}, IValueDescriptor{T1}, IValueDescriptor{T2})"/>
    ICommandBaseCanSetProperties SetHandler<T1, T2>(Action<T1, T2> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2);

    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3}(Command, Action{T1, T2, T3}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3})"/>
    ICommandBaseCanSetProperties SetHandler<T1, T2, T3>(Action<T1, T2, T3> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3);

    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4}(Command, Action{T1, T2, T3, T4}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4})"/>
    ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4>(Action<T1, T2, T3, T4> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4);

    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4, T5}(Command, Action{T1, T2, T3, T4, T5}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5})"/>
    ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5);

    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4, T5, T6}(Command, Action{T1, T2, T3, T4, T5, T6}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6})"/>
    ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6);

    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4, T5, T6, T7}(Command, Action{T1, T2, T3, T4, T5, T6, T7}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6}, IValueDescriptor{T7})"/>
    ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6,
        IValueDescriptor<T7> symbol7);

    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4, T5, T6, T7, T8}(Command, Action{T1, T2, T3, T4, T5, T6, T7, T8}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6}, IValueDescriptor{T7}, IValueDescriptor{T8})"/>
    ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6,
        IValueDescriptor<T7> symbol7,
        IValueDescriptor<T8> symbol8);
}
