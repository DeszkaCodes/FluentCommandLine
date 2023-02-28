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
    public ICommandBaseCanSetProperties SetHandler(Func<Task> handle)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public ICommandBaseCanSetProperties SetHandler(Func<InvocationContext, Task> handle)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public ICommandBaseCanSetProperties SetHandler<T1>(Func<T1, Task> handle, IValueDescriptor<T1> symbol)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public ICommandBaseCanSetProperties SetHandler<T1, T2>(Func<T1, T2, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public ICommandBaseCanSetProperties SetHandler<T1, T2, T3>(Func<T1, T2, T3, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4>(Func<T1, T2, T3, T4, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5, IValueDescriptor<T6> symbol6)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5, IValueDescriptor<T6> symbol6, IValueDescriptor<T7> symbol7)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public ICommandBaseCanSetProperties SetHandler<T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8, Task> handle, IValueDescriptor<T1> symbol1, IValueDescriptor<T2> symbol2, IValueDescriptor<T3> symbol3, IValueDescriptor<T4> symbol4, IValueDescriptor<T5> symbol5, IValueDescriptor<T6> symbol6, IValueDescriptor<T7> symbol7, IValueDescriptor<T8> symbol8)
    {
        throw new NotImplementedException();
    }
}
