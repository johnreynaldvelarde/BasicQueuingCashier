using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuingCashier
{
    public partial class CustomerView : Form
    {
        private CashierClass cashier;
        public CustomerView()
        {
            InitializeComponent();
            cashier = new CashierClass();
            countTimer();
        }

        public void countTimer()
        {
            Timer timer = new Timer();
            timer.Interval = (1 * 1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count > 0)
            {
                lblView.Text = CashierClass.CashierQueue.Peek();
            }
            else
            {
                lblView.Text = "P - ";
            }
        }
    }
}
