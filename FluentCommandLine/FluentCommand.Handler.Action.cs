using FluentCommandLine.Abstraction;
using FluentCommandLine.Abstraction.Interfaces;
using System.CommandLine;
using System.CommandLine.Binding;
using System.CommandLine.Invocation;

namespace FluentCommandLine;

partial class FluentCommand : FluentCommandBase<Command>,
    ICommandCanSetName, ICommandCanSetProperties
{
    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override ICommandCanSetProperties SetHandler(Action<InvocationContext> handle)
    {
        base.SetHandler(handle);
        return this;
    }

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override ICommandCanSetProperties SetHandler(Action handle)
    {
        base.SetHandler(handle);
        return this;
    }

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override ICommandCanSetProperties SetHandler<T>(Action<T> handle, IValueDescriptor<T> symbol)
    {
        base.SetHandler(handle, symbol);
        return this;
    }

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override ICommandCanSetProperties SetHandler<T1, T2>(Action<T1, T2> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2)
    {
        base.SetHandler(handle,
            symbol1,
            symbol2);
        return this;
    }

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override ICommandCanSetProperties SetHandler<T1, T2, T3>(Action<T1, T2, T3> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3)
    {
        base.SetHandler(handle,
            symbol1,
            symbol2,
            symbol3);
        return this;
    }

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override ICommandCanSetProperties SetHandler<T1, T2, T3, T4>(Action<T1, T2, T3, T4> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4)
    {
        base.SetHandler(handle,
            symbol1,
            symbol2,
            symbol3,
            symbol4);
        return this;
    }

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override ICommandCanSetProperties SetHandler<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5)
    {
        base.SetHandler(handle,
            symbol1,
            symbol2,
            symbol3,
            symbol4,
            symbol5);
        return this;
    }

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override ICommandCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5, IValueDescriptor<T6> symbol6)
    {
        base.SetHandler(handle,
            symbol1,
            symbol2,
            symbol3,
            symbol4,
            symbol5,
            symbol6);
        return this;
    }

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override ICommandCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5, IValueDescriptor<T6> symbol6, IValueDescriptor<T7> symbol7)
    {
        base.SetHandler(handle,
            symbol1,
            symbol2,
            symbol3,
            symbol4,
            symbol5,
            symbol6,
            symbol7);
        return this;
    }

    /// <returns>An <see cref="ICommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override ICommandCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5, IValueDescriptor<T6> symbol6, IValueDescriptor<T7> symbol7, IValueDescriptor<T8> symbol8)
    {
        base.SetHandler(handle,
            symbol1,
            symbol2,
            symbol3,
            symbol4,
            symbol5,
            symbol6,
            symbol7,
            symbol8);
        return this;
    }
}
