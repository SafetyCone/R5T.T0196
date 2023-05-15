using System;

using R5T.T0178;


namespace R5T.T0196
{
    /// <summary>
    /// Quality-of-life name for <see cref="IWindowsFormName"/>.
    /// </summary>
    [StrongTypeMarker]
    public interface IFormName : IStrongTypeMarker,
        IWindowsFormName
    {
    }
}