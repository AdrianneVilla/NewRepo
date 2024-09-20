using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QueuingForm
{
    public partial class CustomerView : Form
    {
        private CashierWindowQueueForm queueForm = new CashierWindowQueueForm();
        public CustomerView()
        {
            InitializeComponent();
        }

        private void ServingQueue_Click(object sender, EventArgs e)
        {

        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
           label1.Text = queueForm.studentInQueue.ToString();
        }
    }
}
