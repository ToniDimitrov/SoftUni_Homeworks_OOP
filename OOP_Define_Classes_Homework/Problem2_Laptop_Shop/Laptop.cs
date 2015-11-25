using System;
using System.Text.RegularExpressions;

namespace Problem2_Laptop_Shop
{
    internal class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private string RAM;
        private string graphicsCard;
        private string hardDisk;
        private string screen;
        private Battery battery;
        private string price;
        private string constructorType; //Makes printing easier

        public Laptop(string model, string manufacturer, string processor, string ram, string graphicsCard,
            string hardDisk, string screen, string price, string batteryLife, string batteryName)
        {
            Model = model;
            Manufacturer = manufacturer;
            Processor = processor;
            Ram = ram;
            GraphicsCard = graphicsCard;
            HardDisk = hardDisk;
            Screen = screen;
            Price = price;
            battery = new Battery(batteryLife, batteryName);
            constructorType = "full";
        }

        public Laptop(string model, string price) : this(model, null, null, null, null, null, null, price, null, null)
        {
            constructorType = "minimum";
        }

        public Laptop(string model, string price, string batteryLife, string batteryName)
            : this(model, null, null, null, null, null, null, price, batteryName, batteryLife)
        {
            constructorType = "minimum and battery";
        }

        public Laptop(string model, string manufacturer, string price, string ram, string processor, string hardDisk)
            : this(model, manufacturer, processor, ram, null, hardDisk, null, price, null, null)
        {
            constructorType = "no battery and graphics";
        }

        public Laptop(string model, string price, string manufacturer, string graphicsCard, string screen)
            : this(model, manufacturer, null, null, graphicsCard, null, screen, price, null, null)
        {
            constructorType = "no battery processor ram and hard disk";
        }

        private static void IsEmpty(string value)
        {
            if (value == "")
            {
                throw new ArgumentException("Value must be non-empty!");
            }
        }

        private static void IsNegative(string value)
        {
            if (value!=null)
            {
                string pattern = "[^\\d.\\-,]+\\s*.";
                string replacement = "";
                Regex rgx = new Regex(pattern);
                double result = double.Parse(rgx.Replace(value.Replace('.', ','), replacement));
                if (result < 0)
                {
                    throw new ArgumentOutOfRangeException("The value must be non-negative!");
                }
            }
        }

        public string Model
        {
            get { return model; }
            set
            {
                IsEmpty(value);
                model = value;
            }
        }

        public string Manufacturer
        {
            get { return manufacturer; }
            set
            {
                IsEmpty(value);
                manufacturer = value;
            }
        }

        public string Processor
        {
            get { return processor; }
            set
            {
                if (value!=null)
                {
                    string pattern = "([\\d+.\\-]+ GHz)|( [\\d+.\\-]+ )";
                    Regex rgx = new Regex(pattern);

                    foreach (Match ItemMatch in rgx.Matches(value))
                    {
                        if (ItemMatch.ToString().Equals(" - "))
                        {
                            continue;
                        }
                        string pattern2 = "[^\\d.,]+\\s*.";
                        string replacement = "";
                        Regex rgx2 = new Regex(pattern2);
                        double result = double.Parse(rgx2.Replace(ItemMatch.ToString().Trim().Replace('.', ','), replacement));
                        if (result < 0)
                        {
                            throw new ArgumentOutOfRangeException("The value must be non-negative!");
                        }
                    }
                }
                processor = value;
            }
        }

        public string GraphicsCard
        {
            get { return graphicsCard; }
            set
            {
                IsEmpty(value);
                graphicsCard = value;
            }
        }

        public string Ram
        {
            get { return RAM; }
            set
            {
                IsEmpty(value);
                IsNegative(value);
                RAM = value;
            }
        }

        public string HardDisk
        {
            get { return hardDisk; }
            set
            {
                IsEmpty(value);
                IsNegative(value);
                hardDisk = value;
            }
        }

        public string Screen
        {
            get { return screen; }
            set
            {
                IsEmpty(value);
                if (value != null)
                {
                    string pattern = "([\\d+.\\-]+\")|([\\d+\\-.]+ )";
                    Regex rgx = new Regex(pattern);
                    foreach (Match ItemMatch in rgx.Matches(value))
                    {
                        if (double.Parse(ItemMatch.ToString().Trim().Replace(" GHz", "").Replace('.', ',').Replace("\"","")) < 0)
                        {
                            throw new ArgumentOutOfRangeException("The value must be non-negative!");
                        }
                    }
                    screen = value;
                }
            }
        }

        public string Price
        {
            get { return price; }
            set
            {
                IsEmpty(value);
                IsNegative(value);
                price = value;
            }
        }

        public override string ToString()
        {
            if (constructorType.Equals("minimum and battery"))
            {
                return string.Format("Model: {0}\n" +
                                     "Price: {1}\n" +
                                     "Battery: {2}\n" +
                                     "Battery Life: {3}\n"
                    , Model, Price, battery.BatteryName, battery.BatteryLife
                    );
            }
            if (constructorType.Equals("no battery and graphics"))
            {
                return string.Format("Model: {0}\n" +
                                     "Price: {1}\n" +
                                     "Manufacturer: {2}\n" +
                                     "RAM: {3}\n" +
                                     "CPU: {4}\n" +
                                     "HDD: {5}\n"
                    , Model, Price, Manufacturer, Ram, Processor, HardDisk
                    );
            }

            if (constructorType.Equals("no battery processor ram and hard disk"))
            {
                return string.Format("Model: {0}\n" +
                                     "Price: {1}\n" +
                                     "Manufacturer: {2}\n" +
                                     "Graphics Card: {3}\n" +
                                     "Screen: {4}\n"
                    , Model, Price, Manufacturer, GraphicsCard, Screen
                    );
            }
            if (constructorType.Equals("minimum"))
            {
                return string.Format("Model: {0}\n" +
                                     "Price: {1}\n"
                    , Model, Price
                    );
            }
            return string.Format("Model: {0}\n" +
                                 "Price: {1}\n" +
                                 "Manufacturer: {2}\n" +
                                 "CPU: {3}\n" +
                                 "RAM: {4}\n" +
                                 "HDD: {5}\n" +
                                 "Graphics Card: {6}\n" +
                                 "Screen: {7}\n" +
                                 "Battery: {8}\n" +
                                 "Battery Life: {9}\n"

                , Model, Price, Manufacturer, Processor, Ram, HardDisk, GraphicsCard, Screen,
                battery.BatteryName, battery.BatteryLife
                );
        }
    }
}
