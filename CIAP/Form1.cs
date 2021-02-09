using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //throw new System.NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image img = Clipboard.GetImage();
            Guid uuid = Guid.NewGuid();
            if (img != null)
            {
                ImageFormat fmt = ImageFormat.Png;
                try
                {
                    img.Save(textBox1.Text + @"/" + uuid.ToString() + ".png", fmt);
                    MessageBox.Show("正しく保存されました", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (Exception exception)
                {
                    MessageBox.Show("正しいパスが入力されていないか、画像がクリップボードに存在しません", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine(exception);
                    //throw;
                }
            }
            //throw new System.NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog
            {
                Description = "フォルダを選択してください",
                RootFolder = Environment.SpecialFolder.Desktop,
                SelectedPath = @"C:\Windows",
                ShowNewFolderButton = true
            };
            if (fbd.ShowDialog((this)) == DialogResult.OK)
            {
                textBox1.Text = fbd.SelectedPath;
            }
            //throw new System.NotImplementedException();
        }
    }
}
