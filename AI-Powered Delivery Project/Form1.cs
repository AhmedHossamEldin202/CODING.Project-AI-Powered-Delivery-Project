using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace AI_Powered_Delivery_Project
{
    public partial class Form1: Form
    {
        // Fields
        private Button currentButton;
        private Random random;
        private int tempindex;
        private Form activeForm;

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
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = themecolor.ChangeColorBrightness(color,-0.3);
                    themecolor.primaryColor = color;
                    themecolor.SecondaryColor = themecolor.ChangeColorBrightness(color,-0.3);
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
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label2.Text = childForm.Text;
        }

        private void btnMobiles_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMobiles(), sender);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void btnElectricalDevices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormElectricalDevices(), sender);

        }

        private void btnLaptops_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormLaptops(), sender);

        }

        private void btnPS_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPS(), sender);

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHome(), sender);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
