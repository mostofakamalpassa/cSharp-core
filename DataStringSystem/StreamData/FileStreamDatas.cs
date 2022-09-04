using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStringSystem.StreamData
{
    public class FileStreamDatas
    {
        public void GetFileStream()
        {
            // Create a file called test.txt in the current directory:
            using (Stream s = new FileStream("text.txt", FileMode.Create))
            {
                Console.WriteLine(s.CanRead); // true
                Console.WriteLine(s.CanWrite); // true
                Console.WriteLine(s.CanSeek); // true

                s.WriteByte(101);
                s.WriteByte(102);

                byte[] block = { 6, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, };
                s.Write(block, 0, block.Length);
                Console.WriteLine(s.Length); // 7
                Console.WriteLine(s.Position); // 7
                s.Position = 0; // Move back to the start

                Console.WriteLine(s.ReadByte()); // 101
                Console.WriteLine(s.ReadByte()); // 102
                                                 // Read from the stream back into the block array:
                Console.WriteLine(s.Read(block, 0, block.Length)); // 5
                                                                   // Assuming the last Read returned 5, we'll be at
                                                                   // the end of the file, so Read will now return 0:
                Console.WriteLine(s.Read(block, 0, block.Length)); // 0
            }
        }
    }
}
