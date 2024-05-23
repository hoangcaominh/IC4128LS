using System;
using System.IO;
using System.Drawing;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace IC4128LS
{
    public partial class MainWindow : Form
    {
        private readonly THProcess thprocess = new THProcess();

        // medal_state is needed for medal counting
        // short: stage, miss, lives, bomb, gold, silver, bronze;
        // int: score
        private byte difficulty, medal_state, _medal_state;
        private ushort stage, miss, bomb, gold, silver, bronze;
        private int lives, _lives, pf, _pf;
        private uint p_medal_state, frame_count, score;

        private float iscore;

        private string lang;

        public MainWindow()
        {
            SelectLang();
            InitializeComponent();
        }

        private void SelectLang()
        {
            if (!File.Exists("lang.txt"))
            {
                Lang lang_dialog = new Lang();
                lang_dialog.ShowDialog();
            }

            lang = File.ReadAllText("lang.txt");
            if (lang == "en")
            {
                // do nothing
            }
            else if (lang == "ja")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ja");
            }
            else if (lang == "zh")
            {
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("zh-Hans");
            }
            else
            {
                // corrupted
                lang = "en";
                File.WriteAllText("lang.txt", lang);
            }
        }

        private void Find_Found()
        {
            FindButton.Enabled = false;
            LabelFound.Visible = true;
            LabelNotFound.Visible = false;
            new Task(UpdateStatus).Start();
        }

        private void Find_NotFound()
        {
            FindButton.Enabled = true;
            LabelFound.Visible = false;
            LabelNotFound.Visible = true;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            // Lang lang = new Lang();
            // lang.Show();
            if (thprocess.FindProcess())
            {
                Find_Found();
            }
            else
            {
                Find_NotFound();
            }
        }

        private readonly string[] ArrDiff = { "Easy", "Normal", "Hard", "Lunatic", "Extra" };
        private readonly string[] ArrRoute = { "?", "A", "A1", "A1", "A2", "A2", "B", "B1", "B1", "B2", "B2", "C", "C1", "C1", "C2", "C2", "Ex" };
        
        private void UpdateStatus()
        {
            do
            {
                // Read memory
                ReadMemory(0x004B4D20, 0, sizeof(uint), ref frame_count);
                ReadMemory(0x004B4D0C, 0, sizeof(byte), ref difficulty);
                ReadMemory(0x004B4D14, 0, sizeof(ushort), ref stage);
                ReadMemory(0x004B4D64, 0, sizeof(uint), ref lives);
                ReadMemory(0x004B4D70, 0, sizeof(uint), ref pf);
                ReadMemory(0x004B4CC4, 0, sizeof(uint), ref score);
                ReadMemory(0x004B8934, 0, sizeof(uint), ref p_medal_state);
                ReadMemory(p_medal_state, 0x7C, sizeof(byte), ref medal_state);

                // Calculate
                lock (this)
                {
                    // reset
                    if (frame_count <= 0x0F && score == 0)
                        miss = bomb = gold = silver = bronze = 0;
                    // miss count
                    // 10000 / 2 because fast forward can make the resource reduce less than 10000. Why not 1? Because Marisa laser exists
                    if (lives < _lives - 10000 / 2)
                        miss++;
                    _lives = lives;
                    // bomb count
                    if (pf < _pf - 10000 / 2)
                        bomb++;
                    _pf = pf;
                    // medal count
                    if ((_medal_state & 128) > 0 && (medal_state & 128) == 0)
                    {
                        if ((medal_state & 4) > 0)
                            gold++;
                        else if ((medal_state & 2) > 0)
                            silver++;
                        else
                            bronze++;
                    }
                    _medal_state = medal_state;
                    // iscore
                    // if (difficulty == 3)
                    iscore = gold * 1.5f - miss - bomb * 2;
                }

                // Update UI
                Invoke(new Action(() =>
                {
                    ValueDiff.Text = ArrDiff[difficulty];
                    ValueRoute.Text = ArrRoute[stage];
                    ValueMiss.Text = miss.ToString();
                    ValueBomb.Text = bomb.ToString();
                    ValueGold.Text = gold.ToString();
                    ValueSilver.Text = silver.ToString();
                    ValueBronze.Text = bronze.ToString();
                    ValueISCORE.Text = iscore.ToString();
                }));
                Thread.Sleep(10);
            }
            while (FindProcess());

            // Display info after closing the game
            Invoke(new Action(() =>
            {
                Find_NotFound();
            }));
        }
    }
}
