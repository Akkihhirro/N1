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
            commands.Add(new String[] {"��","��","��","��","��","��", "��", "��", "��", "��" });
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
                case "��":
                    richTextBox1.Text += "��";
                    break;

                case "��":
                    richTextBox1.Text += "��";
                    break;

                case "��":
                    richTextBox1.Text += "��";
                    break;

                case "��":
                    richTextBox1.Text += "��";
                    break;

                case "��":
                    richTextBox1.Text += "��";
                    break;

                case "��":
                    richTextBox1.Text += "��";
                    break;

                case "��":
                    richTextBox1.Text += "��";
                    break;

                case "��":
                    richTextBox1.Text += "��";
                    break;

                case "��":
                    richTextBox1.Text += "��";
                    break;

                case "��":
                    richTextBox1.Text += "��";
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