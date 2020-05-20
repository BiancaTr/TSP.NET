using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PhotosInterface
{
    public partial class MainForm : Form
    {
        private ServiceClient myApi = new ServiceClient();

        public MainForm()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            var data = myApi.GetAllInfo();

            dataGridView1.DataSource = data.Select(itm => new
            {
                ID = itm.Id,
                Nume = itm.Name,
                Description = itm.Description,
                Category = itm.Category,
                Place = itm.Place,
                Person = itm.Person,
                Date = itm.Create_Date,
                Path = itm.Path
            }).ToList();

            
            openFiles.Filter = "Photos|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|Movie|*.avi;*.mp4;*.mkv;*.m4v";
            modifyPath.Filter = "Photos|*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff|Movie|*.avi;*.mp4;*.mkv;*.m4v";
            openFiles.Multiselect = true;

        }


        private void max_one_check(object sender, ItemCheckEventArgs e)
        {
            for (int index = 0; index < checkedListBox1.Items.Count; ++index)
                if (index != e.Index) 
                    checkedListBox1.SetItemChecked(index, false);
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            DialogResult openfileStatus = openFiles.ShowDialog();
            if (openfileStatus == DialogResult.OK)
            {
                showAddForm(openFiles.FileNames);
            }
        }

        private void OnlyOneCheckAllowed(object sender, ItemCheckEventArgs e)
        {
           
                for (int index = 0; index < checkedListBox1.Items.Count; index++)
                    if (index != e.Index) 
                        checkedListBox1.SetItemChecked(index, false);
            
        }

        private void openbtn_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                    
                int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                string path = dataGridView1.SelectedCells[7].Value.ToString();

                if (File.Exists(path))
                {
                    Process.Start(path);
                }
                else
                    pathError(id);
            }
        }

        private bool messagePopOut(string message, string title)
        {
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                return true;
            return false;
        }

        private void showAddForm(string[] fileNames)
        {
            
            for(int i = 0; i < fileNames.Length; i++)
            {
                AddForm addForm = new AddForm(fileNames[i]);
                addForm.ShowDialog();
                

                var data = myApi.GetAllInfo();

                dataGridView1.DataSource = data.Select(itm => new
                {
                    ID = itm.Id,
                    Nume = itm.Name,
                    Description = itm.Description,
                    Category = itm.Category,
                    Place = itm.Place,
                    Person = itm.Person,
                    Date = itm.Create_Date,
                    Path = itm.Path
                }).ToList();

            }
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            bool result = messagePopOut("Are you sure you want to delete this?", "Delete photo");
            if (result) 
            {
                if (File.Exists(dataGridView1.SelectedCells[7].Value.ToString()))
                {
                    int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                    myApi.deletePhotoById(id);
                    var data = myApi.GetAllInfo();

                    dataGridView1.DataSource = data.Select(itm => new
                    {
                        ID = itm.Id,
                        Nume = itm.Name,
                        Description = itm.Description,
                        Category = itm.Category,
                        Place = itm.Place,
                        Person = itm.Person,
                        Date = itm.Create_Date,
                        Path = itm.Path
                    }).ToList();

                }
            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            ServiceClient myApi = new ServiceClient();
            if(string.IsNullOrWhiteSpace(searchBox.Text) || checkedListBox1.SelectedItems.Count == 0)
                dataGridView1.DataSource = myApi.GetAllInfo();
            else
            {
                string searchBy = checkedListBox1.SelectedItem.ToString();
               


                var data = myApi.GetInfoBySomething(searchBy, searchBox.Text);

                dataGridView1.DataSource = data.Select(itm => new
                {
                    ID = itm.Id,
                    Nume = itm.Name,
                    Description = itm.Description,
                    Category = itm.Category,
                    Place = itm.Place,
                    Person = itm.Person,
                    Date = itm.Create_Date,
                    Path = itm.Path
                }).ToList();

            }

        }

        private void modifybtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

                int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
                string path = dataGridView1.SelectedCells[7].Value.ToString();

                if (File.Exists(path))
                {
                    ServiceClient apiClass = new ServiceClient();
                    ModifyForm modifyForm = new ModifyForm(apiClass.getInfoById(id));
                    modifyForm.ShowDialog();
                    
                }
                else
                    pathError(id);

            }
            ServiceClient api = new ServiceClient();

            var data = api.GetAllInfo();

            dataGridView1.DataSource = data.Select(itm => new
            {
                ID = itm.Id,
                Nume = itm.Name,
                Description = itm.Description,
                Category = itm.Category,
                Place = itm.Place,
                Person = itm.Person,
                Date = itm.Create_Date,
                Path = itm.Path
            }).ToList();

        }

        private void previewbtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            string path = dataGridView1.SelectedCells[7].Value.ToString();
            string extension = Path.GetExtension(path);
            if (File.Exists(path))
            {
                if ("*.bmp;*.jpg;*.jpeg;*.png;*.tif;*.tiff".Contains(extension)) 
                {
                    pictureBox1.Image = new Bitmap(path);
                    axWindowsMediaPlayer1.URL = "";
                }
                else
                {
                    pictureBox1.Image = PhotosInterface.Properties.Resources.mycameraphoto;
                    axWindowsMediaPlayer1.URL = path;
                }

            }
            else
                pathError(id);

        }

        private void pathError(int id)
        {
            bool result = messagePopOut("Fisierul lipseste! Doresti sa alegi din nou path-ul?", "Eroare!");
            if (result)
            {
                DialogResult openfileStatus = modifyPath.ShowDialog();
                if (openfileStatus == DialogResult.OK)
                {
                    myApi.modifyPath(id, modifyPath.FileName);
                }
            }

            else
            {
                myApi.deletePhoto(myApi.getInfoById(id));
            }

            var data = myApi.GetAllInfo();

            dataGridView1.DataSource = data.Select(itm => new
            {
                ID = itm.Id,
                Nume = itm.Name,
                Description = itm.Description,
                Category = itm.Category,
                Place = itm.Place,
                Person = itm.Person,
                Date = itm.Create_Date,
                Path = itm.Path
            }).ToList();
        }
    }
}
