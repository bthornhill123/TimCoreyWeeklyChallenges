using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TextFileChallenge
{
    public partial class ChallengeForm : Form
    {
        BindingList<UserModel> users = new BindingList<UserModel>();
        int firstNameOrder = 0;
        int lastNameOrder = 0;
        int ageOrder = 0;
        int isAliveOrder = 0;

        public ChallengeForm()
        {
            InitializeComponent();

            LoadListFromFile();

            WireUpDropDown();
        }

        private void LoadListFromFile()
        {
            // Load the file
            string[] lines = File.ReadAllLines("StandardDataSet.csv");

            string[] headers = lines[0].Split(',');

            for (int i = 0; i < headers.Length; i++)
            {
                if(headers[i] == "FirstName")
                {
                    firstNameOrder = i;
                }
                else if (headers[i] == "FirstName")
                {
                    firstNameOrder = i;
                } else if (headers[i] == "FirstName")
                {
                    firstNameOrder = i;
                }

            }


            // Parse each line 
            for (int i = 1; i < lines.Length; i++)
            {
                string[] columns = lines[i].Split(',');

                bool isAlive = false;
                if(columns[3] == "1")
                {
                    isAlive = true;
                }

                // Create a model from the line
                // Add model to list
                users.Add(new UserModel
                {
                    FirstName = columns[0],
                    LastName = columns[1],
                    Age = int.Parse(columns[2]),
                    IsAlive = isAlive
                });
            }
        }

        private void WireUpDropDown()
        {
            usersListBox.DataSource = users;
            usersListBox.DisplayMember = nameof(UserModel.DisplayText);
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            users.Add(new UserModel
            {
                FirstName = firstNameText.Text,
                LastName = lastNameText.Text,
                Age = (int)agePicker.Value,
                IsAlive = isAliveCheckbox.Checked
            });

            firstNameText.Text = "";
            lastNameText.Text = "";
            agePicker.Value = 0;
            isAliveCheckbox.Checked = false;
        }

        private void SaveListButton_Click(object sender, EventArgs e)
        {
            List<string> linesToSave = new List<string>();
            linesToSave.Add("FirstName,LastName,Age,IsAlive");
            foreach (UserModel user in users)
            {
                int isAliveValue = 0;
                if(user.IsAlive == true)
                {
                    isAliveValue = 1;
                }
                linesToSave.Add($"{user.FirstName},{user.LastName},{user.Age},{isAliveValue}");
            }

            File.WriteAllLines("StandardDataSet.csv", linesToSave);

            MessageBox.Show("Save Complete");
        }
    }
}
