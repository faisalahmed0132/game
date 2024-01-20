using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assingment1MCQGame_AnyaScheinman
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //making sure the name is not empty or greater then 20 Characters
            if (txtName.Text.Length > 20 || txtName.Text == "")
            {
                //show an error the emtpty the text box
                lblError.Text = " name empty or greater then 20 characters";
                txtName.Text = String.Empty;
            }
            else
            {
                //once user inputs their name, hide the form and only display the main game
                Form1 f1 = new Form1(txtName.Text);
                f1.Show();
                this.Hide();
            }




        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
