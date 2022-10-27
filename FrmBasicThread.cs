using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyThreadClass
{
    public partial class FrmBasicThread : Form
    {
        Thread threadA = new Thread(MyThreadClass.thread1);
        Thread threadB = new Thread(MyThreadClass.thread1);

        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void btnThread_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before Starting Thread-");
            threadA.Name = "Thread A Process";
            threadB.Name = "Thread B Process";

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            label1.Text = "-End of Thread-";

            Console.WriteLine("-End of Thread-");
        }
    }
}
