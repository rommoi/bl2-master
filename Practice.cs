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

            int place_int = place;                   //Implicit. Fail. result 51
            int place_int1 = (int)place;             //Explicit. Fail. result 51
            int place_int2 = Convert.ToInt32(place); //Convert.  Fail. result 51

            char hasFingerPrints = '0';//to boolean

            //bool hasFingerPrints_bool = hasFingerPrints;                      //Implicit. Fail. Not Compiling
            //bool hasFingerPrints_bool1 = (bool)hasFingerPrints;               //Explicit. Fail. Not Compiling
            //bool hasFingerPrints_bool2 = Convert.ToBoolean(hasFingerPrints);  //Convert. Fail. System.InvalidCastException

            //2. STRING CONVERSION           
            string hasPhotoString = "True";//to bolean

            //bool hasPhotoString_bool = hasPhotoString;                        //Implicit. Fail. Not Compiling
            //bool hasPhotoString_bool1 = (bool)hasPhotoString;                 //Explicit. Fail. Not Compiling
            bool hasPhotoString_bool2 = Convert.ToBoolean(hasPhotoString);    //Convert. OK.

            string flatNumber = "34";//to int

            //int flatNumber_int = flatNumber;                        //Implicit. Fail. Not Compiling
            //int flatNumber_int1 = (int)flatNumber;                  //Explicit. Fail. Not Compiling
            int flatNumber_int2 = Convert.ToInt32(flatNumber);      //Convert. OK.

            string visaPriceString = "34,23";//to float

            //float visaPriceString_float = visaPriceString;                             //Implicit. Fail. Not Compiling
            //float visaPriceString_float1 = (float)visaPriceString;                     //Explicit. Fail. Not Compiling
            //float visaPriceString_float2 = Convert.ToDouble(visaPriceString);          //Convert.ToDouble(). Fail. Not compiling
            float visaPriceString_float3 = (float)Convert.ToDouble(visaPriceString);   //Explicit. (float)Convert.ToDouble(). Fail. result (float)3423

            string photoPriceString = "7.23";//to float

            //float photoPriceString_float = photoPriceString;                            //Implicit. Fail. Not Compiling
            //float photoPriceString_float1 = (float)photoPriceString;                    //Explicit. Fail. Not Compiling
            //float photoPriceString_float2 = Convert.ToDouble(photoPriceString);         //Convert.ToDouble(). Fail. Not Compiling
            float photoPriceString_float3 = (float)Convert.ToDouble(photoPriceString);  //Explicit. (float)Convert.ToDouble(). OK. result 7.23

            //3. BOOL CONVERSION
            bool hasFree2Pages = false;//to string, to char, to int

            //string hasFree2Pages_str = hasFree2Pages;                       //Implicit. Fail. Not Compiling
            //string hasFree2Pages_str1 = (string)hasFree2Pages;              //Explicit. Fail. Not Compiling
            string hasFree2Pages_str2 = Convert.ToString(hasFree2Pages);    //Convert. I think OK. instead of |false| returned |False|

            //char hasFree2Pages_char = hasFree2Pages;                   //Implicit. Fail. Not Compiling
            //char hasFree2Pages_char1 = (char)hasFree2Pages;            //Explicit. Fail. Not Compiling
            //char hasFree2Pages_char2 = Convert.ToChar(hasFree2Pages);  //Convert. Fail. System.InvalidCastException

            //int hasFree2Pages_int = hasFree2Pages;                    //Implicit. Fail. Not Compiling
            //int hasFree2Pages_int1 = (int)hasFree2Pages;              //Explicit. Fail. Not Compiling
            int hasFree2Pages_int2 = Convert.ToInt32(hasFree2Pages);  //Convert. Fail. instead of |false| returned |0|

            //4. DECIMAL CONVERSION
            double visaPrice = 60;//to int, to string

            //int visaPrice_int = visaPrice;                    //Implicit. Fail. Not Compiling
            int visaPrice_int1 = (int)visaPrice;              //Explicit. OK. result 60
            int visaPrice_int2 = Convert.ToInt32(visaPrice);  //Convert. OK. result 60
            int a = 5;
            a++;
            //string visaPrice_str = visaPrice;                    //Implicit. Fail. Not Compiling
            //string visaPrice_str1 = (string)visaPrice;           //Explicit. Fail. Not Compiling
            string visaPrice_str2 = Convert.ToString(visaPrice); //Convert. OK. result "60"
            string visaPrice_str3 = visaPrice.ToString();        //ToString(). OK. result "60"

            double finterPrintsPrice = 55.2;//to int, to string

            //int finterPrintsPrice_int = finterPrintsPrice;                    //Implicit. Fail. Not Compiling
            int finterPrintsPrice_int1 = (int)finterPrintsPrice;              //Explicit. Fail. result 55
            int finterPrintsPrice_int2 = Convert.ToInt32(finterPrintsPrice);  //Convert. Fail. result 55

            //string finterPrintsPrice_str = finterPrintsPrice;                     //Implicit. Fail. Not Compiling
            //string finterPrintsPrice_str1 = (string)finterPrintsPrice;            //Explicit. Fail. Not Compiling
            string finterPrintsPrice_str2 = Convert.ToString(finterPrintsPrice);  //Convert. OK. result "55.2"
            string finterPrintsPrice_str3 = finterPrintsPrice.ToString();         //ToString(). OK. result "55.2"

            //4. INT CONVERSION
            int birthYear = 2000;//to string, to double, to char
            char birhtYearChar = (char)birthYear;

            int hasPhotoInt = 1;//to boolean
        }
    }
}
