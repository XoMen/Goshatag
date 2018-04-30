using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Microsoft.Office.Interop.Word;//<- this is what I am talking about
using Microsoft.Office.Core;
//using Word = Microsoft.Office.Interop.Word;

namespace goshatag
{
    public partial class Form1 : Form
    {

        OpenFileDialog ofd_browser = new OpenFileDialog();
        OpenFileDialog ofd_template = new OpenFileDialog();
        string action = "";
        Dictionary<string, string[]> dic_data = new Dictionary<string, string[]>();

        public Form1()
        {
            InitializeComponent();

            //setup ofd browser
            ofd_browser.Filter = "txt files (*.txt)|*.txt";
            ofd_browser.Multiselect = false;
            ofd_browser.FileOk += Ofd_browser_FileOk;

            //setup ofd template
            ofd_template.Filter = "word doc|*.docx";
            ofd_template.Multiselect = false;
            ofd_template.FileOk += Ofd_template_FileOk;


            Directory.CreateDirectory("export/");
        }

        private void Ofd_template_FileOk(object sender, CancelEventArgs e)
        {
        }

        // choose tag and content files
        private void Ofd_browser_FileOk(object sender, CancelEventArgs e)
        {
            if(ofd_browser.FileName !=null || ofd_browser.FileName !="")
            {

                string[] contents = File.ReadAllLines(ofd_browser.FileName);
                if (contents == null) { MessageBox.Show("empty file!"); return; }

                if (action == "tag")
                {
                    foreach (var item in contents)
                    {
                        dic_data.Add(item, null);
                        dgv_data.Rows.Add(item, "not set", "0");
                    }
                }
                else
                {
                    string selected_tag = "";
                    if (dgv_data.SelectedRows.Count > 0) { selected_tag = dgv_data.SelectedRows[0].Cells[0].Value.ToString(); }
                    else
                    if (dgv_data.SelectedCells.Count > 0) { selected_tag = dgv_data.Rows[dgv_data.SelectedCells[0].RowIndex].Cells[0].Value.ToString(); }

                    if(dgv_data.SelectedRows.Count>0)
                    {
                        dgv_data.SelectedRows[0].Cells[1].Value = "ok";
                        dgv_data.SelectedRows[0].Cells[2].Value = contents.Length.ToString();
                    }
                    else
                    {
                        dgv_data.Rows[dgv_data.SelectedCells[0].RowIndex].Cells[1].Value = "ok";
                        dgv_data.Rows[dgv_data.SelectedCells[0].RowIndex].Cells[2].Value = contents.Length.ToString();
                    }



                    dic_data[selected_tag] = contents;

                }

            }
        }

        private void btn_tag_Click(object sender, EventArgs e)
        {
            action = "tag";
            ofd_browser.Title = "choose tag file";
            ofd_browser.ShowDialog();
        }

        private void btn_content_Click(object sender, EventArgs e)
        {
            try
            {
                string selected_tag = "";
                if (dgv_data.SelectedRows.Count > 0) { selected_tag = dgv_data.SelectedRows[0].Cells[0].Value.ToString(); }
                else
                if (dgv_data.SelectedCells.Count > 0) { selected_tag = dgv_data.Rows[dgv_data.SelectedCells[0].RowIndex].Cells[0].Value.ToString(); }
            }
            catch (Exception)
            {

                MessageBox.Show("select a row first");
                return;
            }
            

            if (dgv_data.SelectedRows.Count>0 || dgv_data.SelectedCells.Count>0)
            {
                action = "content";
                ofd_browser.Title = "choose content file";
                ofd_browser.ShowDialog();
            }
            else
            {
                MessageBox.Show("select a row first");
            }

        }

        private void btn_export_Click(object sender, EventArgs e)
        {
            Process.Start(System.Windows.Forms.Application.StartupPath+"/export/");
        }

        private void btn_template_Click(object sender, EventArgs e)
        {
            ofd_template.ShowDialog();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {

            //check if template exists
            if (ofd_template.FileName.Length ==0)
            {
                MessageBox.Show("first choose a doc word");
                return;
            }

            // check empty table
            if (dgv_data.Rows.Count == 0) { MessageBox.Show("table is empty");return; }

            //check row contents
            int base_vle = -1;
            for (int i = 0; i < dgv_data.Rows.Count-1; i++)
            {
                if(base_vle==-1)
                {
                    base_vle = Convert.ToInt32(dgv_data.Rows[i].Cells[2].Value);
                }
                else
                {
                    int this_vle = Convert.ToInt32(dgv_data.Rows[i].Cells[2].Value); ;
                    if(this_vle !=base_vle)
                    {
                        MessageBox.Show("content rows are not same!");
                        return;
                    }
                }
            }

            Directory.CreateDirectory("export/");
            if (Directory.GetFiles("export/").Length > 0) { MessageBox.Show("first empty export folder");return; }

            progressBar1.Maximum = base_vle;
            progressBar1.Value = 0;
            for (int i = 0; i < base_vle; i++)
            {

                progressBar1.Value = i+1;
                
                Word.Application wordApp = new Word.Application();
                
                Word.Document aDoc = null;

                
                wordApp.Visible = false;


                File.Copy(ofd_template.FileName, "export/" + i + ".docx");

                aDoc = wordApp.Documents.Open(System.Windows.Forms.Application.StartupPath+"/export/" + i + ".docx");


                aDoc.Activate();


                //  Call FindAndReplace()function for each change
                for (int ii = 0; ii < dgv_data.RowCount-1; ii++)
                {
                    string this_tag = dgv_data.Rows[ii].Cells[0].Value.ToString();
                    string[] contents = dic_data[this_tag];

                    this.FindAndReplace(wordApp, this_tag, contents[i]);

                }


                aDoc.Save();
                aDoc.Close();

            }
            MessageBox.Show("done!");

        }
        private void FindAndReplace(Word.Application wordApp,
            object findText, object replaceText)
        {
            object matchCase = true;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            wordApp.Selection.Find.Execute(ref findText, ref matchCase,
                ref matchWholeWord, ref matchWildCards, ref matchSoundsLike,
                ref matchAllWordForms, ref forward, ref wrap, ref format,
                ref replaceText, ref replace, ref matchKashida,
                        ref matchDiacritics,
                ref matchAlefHamza, ref matchControl);
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            frm_help obj_hp = new frm_help();
            obj_hp.ShowDialog();
        }

        private void btn_aboutus_Click(object sender, EventArgs e)
        {
            frm_about obj_ab = new frm_about();
            obj_ab.ShowDialog();
        }
    }
}
