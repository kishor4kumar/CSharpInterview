using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    public class DataTypes
    {
        enum Days
        {
            SUNDAY, MONDAY
        }

        public DataTypes()
        {
            Dictionary<int, string> collect = new Dictionary<int, string>();
            Array arr = new char[7];
            
            ArrayList arrList = new ArrayList();
            arrList.Add(new object());
            arrList.Add(new int[7]);
            arrList.Add(new Dictionary<int,string>());
        }

        public static string GetDateTime(string format)
        {
            return DateTime.Now.ToString(format);
        }

        public void StringBuilderUsage()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("This");
            stringBuilder.AppendLine("is");
            stringBuilder.AppendLine("SPARTA!!!");

            Console.WriteLine(stringBuilder.ToString());
        }

        public void EnumUsage()
        {
            string value1 = Enum.GetName(typeof(Days), Days.SUNDAY); //returns SUNDAY
            string value2 = Enum.GetName(typeof(Days), 0); //returns SUNDAY
        }
    }
}
