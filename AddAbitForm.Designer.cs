
namespace AbitQueue
{
    partial class AbitAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AbitAddForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.middleNameTB = new System.Windows.Forms.TextBox();
            this.addSalesmanButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("KyivType Sans Bold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Прізвище";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("KyivType Sans Bold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("KyivType Sans Bold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(28, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "По батькові";
            // 
            // lastNameTB
            // 
            this.lastNameTB.BackColor = System.Drawing.Color.LavenderBlush;
            this.lastNameTB.Location = new System.Drawing.Point(27, 56);
            this.lastNameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(208, 22);
            this.lastNameTB.TabIndex = 3;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(27, 121);
            this.firstNameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(208, 22);
            this.firstNameTB.TabIndex = 4;
            this.firstNameTB.TextChanged += new System.EventHandler(this.firstNameTB_TextChanged);
            // 
            // middleNameTB
            // 
            this.middleNameTB.Location = new System.Drawing.Point(27, 189);
            this.middleNameTB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.middleNameTB.Name = "middleNameTB";
            this.middleNameTB.Size = new System.Drawing.Size(208, 22);
            this.middleNameTB.TabIndex = 5;
            // 
            // addSalesmanButton
            // 
            this.addSalesmanButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addSalesmanButton.Font = new System.Drawing.Font("KyivType Sans Bold", 10.8F, System.Drawing.FontStyle.Bold);
            this.addSalesmanButton.Location = new System.Drawing.Point(259, 189);
            this.addSalesmanButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addSalesmanButton.Name = "addSalesmanButton";
            this.addSalesmanButton.Size = new System.Drawing.Size(196, 67);
            this.addSalesmanButton.TabIndex = 8;
            this.addSalesmanButton.Text = "Додати до черги";
            this.addSalesmanButton.UseVisualStyleBackColor = false;
            this.addSalesmanButton.Click += new System.EventHandler(this.addAbitButton_Click);
            // 
            // AbitAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(467, 267);
            this.Controls.Add(this.addSalesmanButton);
            this.Controls.Add(this.middleNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AbitAddForm";
            this.Text = "Додати абітурієнта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox middleNameTB;
        private System.Windows.Forms.Button addSalesmanButton;
    }
}