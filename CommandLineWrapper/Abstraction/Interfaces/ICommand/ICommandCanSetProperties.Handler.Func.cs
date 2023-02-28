using System.CommandLine;
using System.CommandLine.Binding;
using System.CommandLine.Invocation;

namespace CommandLineWrapper.Abstraction.Interfaces;

/// <summary>
/// Defines fluent methods responsible for setting the properties of a <see cref="Command"/>.
/// </summary>
public partial interface ICommandCanSetProperties : ICommandBaseCanSetProperties
{
    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler(Func{Task})"/>
    new ICommandCanSetProperties SetHandler(Func<Task> handle);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler(Func{InvocationContext, Task})"/>
    new ICommandCanSetProperties SetHandler(Func<InvocationContext, Task> handle);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler{T}(Func{T, Task}, IValueDescriptor{T})"/>
    new ICommandCanSetProperties SetHandler<T>(Func<T, Task> handle, IValueDescriptor<T> symbol);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// ICommandBaseCanSetProperties.SetHandler{T1, T2}(Func{T1, T2, Task}, IValueDescriptor{T1}, IValueDescriptor{T2})
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler{T1, T2}(Func{T1, T2, Task}, IValueDescriptor{T1}, IValueDescriptor{T2})"/>
    new ICommandCanSetProperties SetHandler<T1, T2>(Func<T1, T2, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler{T1, T2, T3}(Func{T1, T2, T3, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3})"/>
    new ICommandCanSetProperties SetHandler<T1, T2, T3>(Func<T1, T2, T3, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler{T1, T2, T3, T4}(Func{T1, T2, T3, T4, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4})"/>
    new ICommandCanSetProperties SetHandler<T1, T2, T3, T4>(Func<T1, T2, T3, T4, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler{T1, T2, T3, T4, T5}(Func{T1, T2, T3, T4, T5, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5})"/>
    new ICommandCanSetProperties SetHandler<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler{T1, T2, T3, T4, T5, T6}(Func{T1, T2, T3, T4, T5, T6, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6})"/>
    new ICommandCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler{T1, T2, T3, T4, T5, T6, T7}(Func{T1, T2, T3, T4, T5, T6, T7, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6}, IValueDescriptor{T7})"/>
    new ICommandCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6,
        IValueDescriptor<T7> symbol7);

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc cref="ICommandBaseCanSetProperties.SetHandler{T1, T2, T3, T4, T5, T6, T7, T8}(Func{T1, T2, T3, T4, T5, T6, T7, T8, Task}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6}, IValueDescriptor{T7}, IValueDescriptor{T8})"/>
    new ICommandCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6,
        IValueDescriptor<T7> symbol7,
        IValueDescriptor<T8> symbol8);
}
