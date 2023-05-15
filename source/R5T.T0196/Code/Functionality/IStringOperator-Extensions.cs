using System;

using R5T.T0132;


namespace R5T.T0196.Extensions
{
    [FunctionalityMarker]
    public partial interface IStringOperator : IFunctionalityMarker
    {
        /// <inheritdoc cref="IFormName"/>
        public IFormName ToFormName(string value)
        {
            var output = new FormName(value);
            return output;
        }

        /// <inheritdoc cref="IWindowsFormName"/>
        public IWindowsFormName ToWindowsFormName(string value)
        {
            var output = new WindowsFormName(value);
            return output;
        }
    }
}
