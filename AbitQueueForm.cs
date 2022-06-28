using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ShopNet;
using Newtonsoft.Json;
using System.IO;
namespace AbitQueue
{
    public partial class AbitQueueForm : Form
    {
        //Збереження списку черг у файл JSON
        public static void SaveQueueItemsInFile()
        {
            string fileName = "C:/Users/user/Desktop/кр/CourseWork/Kursach/DataBase/queueitems.json";
            string jsonString = JsonConvert.SerializeObject(Base<Queue>.Items);
            File.WriteAllText(fileName,jsonString);
        }
        
        //Зчитування списку черг з файла JSON
        public static bool ReadQueueItemsFromFile()
        {
            string fileName = "C:/Users/user/Desktop/кр/CourseWork/Kursach/DataBase/queueitems.json";
            if (!File.Exists(fileName))
            {
                var result = MessageBox.Show("Хочете почати роботу без доданих абітурієнтів та черг?", "Завершення роботи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    return false;
                }
                else
                {
                    MessageBox.Show("Перевірте папку D:/VisualStudio Projects/Kursach/DataBase на наявність файлу queueitems.json", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            string jsonString = File.ReadAllText(fileName);
            Base<Queue>.Items = JsonConvert.DeserializeObject<Dictionary<Guid,Queue>>(jsonString);
            return true;
        }
        //Метод для отримання черги, що обрана у елементі Combobox
        public Queue GetQueue()
        {
            return Queue.ListsOfQueues.Where(s => s.ToString().Equals(queuesCB.SelectedItem.ToString())).Single();
        }

        //Оновлення AbitDataGridView, де відображається список абітурієнтів у вибраній черзі
        public void UpdateAbitDT(Queue currentQueue)
        {
            if (currentQueue.ListOfAbits == null)
            {
                return;
            }
            DataTable abitDT = new DataTable();
            abitDT.Columns.Add("ID", typeof(Guid));
            abitDT.Columns.Add("Номер", typeof(string));
            abitDT.Columns.Add("Прізвище", typeof(string));
            abitDT.Columns.Add("Ім'я", typeof(string));
            abitDT.Columns.Add("По батькові", typeof(string));
            
            foreach (var abit in currentQueue.ListOfAbits)
            {
                abitDT.Rows.Add(abit.ID, abit.Number, abit.LastName, abit.FirstName, abit.MiddleName);
            }
            abitDV.DataSource = abitDT;
            abitDV.Columns[0].Visible = false;
        }

        public AbitQueueForm()
        {
            InitializeComponent();
           if(ReadQueueItemsFromFile())
            {
                foreach (var queue in Queue.ListsOfQueues)
                {
                    queuesCB.Items.Add(queue.ToString());
                }       
            }
        }
        //Обробка натиснення на кнопку "Відкрити нову чергу"
        private void openQueueButton_Click(object sender, EventArgs e)
        {
            AddQueueForm addNewQueue = new AddQueueForm(this);
            addNewQueue.Show();
        }
        //Обробка натиснення на кнопку "Додати до черги"
        private void addButton_Click(object sender, EventArgs e)
        {
            if(queuesCB.SelectedItem==null)
            {
                MessageBox.Show("Оберіть чергу, куди хочете додати абітурієнта", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            AbitAddForm addNewAbit = new AbitAddForm(this);
            addNewAbit.Show();
        }
        //Обробка зміни поточної черги в Combobox
        private void queuesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            Queue currentQueue = GetQueue();
            UpdateAbitDT(currentQueue);
            
        }
        //Обробка натиснення на кнопку "Видалити з черги"
        private void removeButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви точно хочете видалити абітурієнта з черги?", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Queue currentQueue = GetQueue();
                    Abits abit = currentQueue.ListOfAbits.Where(s => s.ID.Equals(abitDV.SelectedRows[0].Cells[0].Value)).Single();
                    currentQueue.RemoveAbit(abit);
                    UpdateAbitDT(currentQueue);
                    MessageBox.Show("Абітурієнта видалено", "Видалення", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch(ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Будь ласка, виділіть повністю всі поля абітурієнта(натисніть стрілку у першій колонці напроти абітурієнта)","Помилка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                catch(Exception)
                {
                    MessageBox.Show("Будь ласка, оберіть чергу, де наявний абітурієнт", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                return;
            }
        }
       
        //Обробка натиснення на кнопку "Закрити чергу"
        private void closeQueueButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Ви точно хочете закрити цю чергу?", "Закриття", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    if (queuesCB.SelectedItem == null)
                    {
                        throw new Exception();
                    }
                    Queue.CloseQueue(GetQueue());
                    queuesCB.Items.Remove(queuesCB.SelectedItem);
                }
                catch(Exception)
                {
                    MessageBox.Show("Оберіть чергу, яку хочете закрити!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                MessageBox.Show("Чергу закрито", "Черга", MessageBoxButtons.OK, MessageBoxIcon.Information);
                while(abitDV.Rows.Count!=0)
                {
                    abitDV.Rows.Remove(abitDV.Rows[0]);
                }
                
            }
            else
            {
                return;
            }
            
        }
        //Обробка натискання кнопки "Завершити роботу"
        private void closeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Будь ласка, перевірте, чи ви зберегли результат роботи програми", "Завершення роботи", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var result = MessageBox.Show("Ви точно хочете завершити роботу програми?", "Завершення роботи", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result==DialogResult.Yes)
            {
                Close();
            }
            else
            {
                return;
            }

        }
        //Обробка натискання кнопки "Зберегти всі зміни"
        private void savingButton_Click(object sender, EventArgs e)
        {
            SaveQueueItemsInFile();
            MessageBox.Show("Дані збережено", "Збереження", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
