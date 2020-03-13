using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceTravel.Util
{
    static class ImageHandler
    {

        static public byte[] GetImageBin(string fileName)
        {
            byte[] ImageData;
            using (FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader binaryReader = new BinaryReader(fileStream))
                {
                    ImageData = binaryReader.ReadBytes((int)fileStream.Length);
                }
            }

            return ImageData;
        }
    }
}
