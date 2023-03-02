using FluentCommandLine.Abstraction;
using FluentCommandLine.Abstraction.Interfaces;
using System.CommandLine;
using System.CommandLine.Binding;
using System.CommandLine.Invocation;

namespace FluentCommandLine;

partial class RootCommandWrapper : CommandWrapperBase<RootCommand>,
    IRootCommandCanSetProperties
{
    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override IRootCommandCanSetProperties SetHandler(Func<Task> handle)
    {
        base.SetHandler(handle);
        return this;
    }

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override IRootCommandCanSetProperties SetHandler(Func<InvocationContext, Task> handle)
    {
        base.SetHandler(handle);
        return this;
    }

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override IRootCommandCanSetProperties SetHandler<T>(Func<T, Task> handle, IValueDescriptor<T> symbol)
    {
        base.SetHandler(handle, symbol);
        return this;
    }

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override IRootCommandCanSetProperties SetHandler<T1, T2>(Func<T1, T2, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2)
    {
        base.SetHandler(handle,
            symbol1,
            symbol2);
        return this;
    }

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override IRootCommandCanSetProperties SetHandler<T1, T2, T3>(Func<T1, T2, T3, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3)
    {
        base.SetHandler(handle,
            symbol1,
            symbol2,
            symbol3);
        return this;
    }

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override IRootCommandCanSetProperties SetHandler<T1, T2, T3, T4>(Func<T1, T2, T3, T4, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4)
    {
        base.SetHandler(handle,
            symbol1,
            symbol2,
            symbol3,
            symbol4);
        return this;
    }

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override IRootCommandCanSetProperties SetHandler<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5)
    {
        base.SetHandler(handle,
            symbol1,
            symbol2,
            symbol3,
            symbol4,
            symbol5);
        return this;
    }

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override IRootCommandCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5, IValueDescriptor<T6> symbol6)
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

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override IRootCommandCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5, IValueDescriptor<T6> symbol6, IValueDescriptor<T7> symbol7)
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

    /// <returns>An <see cref="IRootCommandCanSetProperties"/> with the new handler.</returns>
    /// <inheritdoc/>
    public override IRootCommandCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5, IValueDescriptor<T6> symbol6, IValueDescriptor<T7> symbol7, IValueDescriptor<T8> symbol8)
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
