public class Buffer
{
    //reads the files in current directory to byte array. SHould include folders later
    public List<byte[]> CreateBuffer()
    {
        List<byte[]> bufferCollection = new List<byte[]>();
        string currentDirectoryPath = Directory.GetCurrentDirectory();
        string[] files = Directory.GetFiles(currentDirectoryPath);

        foreach (string file in files)
        {
            byte[] buffer = File.ReadAllBytes(file);
            bufferCollection.Add(buffer);
        }

        return bufferCollection;
    }

    public void ReadBuffer(List<byte[]> bufferCollection)
    {
        // using var writer = new BinaryWriter(File.OpenWrite(files.);
        // writer.Write(data);
    }
}
