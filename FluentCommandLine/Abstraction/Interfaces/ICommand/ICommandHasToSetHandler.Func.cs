﻿using System.CommandLine.Binding;
using System.CommandLine.Invocation;

namespace FluentCommandLine.Abstraction.Interfaces;

public partial interface ICommandHasToSetHandler
{
    /// <returns>An <see cref="ICommandHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseHasToSetHandler.SetHandler(Func{Task})"/>
    new ICommandHasToSetName SetHandler(Func<Task> handle);

    /// <returns>An <see cref="ICommandHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseHasToSetHandler.SetHandler(Func{InvocationContext, Task})"/>
    new ICommandHasToSetName SetHandler(Func<InvocationContext, Task> handle);

    /// <returns>An <see cref="ICommandHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseHasToSetHandler.SetHandler{T}(Func{T, Task}, IValueDescriptor{T})"/>
    new ICommandHasToSetName SetHandler<T>(Func<T, Task> handle, IValueDescriptor<T> symbol);

    /// <returns>An <see cref="ICommandHasToSetName"/> with the new handler.</returns>
    /// ICommandBaseHasToSetHandler.SetHandler{T1, T2}(Func{T1, T2, Task}, IValueDescriptor{T1}, IValueDescriptor{T2})
    /// <inheritdoc cref="ICommandBaseHasToSetHandler.SetHandler{T1, T2}(Func{T1, T2, Task}, IValueDescriptor{T1}, IValueDescriptor{T2})"/>
    new ICommandHasToSetName SetHandler<T1, T2>(Func<T1, T2, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2);

    /// <returns>An <see cref="ICommandHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseHasToSetHandler.SetHandler{T1, T2, T3}(Func{T1, T2, T3, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3})"/>
    new ICommandHasToSetName SetHandler<T1, T2, T3>(Func<T1, T2, T3, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3);

    /// <returns>An <see cref="ICommandHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseHasToSetHandler.SetHandler{T1, T2, T3, T4}(Func{T1, T2, T3, T4, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4})"/>
    new ICommandHasToSetName SetHandler<T1, T2, T3, T4>(Func<T1, T2, T3, T4, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4);

    /// <returns>An <see cref="ICommandHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseHasToSetHandler.SetHandler{T1, T2, T3, T4, T5}(Func{T1, T2, T3, T4, T5, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5})"/>
    new ICommandHasToSetName SetHandler<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5);

    /// <returns>An <see cref="ICommandHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseHasToSetHandler.SetHandler{T1, T2, T3, T4, T5, T6}(Func{T1, T2, T3, T4, T5, T6, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6})"/>
    new ICommandHasToSetName SetHandler<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6);

    /// <returns>An <see cref="ICommandHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseHasToSetHandler.SetHandler{T1, T2, T3, T4, T5, T6, T7}(Func{T1, T2, T3, T4, T5, T6, T7, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6}, IValueDescriptor{T7})"/>
    new ICommandHasToSetName SetHandler<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6,
        IValueDescriptor<T7> symbol7);

    /// <returns>An <see cref="ICommandHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseHasToSetHandler.SetHandler{T1, T2, T3, T4, T5, T6, T7, T8}(Func{T1, T2, T3, T4, T5, T6, T7, T8, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6}, IValueDescriptor{T7}, IValueDescriptor{T8})"/>
    new ICommandHasToSetName SetHandler<T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6,
        IValueDescriptor<T7> symbol7,
        IValueDescriptor<T8> symbol8);
}
