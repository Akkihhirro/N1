using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Recognition;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("test");
            using (SpeechRecognitionEngine recognizer = new SpeechRecognitionEngine())
            {

                // Create and load a dictation grammar.  
                recognizer.LoadGrammar(new DictationGrammar());

                recognizer.SpeechDetected += new EventHandler<SpeechDetectedEventArgs>(recognizer_SpeechDetected);

                // Add a handler for the speech recognized event.  
                recognizer.SpeechRecognized +=
                  new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);

                // Configure input to the speech recognizer.  
                recognizer.SetInputToDefaultAudioDevice();

                // Start asynchronous, continuous speech recognition.  
                recognizer.RecognizeAsync(RecognizeMode.Multiple);

                // Keep the console window open.  
                while (true)
                {
                    Console.ReadLine();
                }
                //using (var recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("ja-JP")))
                //{
                //    recognizer.LoadGrammar(new DictationGrammar());
                //   // recognizer.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(Recognizer_SpeechRecognized);
                //    recognizer.SetInputToDefaultAudioDevice();
                //    recognizer.RecognizeAsync(RecognizeMode.Multiple);
                //}
            }
        }
        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            Console.WriteLine("Recognized text: " + e.Result.Text);
        }

        static void recognizer_SpeechDetected(object sender, SpeechDetectedEventArgs e)
        {
            Console.WriteLine("検出しました");
        }

        //private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        //    {
        //        textBox1.Text = e.Result.Text;
        //    }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
