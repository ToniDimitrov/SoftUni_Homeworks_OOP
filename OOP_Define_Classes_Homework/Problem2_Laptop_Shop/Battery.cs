using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem2_Laptop_Shop
{
    class Battery
    {
        private string batteryName;
        private string batteryLife;

        public Battery(string batteryName, string batteryLife)
        {
            BatteryName = batteryName;
            BatteryLife = batteryLife;
        }

        public Battery(string batteryLife) : this("unknown", batteryLife)
        {
        }

        public string BatteryName
        {
            get { return batteryName; }
            set
            {
                if (value == "")
                {
                    throw new ArgumentNullException("The battery name must be non-empty!");
                }
                batteryName = value;
            }
        }

        public string BatteryLife
        {
            get { return batteryLife; }
            set
            {
                if (value != null)
                {
                    string pattern = "[^\\d.,\\-]+\\s*.";
                    string replacement = "";
                    Regex rgx = new Regex(pattern);
                    double result = double.Parse(rgx.Replace(value.Replace('.', ','), replacement));
                    if (result < 0)
                    {
                        throw new ArgumentOutOfRangeException("The value must be non-negative!");
                    }

                    batteryLife = value;
                }
            }
        }
    }
}
