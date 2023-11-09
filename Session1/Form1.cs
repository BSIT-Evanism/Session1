using MySql.Data.MySqlClient;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Session1
{
    public partial class Form1 : Form
    {
        Connection con = new Connection();
        public string? id, username, password, firstname, lastname, address;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void text_employee_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void check_password_CheckedChanged(object sender, EventArgs e)
        {
            if (check_password.Checked)
            {
                text_password.PasswordChar = '\0';
            }
            else
            {
                text_password.PasswordChar = '*';
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                if (text_user.Text != "" && text_password.Text != "")
                {
                    con.Open();
                    string query = "select UserTypeID,Username,Password,FullName from users WHERE Username ='" + text_user.Text + "' AND Password ='" + text_password.Text + "'";
                    MySqlDataReader row;
                    row = con.ExecuteReader(query);

                    if (row.HasRows)
                    {
                        while (row.Read())
                        {
                            id = row["UserTypeID"].ToString();
                            username = row["Username"].ToString();
                            password = row["Password"].ToString();
                            firstname = row["FullName"].ToString();
                            
                        }
                        MessageBox.Show("Welcome");
                        this.Hide();
                        Form2 f2 = new Form2();
                        f2.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Data not found", "Information");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password is empty", "Information");
                }
            }
            catch
            {
                MessageBox.Show("Connection Error", "Information");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}