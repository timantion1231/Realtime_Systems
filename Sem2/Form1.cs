using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Sem2
{
    public partial class Form1 : Form
    {
        public const int maxVal = 400000000;

        public Form1()
        {
            InitializeComponent();
        }

        public void ThrFun1()
        {
            for (int i = 0; i < maxVal; i++)
            {
                if (i % (maxVal / 100) == 0)
                {
                    setPB('A', i);
                }
                if (flagA)
                {
                    flagA = false;
                    Thread.Sleep(1000);
                }
                double d = Math.Sqrt(2);
            }
            setPB('A', maxVal);


            Log("Thread " + Thread.CurrentThread.Name + "is done");
        }

        public void ThrFun2()
        {
            for (int i = 0; i < maxVal; i++)
            {
                if (i % (maxVal / 100) == 0)
                {
                    setPB('B', i);

                }
                if (flagB)
                {
                    flagB = false;
                    Thread.Sleep(1000);
                }
                double d = Math.Sqrt(2);
            }
            setPB('B', maxVal);

            Log("Thread " + Thread.CurrentThread.Name + "is done");
            if (flagOff) btnOn(true);
            else flagOff = true;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(ThrFun1);
            Thread t2 = new Thread(ThrFun2);



                PBB.Maximum = maxVal;
                PBA.Maximum = maxVal;

                Log("запуск потоков");
                
                t1.Name = "A";
                t1.Start();

                t2.Name = "B";
                t2.Start();

            startBtn.Enabled = false;

            if (flagOff) btnOn(true);
            else flagOff = true;

        }

        public delegate void DLog(string msg);

        private void Log(string msg)
        {
            if (this.InvokeRequired)
            {
                DLog dl = new DLog(Log);
                this.Invoke(dl, new object[] { msg });

            }
            else textBox1.Text += DateTime.Now + msg + "\r\n";

        }

        public delegate void DSetPB(char c, int val);
        
        public void setPB(char c, int val)
        {
            if (this.InvokeRequired)
            {
                DSetPB dl = new DSetPB(setPB);
                this.Invoke(dl, new object[] { c, val });
            }
            else
            {
                if (c == 'A') PBA.Value = val;
                else PBB.Value = val;
            }
        }

        public bool flagA = false, flagB = false, flagOff = false;

        private void btnStopB_Click(object sender, EventArgs e)
        {
            flagB = true;
        }

        private void btnStopA_Click(object sender, EventArgs e)
        {
            flagA = true;
        }

        public delegate void DBtnOn(bool on);

        public void btnOn(bool on)
        {
            if (this.InvokeRequired)
            {
                DBtnOn dl = new DBtnOn(btnOn);
                this.Invoke(dl, new object[] { on });
            }
            else
            {
                startBtn.Enabled = on;
            }
        }
    }
}
