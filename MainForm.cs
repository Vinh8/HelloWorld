// Programmer: Vinh Huynh   
// Project: Lab 6-1
// Date: 04/23/2021
// Description: Ice cream selection form
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Add stream reader and writer classes
namespace Lab_6_1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // Executes when form loads
        private void MainForm_Load(object sender, EventArgs e)
        {
            {
                PopulateBoxes();

                // Sets Vanilla as the default choice
                iceCreamFlavorComboBox.SelectedItem = "Vanilla";
            }
        }

        private void PopulateBoxes()
        {
            // Ensures that the file is readable
            try
            {
                // Retreives data from file and inputs it into the corresponding locations
                StreamReader inputFile;
                inputFile = File.OpenText("Flavors.txt");
                while (!inputFile.EndOfStream)
                {
                    iceCreamFlavorComboBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();

                inputFile = File.OpenText("Toppings.txt");
                while (!inputFile.EndOfStream)
                {
                    toppingsListBox.Items.Add(inputFile.ReadLine());
                }
                inputFile.Close();
                
            }

            // Displays error message when there is a problem reading from file
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }      

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter outputFile;
                outputFile = File.AppendText("Orders.txt");
                outputFile.WriteLine(DateTime.Now.ToString("MM/dd/yyyy")); // Writes Current date into the file

                // Checks which cone type was selected and writes it into file
                if (sugarConeRadioButton.Checked)
                {
                    outputFile.WriteLine("Sugar Cone");
                }
                if (waffleConeRadioButton.Checked)
                {
                    outputFile.WriteLine("Waffle Cone");
                }

                // Writes selected flavor to file
                outputFile.WriteLine(iceCreamFlavorComboBox.SelectedItem.ToString());

                // Loops through list box to see which toppings were selected
                for (int num = 0; num < toppingsListBox.Items.Count; num++)
                {
                    if (toppingsListBox.GetSelected(num))
                    {
                        outputFile.WriteLine(toppingsListBox.Items[num]);
                    }
                }
                outputFile.WriteLine(); // Separates order written in file
                outputFile.Close();

            }

            // Displays error message when there is a problem reading from file
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Resets form
            sugarConeRadioButton.Checked = true;
            iceCreamFlavorComboBox.SelectedItem = "Vanilla";
            toppingsListBox.ClearSelected();

            // Sets focus back to first radio button
            sugarConeRadioButton.Focus();
        }

        // Closes the form
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Handles the about menu item click event
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm myAboutForm = new AboutForm(); // New AboutForm Instance

            // Displays the about form as modal form
            myAboutForm.ShowDialog();
        }
    }
}    
