using System;
using System.Linq;
using System.Windows.Forms;
using ShopNet;
namespace AbitQueue
{
    public partial class AddQueueForm : Form
    {
        private AbitQueueForm _mainForm;
        private class QueueException : Exception
        {
            public QueueException(string message) : base(message)
            {

            }
        }
        public AddQueueForm(AbitQueueForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }
        //Обробник події натискання кнопки "Додати"
        private void addSQueueButton_Click(object sender, EventArgs e)
        {
            try
            {
                string faculty = choose_faculcyCB.SelectedItem.ToString();
                string paid = bud_kon_CB.SelectedItem.ToString();

                if (Queue.ListsOfQueues.Contains(new Queue(Guid.NewGuid(),faculty, paid)))
                {
                    throw new QueueException("У вас не може бути більше 1 черги з однаковими параметрами!!!");
                }
                Base<Queue>.Items.Remove(Base<Queue>.Items.Last().Key);
               
                Queue.OpenNewQueue(faculty, paid);
            }
            catch (QueueException ex)
            {
                MessageBox.Show(ex.Message,"Помилка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                Base<Queue>.Items.Remove(Base<Queue>.Items.Last().Key);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Будь ласка, введіть коректні дані!!!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Чергу створено!","Успіх",MessageBoxButtons.OK,MessageBoxIcon.Information);
            _mainForm.queuesCB.Items.Add(Queue.ListsOfQueues.Last());
            Close();
        }
    }
}
