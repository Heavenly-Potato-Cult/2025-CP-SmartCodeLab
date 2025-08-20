using System.Diagnostics;

namespace SmartCodeLab2.Models
{
    class Task
    {
        private string taskName;
        private string instruction;
        private string language;
        private Dictionary<string, byte[]> associateFiles;
        private Dictionary<string, string> testCases;

        public Task(string taskName, string instruction, string language)
        {
            this.taskName = taskName;
            this.instruction = instruction;
            this.language = language;
            this.associateFiles = new Dictionary<string, byte[]>();
            this.testCases = new Dictionary<string, string>();
        }

        //key is/are the inputs, while value will be the expected output
        public void Add_Test_Case(KeyValuePair<string, string> pair) {
            try
            {
                testCases.Add(pair.Key, pair.Value);
            }
            catch(System.ArgumentException)
            {
                //do nothing.... for now, later will notify user that the same iputs/keys are used
            }
        }

        public override string ToString()
        {
            string testCasesString = string.Join(", ", testCases.Select(kvp => $"[{kvp.Key}: {kvp.Value}]"));

            return $"TaskName: {taskName}, Instruction: {instruction}, Language: {language}, TestCases: {testCasesString}";
        }

    }
}
