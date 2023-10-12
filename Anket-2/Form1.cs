using Anket_2.Models;

using Newtonsoft.Json;
namespace Anket_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Anket_Enter(object sender, EventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
        
            if (!string.IsNullOrEmpty(adtxt.Text)&& !string.IsNullOrEmpty(soyadtxt.Text) &&
                !string.IsNullOrEmpty(emailtxt.Text) && !string.IsNullOrEmpty(telefontxt.Text) && !string.IsNullOrEmpty(dogumtxt.Text) )
            {

                Person p = new Person(adtxt.Text,soyadtxt.Text,emailtxt.Text,telefontxt.Text,dogumtxt.Text);
                error.Visible = false;
                listBox1.Items.Add(p);
                adtxt.Text = "";
                soyadtxt.Text = "";
                emailtxt.Text = "";
                telefontxt.Text = "";
                dogumtxt.Text = "";
            }
        
            else
            {
                error.Text = "Bos buraxmaq olmaz!";
                error.Visible = true;
            }
        }

        private void btn_save_file_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                if (!string.IsNullOrEmpty(filename.Text))
                {
                    string fileName = "../../../" + filename.Text;
                    string json = JsonConvert.SerializeObject(listBox1.Items, Formatting.Indented);
                    File.WriteAllText(fileName, json);
                }

                else
                {
                    error2.Text = "Filename is empty!";
                    error2.Visible = true;
                }
            }
            else {
                error2.Text = "List is empty!";
                error2.Visible = true;
            }
        }

        private void filename_TextChanged(object sender, EventArgs e)
        {
            error2.Visible = false;
        }

        private void btn_load_file_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "C:\\Users\\ROG\\source\\repos\\Anket-2\\Anket-2";
                var netice = openFileDialog1.ShowDialog();
                if (netice == DialogResult.OK)
                {
                    string fileName = openFileDialog1.FileName;
                    if (File.Exists(fileName))
                    {
                        string json = File.ReadAllText(fileName);
                            List<Person>list = JsonConvert.DeserializeObject<List<Person>>(json);
                    foreach (var item in list)
                    {
                        listBox1.Items.Add(item);
                    }
                    filename.Text= openFileDialog1.SafeFileName;

                    }
                }
            
               
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {

                
                if (listBox1.SelectedItem is Person person)
                {
                    adtxt.Text = person._ad;
                    soyadtxt.Text = person._soyad;
                    emailtxt.Text = person._email;
                    telefontxt.Text = person._telefon;
                    dogumtxt.Text = person._dogum;
                    deyis.Visible = true;
                    btn_save.Visible = false;
                }
                else
                {
                    
                }
            }
            else
            {
              
            }
        }

        private void deyis_Click(object sender, EventArgs e)
        {
            if ( !string.IsNullOrEmpty(adtxt.Text) && !string.IsNullOrEmpty(soyadtxt.Text) &&
            !string.IsNullOrEmpty(emailtxt.Text) && !string.IsNullOrEmpty(telefontxt.Text) && !string.IsNullOrEmpty(dogumtxt.Text))
            {

                Person p = new Person(adtxt.Text, soyadtxt.Text, emailtxt.Text, telefontxt.Text, dogumtxt.Text);
                error.Visible = false;
                listBox1.Items[listBox1.SelectedIndex] = p;
                listBox1.SelectedIndex = -1;
                adtxt.Text = "";
                soyadtxt.Text = "";
                emailtxt.Text = "";
                telefontxt.Text = "";
                dogumtxt.Text = "";

                
                btn_save.Visible = true;
                deyis.Visible=false;
              
            }
        }

      
    }
}