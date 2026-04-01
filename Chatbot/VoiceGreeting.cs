using System;
using System.IO;
using NAudio.Wave;

namespace CybersecurityChatbot.Chatbot
{
    public class VoiceGreeting
    {
        public void PlayGreeting()
        {
            try
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string fullPath = Path.Combine(basePath, "Audio", "greeting.wav");

                if (!File.Exists(fullPath))
                {
                    Console.WriteLine("Audio file not found: " + fullPath);
                    return;
                }

                using (var audioFile = new AudioFileReader(fullPath))
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Play();

                    // Wait until playback finishes
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        System.Threading.Thread.Sleep(200);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error playing audio: " + ex.Message);
            }
        }
    }
}