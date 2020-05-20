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
    public partial class ModifyForm : Form
    {
        private int id;
        private string fileName, path, extension, description, place, events,category;
        private DateTime createTime;

        private void submitBtn_Click(object sender, EventArgs e)
        {
            ServiceClient myApi = new ServiceClient();
            string people = String.Join(",", listBox1.Items.Cast<string>().ToList());
            myApi.modifyPhoto(id, nameBox.Text, placeBox.Text, people, descriptionBox.Text, eventBox.Text, categoryBox.Text, createTime, pathBox.Text);
            MessageBox.Show("Successfully modified!", "Congratulations");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Photos|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|Movie|*.avi;*.mp4;*.mkv;*.m4v";
            DialogResult openfileStatus = openFileDialog1.ShowDialog();
            if (openfileStatus == DialogResult.OK)
            {
                pathBox.Text = openFileDialog1.FileName;
                createTime = File.GetCreationTime(pathBox.Text);
                createBox.Text = createTime.ToString();
                extensionBox.Text = Path.GetExtension(pathBox.Text);

            }
        }

        private ServiceClient apiClass;
        public ModifyForm(MyPhotoTable myPhotoTable)
        {
            InitializeComponent();
            apiClass = new ServiceClient();
            id = myPhotoTable.Id;
            path = pathBox.Text = myPhotoTable.Path;
            extension = extensionBox.Text = Path.GetExtension(path);
            createTime = File.GetCreationTime(path);
            createBox.Text = createTime.ToString();
            fileName = nameBox.Text = myPhotoTable.Name;
            description = descriptionBox.Text = myPhotoTable.Description;
            place = placeBox.Text = myPhotoTable.Place;
            events = eventBox.Text = myPhotoTable.Event;
            category = categoryBox.Text = myPhotoTable.Category;
            var people = myPhotoTable.Person.Split(',').ToList();
            
            foreach (string person in people)
                if(!string.IsNullOrWhiteSpace(person))
                listBox1.Items.Add(person);


        }

        private void ModifyForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(comboBox1.Text))
            {
                MessageBox.Show("Please make a selection from ComboBox!", "Invalid!",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                {
                switch (comboBox1.Text)
                {
          
                    case "Name":
                        nameBox.Text = setBox.Text;
                        setBox.Text = "";
                        break;

                    case "Place":
                        placeBox.Text = setBox.Text;
                        setBox.Text = "";
                        break;
                    case "Event":
                        eventBox.Text = setBox.Text;
                        setBox.Text = "";
                        break;
                    case "Category":
                        categoryBox.Text = setBox.Text;
                        setBox.Text = "";
                        break;
                }
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

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(addBox.Text))
            {
                listBox1.Items.Add(addBox.Text);
                addBox.Text = "";
            }
        }
    }
}
