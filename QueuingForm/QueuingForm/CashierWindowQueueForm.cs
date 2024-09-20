using System;
using System.Collections;
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
    public partial class CashierWindowQueueForm : Form
    {

        private CustomerView view;
        public string studentInQueue = "";
        public CashierWindowQueueForm()
        {
            InitializeComponent();
          

        }

        public void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count != 0)
            {
                studentInQueue = CashierClass.CashierQueue.Peek().ToString();
                //will dequeue or remove the number that is already done
                CashierClass.CashierQueue.Dequeue();

                DisplayCashierQueue(CashierClass.CashierQueue);
                view.Show();
            }
            else
            {
               MessageBox.Show("The queuing is empty");
            }
        }
    }
}
