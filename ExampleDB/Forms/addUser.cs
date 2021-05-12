using ExampleDB.Classes.Entityes;
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
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }

        private UserData EditedUser;
        public addUser(UserData user) {
            this.EditedUser = user;
            InitializeComponent();
            tb_name.Text = user.user_name;
            tb_pass.Text = user.user_pass;
            dtp_dateofbird.Value = user.dateofbird;
        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (tb_name.TextLength > 0 && tb_pass.TextLength > 0) {
                if (EditedUser == null)
                {
                    UserData.Add(tb_name.Text, tb_pass.Text, dtp_dateofbird.Value);
                }
                else {
                    EditedUser.Edit(tb_name.Text, tb_pass.Text, dtp_dateofbird.Value);
                }
                Close();
            }
        }
    }
}
