public class DataAccess
{
    private static List<Scripture> _scriptures;

    public static List<Scripture> LoadFile(string filename)
    {
        List<Scripture> scriptures = new List<Scripture>();

        // Code to load file and create Scripture objects goes here

        _scriptures = scriptures;

        return scriptures;
    }
}
