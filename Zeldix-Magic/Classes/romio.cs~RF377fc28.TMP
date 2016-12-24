/*
 * Class        : Romio.cs
 * Author       : Corndoggers
 * Description  : Reads and writes to ROM
 */
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Zeldix.Classes
{
    public class Romio
    {
        private string filePath;

        //constructor with ROM verification
        public Romio(string filePath, ref bool pass)
        {
            pass = false;
            this.filePath = filePath;

            string
                internalName = readInASCII(0x7FC0, 22),
                expectedInternalName = "THE LEGEND OF ZELDA   ";

            pass = expectedInternalName.Equals(internalName);

            if (pass)
                MessageBox.Show("Internal name checks out.");
            else
                MessageBox.Show("Expected the internal name \"" + expectedInternalName + "\"\n" +
                    "but got \"" + internalName + "\".", "Error");
        }

        //constructor w/o ROM verification
        public Romio(string filePath)
        { this.filePath = filePath; }

        //convert the script to the ROM's hexadecimal
        public string convertScriptToHex(string size, string[] allMonologues, CharacterTable chr)
        {
            string output = "";
            foreach (string s in allMonologues)
                output += s + "%";
            for (int i = 0, max = chr.getSize(); i < max; i++)
            {
                if (chr.getSortTableValues(i) != null)
                    output = output.Replace(chr.getSortTableValues(i), chr.getSortTableIndex(i));
            }
            return output;
        }

        //write to the ROM
        public bool writeToROM(string startingPosition, string size, string input, string filePath)
        {

            bool pass = false;
            int
                intSize = (new MyMath()).hexToDec(size),
                start = (new MyMath()).hexToDec(startingPosition);


            //if script to big, get rid of space
            if (intSize < input.Length / 2) //lazy code
                input = input.Replace("FF", "");

            //made the string longer if it's too short
            while (intSize > input.Length / 2)//lazy code
                input += "FF";

            //is the string the right size?
            if (intSize == input.Length / 2)//lazy code
                pass = true;

            if (pass)
            {
                //let's insert into the ROM
                BinaryWriter write = new BinaryWriter(File.OpenWrite(filePath));
                write.BaseStream.Position = start;
                write.Write(input);
                write.Close();
            }
            return pass;
        }

        private string readBinaryFile(int startingPosition, int size, string typeOfReturn)
        {
            /*
             * Stolen from a website with this text:
             * "Seek locates a position in a file. It allows data to be read from
             * a binary file at a certain part. "
             */
            using (BinaryReader b = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                int length = (int)b.BaseStream.Length,
                    pos = startingPosition,
                    required = size,
                    count = 0;

                b.BaseStream.Seek(pos, SeekOrigin.Begin);

                string s = "";
                while (pos++ < length && count < required)
                {
                    switch (typeOfReturn)
                    {
                        case "toHex":
                            s += (new MyMath()).decToHex(b.ReadByte()) + " ";
                            break;
                        case "toDec":
                            s += b.ReadByte() + " ";
                            break;
                        case "toASCII":
                            byte[] bb = new byte[1];
                            bb[0] = b.ReadByte();
                            char[] ch = Encoding.ASCII.GetChars(bb);
                            s += ch[0].ToString();
                            break;
                    }
                    count++;
                }
                return s;
            }
        }

        public string readInASCII(int startingPosition, int size)
        { return readBinaryFile(startingPosition, size, "toASCII"); }
        public string readInDecimal(int startingPosition, int size)
        { return readBinaryFile(startingPosition, size, "toDec"); }
        public string readInHex(int startingPosition, int size)
        { return readBinaryFile(startingPosition, size, "toHex"); }
    }
}
