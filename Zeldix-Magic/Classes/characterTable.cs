/* 
 * Class        :   CharacterTable.cs
 * Author       :   Corndoggers
 * Description  :   
 */

using System;
using System.Diagnostics;
using System.Windows;

namespace Zeldix.Classes
{
    public class CharacterTable
    {
        private string[] characterTable;
        private string seperator;
        private int characterTableSize;
        private string[][] sortTable;

        public CharacterTable(string seperator)
        {
            this.seperator = seperator;
            try
            {
                Txtio txt = new Txtio("../../Resources/charset.txt");
                characterTableSize = 256;
                characterTable = new string[characterTableSize];

                int i = 0;
                while (i < txt.getNoOfLines() - 1)
                {
                    string line = txt.readLine(i);
                    characterTable[getHexValue(line)] = getStr(line);
                    i++;
                }
                sortCharactertable();
            }
            catch (Exception e)
            {
                MessageBox.Show("Failure to create character table for monologues." +
                    "Check to make sure the largest hex value is last in the file.\n\n" + e, "Error");
                Process.GetCurrentProcess().Kill();
            }
        }

        public void displayCharacterTable()
        {
            string output = "";
            for (int i = 0; i < characterTableSize; i++)
            {
                if (characterTable[i] != null)
                    output += i + " = " + characterTable[i] + ", ";
            }
            MessageBox.Show(output);
        }

        /*
         * Sort an array in terms of priority
         * 
         * From highest to greatest (roughly)
         * 
         * Letters 'A' through 'F'
         * Numbers 0 through 9
         * Words that start with '['
         * Large words
         * 
         * 
         * Why this method exist:
         *      1) To make the compression more efficient. The script prioritizes
         *      compressing "the" (one byte) before "th" and "e" (two bytes)
         * 
         *      2) Avoid conflicts when converting from plaintext to Hexadecimal.
         *      For example: let' say all instances of "[Free space]" are
         *      converted to FF; however, then all instances of "F" are
         *      converted to 05. Therefore the value "[Free space]" is lost.
         *      Prioritizing letters will avoid conflict.
         *      
         * Shortcomings:
         *      1) The code assumes that letters A through F do not have a hexadecimal
         *      equivalent that contain letters. In the case that the ROM is
         *      modified so they do, the code will need to be modified to
         *      accomodate for this. In this case, a quick hack I would reccomend 
         *      is prioritizing each single letter to avoid conflict or to use a
         *      different means of conversion entirely.
         *      2) The priorities aren't exactly perfect and aren't very strictly
         *      enforced. This is part of the code one should look over if something
         *      doesn't encode quite right.
         */
        public void sortCharactertable()
        {
            //sortTable

            sortTable = new string[characterTable.Length][];

            int index = 0;
            foreach (string s in characterTable)
            {
                string[] str = new string[2];
                str[0] = index.ToString("X");
                str[1] = s;

                sortTable[index++] = str;
            }
            string a, b;
            
            //bubble sort
            int switchy = 0;
            try
            {
                for (int i = 1; i <= sortTable.Length; i++)
                {
                    for (int j = 0; j < sortTable.Length - 1; j++)
                    {
                        a = sortTable[j][1];
                        b = sortTable[j + 1][1];

                        if (a != null && b != null)
                        {
                            if (
                                !(isHex(a[0])) && isHex(b[0]) ||
                                (!(a[0] == '[') && !isHex(a[0])) && b[0] == '[' ||
                                (!Char.IsNumber(a[0]) && !isHex(a[0])) && Char.IsNumber(b[0]) 
                                || (a.Length < b.Length)
                                )
                            {
                                string[] temp = sortTable[j];
                                sortTable[j] = sortTable[j + 1];
                                sortTable[j + 1] = temp;
                                switchy++;
                            }
                        }
                        else if ((a == null && b != null) || (a != null && b == null))
                        {
                            string[] temp = sortTable[j];
                            sortTable[j] = sortTable[j + 1];
                            sortTable[j + 1] = temp;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
                Process.GetCurrentProcess().Kill();
            }
        }

        private bool isHex(char c)
        { return c == 'A' || c == 'B' || c == 'C' || c == 'D' || c == 'E' || c == 'F'; }


        public string getSortTableValues(int i )
        { return sortTable[i][1]; }

        public string getSortTableIndex(int i)
        { return sortTable[i][0]; }

        public int getSize()
        { return characterTableSize; }

        public string getStr(string str)
        {
            int start = str.IndexOf(seperator) + seperator.Length;
            return str.Substring(start).ToString();
        }

        public int getHexValue(string str)
        {
            int returnValue = 0;
            string stringy = "";
            try
            {
                //obtains the numerial value
                stringy = str.Substring(0, str.IndexOf(seperator));
            }
            catch (Exception e)
            {
                MessageBox.Show("Make sure not to have any empty lines in your textfile.\n" + e);
                Process.GetCurrentProcess().Kill();
            }

            try { returnValue = Convert.ToInt32(stringy, 16); }
            catch (Exception e)
            {
                MessageBox.Show("\"" + stringy + "\" is not a valid hexadecimal value.\n" + e);
                Process.GetCurrentProcess().Kill();
            }
            return returnValue;
        }

        public string convertDecimaltoChara(string binary)
        {
            //characterTable
            string[] stringy = binary.Split(' ');
            string output = "";

            int i = 0;
            foreach (string s in stringy)
            {
                if (!stringy[i].Equals(""))
                {
                    int index = Convert.ToInt32(stringy[i]);
                    try
                    {
                        if (characterTable[index] != null)
                            output += characterTable[index];
                        else //in the case that the value is not on the file
                            output += "{" + index.ToString("X") + "}";
                    }
                    catch //copy pasted line
                    {
                        output += "{" + index.ToString("X") + "}";
                    }
                    i++;
                }
            }
            return output;
        }
    }
}