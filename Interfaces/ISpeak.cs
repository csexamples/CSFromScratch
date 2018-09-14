using System;

namespace Interfaces
{
    public interface ISpeak
    {
        double DurationOfSpeech { get; }
        void Speak();
    }
}
