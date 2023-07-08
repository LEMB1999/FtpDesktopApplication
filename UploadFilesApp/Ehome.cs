using System.Net;
using System.Windows.Forms;

namespace UploadFilesApp
{
    public partial class Ehome : Form
    {
        public Ehome()
        {
            InitializeComponent();
        }

        private void Ehome_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog{
                Title = "Select File to upload to Server"
            };
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string user = "user";
                    string password = "mypass";
                    string to = $"ftp://127.0.0.1:21/{ofd.SafeFileName}";
                    //Read File and Upload to Server using FTP
                    using (WebClient client = new WebClient())
                    {
                        client.Credentials = new NetworkCredential(user, password);
                        client.UploadFile(to, WebRequestMethods.Ftp.UploadFile, ofd.FileName);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error to upload File", "Error");


                }

            }
            
        }
    }
}