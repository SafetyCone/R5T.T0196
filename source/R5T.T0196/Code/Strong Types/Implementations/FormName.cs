using System;

using R5T.T0178;
using R5T.T0179;


namespace R5T.T0196
{
    /// <inheritdoc cref="IFormName"/>
    [StrongTypeImplementationMarker]
    public class FormName : TypedBase<string>, IStrongTypeMarker,
        IFormName
    {
        public FormName(string value)
            : base(value)
        {
        }
    }
}