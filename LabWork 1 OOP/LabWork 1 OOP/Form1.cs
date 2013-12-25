using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork_1_OOP
{
    public partial class Form1 : Form
    {
        Country cntry;
        Corporation corpn;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Country_Click(object sender, EventArgs e)
        {
            cntry = new Country();
            cntry.Name = textBox_Country.Text;

            MessageBox.Show("Создана страна:" + cntry.Name);
        }

        private void btn_Corporation_Click(object sender, EventArgs e)
        {
            corpn = new Corporation();
            corpn.Name = textBox_Corporation.Text;
            cntry.Corporation = corpn;

            MessageBox.Show("Cоздана корпорация:" + corpn.Name);
        }

        private void btn_Product_Click(object sender, EventArgs e)
        {
            Product pt = new Product();
            pt.Name = textBox_Product_Name.Text;
            pt.Price = (int)numericUpDown_Price.Value;
            pt.Count = (int)numericUpDown_Count.Value;
            
            corpn.LProduct.Add(pt);
            
            MessageBox.Show("Страна: " + cntry.Name + "\nКорпорация: " + corpn.Name + "\n Производится продуктов: " +
                corpn.LProduct.Count);
        }
    }
}
