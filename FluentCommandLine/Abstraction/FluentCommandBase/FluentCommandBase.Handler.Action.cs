using FluentCommandLine.Abstraction.Interfaces;
using System.CommandLine.Invocation;
using System.CommandLine.Binding;
using System.CommandLine;

namespace FluentCommandLine.Abstraction;

public abstract partial class FluentCommandBase<T> : FluentIdentifierSymbolBase,
    ICommandBaseCanSetName, ICommandBaseCanSetProperties
{
    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler(Action<InvocationContext> handle)
    {
        _command.SetHandler(handle);
        return this;
    }

    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler(Action handle)
    {
        _command.SetHandler(handle);
        return this;
    }

    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler<T1>(Action<T1> handle, IValueDescriptor<T1> symbol)
    {
        _command.SetHandler(handle, symbol);
        return this;
    }

    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler<T1, T2>(Action<T1, T2> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2)
    {
        _command.SetHandler(handle,
            symbol1,
            symbol2);
        return this;
    }

    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler<T1, T2, T3>(Action<T1, T2, T3> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3)
    {
        _command.SetHandler(handle,
            symbol1,
            symbol2,
            symbol3);
        return this;
    }

    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4>(Action<T1, T2, T3, T4> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4)
    {
        _command.SetHandler(handle,
            symbol1,
            symbol2,
            symbol3,
            symbol4);
        return this;
    }

    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5>(Action<T1, T2, T3, T4, T5> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5)
    {
        _command.SetHandler(handle,
            symbol1,
            symbol2,
            symbol3,
            symbol4,
            symbol5);
        return this;
    }

    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6>(Action<T1, T2, T3, T4, T5, T6> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5, IValueDescriptor<T6> symbol6)
    {
        _command.SetHandler(handle,
            symbol1,
            symbol2,
            symbol3,
            symbol4,
            symbol5,
            symbol6);
        return this;
    }

    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7>(Action<T1, T2, T3, T4, T5, T6, T7> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5, IValueDescriptor<T6> symbol6, IValueDescriptor<T7> symbol7)
    {
        _command.SetHandler(handle,
            symbol1,
            symbol2,
            symbol3,
            symbol4,
            symbol5,
            symbol6,
            symbol7);
        return this;
    }

    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7, T8>(Action<T1, T2, T3, T4, T5, T6, T7, T8> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5, IValueDescriptor<T6> symbol6, IValueDescriptor<T7> symbol7, IValueDescriptor<T8> symbol8)
    {
        _command.SetHandler(handle,
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
