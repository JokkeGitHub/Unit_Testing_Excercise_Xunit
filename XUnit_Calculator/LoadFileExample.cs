using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XUnit_Calculator
{
    public class LoadFileExample
    {
        public string LoadTextFile(string file)
        {
            if(file.Length < 10)
            {
                throw new ArgumentException("The file name was too short.", "File");
                //throw new System.IO.FileNotFoundException();
            }

            return "The file was correctly loaded.";
        }
    }
}
