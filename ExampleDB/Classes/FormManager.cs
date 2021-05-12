using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleDB.Classes
{
    class FormManager
    {
        private static Form CurForm;//Хранение текущей формы
        public static void ChangeForm(Form form) {//Метод переключения формы
            if (CurForm != null) {//Если текущая форма существует
                //Отвязываем от нее события закрытия
                CurForm.FormClosed -= Form_FormClosed;
                CurForm.FormClosing -= Form_FormClosing;
                //Закрываем и уничтожаем форму
                CurForm.Close();
                CurForm.Dispose();
            }
            //Записываем новую форму в переменную form
            CurForm = form;
            //Привязываем эвенты
            CurForm.FormClosed += Form_FormClosed;//Событие после закрытия формы
            CurForm.FormClosing += Form_FormClosing;//Событие до закрытия формы
            //Показываем форму
            CurForm.Show();
        }

        private static void Form_FormClosing(object sender, FormClosingEventArgs e)//При попытке закрытия формы
        {
            //Спрашиваем пользователя, уверен ли он.
            if (MessageBox.Show("You want to exit?", "Exit?", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                //Если пользователь не согласен - отменяем событие закрытия
                e.Cancel = true;
            }
        }

        private static void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            //При закрытии формы - закрываем программу
            Application.Exit();
        }
    }
}
