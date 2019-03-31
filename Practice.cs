using System;
using System.ComponentModel;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            //CONVERSION (explicit, implicit, Convert)

            //1. CHAR CONVERSION 
            char sex = 'М';//to string

            //string sex_str = sex;                  //Implicit. Fail. Not compiling..
            //string sex_str2 = (string)sex;         //Explicit. Fail. Not compiling..
            string sex_str3 = Convert.ToString(sex); //Convert. OK..
            string sex_str4 = sex.ToString();        //ToString(). OK.

            char place = '3';//to int

            int place_int = place;                   //Implicit. 
            int place_int1 = (int)place;             //Explicit.
            int place_int2 = Convert.ToInt32(place); //Convert.

            char hasFingerPrints = '0';//to boolean

            //bool hasFingerPrints_bool = hasFingerPrints;                      //Implicit. Fail. Not Compiling
            //bool hasFingerPrints_bool1 = (bool)hasFingerPrints;               //Explicit. Fail. Not Compiling
            //bool hasFingerPrints_bool2 = Convert.ToBoolean(hasFingerPrints);  //Convert. Fail. System.InvalidCastException

            //2. STRING CONVERSION           
            string hasPhotoString = "True";//to bolean
            string flatNumber = "34";//to int
            string visaPriceString = "34,23";//to float
            string photoPriceString = "7.23";//to float

            //3. BOOL CONVERSION
            bool hasFree2Pages = false;//to string, to char, to int

            //4. DECIMAL CONVERSION
            double visaPrice = 60;//to int, to string
            double finterPrintsPrice = 55.2;//to int, to string

            //4. INT CONVERSION
            int birthYear = 2000;//to string, to double, to char
            char birhtYearChar = (char)birthYear;

            int hasPhotoInt = 1;//to boolean
        }
    }
}
