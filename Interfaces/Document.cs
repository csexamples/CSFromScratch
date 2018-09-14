using System;

namespace Interfaces
{
    public class Document : IStorable, ISpeak
    {
        public void Reformat()
        {
            Console.WriteLine("Reformatting the document");
        }

        public void Read(string nameOfFile)
        {
            Console.WriteLine($"Reading from file {nameOfFile}");
        }

        public void Write(string fileName)
        {
            Console.WriteLine($"Writing to file {fileName}");
        }

        public double DurationOfSpeech
        {
            get { return 42; }
        }

        public void Speak()
        {
            Console.WriteLine($"Speaking...");
        }
    }
}
