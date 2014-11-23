using System;
using System.Windows.Forms;


namespace DelegateWpfBackgroundProgressBar
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();            
        }

        readonly DelegateSample _sampleDelegate = new DelegateSample();

        void Notify(int step, string msg)
        {
            // MessageBox.Show(msg);
            progressBar1.Value = step;
            
            //label1.Content = msg;
        }

        public void GoProgress()
        {
            _sampleDelegate.Run(Notify);            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            (new System.Threading.Thread(GoProgress)).Start();
            
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
           // GOProgress();
        }

        private void progressBar1_VisibleChanged(object sender, EventArgs e)
        {
            GoProgress();
        }
    }
}
