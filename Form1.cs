using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary
{
    public partial class Form1 : Form
    {
        string path = string.Empty;
        List<string> WordsList; // Список слов
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            ReadFile();
        }
        private void ReadFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; // Фильтр типа файлов
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }
            if (!path.Equals(string.Empty)) // Если пользователь выбрал какой-то файл, то заполняем список
            {
                WordsList = FSWork.ReadToListOfString(path);
            }
        }
    }
}
