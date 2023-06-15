using System;
using System.Collections;

namespace CarLibrary
{
    public class Cars
    {
        private const char MAIN_FILE_SEPARATOR = ';';
        private const char SECONDARY_FILE_SEPARATOR = ' ';

        private const int ID_CAR = 0;
        private const int BRAND = 1;
        private const int MODEL = 2;
        private const int YEAR = 3;
        private const int CILINDRICAL_CAPACITY = 4;
        private const int COLOR = 5;
        private const int OPTIONS = 6;
        private const int IS_AVAILABLE = 7;

        [Flags]
        public enum Servicii
        {
            None = 0,
            Schimb_Frane = 1,
             Schimb_Ulei= 2,
            Distributie = 3,
            Schimb_Far = 4,
         Vulcanizare = 5,
            Polish = 6
        }
        
        public int IdCar { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Cilindrical_Capacity { get; set; }
        public CarColor Color { get; set; }
        public ArrayList Options { get; set; }
        public bool IsAvailable { get; set; }

        public string OptionsAsString
        {
            get
            {
                string cOptions = string.Empty;

                foreach (string option in Options)
                {
                    if (cOptions != string.Empty)
                    {
                        cOptions += SECONDARY_FILE_SEPARATOR;
                    }
                    cOptions += option;
                }

                return cOptions;

            }
        }

        public Cars()
        {
            Brand = Model = string.Empty;
            Year = string.Empty;
            Cilindrical_Capacity = string.Empty;
        }

        public Cars(int idCar, string brand, string model, string year, string price, bool isAvailable)
        {
            this.IdCar = idCar;
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.Cilindrical_Capacity = price;
            this.IsAvailable = isAvailable;
        }

        public Cars(string fileLine)
        {
            string[] fileData = fileLine.Split(MAIN_FILE_SEPARATOR);

            IdCar = Convert.ToInt32(fileData[ID_CAR]);
            Brand = fileData[BRAND];
            Model = fileData[MODEL];
            Year = fileData[YEAR];
            Cilindrical_Capacity = fileData[CILINDRICAL_CAPACITY];
            Color = (CarColor)Enum.Parse(typeof(CarColor), fileData[COLOR], true);
            Options = new ArrayList();
            Options.AddRange(fileData[OPTIONS].Split(SECONDARY_FILE_SEPARATOR));
            IsAvailable = Convert.ToBoolean(fileData[IS_AVAILABLE]);
        }

        public string InfoCar()
        {
            string info = string.Format("IdCar:{0}, Make: {1}, Model: {2}, Year: {3}, Price: {4}",
                IdCar.ToString(),
                (Brand ?? " UNKNOWN "),
                (Model ?? " UNKNOWN "),
                (Year ?? " UNKNOWN "),
                (Cilindrical_Capacity ?? " UNKNOWN "));

            return info;
        }

        public string ConvertToString_ForFile()
        {
            string carObjectForFile = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}",
                MAIN_FILE_SEPARATOR,
                IdCar.ToString(),
                (Brand ?? " UNKNOWN "),
                (Model ?? " UNKNOWN "),
                (Year ?? " UNKNOWN "),
                (Cilindrical_Capacity ?? " UNKNOWN "),
                Color.ToString(),
                OptionsAsString,
                IsAvailable.ToString());

            return carObjectForFile;
        }

        public override string ToString()
        {
            return ConvertToString_ForFile();
        }

    }



    public enum CarColor
    {
        Unknown,
        Black,
        White,
        Gray,
        Red,
        Blue,
        Green,
        Silver,
        Brown,
        Yellow
    }

}