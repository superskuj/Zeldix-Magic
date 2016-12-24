/**
 * Class    : Txtio.cs
 * Author   : Corndoggers
 * Info     : A class that reads a file and writes to a file line by line.
 * 
 */

using System;
using System.IO;
namespace Zeldix.Classes
{
    public class Txtio
    {
        private string path, file;
        private int lineNumber;

        public Txtio(string path)
        {
            this.path = path;
            lineNumber = 0;
            updateInternalFile();
        }

        public void writeToLine(string text)
        { writeToLine(text, getNoOfLines() - 1); }
        public void writeToLine(string text, int index)
        {
            char lineChar = '\n';

            updateInternalFile();

            string[] array = file.Split(lineChar);
            if (array.Length > 0)
            {
                string s = "";
                int i = 0;

                while (i < array.Length)
                {
                    if (i != index)
                        s += array[i] + lineChar;
                    else
                    {
                        if (i < lineNumber)
                        {
                            foreach (char c in text)
                            {
                                if (c == lineChar)
                                    lineNumber++;
                            }
                        }
                        s += text;
                    }
                    i++;
                }
                s.Replace("\r", "");

                File.WriteAllText(path, s + "\r");
                updateInternalFile();
            }
        }
        public bool contains(string str)
        { return file.Contains(str); }

        public void setLineNumber(int i)
        { lineNumber = i; }

        public string printAll()
        { return File.ReadAllText(path); }
        public void clear()
        {
            File.WriteAllText(path, "");
            lineNumber = 0;
            updateInternalFile();
        }

        public int getNoOfLines()
        { return file.Split('\n').Length; }

        public string readLine()
        {
            string s = "";
            if (lineNumber > getNoOfLines())
            {
                s = readLine();
                lineNumber++;
            }
            return s;
        }

        public bool isEmpty()
        { return (file.Length < 2); }

        public string readLine(int i)
        {
            string[] array = file.Split('\n');
            string readString = null;

            if (array.Length > 0)
            {
                File.ReadAllText(path);
                readString = array[i];
            }
            return readString.Replace("\r", ""); ;
        }

        private void updateInternalFile()
        {
            try
            {
                file = File.ReadAllText(path) + "\n";
            }
            catch
            {
                File.Create(path);
                file = File.ReadAllText(path) + "\n";
            }
        }
    }
}