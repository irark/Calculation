using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        private long n = 0;
        private long m = 0;
        private long[] v;
        private long[] counts;
        private Calculation calculation;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void FillHeaders(string mes, DataGridView dgv)
        {
            foreach(DataGridViewColumn col in dgv.Columns)
            {
                col.HeaderText = String.Format(mes, (col.Index + 1).ToString());
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

       
        private void GetN()
        {
            bool result = long.TryParse(tbN.Text, out n);
            if (!result || n < 1)
            {
                MessageBox.Show("Incorrect data. Enter an integer greater then 0", "ERROR", MessageBoxButtons.OK);
                tbN.Text = "";
            }
            else
            {
                dgvSpeeds.RowCount = 1;
                dgvSpeeds.ColumnCount = (int)n;
                dgvSpeeds.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                v = new long[n];
                FillHeaders("team member {0}", dgvSpeeds);
            }
        }

        private void tbM_Enter(object sender, EventArgs e)
        {
            GetM();
        }
        private void GetM()
        {
            bool result = long.TryParse(tbM.Text, out m);
            if (!result || m < 1)
            {
                MessageBox.Show("Incorrect data. Enter an integer greater then 0", "ERROR", MessageBoxButtons.OK);
                tbM.Text = "";
            }
        }
        private void GetV()
        {
            for(int i = 0; i < n; i++)
            {
                bool result = long.TryParse(dgvSpeeds[i, 0].Value.ToString(), out v[i]);
                if (!result || v[i] < 1)
                {
                    dgvSpeeds[i, 0].Value = "";
                }
            }
        }
       

        private void calc_Click(object sender, EventArgs e)
        {
            Calc();
        }
        private void Calc()
        {
            GetV();
            try
            {
                calculation = new Calculation(n, m, v);
                long result = calculation.GetResult(out counts);
                tbResult.Text = result.ToString();
                ShowResult(result);
            }
            catch
            {
                MessageBox.Show($"Incorrect data.", "ERROR", MessageBoxButtons.OK);
            }
            
        }
        private void ShowResult(long x)
        {
            dgvResult.RowCount = 1;
            dgvResult.ColumnCount = (int)n;
            dgvResult.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            FillHeaders("team member {0} edits ", dgvResult);
         
            for(int i = 0; i < n; i++ )
            {
                dgvResult[i, 0].Value = counts[i].ToString();
            }
        }

        private void tbN_TextChanged(object sender, EventArgs e)
        {
            GetN();
        }

        private void tbM_TextChanged(object sender, EventArgs e)
        {
            GetM();
        }
    }
}
