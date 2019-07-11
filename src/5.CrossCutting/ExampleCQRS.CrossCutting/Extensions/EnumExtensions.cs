namespace ExampleCQRS.CrossCutting.Extensions
{
    using System;
    using System.Globalization;

    public static class EnumExtensions
    {
        public static string GetString(this Enum code) =>
            Convert.ToString(code, CultureInfo.InvariantCulture);
    }
}