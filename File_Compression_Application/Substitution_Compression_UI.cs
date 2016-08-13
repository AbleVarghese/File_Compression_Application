using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace File_Compression_Application
{
    public partial class Substitution_Compression_UI : Form
    {

        public string _filePath;

        public Substitution_Compression_UI()
        {
            InitializeComponent();
        }



        public void button1_Click(object sender, EventArgs e)
        {
            var FileDialog = new System.Windows.Forms.OpenFileDialog();
            if (FileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string OpenThisFile = FileDialog.FileName;

              //  FileInfo File = new FileInfo(FileDialog.FileName);
               

            //Use this line to read from the file that is selected using the browse button, 
                StreamReader reader = new StreamReader(OpenThisFile);
               

                this._filePath = filePath.Text = FileDialog.FileName;

         //Copy the 2 lines below to get the file path of the file in any other class
            //   FormObj = new Substitution_Compression_UI();
             //   Console.WriteLine(FormObj._filePath);
            
                
            }
        }




    }
}
