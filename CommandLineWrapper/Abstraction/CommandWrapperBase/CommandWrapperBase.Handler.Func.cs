using CommandLineWrapper.Abstraction.Interfaces;
using System.CommandLine;
using System.CommandLine.Binding;
using System.CommandLine.Invocation;

namespace CommandLineWrapper.Abstraction;

/// <summary>
/// Defines a base for a <see cref="Command"/> wrapper.
/// </summary>
public abstract partial class CommandWrapperBase<T> : IdentifierSymbolWrapperBase,
    ICommandBaseCanSetName, ICommandBaseCanSetProperties
{
    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler(Func<Task> handle)
    {
        _command.SetHandler(handle);
        return this;
    }

    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler(Func<InvocationContext, Task> handle)
    {
        _command.SetHandler(handle);
        return this;
    }

    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler<T1>(Func<T1, Task> handle, IValueDescriptor<T1> symbol)
    {
        _command.SetHandler(handle, symbol);
        return this;
    }

    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler<T1, T2>(Func<T1, T2, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2)
    {
        _command.SetHandler(handle,
            symbol1,
            symbol2);
        return this;
    }

    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler<T1, T2, T3>(Func<T1, T2, T3, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3)
    {
        _command.SetHandler(handle,
            symbol1,
            symbol2,
            symbol3);
        return this;
    }

    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4>(Func<T1, T2, T3, T4, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4)
    {
        _command.SetHandler(handle,
            symbol1,
            symbol2,
            symbol3,
            symbol4);
        return this;
    }

    /// <inheritdoc/>
    public virtual ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5)
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
    public virtual ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5, IValueDescriptor<T6> symbol6)
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
    public virtual ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5, IValueDescriptor<T6> symbol6, IValueDescriptor<T7> symbol7)
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
    public virtual ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5, IValueDescriptor<T6> symbol6, IValueDescriptor<T7> symbol7, IValueDescriptor<T8> symbol8)
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
