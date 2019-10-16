using System;
using System.Windows.Forms;
using UIWindows.Business.Concrete;
using UIWindows.Context;

namespace UIWindows.Views.Users
{
    public partial class frmChargingScreen : Form
    {
        static InoxErpContext ctx = new InoxErpContext();
        UsersBusiness objLogin = new UsersBusiness(ctx);
        public Entities.Users u { get; set; }

        private Timer t = new Timer();
        private int contTimer = 1;
        public bool log { get; set; } = false;

        public frmChargingScreen(Entities.Users user)
        {
            InitializeComponent();
            u = user;
        }

        private void frmChargingScreen_Load(object sender, EventArgs e)
        {
            InitializeTimer();
        }

        private void InitializeTimer()
        {
            t.Enabled = true;
            t.Start();
            t.Interval = 1000;

            t.Tick += new EventHandler(Timer_Tick);
        }

        private void Timer_Tick(object Sender, EventArgs e)
        {
            if (contTimer == 4)
            {
                t.Stop();
                this.Close();
            }
            else if (contTimer == 3)
            {
                picModules.Image = Properties.Resources.modules2;
                prb(prbModules);
            }
            else if (contTimer == 2)
            {
                picSystem.Image = Properties.Resources.system2;
                prb(prbSystem);
            }
            else
            {
                if (!login())
                    Application.Restart();
                else
                    log = true;

                prb(prbNet);
                picNet.Image = Properties.Resources.net2;
            }
            contTimer++;
            InitializeTimer();
        }

        private void prb(ProgressBar p)
        {
            p.Minimum = 1;
            p.Maximum = 100;
            p.Step = 1;

            for (int i = 1; i <= p.Maximum; i++)
            {
                p.Value = i;
            }
        }

        private bool login()
        {
            t.Stop();
            u = objLogin.signIn(u);
            if (u != null)
                return true;
            else
            {
                picNet.Image = Properties.Resources.error;

                MessageBox.Show("Desculpe, O usuário não foi Encontrado");

                return false;
            }
        }
    }
}
