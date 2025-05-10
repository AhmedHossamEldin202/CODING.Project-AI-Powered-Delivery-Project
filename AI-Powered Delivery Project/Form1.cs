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
            random = new Random();
        }

        // Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(themecolor.ColorList.Count);
            while (tempindex == index)
            {
              index = random.Next(themecolor.ColorList.Count);
            }
            tempindex = index;
            string color = themecolor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null) {
                if (currentButton != (Button)btnSender) {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void DisableButton() 
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void BtnHealth_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void BtnPets_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void BtnFashion_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void BtnDevices_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void BtnToys_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void BtnBooks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void BtnSports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void BtnOffice_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
