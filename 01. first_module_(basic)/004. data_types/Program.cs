using System;

namespace _004._data_types
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enteros con signo

            // tamano de 8 bits
            sbyte negativeValueSbyte = -128;
            sbyte positiveValueSbyte = 127;

            // tamano de 16 bits
            short negativeValueShort = -32768;
            short positiveValueShort = 32767;

            // tamano de 32 bits
            int negativeValueInt = -2147483648;
            int positiveValueInt = 2147483647;

            // tamano de 64 bits
            long negativeValueLong = -9223372036854775808;
            long positiveValueLong = 9223372036854775807;

            #endregion

            #region Entero sin signo
            // todos tienen como valor minimo el 0

            // tamano de 8 bits
            byte maxValueByte = 255;

            // tamano de 16 bits
            ushort maxValueUshort = 65535;

            // tamano de 32 bits
            uint maxValueUint = 4294967295;

            // tamano de 64 bits
            ulong maxValueUlong = 18446744073709551615;

            #endregion
        
            #region Punto flotante
            
            // tamano de 32 bits, precision de 7 digitos
            float negativeValueFloat = 1.5 * 10^-45;
            float negativeValueFloat = 3.4 * 10^38;

            // tamano de 64 bits, precision de 15 digitos
            double negativeValueDouble = 5.0 * 10^-324;
            double positiveValueDouble = 1.7 * 10^28;

            #endregion

            #region Decimal

            // tamano de 128 bits, precision de 28 digitos
            decimal negativeValueDecimal = 1.0 * 10^-28;
            decimal positiveValueDecimal = 7.9 * 10^28;
                
            #endregion
        }
    }
}
