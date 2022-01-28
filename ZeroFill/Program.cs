using System;
using System.IO;

namespace ZeroFill
{
    public static class Program
    {
        private const int BufferSize = 64 * 1024;

        public static void Main()
        {
            using (var file = File.Create("zero.dat", BufferSize, FileOptions.DeleteOnClose | FileOptions.WriteThrough))
            {
                var buffer = new byte[BufferSize];

                while (true)
                {
                    try
                    {
                        file.Write(buffer, 0, buffer.Length);
                    }
                    catch
                    {
                        break;
                    }
                }
            }
        }
    }
}

