using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1
{
    public partial class Form1 : Form
    {
        String alphabet = "abcdefghijklmnopqrstuvwxyz1234567890 !@#$%^&*()_+=-<>.,`~\"\'|\\/?";
        //String revhabet = "@#$%^&*()_+=-<>.,`~\"\'|\\/?qwertyuiopasdfghjklzxcvbnm 0987654321!";
        String revhabet;
        String normallyT;
        String encodeT;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            revhabet = genKey(alphabet);
            keyBox.Text = revhabet;
            textBox1.ScrollBars = ScrollBars.Vertical;
            encodeTextBox2.ScrollBars = ScrollBars.Vertical;
        }

        public static string getStep(string t)
        {
            //
            return t.Substring(1, t.Length - 1) + t.Substring(0, 1);
        }
        
        private string enigma(String text, String outside, String inside)
        {
            String outText = "";
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < outside.Length; j++)
                {
                    Console.WriteLine(text.Length);
                    if (text[i] == outside[j])
                    {
                        outText += inside[j];
                        //inside = getStep(inside);
                        break;
                    }
                }
            }
            return outText;
        }

        private string genKey(String str)
        {
            char[] array = str.ToCharArray();
            Random rng = new Random();
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                var value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
            return new string(array);
        }

        private void encode_Click(object sender, EventArgs e)
        {   
            if (checkBox1.Checked == true)
            {
                //text from file
            }
            normallyT = textBox1.Text.ToLower();
            encodeTextBox2.Text = enigma(normallyT, alphabet, revhabet);
        }

        private void decode_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                //text from file
            }
            encodeT = encodeTextBox2.Text;
            textBox1.Text = enigma(encodeT, revhabet, alphabet);
        }

        private void clear_click(object sender, EventArgs e)
        {
            textBox1.Clear();
            encodeTextBox2.Clear();
            //OpenFileDialog ofd = new OpenFileDialog();
            //if (ofd.ShowDialog() == DialogResult.Cancel)
            //    return;
            //MessageBox.Show(ofd.FileName.Replace(".txt", "Decoded.txt"));
            //revhabet = getStep(revhabet);
            //MessageBox.Show(revhabet);   
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked == true)
            {
                keyBox.Visible = true;
                setKeyBt.Visible = true;
            }
            else
            {
                keyBox.Visible = false;
                setKeyBt.Visible = false;
            }
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            statusLb.Text = "Loading";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            textBox1.Text = System.IO.File.ReadAllText(ofd.FileName);
            encodeT = textBox1.Text.ToLower();
            normallyT = enigma(encodeT, alphabet, revhabet);
            encodeTextBox2.Text = normallyT;
            //ofd.FileName.Replace(".txt", "Decoded.txt");
            
            statusLb.Text = "Complete";
        }

        private void loadEncodeFile_Click(object sender, EventArgs e)
        {
            statusLb.Text = "Loading";
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.Cancel)
                return;
            encodeTextBox2.Text = System.IO.File.ReadAllText(ofd.FileName);
            normallyT = encodeTextBox2.Text;
            encodeT = enigma(normallyT, revhabet, alphabet);
            textBox1.Text = encodeT;
            
            statusLb.Text = "Complete";
        }

        private void setKeyBt_Click(object sender, EventArgs e)
        {
            if (keyBox.Text == "")
            {
                keyBox.Text = genKey(alphabet);
                revhabet = keyBox.Text;
                statusLb.Text = "Key generated";
            } else
            {
                revhabet = keyBox.Text;
                statusLb.Text = "Key set";
            }
        }

        private void saveTxtBt_MouseClick(object sender, MouseEventArgs e)
        {
            if (String.IsNullOrEmpty(normallyT))
            {
                normallyT = textBox1.Text;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            System.IO.File.WriteAllText(saveFileDialog.FileName, normallyT);
        }

        private void saveEncodeBt_MouseClick(object sender, MouseEventArgs e)
        {
            if (String.IsNullOrEmpty(encodeT))
            {
                encodeT = encodeTextBox2.Text;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            System.IO.File.WriteAllText(saveFileDialog.FileName, encodeT);
        }
    }
}
