using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineApplianceStore.Data
{
    public class DataWrapper<T>
    {
        public T Data { get; set; }
        public bool IsOK => ResultMessage == null;
        public string ResultMessage { get; set; }
    }
}
