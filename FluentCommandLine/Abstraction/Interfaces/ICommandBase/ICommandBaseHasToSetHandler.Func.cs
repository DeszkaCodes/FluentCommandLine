using System.CommandLine.Invocation;
using System.CommandLine.Binding;
using System.CommandLine;

namespace FluentCommandLine.Abstraction.Interfaces;

public partial interface ICommandBaseHasToSetHandler
{
    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler(Command, Func{Task})"/>
    ICommandBaseHasToSetName SetHandler(Func<Task> handle);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler(Command, Func{InvocationContext, Task})"/>
    ICommandBaseHasToSetName SetHandler(Func<InvocationContext, Task> handle);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler{T}(Command, Func{T, Task}, IValueDescriptor{T})"/>
    ICommandBaseHasToSetName SetHandler<T>(Func<T, Task> handle, IValueDescriptor<T> symbol);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler{T1, T2}(Command, Func{T1, T2, Task}, IValueDescriptor{T1}, IValueDescriptor{T2})"/>
    ICommandBaseHasToSetName SetHandler<T1, T2>(Func<T1, T2, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3}(Command, Func{T1, T2, T3, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3})"/>
    ICommandBaseHasToSetName SetHandler<T1, T2, T3>(Func<T1, T2, T3, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4}(Command, Func{T1, T2, T3, T4, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4})"/>
    ICommandBaseHasToSetName SetHandler<T1, T2, T3, T4>(Func<T1, T2, T3, T4, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4, T5}(Command, Func{T1, T2, T3, T4, T5, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5})"/>
    ICommandBaseHasToSetName SetHandler<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4, T5, T6}(Command, Func{T1, T2, T3, T4, T5, T6, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6})"/>
    ICommandBaseHasToSetName SetHandler<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4, T5, T6, T7}(Command, Func{T1, T2, T3, T4, T5, T6, T7, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6}, IValueDescriptor{T7})"/>
    ICommandBaseHasToSetName SetHandler<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6,
        IValueDescriptor<T7> symbol7);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4, T5, T6, T7, T8}(Command, Func{T1, T2, T3, T4, T5, T6, T7, T8, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6}, IValueDescriptor{T7}, IValueDescriptor{T8})"/>
    ICommandBaseHasToSetName SetHandler<T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6,
        IValueDescriptor<T7> symbol7,
        IValueDescriptor<T8> symbol8);
}
