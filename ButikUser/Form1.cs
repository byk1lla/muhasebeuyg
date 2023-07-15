
using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace butikunmuhasebe.ButikUser
{
    public partial class loading : Form
    {
        private const int TotalSeconds = 10;
        private const int Interval = 500;
        private int currentSecond;


        private const int AW_SLIDE = 0x40000;
        private const int AW_VER_NEGATIVE = 0x00000008;
        private const int AW_BLEND = 0x00080000;

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr hwnd, int time, int flags);
        public loading()
        {
            InitializeComponent();
        }

        private void loading_Load(object sender, EventArgs e)
        {            
            timer1.Start();
            progressBar1.Maximum = TotalSeconds;
            progressBar1.Minimum = 0;
            progressBar1.Value = 0;
            progressLBL.Text = "İşlemler Tamamlanırken Lütfen Bekleyin.";
            timer1.Interval = Interval;
            timer1.Tick += Timer_Tick;
            
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            currentSecond++;
            progressBar1.Value = currentSecond;

            if (currentSecond == TotalSeconds)
            {
                timer1.Stop();
                 AnimateWindow(this.Handle, 200, AW_BLEND | AW_VER_NEGATIVE | AW_SLIDE);
                this.Close();
            }
        }
    }
}
