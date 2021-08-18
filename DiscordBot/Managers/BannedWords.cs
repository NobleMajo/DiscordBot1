using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiscordBot.Managers
{
    class BannedWords
    {
        Form1 myForm = Application.OpenForms.OfType<Form1>().FirstOrDefault();
        private readonly string PATH = $@"{Environment.CurrentDirectory}/bannedWords.txt";
        SafeThreading.SafeThreadingForm safe;
        public void getMessages()
        {
            safe = new SafeThreading.SafeThreadingForm();
            string BannedWord;
            if (!File.Exists(PATH))
            {
                File.Create(PATH);
            }
            using (StreamReader read = File.OpenText(PATH))
            {
                while ((BannedWord = read.ReadLine()) != null)
                {
                    safe.safeComboThreading(myForm.BannedWords, BannedWord);
                }
                //test
            }
        }
        public void AddWord(string word)
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH);
            }
            using(StreamWriter writer = File.AppendText(PATH))
            {
                writer.WriteLine(word);
            }
           
        }
        public void RemoveWord(string word)
        {
            string tempFile = Path.GetTempFileName();

            using (var sr = new StreamReader(PATH))
            using (var sw = new StreamWriter(tempFile))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    if (line != word)
                        sw.WriteLine(line);
                }
            }

            File.Delete("bannedWords.txt");
            File.Move(tempFile, "bannedWords.txt");
        }
        
    }
}
