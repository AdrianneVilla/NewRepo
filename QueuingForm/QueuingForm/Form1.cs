using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        private CashierWindowQueueForm queueForm;

        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();
            queueForm = new CashierWindowQueueForm();
            queueForm.Show();           
            Timer timer = new Timer();
            timer.Interval = (4 * 1000); //4 seconds
            timer.Tick += new EventHandler(queueForm.btnRefresh_Click);
            timer.Start();
            
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {

            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void QueuingForm_Load(object sender, EventArgs e)
        {

        }

        private void lblQueue_Click(object sender, EventArgs e)
        {

        }
    }
}
