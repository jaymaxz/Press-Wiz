using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        int Id = 0;
        DatabaseConnection newConnection = new DatabaseConnection();

        private void Edit_Load(object sender, EventArgs e)
        {
                PrevButton.Enabled = false;
                Id++;
                User user = new User();
                user = newConnection.ReadRows();
                fillData(user);
                UsersDGV.DataSource = newConnection.ReadValues();
                AddButton.Enabled = false;
                UpdateButton.Enabled = false;
                CancelButton.Enabled = false;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            PrevButton.Enabled = true;
            if (newConnection.RowsCheck())
            {
                Id++;
                User userj = new User();
                userj = newConnection.ReadRows();
                fillData(userj);              
            }
            else
            {
                MessageBox.Show("No more Entries");
                NextButton.Enabled = false;
            }
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            Id--;            
            NextButton.Enabled = true;
            User userj = new User();
            userj = newConnection.specificRow();
            fillData(userj);
            if (Id < 2)
            {
                PrevButton.Enabled = false;
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {    
            User userj = new User();
            userj.UserId = UserIdTextBox.Text;
            userj.Telephone = Int32.Parse(TelephoneMTB.Text);
            userj.Admin = AdminCheckBox.Checked;
            if(MessageBox.Show("Do you want to update " + userj.UserId + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                userj.Password = "00000";
                MessageBox.Show("password  is Reset", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                newConnection.updateRow(userj);
                Edit_Load(this, e);
            }
            else
            {
                PrevButton.PerformClick();
                NextButton.PerformClick();
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void FindButton_Click(object sender, EventArgs e)
        {
            FindForm findForm = new FindForm();
            User userj = new User();
            if (findForm.ShowDialog(this)==DialogResult.OK)
            {
                userj = findForm.Userj;
            }
            fillData(userj);
        }

        private void fillData(User user)
        {
            UserIdTextBox.Text = user.UserId;
            FirstNameTextBox.Text = user.First_Name;
            LastNameTextBox.Text = user.Last_Name;
            TelephoneMTB.Text = user.Telephone.ToString();
            AdminCheckBox.Checked = user.Admin;
            OnlineTextBox.Text = user.ip;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            User userj = new User();
            userj.UserId = UserIdTextBox.Text;
            if (MessageBox.Show("Do you want to delete user " + userj.UserId + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                newConnection.deleteRow(userj.UserId);
                Edit_Load(this, e);
                PrevButton.PerformClick();
                NextButton.PerformClick();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to cancel your edit ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UserIdTextBox.Enabled = false;
                FirstNameTextBox.Enabled = false;
                LastNameTextBox.Enabled = false;
                UpdateButton.Enabled = false;
                CancelButton.Enabled = false;
                FindButton.Enabled = true;
                AddButton.Enabled = false;
                CloseButton.Enabled = true;
                NewButton.Enabled = true;
                DeleteButton.Enabled = true;
                AddButton.Enabled = false;
                PrevButton.PerformClick();
                NextButton.PerformClick();
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            UserIdTextBox.Enabled = true;
            FirstNameTextBox.Enabled = true;
            LastNameTextBox.Enabled = true;
            UserIdTextBox.Text = "";
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            TelephoneMTB.Text = "";
            AdminCheckBox.Checked = false;
            OnlineTextBox.Text = "";
            OnlineTextBox.Enabled = false;
            UpdateButton.Enabled = false;
            CancelButton.Enabled = true;
            FindButton.Enabled = false;
            AddButton.Enabled = true;
            CloseButton.Enabled = false;
            NewButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if(UserIdTextBox.Text==""||TelephoneMTB.Text==""||FirstNameTextBox.Text==""||LastNameTextBox.Text=="")
            {
                MessageBox.Show("Fields cannot be Null", "Warning !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                User userj = new User();
                userj.UserId = UserIdTextBox.Text;
                userj.Telephone = Int32.Parse(TelephoneMTB.Text);
                userj.Admin = AdminCheckBox.Checked;
                userj.Last_Name = LastNameTextBox.Text;
                userj.First_Name = FirstNameTextBox.Text;
                userj.Password = "00000";
                if (MessageBox.Show("Do you want to add user " + userj.UserId + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    newConnection.addRow(userj);
                    Edit_Load(this, e);
                    PrevButton.PerformClick();
                    NextButton.PerformClick();
                }
            }          
        }

        private void TelephoneMTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpdateButton.Enabled = true;
            CancelButton.Enabled = true;
            FindButton.Enabled = false;
            AddButton.Enabled = true;
            CloseButton.Enabled = false;
            NewButton.Enabled = false;
            DeleteButton.Enabled = false;
        }

        private void AdminCheckBox_Click(object sender, EventArgs e)
        {
            UpdateButton.Enabled = true;
            CancelButton.Enabled = true;
            FindButton.Enabled = false;
            AddButton.Enabled = true;
            CloseButton.Enabled = false;
            NewButton.Enabled = false;
            DeleteButton.Enabled = false;
        }
    }
}
