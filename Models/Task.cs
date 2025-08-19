namespace SmartCodeLab2.Models
{
    class Task
    {
        private string taskName;
        private string instruction;
        private string language;
        private Dictionary<string, byte[]> associateFiles;
        private Dictionary<string, string> testCases;
    }
}
