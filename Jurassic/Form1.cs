using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jurassic
{
    public partial class Form1 : Form
    {
        // Jura_204000,279000
        //3000_3000    68_93
        private string local_patch_set_3000px = "set\\"; //C:\\Geoportal_ortofoto_3000px1000m\\Jura
       // private string local_patch_set_150px = "C:\\Geoportal_ortofoto_3000px1000m\\Jura\\set_150px_150px\\";
        private string local_patch_set_30px = "set_30px_30px\\"; //C:\\Geoportal_ortofoto_3000px1000m\\Jura

        //        xmin  497570 
        //ymax336711
        //xmax565570 
        //ymin245711 
        private long XMIN = 497570;
        private long XMAX = 565570;
        private long YMIN = 245711;
        private long YMAX = 336711;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label_xmax.Text = XMAX.ToString() +" [m]";
            label_xmin.Text = XMIN.ToString() + " [m]";
            label_ymin.Text = YMIN.ToString() + " [m]";
            label_ymax.Text = YMAX.ToString() + " [m]";
            



            for (int i = 1; i < 68; i++)
            { 
                    //DataGridViewColumn col = new DataGridViewTextBoxColumn();
                   // col.Name = (498570 + (i - 1) * 1000).ToString();
                DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();

                imageColumn.Name = (498570 + (i - 1) * 1000).ToString();
                imageColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

                 this.data_mapa.Columns.Add(imageColumn);

                   
            }



            for (int i = 0; i < 93; i++)
            {
                this.data_mapa.Rows.Add();
                this.data_mapa.Rows[i].HeaderCell.Value = (336711 - (i) * 1000).ToString();
               
            }

            
           for (int i = 0; i < 93; i++)
            {
                
                for (int j = 0; j < 68; j++)
                {
                    string plik = "Jura_" + (j * 3000).ToString() + "_" + (i * 3000).ToString() + ".jpg";


                    this.data_mapa.Rows[i].Cells[j].Value = Image.FromFile(local_patch_set_30px + plik);
                    


                }
             
            }

                    

        }

        private void wyswietl_fragment(long row, long col)
        {
            Form2 f = new Form2();
                f.pictureBox1.ImageLocation = local_patch_set_3000px + "Jura_" + (col * 3000).ToString() + "_" + (row * 3000).ToString() + ".jpg";
                f.Text += " : " + row.ToString() + ", " + col.ToString() + ", UTM: " + (col * 1000+XMIN).ToString() + "m, " + (YMAX-row * 1000).ToString()+"m ";
            f.Show();
        }

        private void data_mapa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            wyswietl_fragment(e.RowIndex, e.ColumnIndex);         
        }

        private void button_wyswietlregion_Click(object sender, EventArgs e)
        {
             long UsrX=0;
             long UsrY=0;

               try{
                 UsrX=Int64.Parse(textBox_X.Text );  
                 UsrY=Int64.Parse(textBox_Y.Text );


                     if ((UsrX <= XMAX && UsrX >= XMIN && UsrY <= YMAX && UsrY >= YMIN))
                     {
                      
                         wyswietl_fragment(  (UsrX - XMIN) % 1000,  (UsrY - YMIN) % 1000);

                     }

                }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' or '{1} is out of range of a 32-bit integer.", UsrX, UsrY);
            }
            catch (FormatException)
            {
                Console.WriteLine("The format of '{0}' or '{1}' is invalid.", UsrX, UsrY);
            }
             
        }

 









    }
}
