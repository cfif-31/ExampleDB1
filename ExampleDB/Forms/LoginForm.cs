using ExampleDB.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleDB.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if (AuthManager.Autorizate(tb_login.Text, tb_pass.Text))
            {
                MessageBox.Show(AuthManager.login_user.user_id.ToString());
                FormManager.ChangeForm(new MainForm());
            }
            else {
                MessageBox.Show("Uncorrect login or pass!");
            }
        }

        private void bt_reg_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }
    }
}
