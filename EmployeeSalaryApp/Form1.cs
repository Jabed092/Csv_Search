using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace EmployeeSalaryApp
{
    public partial class EmployeeAdvancedApp : Form
    {
        public EmployeeAdvancedApp()
        {
            InitializeComponent();
        }

        private string fileLocation = @"F:\EmployeeInformation.csv";

        string name;
        string email;
        string pcontact;
        string hcontact;
        string address;

        private void buttonSave_Click(object sender, EventArgs e)
        {

            FileStream aFileStream = new FileStream(fileLocation, FileMode.OpenOrCreate);
            CsvFileReader aReader = new CsvFileReader(aFileStream);
            List<string> aRecord = new List<string>();

            name = nameTextBox.Text;
            email = emailTextBox.Text;
            pcontact = pcontactTextBox.Text;
            hcontact = hcontactTextBox.Text;
            address = addressTextBox.Text;

            while (aReader.ReadRow(aRecord))
            {
                string fileEmail = aRecord[1];
                string filepContact = aRecord[2];
                string filehContact = aRecord[3];

                if (email == fileEmail)
                {
                    MessageBox.Show(fileEmail + " " + "Already Existed");

                    aFileStream.Close();

                    return;
                }

                if (pcontact == filepContact)
                {
                    MessageBox.Show(filepContact + " " + "Already Existed");

                    aFileStream.Close();
					
                    return;
                }

                if (hcontact == filehContact)
                {
                    MessageBox.Show(filehContact + " " + "Already Existed");

                    aFileStream.Close();

                    return;
                }

            }

            aFileStream.Close();

            nameTextBox.Text = "";
            emailTextBox.Text = "";
            pcontactTextBox.Text = "";
            hcontactTextBox.Text = "";
            addressTextBox.Text = "";

            FileStream aNewStream = new FileStream(fileLocation, FileMode.Append);
            CsvFileWriter aWriter = new CsvFileWriter(aNewStream);
            List<string> contactInfo = new List<string>();

            contactInfo.Add(name);
            contactInfo.Add(email);
            contactInfo.Add(pcontact);
            contactInfo.Add(hcontact);
            contactInfo.Add(address);
            
            aWriter.WriteRow(contactInfo);

            aNewStream.Close();

        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader (aStream);
            List<string> contactInfo = new List<string>();
            
            detailListView.Items.Clear();


            while (aReader.ReadRow(contactInfo))
            {
                ListViewItem aItem = new ListViewItem(contactInfo[0]);

                aItem.SubItems.Add(contactInfo[1]);
                aItem.SubItems.Add(contactInfo[2]);
                aItem.SubItems.Add(contactInfo[3]);
                aItem.SubItems.Add(contactInfo[4]);

                detailListView.Items.Add(aItem);

            }

            aStream.Close();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            FileStream aFileStream = new FileStream(fileLocation, FileMode.Open);
            CsvFileReader aReader = new CsvFileReader(aFileStream);
            List<string> aSearch = new List<string>();

            name = nameSearchTextBox.Text;
            email = emailSearchTextBox.Text;
            pcontact = pcontactSearchTextBox.Text;
            hcontact = hcontactSearchTextBox.Text;
            address = addressSearchTextBox.Text;

            nameSearchTextBox.Text = "";
            emailSearchTextBox.Text = "";
            pcontactSearchTextBox.Text = "";
            hcontactSearchTextBox.Text = "";
            addressSearchTextBox.Text = "";


            while (aReader.ReadRow(aSearch))
            {
            
                string fileName = aSearch[0];
                string fileEmail = aSearch[1];
				string filepContact = aSearch[2];
                string filehContact = aSearch[3];
                string fileAddress = aSearch[4];


             if (name == fileName || email == fileEmail || pcontact == filepContact || hcontact == filehContact || address == fileAddress)

                {

                    ListViewItem aItem = new ListViewItem(aSearch[0]);

                    aItem.SubItems.Add(aSearch[1]);
                    aItem.SubItems.Add(aSearch[2]);
                    aItem.SubItems.Add(aSearch[3]);
                    aItem.SubItems.Add(aSearch[4]);

                    detailListView.Items.Add(aItem);

                    aFileStream.Close();
					
                    return;
                }

            }

            aFileStream.Close();


        }
 
    }
}
