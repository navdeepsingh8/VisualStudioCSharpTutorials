// indexer.cs
// arguments: indexer.txt
using System;
using System.IO;

/// <summary>
/// Class to provide access to a large file
/// as if it were a byte array.
/// </summary>
public class FileByteArray
{
    /// <summary>
    /// Holds the underlying stream
    /// used to access the file.
    /// </summary>
    Stream stream;      
    

    /// <summary>
    /// Create a new FileByteArray encapsulating a particular file.
    /// </summary>
    /// <param name="fileName">The name of the file</param>
    public FileByteArray(string fileName)
    {
        stream = new FileStream(fileName, FileMode.Open);
    }

    
    /// <summary>
    /// Close the stream. This should be the last thing done when you are finished.
    /// </summary>
    public void Close()
    {
        stream.Close();
        stream = null;
    }

    /// <summary>
    /// Indexer to provide read/write access to the file. 
    /// </summary>
    /// <param name="index">long is a 64-bit integer</param>
    /// <returns>A single byte from the index in the string</returns>
    public byte this[long index] 
    {
        // Read one byte at offset index and return it.
        get
        {
            byte[] buffer = new byte[1];
            stream.Seek(index, SeekOrigin.Begin);
            stream.Read(buffer, 0, 1);
            return buffer[0];
        }
        // Write one byte at offset index and return it.
        set
        {
            byte[] buffer = new byte[1] { value };
            stream.Seek(index, SeekOrigin.Begin);
            stream.Write(buffer, 0, 1);
        }
    }

    // Get the total length of the file.
    public long Length
    {
        get
        {
            return stream.Seek(0, SeekOrigin.End);
        }
    }
}

// Demonstrate the FileByteArray class.
// Reverses the bytes in a file.
public class Reverse
{
    public static void Main(String[] args)
    {
        // Check for arguments.
        if (args.Length == 0)
        {
            Console.WriteLine("indexer <filename>");
            return;
        }

        FileByteArray file = new FileByteArray(args[0]);
        long len = file.Length;

        // Swap bytes in the file to reverse it.
        for (long i = 0; i < len / 2; ++i)
        {
            byte t;

            // Note that indexing the "file" variable invokes the
            // indexer on the FileByteStream class, which reads
            // and writes the bytes in the file.
            t = file[i];
            file[i] = file[len - i - 1];
            file[len - i - 1] = t;
        }

        file.Close();
    }
}