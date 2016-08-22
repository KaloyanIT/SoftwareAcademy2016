namespace Mines
{
    using System;
    class Converter
    {
        const int max_count = 6;
        class CovertBoolToString
        {
            public static void ConvertBoolToString(bool promenliva)
            {
                string promenlivaKatoString = promenliva.ToString();
                Console.WriteLine(promenlivaKatoString);
            }
        }
        public static void InputMethod()
        {
            Converter.CovertBoolToString инстанция =
              new Converter.CovertBoolToString();
            CovertBoolToString.ConvertBoolToString(true);
        }
    }
}