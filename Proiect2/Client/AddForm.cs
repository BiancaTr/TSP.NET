using PhotosAPI;
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

namespace PhotosInterface
{
    public partial class AddForm : Form
    {
        private string fileName,path,extension;
        private DateTime createTime;
        private ServiceClient myApi = new ServiceClient();

        public AddForm(string v)
        {
            InitializeComponent();
            path = pathBox.Text = v;
            pathBox.ReadOnly = true;
            extension = extensionLabel.Text = Path.GetExtension(v);
            createTime = File.GetCreationTime(v);
            createLabel.Text = createTime.ToString();
            fileName = Path.GetFileName(v);

        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(addBox.Text))
            {
                listBox1.Items.Add(addBox.Text);
                addBox.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(removeBox.Text))
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                    if (listBox1.Items[i].ToString() == removeBox.Text)
                        listBox1.Items.RemoveAt(i);
                removeBox.Text = "";
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string people = String.Join(",", listBox1.Items.Cast<string>().ToList());

            if (string.IsNullOrWhiteSpace(nameBox.Text))
                myApi.submitPhoto(fileName, placeBox.Text, people, descriptionBox.Text,eventBox.Text,categoryBox.Text,createTime,path);
            else
                myApi.submitPhoto(nameBox.Text, placeBox.Text, people, descriptionBox.Text, eventBox.Text, categoryBox.Text, createTime, path);

            this.Close();
        }
    }
}
