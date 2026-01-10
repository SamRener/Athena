using System;
using Humanizer;

public static class Extensions
{
    extension(DateTime date)
    {
        public string Extense()
        {
            return date.Humanize();
        }
    }

}