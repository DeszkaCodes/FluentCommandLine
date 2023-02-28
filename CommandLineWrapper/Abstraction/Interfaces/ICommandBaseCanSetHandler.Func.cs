using System.CommandLine;
using System.CommandLine.Binding;
using System.CommandLine.Invocation;

namespace CommandLineWrapper.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods responsible for setting a handler of a <see cref="Command"/>.
/// </summary>
public partial interface ICommandBaseCanSetHandler
{
    /// <inheritdoc cref="Handler.SetHandler(Command, Func{Task})"/>
    ICommandBaseCanSetProperties SetHandler(Func<Task> handle);

    /// <inheritdoc cref="Handler.SetHandler(Command, Func{InvocationContext, Task})"/>
    ICommandBaseCanSetProperties SetHandler(Func<InvocationContext, Task> handle);

    /// <inheritdoc cref="Handler.SetHandler{T}(Command, Func{T, Task}, IValueDescriptor{T})"/>
    ICommandBaseCanSetProperties SetHandler<T>(Func<T, Task> handle, IValueDescriptor symbol);

    /// <inheritdoc cref="Handler.SetHandler{T1, T2}(Command, Func{T1, T2, Task}, IValueDescriptor{T1}, IValueDescriptor{T2})"/>
    ICommandBaseCanSetProperties SetHandler<T1, T2>(Func<T1, T2> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2);

    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3}(Command, Func{T1, T2, T3, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3})"/>
    ICommandBaseCanSetProperties SetHandler<T1, T2, T3>(Func<T1, T2, T3, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3);

    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4}(Command, Func{T1, T2, T3, T4, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4})"/>
    ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4>(Func<T1, T2, T3, T4, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4);

    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4, T5}(Command, Func{T1, T2, T3, T4, T5, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5})"/>
    ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5);

    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4, T5, T6}(Command, Func{T1, T2, T3, T4, T5, T6, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6})"/>
    ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6);

    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4, T5, T6, T7}(Command, Func{T1, T2, T3, T4, T5, T6, T7, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6}, IValueDescriptor{T7})"/>
    ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6,
        IValueDescriptor<T7> symbol7);

    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4, T5, T6, T7, T8}(Command, Func{T1, T2, T3, T4, T5, T6, T7, T8, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6}, IValueDescriptor{T7}, IValueDescriptor{T8})"/>
    ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6,
        IValueDescriptor<T7> symbol7,
        IValueDescriptor<T8> symbol8);
}
