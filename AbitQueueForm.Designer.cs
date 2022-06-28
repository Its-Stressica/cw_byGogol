
namespace AbitQueue
{
    partial class AbitQueueForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbitQueueForm));
            this.savingButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.closeQueueButton = new System.Windows.Forms.Button();
            this.abitDV = new System.Windows.Forms.DataGridView();
            this.openQueueButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.queuesCB = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.abitDV)).BeginInit();
            this.SuspendLayout();
            // 
            // savingButton
            // 
            this.savingButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.savingButton.Font = new System.Drawing.Font("KyivType Sans Medium2", 9F, System.Drawing.FontStyle.Bold);
            this.savingButton.Location = new System.Drawing.Point(9, 461);
            this.savingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savingButton.Name = "savingButton";
            this.savingButton.Size = new System.Drawing.Size(204, 35);
            this.savingButton.TabIndex = 1;
            this.savingButton.Text = "Зберегти всі зміни";
            this.savingButton.UseVisualStyleBackColor = false;
            this.savingButton.Click += new System.EventHandler(this.savingButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.closeButton.Font = new System.Drawing.Font("KyivType Sans Medium2", 9F, System.Drawing.FontStyle.Bold);
            this.closeButton.Location = new System.Drawing.Point(668, 458);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(204, 35);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Завершити роботу";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // closeQueueButton
            // 
            this.closeQueueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.closeQueueButton.Font = new System.Drawing.Font("KyivType Sans Medium2", 9F, System.Drawing.FontStyle.Bold);
            this.closeQueueButton.Location = new System.Drawing.Point(627, 354);
            this.closeQueueButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeQueueButton.Name = "closeQueueButton";
            this.closeQueueButton.Size = new System.Drawing.Size(245, 26);
            this.closeQueueButton.TabIndex = 26;
            this.closeQueueButton.Text = "Закрити чергу";
            this.closeQueueButton.UseVisualStyleBackColor = false;
            this.closeQueueButton.Click += new System.EventHandler(this.closeQueueButton_Click);
            // 
            // abitDV
            // 
            this.abitDV.AllowUserToAddRows = false;
            this.abitDV.AllowUserToDeleteRows = false;
            this.abitDV.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.abitDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.abitDV.Location = new System.Drawing.Point(12, 83);
            this.abitDV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.abitDV.Name = "abitDV";
            this.abitDV.ReadOnly = true;
            this.abitDV.RowHeadersWidth = 62;
            this.abitDV.RowTemplate.Height = 28;
            this.abitDV.Size = new System.Drawing.Size(579, 275);
            this.abitDV.TabIndex = 25;
            // 
            // openQueueButton
            // 
            this.openQueueButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.openQueueButton.Font = new System.Drawing.Font("KyivType Sans Medium2", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openQueueButton.Location = new System.Drawing.Point(628, 312);
            this.openQueueButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.openQueueButton.Name = "openQueueButton";
            this.openQueueButton.Size = new System.Drawing.Size(244, 26);
            this.openQueueButton.TabIndex = 24;
            this.openQueueButton.Text = "Створити нову чергу";
            this.openQueueButton.UseVisualStyleBackColor = false;
            this.openQueueButton.Click += new System.EventHandler(this.openQueueButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("KyivType Sans Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(623, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Оберіть чергу:";
            // 
            // queuesCB
            // 
            this.queuesCB.FormattingEnabled = true;
            this.queuesCB.Location = new System.Drawing.Point(628, 80);
            this.queuesCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queuesCB.Name = "queuesCB";
            this.queuesCB.Size = new System.Drawing.Size(245, 24);
            this.queuesCB.TabIndex = 22;
            this.queuesCB.SelectedIndexChanged += new System.EventHandler(this.queuesCB_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addButton.Font = new System.Drawing.Font("KyivType Sans Medium2", 9F, System.Drawing.FontStyle.Bold);
            this.addButton.Location = new System.Drawing.Point(12, 381);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(164, 26);
            this.addButton.TabIndex = 21;
            this.addButton.Text = "Додати до черги";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.removeButton.Font = new System.Drawing.Font("KyivType Sans Medium2", 9F, System.Drawing.FontStyle.Bold);
            this.removeButton.Location = new System.Drawing.Point(427, 381);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(164, 26);
            this.removeButton.TabIndex = 20;
            this.removeButton.Text = "Видалити з черги";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("KyivType Sans Bold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "Абітурієнти";
            // 
            // AbitQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 507);
            this.Controls.Add(this.closeQueueButton);
            this.Controls.Add(this.abitDV);
            this.Controls.Add(this.openQueueButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.queuesCB);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.savingButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AbitQueueForm";
            this.RightToLeftLayout = true;
            this.Text = "Електронна Черга Абітурієнтів";
            ((System.ComponentModel.ISupportInitialize)(this.abitDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button savingButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button closeQueueButton;
        public System.Windows.Forms.DataGridView abitDV;
        private System.Windows.Forms.Button openQueueButton;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox queuesCB;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label1;
    }
}

