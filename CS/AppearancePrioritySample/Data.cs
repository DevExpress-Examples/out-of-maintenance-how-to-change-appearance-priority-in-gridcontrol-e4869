using System;
using System.Collections.Generic;
using System.Linq;

namespace GridControlDescendant
{
    public class Data
    {
        public static List<Data> CreateData(int count)
        {
            List<Data> l = new List<Data>();
            for (int i = 0; i < count; i++)
            {
                l.Add(new Data { ID = i, Value = "Value_" + i, Value1 = count - i, Value2 = "Value2_" + i });
            }
            return l;
        }
        public int ID { get; set; }
        public string Value { get; set; }
        public int Value1 { get; set; }
        public string Value2 { get; set; }
    }
}
