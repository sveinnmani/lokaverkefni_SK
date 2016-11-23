﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FOR2B2U_Tverk7
{
    
    public partial class Form1 : Form
    {
        Gagnagrunnur gagnagrunnur = new Gagnagrunnur();        
        public Form1()
        {
            
            InitializeComponent();
            try
            {
                gagnagrunnur.TengingVidGagnagrunn();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lvTafla.Columns.Add("ID", 50);
            lvTafla.Columns.Add("Titill", 180);
            lvTafla.Columns.Add("Leikstjóri", 180);
            lvTafla.Columns.Add("Útgefandi", 180);
            lvTafla.Columns.Add("Ár", 40);
            lvTafla.Columns.Add("Flokkur", 100);

            List<string> linur = new List<string>();
            string[] arr = new string[6];

            ListViewItem itm;

            try
            {
                linur = gagnagrunnur.LesaUt();

                foreach(string lin in linur)
                {
                    string[] linaUrLista = lin.Split(':');
                    string ID = linaUrLista[0];
                    string titill = linaUrLista[1];
                    string leikstjori = linaUrLista[2];
                    string utgefandi = linaUrLista[3];
                    string ar = linaUrLista[4];
                    string flokkur = linaUrLista[5];

                    arr[0] = ID;
                    arr[1] = titill;
                    arr[2] = leikstjori;
                    arr[3] = utgefandi;
                    arr[4] = ar;
                    arr[5] = flokkur;

                    itm = new ListViewItem(arr);
                    lvTafla.Items.Add(itm);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());    
            }
        }

        private void lvOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTafla.SelectedIndices.Count <=0)
            {
                return;
            }
            int intSelectedIndex = lvTafla.SelectedIndices[0];
            if (intSelectedIndex >= 0)
            {
                tbTitill.Text = lvTafla.SelectedItems[2].SubItems[2].Text;
                /*tbLeikstjori.Text = lvTafla.SelectedItems[2].SubItems[2].Text;
                tbUtgefandi.Text = lvTafla.SelectedItems[3].SubItems[3].Text;
                tbAr.Text = lvTafla.SelectedItems[4].SubItems[4].Text;
                tbFlokkur.Text = lvTafla.SelectedItems[5].SubItems[5].Text;*/
            }
        }

        private void btSyna_Click(object sender, EventArgs e)
        {
            
        }

        private void btSkra_Click(object sender, EventArgs e)
        {
            gagnagrunnur.SettInnSqlToflu(tbSkraTitill.Text, tbSkraLeikstjori.Text, tbSkraUtgefandi.Text, tbSkraAr.Text, cbSkraFlokkur.Text);
        }

               
        
        /*private void lbOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTafla.SelectedIndex != -1)
            {
                string nafn = null;
                string[] nafnid = null;
                nafn = lvTafla.SelectedItem.ToString();

                char split = ':';

                nafnid = nafn.Split(split);
                tbKennitalaBreyta.Text = nafnid[0];
                tbNafnBreyta.Text = nafnid[1];
                tbNetfangBreyta.Text = nafnid[2];
                tbSimiBreyta.Text = nafnid[3];
            }
        }*/

        

        

                
    }
}
