using MySql.Data.MySqlClient;
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

namespace LoginForm_CSharp.Views
{
    public partial class DashboardForm : Form
    {
        private readonly string username;
        private readonly MySqlConnection connection;
        public DashboardForm(string username)
        {
            InitializeComponent();
            this.username = username;
            connection = new MySqlConnection("server=localhost;database=csharploginform;port=3306;username=root;password=");
            DisplayProfile();
        }

        private void DisplayProfile()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM users WHERE Username = @Username";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        DFirstName.Text = reader["FirstName"].ToString();
                        DLastName.Text = reader["LastName"].ToString();
                        DUserName.Text = reader["Username"].ToString();
                        DOccupation.Text = reader["Occupation"].ToString();

                        if (reader["ProfilePicture"] != DBNull.Value)
                        {
                            byte[] img = (byte[])reader["ProfilePicture"];
                            using (MemoryStream ms = new MemoryStream(img))
                            {
                                ProfilePic.Image = Image.FromStream(ms);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Profile Picture Found");
                            this.Close();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
            
        } 
        
        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap resizedImage = new Bitmap(width, height);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, width, height);
            }
            return resizedImage;
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
