using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0196
{
    /// <summary>
    /// Strongly-types a string as the name of a Windows Form.
    /// </summary>
    [StrongTypeMarker]
    public interface IWindowsFormName : IStrongTypeMarker,
        ITyped<string>
    {
    }
}