using LSP.Correct;
using OCP.Correct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solid
{
    /// <summary>
    /// Advantages of SOLID Design Principles in C#
    /// 1.Maintainability
    /// 2.Testability(TDD=Test-Driven Development)=We need to design the application in such a way that we should test each individual functionalities
    /// 3.Flexibility and Extensibility=So we should design the application in such a way that it should be flexible so that it can be adapted to work in different ways and extensible so that we can add new features easily with minimum modifications.
    /// 4.Parallel Development=entire development team will work on the same module at the same time
    /// 5.
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public void LSP()
        {
            Fruit fruit = new Apple();
            MessageBox.Show("LSP - Apple");

            fruit = new Orange();
            MessageBox.Show("LSP - Orange");
        }
        public void OCP()
        {
            Invoice FInvoice = new FinalInvoice();
            Invoice PInvoice = new ProposedInvoice();
            Invoice RInvoice = new RecurringInvoice();

            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(10000);
            MessageBox.Show("LSP - FInvoiceAmount" + FInvoiceAmount);

            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(10000);
            MessageBox.Show("LSP - PInvoiceAmount" + PInvoiceAmount);

            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(10000);
            MessageBox.Show("LSP - RInvoiceAmount" + RInvoiceAmount);
        }


        private void btnLSP_Click(object sender, EventArgs e)
        {
            LSP();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOCP_Click(object sender, EventArgs e)
        {
            OCP();
        }
    }    

}
