using System.Runtime.InteropServices;

namespace ClinicManagement
{
    public partial class Form1 : Form
    {
        #region Custom title bar
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void TitleBarMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                Console.WriteLine("Dragged in");

                if (Location.Y <= 0)
                    UpdateWindowState(FormWindowState.Maximized);
                else
                {
                    UpdateWindowState(FormWindowState.Normal);
                    Size = new Size(1280, 720);
                }
            }

            
        }

        #endregion

        #region InitHelper

        private void LayoutInit()
        {
            _navContainer.VerticalScroll.Maximum = 0;
            _navContainer.AutoScroll = false;
            _navContainer.VerticalScroll.Visible = false;
            _navContainer.AutoScroll = true;
        }

        private void FontInit()
        {
            // add fonts
            Utils.AddMemoryFont(Resource1.Roboto_Light);
            Utils.AddMemoryFont(Resource1.Roboto_Black);
            Utils.AddMemoryFont(Resource1.Roboto_Regular);

            //use font
            //_title.Font = Utils.GetFont("Roboto Black", 14, FontStyle.Bold);
            foreach (Control c in _navContainer.Controls)
                c.Font = Utils.GetFont("Roboto Light", 10);
        }

        #endregion

        #region Member
        private Button _currentPageBtn;
        public Button CurrentPageBtn { get { return _currentPageBtn; } set { _currentPageBtn = value; } }

        private Form _activeForm;
        public Form ActiveForm { get => _activeForm; set => _activeForm = value; }

        
        #endregion

        public Form1()
        {
            InitializeComponent();
            FontInit();
            LayoutInit();

            _currentPageBtn = _patienBtn;
            CurrentPageBtn.BackColor = Utils.FromHex("#201447");
            CurrentPageBtn.Font = Utils.GetFont("Roboto Black", 10);
            OpenChildForm(new Forms.PatientForm());
        }

        #region Helper
        private void UpdateWindowState(FormWindowState state)
        {
            if (state == FormWindowState.Maximized)
                _resizeBtn.BackgroundImage = Resource1.fullscreenexit;
            else
                _resizeBtn.BackgroundImage = Resource1.fullscreen;

            WindowState = state;
        }

        private void OpenChildForm(Form form)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActiveForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            _title.Text = form.Text;
            _innerFrame.Controls.Add(form);
            _innerFrame.Tag = form;
            form.BringToFront();
            form.Show();
        }
        #endregion

        #region Handle Event
        private void HandleNavigate(object sender, EventArgs e) {
            if (((Button)sender) == CurrentPageBtn)
                return;
            Button prev = CurrentPageBtn;
            CurrentPageBtn = ((Button)sender);

            CurrentPageBtn.BackColor = Utils.FromHex("#201447");
            CurrentPageBtn.Font = Utils.GetFont("Roboto Black", 10);

            prev.BackColor = Color.FromArgb(51, 51, 76);
            prev.Font = Utils.GetFont("Roboto Light", 10);

            if (CurrentPageBtn == _patienBtn)
                OpenChildForm(new Forms.PatientForm());
            else if (CurrentPageBtn == _ticket)
                OpenChildForm(new Forms.MedicalBillForm());
            else if (CurrentPageBtn == _illness)
                OpenChildForm(new Forms.IllnessForm());
            else if (CurrentPageBtn == _usage)
                OpenChildForm(new Forms.UsageForm());
            else if (CurrentPageBtn == _import)
                OpenChildForm(new Forms.ImportForm());
        }

        private void HandleClose(object sender, EventArgs e)
        {
            Close();
        }

        private void HandleResize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                UpdateWindowState(FormWindowState.Normal);
            else
                UpdateWindowState(FormWindowState.Maximized);
        }

        private void HandleMinimize(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
                WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}