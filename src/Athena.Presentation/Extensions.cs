using System;
using System.Globalization;
using Humanizer;

public static class Extensions
{
    extension(DateTime date)
    {
        public string Extense()
        {
            return date.Humanize(culture : new CultureInfo("pt-BR"));
        }
    }

}