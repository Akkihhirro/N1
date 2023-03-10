using System;
using System.Speech.Recognition;

namespace N1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
                using (var recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("ja-JP")))
                {
                    recognizer.LoadGrammar(new DictationGrammar());
                    recognizer.SpeechRecognized += Recognizer_SpeechRecognized;
                    recognizer.SetInputToDefaultAudioDevice();
                    recognizer.RecognizeAsync(RecognizeMode.Multiple);
                    Console.ReadLine();
                }
        }
        private static void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine(e.Result.Text);
        }
    }

            
}

