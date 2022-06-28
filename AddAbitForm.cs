using System;
using System.Windows.Forms;
using ShopNet;
namespace AbitQueue
{
    public partial class AbitAddForm : Form
    {
        private AbitQueueForm _mainForm;
        private class ListOverFlowException : Exception
        {
            public ListOverFlowException(string message) : base(message)
            {

            }
        }
        public AbitAddForm(AbitQueueForm mainForm)
        {
            _mainForm = mainForm;
            InitializeComponent();
        }   
        //Обробка події натискання кнопки "Додати до черги"
        private void addAbitButton_Click(object sender, EventArgs e)
        {   
            try
            {
                Queue currentQueue=_mainForm.GetQueue();
                string firstName = firstNameTB.Text;
                string middleName = middleNameTB.Text;
                string lastName = lastNameTB.Text;
                foreach (var queue in Queue.ListsOfQueues)
                {
                    Abits abit = new Abits(Guid.NewGuid(), firstName, middleName, lastName, currentQueue);
                        _mainForm.UpdateAbitDT(currentQueue);
                        break;
                }
            }
            catch(ListOverFlowException ex)
            {
                MessageBox.Show(ex.Message,"Помилка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            catch (Exception)
            {
                MessageBox.Show("Будь ласка, введіть коректні дані!!!","Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Абітурієнта успішно додано до черги!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void firstNameTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
