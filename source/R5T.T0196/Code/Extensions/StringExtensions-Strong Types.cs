using System;


namespace R5T.T0196.Extensions
{
    public static class StringExtensions
    {
        /// <inheritdoc cref="IStringOperator.ToFormName(string)"/>
        public static IFormName ToFormName(this string value)
        {
            return Instances.StringOperator_Extensions.ToFormName(value);
        }

        /// <inheritdoc cref="IStringOperator.ToWindowsFormName(string)"/>
        public static IWindowsFormName ToWindowsFormName(this string value)
        {
            return Instances.StringOperator_Extensions.ToWindowsFormName(value);
        }
    }
}
