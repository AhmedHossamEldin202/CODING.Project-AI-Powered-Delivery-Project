using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Powered_Delivery_Project
{
    public partial class Form1: Form
    {
        // Fields
        private Button currentButton;
        private Random random;
        private int tempindex;

        // Constructor 
        public Form1()
        {
            InitializeComponent();
        }

        // Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(themecolor.ColorList.Count);
            while (tempIndex == index)
            {
                random.Next(themecolor.ColorList.Count);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
