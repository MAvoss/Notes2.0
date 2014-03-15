using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace notes2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string res;
        private string issues;
        private string items;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            res = textBoxres.Text;
            issues = textBoxActions.Text;
            items = textBoxissues.Text;  // resets itwem variable so it wont retain last values 
            foreach (string s in checkedListBoxVideo.CheckedItems)
            {
                items = items + " //  " + s;//keeps formatting nice 

            }
            foreach (string s in checkedListBoxInternet.CheckedItems)
            {
                items = items + " //  " + s;//keeps formatting nice 

            }
            foreach (string s in checkedListBoxPhone.CheckedItems)
            {
                items = items + " //  " + s;//keeps formatting nice 

            }
            foreach (string s in checkedListBoxHomeSecurity.CheckedItems)
            {
                items = items + " //  " + s;//keeps formatting nice 

            }
            foreach (string s in checkedListBoxOther.CheckedItems)
            {
                items = items + " //  " + s;//keeps formatting nice 

            }
            ///issues 
            ///

            foreach (string s in checkedListBoxTSTV.CheckedItems)
            {
                issues = issues + " //  " + s;//keeps formatting nice 

            }
            foreach (string s in checkedListBoxTSinternet.CheckedItems)
            {
                issues = issues + " //  " + s;//keeps formatting nice 

            }
            foreach (string s in checkedListBoxTSPhone.CheckedItems)
            {
                issues = issues + " //  " + s;//keeps formatting nice 

            }

            foreach (string s in checkedListBoxTSSEc.CheckedItems)
            {
                issues = issues + " //  " + s;//keeps formatting nice 

            }
            foreach (string s in checkedListBoxTSother.CheckedItems)
            {
                issues = issues + " //  " + s;//keeps formatting nice 

            }
            ///res 
            ///

            foreach (string s in checkedListBoxRes1.CheckedItems)
            {
                res = res + " //  " + s;//keeps formatting nice 

            }
            foreach (string s in checkedListBoxTC.CheckedItems)
            {
                res = res + " //  " + s;//keeps formatting nice 

            }
            foreach (string s in checkedListBoxResults.CheckedItems)
            {
                res = res + " //  " + s;//keeps formatting nice 

            }
            /////logical 
            
                notes();
            
            Clipboard.SetText(textBoxFinal.Text);

            
        


        }

        private void notes()
        {
            textBoxFinal.Text = "Customer Name: " + textBoxName.Text + " // " + Environment.NewLine + "Verfication: " + comboBoxVerfiication.SelectedItem.ToString() + " // " + Environment.NewLine +
                    "Issues: " + items + " // " + Environment.NewLine + "Actions: " + issues + " // " + Environment.NewLine + "Resolution: " + res + " // ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxVerfiication.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (int i in checkedListBoxVideo.CheckedIndices)
            {
                checkedListBoxVideo.SetItemCheckState(i, CheckState.Unchecked);
                checkedListBoxVideo.ClearSelected();
            }
            foreach (int i in checkedListBoxInternet.CheckedIndices)
            {
                checkedListBoxInternet.SetItemCheckState(i, CheckState.Unchecked);
                checkedListBoxInternet.ClearSelected();
            }
            foreach (int i in checkedListBoxPhone.CheckedIndices)
            {
                checkedListBoxPhone.SetItemCheckState(i, CheckState.Unchecked);
                checkedListBoxPhone.ClearSelected();
            }
            foreach (int i in checkedListBoxHomeSecurity.CheckedIndices)
            {
                checkedListBoxHomeSecurity.SetItemCheckState(i, CheckState.Unchecked);
                checkedListBoxHomeSecurity.ClearSelected();
            }
            foreach (int i in checkedListBoxTSTV.CheckedIndices)
            {
                checkedListBoxTSTV.SetItemCheckState(i, CheckState.Unchecked);
                checkedListBoxTSTV.ClearSelected();
            }
            foreach (int i in checkedListBoxTSinternet.CheckedIndices)
            {
                checkedListBoxTSinternet.SetItemCheckState(i, CheckState.Unchecked);
                checkedListBoxTSinternet.ClearSelected();
            }
            foreach (int i in checkedListBoxTSPhone.CheckedIndices)
            {
                checkedListBoxTSPhone.SetItemCheckState(i, CheckState.Unchecked);
                 checkedListBoxTSPhone.ClearSelected();
            }
            foreach (int i in checkedListBoxTSSEc.CheckedIndices)
            {
                checkedListBoxTSSEc.SetItemCheckState(i, CheckState.Unchecked);
                checkedListBoxTSSEc.ClearSelected();
            }
            foreach (int i in checkedListBoxTSother.CheckedIndices)
            {
                checkedListBoxTSother.SetItemCheckState(i, CheckState.Unchecked);
                checkedListBoxTSother.ClearSelected();
            }
            foreach (int i in checkedListBoxRes1.CheckedIndices)
            {
                checkedListBoxRes1.SetItemCheckState(i, CheckState.Unchecked);
                 checkedListBoxRes1.ClearSelected();
            }
            foreach (int i in checkedListBoxTC.CheckedIndices)
            {
                checkedListBoxTC.SetItemCheckState(i, CheckState.Unchecked);
                checkedListBoxTC.ClearSelected();
            }
            foreach (int i in checkedListBoxResults.CheckedIndices)
            {
                checkedListBoxResults.SetItemCheckState(i, CheckState.Unchecked);
                checkedListBoxResults.ClearSelected();
            }

          
                textBoxActions.Clear();
                textBoxissues.Clear();
                textBoxName.Clear();
                comboBoxVerfiication.SelectedIndex = 0;
                textBoxFinal.Clear();
                textBoxres.Clear();

            }

        private void checkedListBoxRes1_SelectedIndexChanged(object sender, EventArgs e)
        {


         if(checkedListBoxRes1.CheckedItems.ToString() == "Issues Resolved")
             MessageBox.Show("hi");
         
         
            
        }


        }
    }


