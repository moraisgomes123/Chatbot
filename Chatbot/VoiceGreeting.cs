using System;
using System.IO;
using NAudio.Wave;

namespace CybersecurityChatbot.Chatbot
{
    // Handles playing a voice greeting when the chatbot starts.
    public class VoiceGreeting
    {
        // Plays the greeting audio file if it exists.
        public void PlayGreeting()
        {
            try
            {
                // Get application base directory
                string basePath = AppDomain.CurrentDomain.BaseDirectory;

                // Build full path to audio file
                string fullPath = Path.Combine(basePath, "Audio", "greeting.wav");

                // Check if file exists
                if (!File.Exists(fullPath))
                {
                    Console.WriteLine("Audio file not found: " + fullPath);
                    return;
                }

                // Initialize audio playback
                using (var audioFile = new AudioFileReader(fullPath))
                using (var outputDevice = new WaveOutEvent())
                {
                    outputDevice.Init(audioFile);
                    outputDevice.Play();

                    // Wait until audio finishes playing
                    while (outputDevice.PlaybackState == PlaybackState.Playing)
                    {
                        System.Threading.Thread.Sleep(200);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any playback errors
                Console.WriteLine("Error playing audio: " + ex.Message);
            }
        }
    }
}
