using System;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;

namespace Chapter05
{
    public sealed class ByteStream : IDisposable
    {
        private readonly Stream stream;
        private readonly byte[] buffer;
        private int position;
        private int bufferedBytes;

        public ByteStream(Stream stream)
        {
            this.stream = stream;
            buffer = new byte[1024 * 8];
        }

        public async ValueTask<byte?> ReadByteAsync()
        {
            if (position == bufferedBytes)
            {
                position = 0;
                bufferedBytes = await stream.ReadAsync(buffer, 0, buffer.Length).ConfigureAwait(false);
                if (bufferedBytes == 0)
                {
                    return null;
                }
            }
            return buffer[position++];
        }

        public void Dispose()
        {
            stream.Dispose();
        }
    }

    [Description("Listing 5.9")]
    class BufferedStreamValueTask
    {
        static async Task Main()
        {
            using (var stream = new ByteStream(File.OpenRead("Chapter05.csproj")))
            {
                int indexOnLine = 0;
                byte? nextByte;
                while ((nextByte = await stream.ReadByteAsync()).HasValue)
                {
                    // This usage ends up boxing every byte anyway, making ValueTask<> less
                    // useful than it would be in other cases - but it's a simple demonstration.
                    Console.Write("{0:x2} ", nextByte.Value);
                    if (++indexOnLine == 16)
                    {
                        Console.WriteLine();
                        indexOnLine = 0;
                    }
                }
            }
        }
    }
}
