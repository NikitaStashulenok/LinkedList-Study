using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListProj.Model
{
    public class TwoWaysItem<T>
    {
        public T Data { get; set; }
        public TwoWaysItem<T> Next { get; set; }
        public TwoWaysItem<T> Previous { get; set; }
        public TwoWaysItem(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
