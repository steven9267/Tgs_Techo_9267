using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace steven
{
    public partial class Login : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;Database=170709267;Uid=root;");
        MySqlDataAdapter adapter;
        DataTable table = new DataTable();

        public static string namaakun;
        public Login()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                passwordbox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordbox.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(link.Text == "Register")
            {
                nama.Visible = namebox.Visible = true;
                nama.Location = new Point(40, 195);
                namebox.Location = new Point(144, 192);
                username.Location = new Point(40, 221);
                usernamebox.Location = new Point(144, 221);
                password.Location = new Point(40, 247);
                passwordbox.Location = new Point(144, 247);
                btnLogin.Text = "Register";
                rekomendasilogin.Text = "Already have an account?";
                link.Text = "Login";
            }
            else
            {
                nama.Visible = namebox.Visible = false;
                username.Location = new Point(40, 199);
                usernamebox.Location = new Point(144, 199);
                password.Location = new Point(40, 247);
                passwordbox.Location = new Point(144, 247);
                btnLogin.Text = "Login";
                rekomendasilogin.Text = "Didn't have any account?";
                link.Text = "Register";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (btnLogin.Text == "Login")
            {
                adapter = new MySqlDataAdapter("SELECT `Username`, `Password`, `Nama` FROM `login` WHERE `Username` = '" + usernamebox.Text + "' AND `Password` = '" + passwordbox.Text + "'", connection);
                adapter.Fill(table);

                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("Username and Password incorrect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Login.namaakun = table.Rows[0]["Nama"].ToString();
                    MessageBox.Show("Login Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Form2 hm = new Form2();
                    hm.Show();
                }
                table.Clear();
            }
            else if (btnLogin.Text == "Register")
            {
                string insertQuery = "INSERT INTO login(Nama,Username,Password) VALUES('"+namebox.Text+"','"+usernamebox.Text+"','"+passwordbox.Text+"')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Data Not Inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();
            }
        }
    }
}
