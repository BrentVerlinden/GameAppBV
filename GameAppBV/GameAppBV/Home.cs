using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameAppBV
{
    public partial class Home : Form
    {
        // Fields
        private Button currentButton;
        private Form activeForm;

        //Constructor
        public Home()
        {
            InitializeComponent();
            //this.Text = string.Empty;
            //this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        //Methods
        private void ActivateButton(object btn) 
        { 
            if(btn!=null)
            {
                if(currentButton!=(Button)btn)
                {
                    DisableButton();
                    currentButton = (Button)btn;
                    //currentButton.BackColor = Color.FromArgb(79, 98, 115);
                    currentButton.BackColor = Color.FromArgb(116, 141, 163);
                    currentButton.ForeColor = Color.Snow;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButton() 
        { 
            foreach(Control previousBtn in panelHome.Controls)
            {
                if(previousBtn.GetType()==typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(57, 73, 87);
                    previousBtn.ForeColor = Color.Snow;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panelTitleBar.BackColor = Color.FromArgb(57, 73, 87);
                }
            }
        }

        private void OpenChildForm(Form childForm, object btn)
        {
            if (activeForm != null) { activeForm.Close(); }
            ActivateButton(btn);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelHome.Text = childForm.Text;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ActivateButton(buttonHome);
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Forms.Home(), sender);
        }

        private void buttonPokemon_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Forms.Pokésearch(), sender);
        }

        private void buttonBank_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Forms.Bank(), sender);
        }

        private void buttonExtra_Click(object sender, EventArgs e)
        {
            //ActivateButton(sender);
            OpenChildForm(new Forms.Calculator(), sender);
        }

        private void buttonContact_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.Contact(), sender);
        }
    }
}
