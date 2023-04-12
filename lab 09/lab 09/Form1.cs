using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_09
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

        private void button1_Click(object sender, EventArgs e)
        {
            IComponent toy1 = new Toy("Плюшевий ведмідь");
            IComponent toy2 = new Toy("Кубики LEGO");
            IComponent furniture1 = new Furniture("Стіл");
            IComponent furniture2 = new Furniture("Диван");
            IComponent picture1 = new Picture("Малюнок 1");
            IComponent picture2 = new Picture("Малюнок 2");

            RoomQuest roomQuest = new RoomQuest();

            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null || comboBox3.SelectedItem == null)
            {
                MessageBox.Show("Select all items");
                return;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                roomQuest.Add(toy1);
            }
            else 
                roomQuest.Add(toy2);
            if (comboBox2.SelectedIndex == 0)
            {
                roomQuest.Add(furniture1);
            }
            else
                roomQuest.Add(furniture2);

            if (comboBox3.SelectedIndex == 0)
            {
                roomQuest.Add(picture1);
            }
            else
                roomQuest.Add(picture2);
            
              

            roomQuest.Display();
        }
    }
}
