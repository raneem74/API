using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormAPIConsumer
{
    public partial class Form1 : Form
    {
        HttpClient client ;
        public Form1()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri( "https://localhost:7288/api/" );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            HttpResponseMessage response = client.GetAsync("Instructors").Result;
            if (response.IsSuccessStatusCode)
            {
                List<Instructor> instructors = response.Content.ReadAsAsync<List<Instructor>>().Result;
                InstructorsGridView.DataSource = instructors;
                insComboBox.DataSource = instructors;
                insComboBox.DisplayMember = "Name";
                insComboBox.ValueMember = "Id";
            }
            else
            {
                MessageBox.Show("Error");
            }
            HttpResponseMessage Deptresponse = client.GetAsync("Departments").Result;
            if (Deptresponse.IsSuccessStatusCode)
            {
                List<Department> deps = Deptresponse.Content.ReadAsAsync<List<Department>>().Result;
                Deptcbx.DataSource = deps;
                Deptcbx.DisplayMember = "Name";
                Deptcbx.ValueMember = "Id";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            Instructor ins = new Instructor()
            {
                Name = Nametxt.Text,
                SSN = SSNtxt.Text,
                Address = Adresstxt.Text,
                Age = int.Parse(agetxt.Text),
                Phone = phonetxt.Text,
                Email = Emailtxt.Text,
                Password = Passwordtx.Text,
                Salary = double.Parse(Salarytxt.Text),
                //DOB = DateTime.Parse( DateTime.Parse(DOBtxt.Text).ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffZ") ),
                DOB = DateTime.Parse(dateTimePicker1.Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffZ") ),
                DepartmentId = (int)Deptcbx.SelectedValue
            };

            HttpResponseMessage postResponse = client.PostAsJsonAsync("Instructors", ins).Result;
            if (postResponse.IsSuccessStatusCode)
            {
                Form1_Load(null, null);
            }
            else
            {
                MessageBox.Show($"Error{postResponse.StatusCode}");
            }
        }

        private void InstructorsGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete?", "confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int id = (int)InstructorsGridView.SelectedRows[0].Cells[0].Value;
                HttpResponseMessage delResponse = client.DeleteAsync($"Instructors/{id}").Result;
                if (delResponse.IsSuccessStatusCode)
                {
                    Form1_Load(null, null);
                }
                else
                {
                    MessageBox.Show($"Error{delResponse.StatusCode}");
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void insComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = insComboBox.SelectedValue;
            HttpResponseMessage response = client.GetAsync($"Instructors/{id}").Result;
            if (response.IsSuccessStatusCode)
            {
                Instructor ins = response.Content.ReadAsAsync<Instructor>().Result;
                Nametxt.Text = ins.Name;
                SSNtxt.Text = ins.SSN;
                Adresstxt.Text = ins.Address;
                agetxt.Text = ins.Age.ToString();
                phonetxt.Text = ins.Phone.ToString();
                Emailtxt.Text = ins.Email;
                Passwordtx.Text = ins.Password;
                Salarytxt.Text = ins.Salary.ToString();
                dateTimePicker1.Value = ins.DOB;
                Deptcbx.SelectedValue = ins.DepartmentId;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var id = insComboBox.SelectedValue;

            Instructor ins = new Instructor()
            {
                Id = (int)id,
                Name = Nametxt.Text,
                SSN = SSNtxt.Text,
                Address = Adresstxt.Text,
                Age = int.Parse(agetxt.Text),
                Phone = phonetxt.Text,
                Email = Emailtxt.Text,
                Password = Passwordtx.Text,
                Salary = double.Parse(Salarytxt.Text),
                DOB = DateTime.Parse(dateTimePicker1.Value.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ss.fffZ")),
                DepartmentId = (int)Deptcbx.SelectedValue
            };

            HttpResponseMessage putResponse = client.PutAsJsonAsync($"Instructors/{id}", ins).Result;
            if (putResponse.IsSuccessStatusCode)
            {
                Form1_Load(null, null);
            }
            else
            {
                MessageBox.Show($"Error{putResponse.StatusCode}");
            }
        }
    }

}
