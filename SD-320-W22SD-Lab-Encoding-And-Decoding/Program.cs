using System.Text;

void encode(string inputPath, string outputPath)
{
    string encodedString = "Text to be encoded";
    Encoding ascii = Encoding.ASCII;
    byte[] asciiBytes = ascii.GetBytes(encodedString);

    for (int i = 0; i < asciiBytes.Length; i++)
    {
        Console.WriteLine(asciiBytes[i]);
    }
}

void decode(string inputPath, string outputPath)
{
    string encodedString = "This has been decoded";
    Encoding utf8 = Encoding.UTF8;
    byte[] utf8Bytes = utf8.GetBytes(inputPath);
    string decodedText = UTF8Encoding.UTF8.GetString(utf8Bytes);

    for (int i = 0; i < utf8Bytes.Length; i++)
    {
        Console.WriteLine(utf8Bytes[i]);
    }
    Console.WriteLine(encodedString);
}

encode(@"C:\Users\hello\OneDrive\Desktop\Sample.txt", @"C:\Users\hello\OneDrive\Desktop\Notes2");
decode(@"C:\Users\hello\OneDrive\Desktop\Sample.txt", @"C:\Users\hello\OneDrive\Desktop\Notes2");