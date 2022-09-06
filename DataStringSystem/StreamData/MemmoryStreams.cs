using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStringSystem.StreamData
{
    internal class MemmoryStreams
    {
        public void MemmoryStremSystem()
        {
            var ms = new MemoryStream();
            using var s = new NamedPipeServerStream("pipedream");
            s.WaitForConnection();
            s.WriteByte(100); // Send the value 100.
            Console.WriteLine(s.ReadByte());
        }

        static byte[] ReadMessage(PipeStream s)
        {
            MemoryStream ms = new MemoryStream();
            byte[] buffer = new byte[0x1000]; // Read in 4 KB blocks
            do { ms.Write(buffer, 0, s.Read(buffer, 0, buffer.Length)); }
            while (!s.IsMessageComplete);
            return ms.ToArray();
        }

        public void MemberCombinable()
        {
            string path = "test.txt";

            FileAttributes fileAttributes = File.GetAttributes(path);
            if((fileAttributes & FileAttributes.ReadOnly) != 0)
            {
                // Use the exclusive-or operator (^) to toggle the ReadOnly flag
                fileAttributes ^= FileAttributes.ReadOnly;
                File.SetAttributes(path, fileAttributes);
            }

            // Now we can delete the file, for instance:
            File.Delete(path);
        }
    }
}
