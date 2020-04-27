using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageTrainer
{
    public partial class Form1 : Form
    {
        private enum WordState
        {
            Waiting,
            Right,
            Wrong
        }

        private static string[] clingonian = new string[]
        {
            "wa'", "cha'", "wej", "loS", "vagh",
            "jav", "Soch", "chorgh", "Hut", "wa'maH"
        };

        private static string[] hindi = new string[]
        {
            "ek", "do", "tin", "car", "panc",
            "cha", "sat", "ath", "nau", "das"
        };

        private static string[] quechua = new string[]
        {
            "huk", "iskay", "kimsa", "tawa", "pichqa",
            "soqta", "qanchis", "pusaq", "isqon", "chunka"
        };

        //All languages:
        private static string[][] languages = new string[][]
        {
            clingonian, hindi, quechua
        };

        //Currently selected language:
        private string[] currentLanguage;

        //Currently selected word index:
        private int currentIndex;

        //Random numbers to select words:
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
            selectLanguage(0);
        }

        private void selectLanguage(int index)
        {
            currentLanguage = languages[index];
            showNextWord();
        }

        private void setWordState(WordState newState)
        {
            switch (newState)
            {
                case WordState.Waiting:

                    label2.Text = "Waiting for your guess ...";
                    label2.ForeColor = Color.Blue;

                    break;

                case WordState.Right:

                    label2.Text = "Right :)";
                    label2.ForeColor = Color.Green;

                    break;

                case WordState.Wrong:

                    label2.Text = "Wrong :(";
                    label2.ForeColor = Color.Red;

                    break;
            }
        }

        private void showNextWord()
        {
            //Select a random word from the current language:
            currentIndex = rand.Next(currentLanguage.Length);
            string word = currentLanguage[currentIndex];
            label1.Text = word;

            //Reset the state label and the textbox:
            setWordState(WordState.Waiting);
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            if (rb.Checked)
            {
                //MessageBox.Show("CheckedChanged: " + rb.Name);
                selectLanguage(int.Parse((string)rb.Tag));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            showNextWord();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Try to cast user's guess to integer:
                string guess = textBox1.Text;
                int guessInt;

                if (!int.TryParse(guess, out guessInt))
                {
                    setWordState(WordState.Wrong);
                    return;
                }

                //Compare to selected word index:
                if ((currentIndex + 1) == guessInt)
                {
                    setWordState(WordState.Right);
                }
                else
                {
                    setWordState(WordState.Wrong);
                }
            }
        }
    }
}
