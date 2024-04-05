
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm_CSharp.Views;
using MySqlConnector;


namespace LoginForm_CSharp
{
    public partial class RegisterForm : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=csharploginform;port=3306;username=root;password=");
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void GotoToLoginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(RegFirtsNameText.Text) || string.IsNullOrEmpty(RegLastNameText.Text) || string.IsNullOrEmpty(RegUsernameText.Text) || string.IsNullOrEmpty(RegOccuText.Text) || string.IsNullOrEmpty(RegPasswordText.Text))
                {
                    MessageBox.Show("Please Fill The All Information");
                    return;
                }
                connection.Open();
                MySqlCommand mySqlCommand1 = new MySqlCommand("SELECT * FROM users WHERE Username = @Username", connection);
                mySqlCommand1.Parameters.AddWithValue("@Username", RegUsernameText.Text);
                bool userExists = false;

                using (var dr1 = mySqlCommand1.ExecuteReader())
                    if (userExists = dr1.HasRows) MessageBox.Show("Username Allready Exist");

                if (!userExists)
                {
                    string iquery = "INSERT INTO csharploginform.users(`ID`, `FirstName`, `LastName`, `Username`, `Occupation`, `Password`, `ProfilePicture`) VALUES(NULL,@FirstName, @LastName,@Username, @Occupation, @Password, @ProfilePicture)";
                    MySqlCommand commandDatabase = new MySqlCommand(iquery, connection);
                    commandDatabase.Parameters.AddWithValue("@FirstName", RegFirtsNameText.Text);
                    commandDatabase.Parameters.AddWithValue("@LastName", RegLastNameText.Text);
                    commandDatabase.Parameters.AddWithValue("@Username", RegUsernameText.Text);
                    commandDatabase.Parameters.AddWithValue("@Occupation", RegOccuText.Text);
                    commandDatabase.Parameters.AddWithValue("@Password", RegPasswordText.Text);

                    if (RegProPicButton.Image != null)
                    {
                        byte[] imageData = ImageToByteArray(RegProPicButton.Image);
                        commandDatabase.Parameters.AddWithValue("@ProfilePicture", imageData);
                    }
                    else
                    {
                        commandDatabase.Parameters.AddWithValue("@ProfilePicture", DBNull.Value);
                    }


                    commandDatabase.CommandTimeout = 60;
                    commandDatabase.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    string LoggedUserName = RegUsernameText.Text;
                    DashboardForm dashboardForm = new DashboardForm(LoggedUserName);
                    dashboardForm.Show(); ;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An Error" + ex.Message, "Error");
            }
            finally
            {
                connection.Close();
            }
        }



        private void RegProPicButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files|*jpg;*jpeg;*png";
            fileDialog.Title = "Select an Image File";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                RegProPicButton.Image = new Bitmap(fileDialog.FileName);
            } 
        }

        private byte[] ImageToByteArray(Image image)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(image, typeof(byte[]));
        }
    }
}
