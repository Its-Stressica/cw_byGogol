
namespace AbitQueue
{
    partial class AddQueueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQueueForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addShopSubButton = new System.Windows.Forms.Button();
            this.choose_faculcyCB = new System.Windows.Forms.ComboBox();
            this.bud_kon_CB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("KyivType Sans Bold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Факультет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("KyivType Sans Bold", 10.8F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Бюджет/контракт";
            // 
            // addShopSubButton
            // 
            this.addShopSubButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addShopSubButton.Font = new System.Drawing.Font("KyivType Sans Bold", 10.8F, System.Drawing.FontStyle.Bold);
            this.addShopSubButton.Location = new System.Drawing.Point(104, 188);
            this.addShopSubButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addShopSubButton.Name = "addShopSubButton";
            this.addShopSubButton.Size = new System.Drawing.Size(120, 60);
            this.addShopSubButton.TabIndex = 6;
            this.addShopSubButton.Text = "Додати";
            this.addShopSubButton.UseVisualStyleBackColor = false;
            this.addShopSubButton.Click += new System.EventHandler(this.addSQueueButton_Click);
            // 
            // choose_faculcyCB
            // 
            this.choose_faculcyCB.FormattingEnabled = true;
            this.choose_faculcyCB.Items.AddRange(new object[] {
            "ІПСА",
            "ІТС",
            "ВПІ",
            "ФТІ",
            "ФІОТ",
            "РТФ",
            "ФПМ",
            "ХТФ",
            "ФБТ",
            "ФБМІ",
            "ФАКС"});
            this.choose_faculcyCB.Location = new System.Drawing.Point(12, 61);
            this.choose_faculcyCB.Name = "choose_faculcyCB";
            this.choose_faculcyCB.Size = new System.Drawing.Size(212, 24);
            this.choose_faculcyCB.TabIndex = 7;
            // 
            // bud_kon_CB
            // 
            this.bud_kon_CB.FormattingEnabled = true;
            this.bud_kon_CB.Items.AddRange(new object[] {
            "Бюджет",
            "Контракт"});
            this.bud_kon_CB.Location = new System.Drawing.Point(12, 149);
            this.bud_kon_CB.Name = "bud_kon_CB";
            this.bud_kon_CB.Size = new System.Drawing.Size(212, 24);
            this.bud_kon_CB.TabIndex = 8;
            // 
            // AddQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(334, 259);
            this.Controls.Add(this.bud_kon_CB);
            this.Controls.Add(this.choose_faculcyCB);
            this.Controls.Add(this.addShopSubButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddQueueForm";
            this.Text = "Додати чергу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addShopSubButton;
        private System.Windows.Forms.ComboBox choose_faculcyCB;
        private System.Windows.Forms.ComboBox bud_kon_CB;
    }
}