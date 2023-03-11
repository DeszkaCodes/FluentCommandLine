using System.CommandLine.Invocation;
using System.CommandLine.Binding;
using System.CommandLine;

namespace FluentCommandLine.Abstraction.Interfaces;

public partial interface ICommandBaseHasToSetHandler
{
    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler(Command, Action{InvocationContext})"/>
    ICommandBaseHasToSetName SetHandler(Action<InvocationContext> handle);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler(Command, Action)"/>
    ICommandBaseHasToSetName SetHandler(Action handle);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler{T}(Command, Action{T}, IValueDescriptor{T})"/>
    ICommandBaseHasToSetName SetHandler<T>(Action<T> handle, IValueDescriptor<T> symbol);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler{T1, T2}(Command, Action{T1, T2}, IValueDescriptor{T1}, IValueDescriptor{T2})"/>
    ICommandBaseHasToSetName SetHandler<T1, T2>(Action<T1, T2> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3}(Command, Action{T1, T2, T3}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3})"/>
    ICommandBaseHasToSetName SetHandler<T1, T2, T3>(Action<T1, T2, T3> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4}(Command, Action{T1, T2, T3, T4}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4})"/>
    ICommandBaseHasToSetName SetHandler<T1, T2, T3, T4>(Action<T1, T2, T3, T4> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4, T5}(Command, Action{T1, T2, T3, T4, T5}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5})"/>
    ICommandBaseHasToSetName SetHandler<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4, T5, T6}(Command, Action{T1, T2, T3, T4, T5, T6}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6})"/>
    ICommandBaseHasToSetName SetHandler<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4, T5, T6, T7}(Command, Action{T1, T2, T3, T4, T5, T6, T7}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6}, IValueDescriptor{T7})"/>
    ICommandBaseHasToSetName SetHandler<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6,
        IValueDescriptor<T7> symbol7);

    /// <returns>An <see cref="ICommandBaseHasToSetName"/> with the new handler.</returns>
    /// <inheritdoc cref="Handler.SetHandler{T1, T2, T3, T4, T5, T6, T7, T8}(Command, Action{T1, T2, T3, T4, T5, T6, T7, T8}, IValueDescriptor{T1}, IValueDescriptor{T2}, IValueDescriptor{T3}, IValueDescriptor{T4}, IValueDescriptor{T5}, IValueDescriptor{T6}, IValueDescriptor{T7}, IValueDescriptor{T8})"/>
    ICommandBaseHasToSetName SetHandler<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> handle,
        IValueDescriptor<T1> symbol1,
        IValueDescriptor<T2> symbol2,
        IValueDescriptor<T3> symbol3,
        IValueDescriptor<T4> symbol4,
        IValueDescriptor<T5> symbol5,
        IValueDescriptor<T6> symbol6,
        IValueDescriptor<T7> symbol7,
        IValueDescriptor<T8> symbol8);
}
