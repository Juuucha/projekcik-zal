using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Za_malo_za_duzo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int RandomNumber;
        private int From;
        private int To;
        bool isPaused = true;
        int Time = 0;
        int Tries = 0;

        List<Runda> GameHistory = new List<Runda>();

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            /// pokazuje pola odpowiadające za wybór liczby
            textBoxOd.Visible = true;
            textBoxDo.Visible = true;
            buttonGenerate.Visible = true;
            textBoxNumber.Visible = true;
            buttonCheck.Visible = true;
            Komentarz.Visible = false;
            Time = 0;
            Tries = 0;
        }

        private void buttonStartPause_Click(object sender, EventArgs e)
        {
            if(isPaused)
            {
                ///wznawia grę
                buttonStartPause.Text = "Resume";
                textBoxOd.Enabled = false;
                textBoxDo.Enabled = false;
                buttonCheck.Enabled = false;
                textBoxNumber.Enabled = false;
                buttonGenerate.Enabled = false;
                isPaused = false;
                timerGame.Stop();
            }
            else
            {
                ///pauzuje grę
                buttonStartPause.Text = "Pause";
                textBoxOd.Enabled = true;
                textBoxDo.Enabled = true;
                buttonCheck.Enabled = true;
                textBoxNumber.Enabled = true;
                buttonGenerate.Enabled = true;
                isPaused = true;
                timerGame.Start();
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            /// try catch odpowiadający za sprawdzenie czy od do to liczba
            From = Convert.ToInt16(textBoxOd.Text);
            To = Convert.ToInt16(textBoxDo.Text);

            Random generate = new Random();

            RandomNumber = generate.Next(From, To);

            textBoxNumber.Enabled = true;
            buttonStartPause.Enabled = true;
            buttonCheck.Enabled = true;
            timerGame.Start();
            labelTime.Visible = true;
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            /// sprawdza czy liczba się zgadza
            string number = " ";
            bool isNumber = false;
            int ConNumber = 0;
            Tries++;
            try
            {
                number = textBoxNumber.Text;
                isNumber = int.TryParse(number, out ConNumber);
                Komentarz.Text = "Please insert Number!";
                Komentarz.ForeColor = Color.Black;
                
            }
            catch (InvalidCastException ex)
            {
                throw;
            }

            if(isNumber)
            {
                if (ConNumber > RandomNumber)
                {
                    Komentarz.Text = "To Big";
                    Komentarz.ForeColor = Color.Red;
                }
                else if (ConNumber < RandomNumber)
                {
                    Komentarz.Text = "To Small";
                    Komentarz.ForeColor = Color.Red;
                }
                else
                {
                    Komentarz.Text = "Correct";
                    Komentarz.ForeColor = Color.Green;
                    labelLiczba.Text = "Generated Number: " + RandomNumber;
                    labelLiczba.Visible = true;
                    timerGame.Stop();

                    textBoxOd.Enabled = false;
                    textBoxDo.Enabled = false;
                    buttonGenerate.Enabled = false;
                    textBoxNumber.Enabled = false;
                    buttonCheck.Enabled = false;

                    Runda runda = new Runda();
                    runda.CorrectNumber = RandomNumber;
                    runda.NumberofTries = Tries;
                    runda.Time = Time;

                    GameHistory.Add(runda);
                }
            }
            isNumber = false;
            
            Komentarz.Visible = true;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            /// tworzy formę prezentującą historię gry
            GameHistoryForm History = new GameHistoryForm();

            ListView lv1 = new ListView();
            lv1.Bounds = new Rectangle(new Point(12, 12), new Size(255, 215));
            lv1.View = View.Details;
            lv1.GridLines = true;
            lv1.Scrollable = true;
            lv1.Columns.Add("Correct Number", -2, HorizontalAlignment.Left);
            lv1.Columns.Add("Number of Tries", -2, HorizontalAlignment.Left);
            lv1.Columns.Add("Seconds", -2, HorizontalAlignment.Left);

            /// dodanie itemów do lv1
            foreach(Runda runda in GameHistory)
            {
                ListViewItem newItem = new ListViewItem(Convert.ToString(runda.CorrectNumber));
                newItem.SubItems.Add(Convert.ToString(runda.NumberofTries));
                newItem.SubItems.Add(Convert.ToString(runda.Time));
                lv1.Items.Add(newItem);
            }

            History.Controls.Add(lv1);

            History.Show();
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {
            /// informacje o autorze
            InfoForm info = new InfoForm();
            info.Show();
        }

        private void textBoxOd_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxOd.Text = " ";
        }

        private void textBoxDo_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxDo.Text = " ";
        }

        private void textBoxNumber_MouseClick(object sender, MouseEventArgs e)
        {
            textBoxNumber.Text = " ";
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            Time++;
            labelTime.Text = "Game Time: " + Time;
        }
    }
}
