using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S7;
using S7.Net;
using SymbolFactoryDotNet;
using SymbolFactoryNetEngine;

namespace final_ui
{
    public class objCtrl
    {
        // Object Control
        public void _Ctrl(StandardControl obj, bool value1, bool value2, bool value3)
        {
            if (value1)
            {
                obj.DiscreteValue1 = true;
            }
            else
            {
                obj.DiscreteValue1 = false;
            }
            if (value2)
            {
                obj.DiscreteValue2 = true;
            }
            else
            {
                obj.DiscreteValue2 = false;
            }
            if (value3)
            {
                obj.DiscreteValue3 = true;
            }
            else
            {
                obj.DiscreteValue3 = false;
            }
        }
    }
}
