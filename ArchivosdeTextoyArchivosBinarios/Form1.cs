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

namespace ArchivosdeTextoyArchivosBinarios
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

        private void btnCrear_Click(object sender, EventArgs e)
        {
            XmlDocument();
        }

        void XmlDocument ()
        {
            sfdWindowSave.Filter = "XML-File|*.xml";
            sfdWindowSave.ShowDialog();
            
            FileStream fs = new FileStream(sfdWindowSave.FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            
            string datos= "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n\r"
                           +"<Datos>"
                           +"<name>"+txtFactName.Text+"</name>"
                           +"<number>"+txtFactNumber.Text+"</number>"
                           +"<address>"+txtFactAddress.Text+"</address>"
                           +"<color>"+txtFactColor.Text+"</color>"
                           +"<pet>"+txtFactPet.Text+"</pet>"
                           +"</Datos>";
            sw.Write (datos);

            sw.Close();
            fs.Close();
            txtFactAddress.Text = "";
            txtFactName.Text = "";
            txtFactPet.Text = "";
            txtFactNumber.Text = "";
            txtFactColor.Text = "";
            MessageBox.Show("El archivo XML a sido creado");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BitMap();
        }

        void BitMap()
        {
            txtResultadobmp.Text = "";
            ofdBitmap.ShowDialog();
            
            FileStream fs = 
                new FileStream(ofdBitmap.FileName,FileMode.Open);
            BinaryReader br = new BinaryReader(fs);

            char b = br.ReadChar();
            char m = br.ReadChar();

            if (b != 60 && m != 77)
            {
                MessageBox.Show("El tipo de formato no es .bmp");
                br.Close();
                fs.Close();
            }
            else
            {
                int size = br.ReadInt32();
                ulong trash = br.ReadUInt64();
                int trash2 = br.ReadInt32();

                int width = br.ReadInt32();
                int heigth = br.ReadInt32();

                int trash3 = br.ReadInt16();

                int pixelsize = br.ReadInt16();

                txtResultadobmp.Text = "Tamño del bit map {"+size.ToString()+"}\r\nTamaño de la anchura {"+width.ToString()+ "}\r\nTamaño de la altura {" + heigth.ToString()+ "}\r\ntotal de piexeles en la imagen {" + pixelsize.ToString()+"}";
                br.Close();
                fs.Close();

            }

        }
    }
}
