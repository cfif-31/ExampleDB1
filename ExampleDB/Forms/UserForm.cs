using ExampleDB.Classes;
using ExampleDB.Classes.Entityes;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExampleDB.Forms
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            UpdateData();

        }

        private void UpdateData() {
            dgv_users.Rows.Clear();
            foreach (UserData user in UserData.Select(tb_search.Text))
            {
                int r = dgv_users.Rows.Add(user.user_name, user.dateofbird.ToString("D"));
                dgv_users.Rows[r].Tag = user;
            }
        }

        private void btn_refresh_Click(object sender, System.EventArgs e)
        {
            UpdateData();
        }

        private void btn_addd_Click(object sender, System.EventArgs e)
        {
            addUser addUser = new addUser();
            addUser.ShowDialog();
            UpdateData();
        }

        private void btn_delete_Click(object sender, System.EventArgs e)
        {
            if (dgv_users.SelectedRows.Count > 0) {
                UserData user = dgv_users.SelectedRows[0].Tag as UserData;
                user.Delete();
                UpdateData();
            }
        }

        private void btn_edit_Click(object sender, System.EventArgs e)
        {
            if (dgv_users.SelectedRows.Count > 0) {
                UserData user = dgv_users.SelectedRows[0].Tag as UserData;
                addUser edit = new addUser(user);
                edit.ShowDialog();
                UpdateData();
            }
        }

        private void tb_search_TextChanged(object sender, System.EventArgs e)
        {
            UpdateData();
        }

        private void btn_export_Click(object sender, System.EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();//Создаем дислог выбора файла
            dialog.Filter = "Файлы excel|*.xlsx";//Задаем шаблон выбора файла <Название для пользователя>|<шаблон расширения файла>
            
            if (dialog.ShowDialog() == DialogResult.OK)//Вызываем диалог выбора файла и проверяем, что полльзователь выбрал файл
            {
                List<UserData> users = UserData.Select("");//Прогружаем список пользователей
                string[,] values = new string[users.Count+1, 5];//Создаем массив со значениями ячеек [строка, столбец]

                //Заполняем первую строку заголовками
                values[0, 0] = "Id";
                values[0, 1] = "Имя";
                values[0, 2] = "Фигня";
                values[0, 3] = "Пароль";
                values[0, 4] = "Дата рождения";

                //Перебираем пользователей и заполняем строки
                for (int i = 0; i < users.Count; i++)
                {
                    values[i+1, 0] = users[i].user_id.ToString();
                    values[i+1, 1] = users[i].user_name;
                    values[i+1, 2] = "Какая-то фигня";
                    values[i+1, 3] = users[i].user_pass;
                    values[i+1, 4] = users[i].dateofbird.ToString("D");
                }
                //Вызываем ранее написаный метод
                ExcelExport.saveExcel(dialog.FileName, "Пользователи", values);
            }
        }
    }
}
