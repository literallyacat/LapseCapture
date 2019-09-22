using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace LapseCapture {
    public partial class Form1 : Form {

        private static readonly int[] _intervals = new int[] {
            30000,
            60000,
            300000
        };

        private readonly BackgroundWorker _worker;

        public Form1() {
            InitializeComponent();
            _worker = new BackgroundWorker();
        }

        private void Form1_Load(object sender, EventArgs e) {
            CaptureIntervalChooser.SelectedIndex = 0;
            StartCapture.Click += StartCapture_Click;
        }

        private void StartCapture_Click(object sender, EventArgs e) {
            if (_worker.IsBusy) {
                StartCapture.Text = "Start Capture";
                _worker.CancelAsync();
            } else {
                _worker.DoWork += Worker_DoWork;
                _worker.WorkerSupportsCancellation = true;
                _worker.RunWorkerAsync();
                WindowState = FormWindowState.Minimized;
                StartCapture.Text = "Cancel";
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e) {
            while (true) {
                if (_worker.CancellationPending) {
                    e.Cancel = true;
                    return;
                }

                int interval = GetIntervalMilliseconds();
                Thread.Sleep(interval);

                Bitmap bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                               Screen.PrimaryScreen.Bounds.Height,
                               PixelFormat.Format32bppArgb);
                Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);
                gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
                            Screen.PrimaryScreen.Bounds.Y,
                            0,
                            0,
                            Screen.PrimaryScreen.Bounds.Size,
                            CopyPixelOperation.SourceCopy);

                bmpScreenshot.Save($"{DateTimeOffset.Now.ToUnixTimeSeconds()}.png", ImageFormat.Png);
            }
        }

        private int GetIntervalMilliseconds() {
            return _intervals[CaptureIntervalChooser.SelectedIndex];
        }
    }
}
