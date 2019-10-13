using System;

namespace Basics
{
    public class DataTypes
    {
        public static string GetDateTime(string format)
        {
            return DateTime.Now.ToString(format);
        }
    }
}
