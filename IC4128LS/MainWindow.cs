using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace IC4128LS
{
    public partial class MainWindow : Form
    {
        private readonly THProcess thprocess = new THProcess();

        // medal_state is needed for medal counting
        private byte difficulty, medal_state, _medal_state;
        private ushort stage, miss, bomb, gold, silver, bronze;
        private uint _miss_state, miss_state, _bomb_state, bomb_state;
        private uint p_medal_state, frame_count, score;

        private readonly string[] ArrDiff = { "Easy", "Normal", "Hard", "Lunatic", "Extra" };
        private readonly string[] ArrRoute = { "?", "A", "A1", "A1", "A2", "A2", "B", "B1", "B1", "B2", "B2", "C", "C1", "C1", "C2", "C2", "Ex" };

        // private float iscore;

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
            mainWorker.RunWorkerAsync();
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

        private void OnClosing(object sender, FormClosingEventArgs e)
        {
            if (mainWorker.IsBusy)
                mainWorker.CancelAsync();
        }

        private void ReadMemory()
        {
            uint p_miss_state = 0, p_bomb_state = 0;
            thprocess.ReadMemory(0x004B4D20, 0, sizeof(uint), ref frame_count);
            thprocess.ReadMemory(0x004B4D0C, 0, sizeof(byte), ref difficulty);
            thprocess.ReadMemory(0x004B4D14, 0, sizeof(ushort), ref stage);
            thprocess.ReadMemory(0x004B8A80, 0, sizeof(uint), ref p_miss_state);
            thprocess.ReadMemory(p_miss_state, 0xF78, sizeof(byte), ref miss_state);
            thprocess.ReadMemory(0x004B892C, 0, sizeof(uint), ref p_bomb_state);
            thprocess.ReadMemory(p_bomb_state, 0x3C, sizeof(byte), ref bomb_state);
            thprocess.ReadMemory(0x004B4CC4, 0, sizeof(uint), ref score);
            thprocess.ReadMemory(0x004B8934, 0, sizeof(uint), ref p_medal_state);
            thprocess.ReadMemory(p_medal_state, 0x7C, sizeof(byte), ref medal_state);
        }

        private void UpdateLogic()
        {
            // reset
            if (frame_count <= 0x0F && score == 0)
                miss = bomb = gold = silver = bronze = 0;
            // miss count - 0: reviving; 1: alive; 2: dying; 4: border of life and death
            if (miss_state != _miss_state && miss_state == 2)
                miss++;
            _miss_state = miss_state;
            // bomb count - 0: not bombing; 1: bombing
            if (bomb_state != _bomb_state && bomb_state == 1)
                bomb++;
            _bomb_state = bomb_state;
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
            // iscore = gold * 1.5f - miss - bomb * 2;
        }

        private void UpdateUI()
        {
            ValueDiff.Text = ArrDiff[difficulty];
            ValueRoute.Text = ArrRoute[stage];
            ValueMiss.Text = miss.ToString();
            ValueBomb.Text = bomb.ToString();
            ValueGold.Text = gold.ToString();
            ValueSilver.Text = silver.ToString();
            ValueBronze.Text = bronze.ToString();
            // ValueISCORE.Text = iscore.ToString();
        }

        private void Worker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (thprocess.FindProcess())
            {
                if (mainWorker.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                ReadMemory();
                UpdateLogic();

                mainWorker.ReportProgress(9);
                Thread.Sleep(15);
            }
        }

        private void Worker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            UpdateUI();
        }

        private void Worker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Find_NotFound();
        }
    }
}
