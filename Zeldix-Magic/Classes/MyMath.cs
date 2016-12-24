/* 
 * Class        :   MyMath.cs
 * Author       : Corndoggers
 * Description  :   Converts
 */

using System;
namespace Zeldix.Classes
{
    public class MyMath
    {
        public string decToHex(int i)
        { return i.ToString("X");}
        public int hexToDec(string s)
        { return Convert.ToInt32(s, 16); }
    }
}
