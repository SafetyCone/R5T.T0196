using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0196
{
    /// <inheritdoc cref="IWindowsFormName"/>
    [StrongTypeImplementationMarker]
    public class WindowsFormName : TypedBase<string>, IStrongTypeMarker,
        IWindowsFormName
    {
        public WindowsFormName(string value)
            : base(value)
        {
        }
    }
}