using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UIWindows.Business.Concrete;
using UIWindows.Context;

namespace UIWindows.Views.Users
{
    public partial class frmChargingScreen : Form
    {
        public Entities.Users u { get; set; }
        static InoxErpContext ctx = new InoxErpContext();
        UsersBusiness objLogin = new UsersBusiness(ctx);

        private Timer t = new Timer();
        private Timer t2 = new Timer();
        private Timer t3 = new Timer();
        private Timer t4 = new Timer();

        public bool log { get; set; } = false;

        public frmChargingScreen(Entities.Users user)
        {
            InitializeComponent();
            u = user;
        }

        private void frmChargingScreen_Load(object sender, EventArgs e)
        {
            timer();
        }

        public void timer()
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

        private void InitializeTimer2()
        {
            t.Enabled = false;
            t2.Enabled = true;
            t2.Start();
            t2.Interval = 1000;
            t2.Tick += new EventHandler(Timer2_Tick);
        }

        private void InitializeTimer3()
        {
            t2.Enabled = false;
            t3.Enabled = true;
            t3.Start();
            t3.Interval = 1000;
            t3.Tick += new EventHandler(Timer3_Tick);
        }

        private void InitializeTimer4()
        {
            t3.Enabled = false;
            t4.Enabled = true;
            t4.Start();
            t4.Interval = 1000;
            t4.Tick += new EventHandler(Timer4_Tick);
        }

        private void Timer_Tick(object Sender, EventArgs e)
        {
            prbConnection();
            login();
            picNet.Image = Properties.Resources.net2;
            InitializeTimer2();
        }

        private void Timer2_Tick(object Sender, EventArgs e)
        {
            prbCheckModules();
            picModules.Image = Properties.Resources.modules2;
            InitializeTimer3();
        }

        private void Timer3_Tick(object Sender, EventArgs e)
        {
            prbStartSystem();
            picSystem.Image = Properties.Resources.system2;
            InitializeTimer4();
        }

        private void Timer4_Tick(object Sender, EventArgs e)
        {
            this.Close();
        }

        private void login()
        {
            u = objLogin.signIn(u);

            if (u == null)
            {
                t.Stop();
                t2.Stop();
                t3.Stop();
                t4.Stop();

                MessageBox.Show("Usuário Inválido");

                Application.Restart();
            }
            else
            {
                log = true;
            }
        }

        private void setTimer(ProgressBar p)
        {
            for (int i = 0; i <= p.Maximum; i++)
            {
                p.Value = i;
            }
        }

        private void prbConnection()
        {
            prbNet.Minimum = 0;
            prbNet.Maximum = 2000;
            prbNet.Step = 1;
            
            setTimer(prbNet);
        }

        private void prbCheckModules()
        {
            prbModules.Minimum = 0;
            prbModules.Maximum = 1000;
            prbModules.Step = 1;

            setTimer(prbModules);
        }

        private void prbStartSystem()
        {
            prbSystem.Minimum = 0;
            prbSystem.Maximum = 1000;
            prbSystem.Step = 1;

            setTimer(prbSystem);
        }
    }
}
