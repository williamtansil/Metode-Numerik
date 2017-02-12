using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _141110205_WilliamTansil_MetodeNumerik.Rumus;
using _141110205_WilliamTansil_MetodeNumerik.View;

namespace _141110205_WilliamTansil_MetodeNumerik
{
    public partial class la1 : Form
    {
        float n, tracehold, sawal, t;
        MenghitungAkar menghitungakar;
        static List<MenghitungAkar.Row> data;

        public la1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if (hasil.Rows.Count > 1)
            {
                foreach (DataGridViewRow x in hasil.Rows)
                {
                    hasil.Rows.Remove(x);
                }
            }
            float truenumber;
            float.TryParse(N.Text, out truenumber);
            if (N.Text == "" || truenumber == 0)
            {
                N.Focus(); return;
            }
            float.TryParse(Tracehold.Text, out truenumber);
            if (Tracehold.Text == "") 
            {
                Tracehold.Focus(); return;
            }
            if (Convert.ToSingle(Tracehold.Text) > 0.99999999999)
            {
                Tracehold.Text = "0." + Tracehold.Text;
            }
            float.TryParse(SAwal.Text, out truenumber);
            if (SAwal.Text == "" || truenumber == 0)
            {
                SAwal.Focus(); return;
            }
            if (Show.Text == "") 
            {
                Show.Text = "Loading..";
            }
            float.TryParse(Show.Text, out truenumber);
            if (truenumber == 0) 
            {
                Show.Focus();
            }
            
            n = Convert.ToSingle(N.Text);
            tracehold = Convert.ToSingle(Tracehold.Text);
            sawal = Convert.ToSingle(SAwal.Text);
            t = n / sawal;
            menghitungakar = new MenghitungAkar(n, sawal, t, tracehold);  
            data = menghitungakar.GetHasil();

            foreach(MenghitungAkar.Row x in data)
            {
                this.hasil.Rows.Add(x.Iterasi, x.S, x.T, x.Error);
            }
            Show.Text = hasil.Rows[hasil.Rows.Count - 2].Cells[1].Value.ToString();
        }

        private void la1_Load(object sender, EventArgs e)
        {
            menghitungakar = new MenghitungAkar();
        }
    }
}
