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

namespace N1_3
{
    public partial class Form1 : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new String[] {"あ","い","う","え","お","ん", "か", "や", "ま", "け" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;
        }

        void recEngine_SpeechRecognized(object sender,SpeechRecognizedEventArgs e)
        {
            switch(e.Result.Text)
            {
                case "あ":
                    richTextBox1.Text += "あ";
                    break;

                case "い":
                    richTextBox1.Text += "い";
                    break;

                case "う":
                    richTextBox1.Text += "う";
                    break;

                case "え":
                    richTextBox1.Text += "え";
                    break;

                case "お":
                    richTextBox1.Text += "お";
                    break;

                case "か":
                    richTextBox1.Text += "か";
                    break;

                case "や":
                    richTextBox1.Text += "や";
                    break;

                case "ま":
                    richTextBox1.Text += "ま";
                    break;

                case "け":
                    richTextBox1.Text += "け";
                    break;

                case "ん":
                    richTextBox1.Text += "ん";
                    break;

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            button2.Enabled = false;
        }
    }
}