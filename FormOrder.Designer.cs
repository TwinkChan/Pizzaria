namespace pizzaria
{
    partial class FormOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOrder));
            this.tabControlProduct = new System.Windows.Forms.TabControl();
            this.tabPageFood = new System.Windows.Forms.TabPage();
            this.checkBoxSicilia = new System.Windows.Forms.CheckBox();
            this.checkBox4cheese = new System.Windows.Forms.CheckBox();
            this.checkBoxKorbanara = new System.Windows.Forms.CheckBox();
            this.checkBoxMargarita = new System.Windows.Forms.CheckBox();
            this.checkBoxPiperoni = new System.Windows.Forms.CheckBox();
            this.tabPageDrink = new System.Windows.Forms.TabPage();
            this.checkBoxJuice = new System.Windows.Forms.CheckBox();
            this.checkBoxFanta = new System.Windows.Forms.CheckBox();
            this.checkBoxCoffe = new System.Windows.Forms.CheckBox();
            this.checkBoxCola = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSummDiscount = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSumm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControlProduct.SuspendLayout();
            this.tabPageFood.SuspendLayout();
            this.tabPageDrink.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProduct
            // 
            this.tabControlProduct.Controls.Add(this.tabPageFood);
            this.tabControlProduct.Controls.Add(this.tabPageDrink);
            this.tabControlProduct.Location = new System.Drawing.Point(12, 12);
            this.tabControlProduct.Name = "tabControlProduct";
            this.tabControlProduct.SelectedIndex = 0;
            this.tabControlProduct.Size = new System.Drawing.Size(776, 305);
            this.tabControlProduct.TabIndex = 0;
            // 
            // tabPageFood
            // 
            this.tabPageFood.Controls.Add(this.checkBoxSicilia);
            this.tabPageFood.Controls.Add(this.checkBox4cheese);
            this.tabPageFood.Controls.Add(this.checkBoxKorbanara);
            this.tabPageFood.Controls.Add(this.checkBoxMargarita);
            this.tabPageFood.Controls.Add(this.checkBoxPiperoni);
            this.tabPageFood.Location = new System.Drawing.Point(4, 22);
            this.tabPageFood.Name = "tabPageFood";
            this.tabPageFood.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFood.Size = new System.Drawing.Size(768, 279);
            this.tabPageFood.TabIndex = 0;
            this.tabPageFood.Text = "Еда";
            this.tabPageFood.UseVisualStyleBackColor = true;
            // 
            // checkBoxSicilia
            // 
            this.checkBoxSicilia.AutoSize = true;
            this.checkBoxSicilia.Location = new System.Drawing.Point(6, 98);
            this.checkBoxSicilia.Name = "checkBoxSicilia";
            this.checkBoxSicilia.Size = new System.Drawing.Size(137, 17);
            this.checkBoxSicilia.TabIndex = 4;
            this.checkBoxSicilia.Text = " Сицилийская 249руб.";
            this.checkBoxSicilia.UseVisualStyleBackColor = true;
            this.checkBoxSicilia.CheckedChanged += new System.EventHandler(this.checkBoxSicilia_CheckedChanged);
            // 
            // checkBox4cheese
            // 
            this.checkBox4cheese.AutoSize = true;
            this.checkBox4cheese.Location = new System.Drawing.Point(6, 75);
            this.checkBox4cheese.Name = "checkBox4cheese";
            this.checkBox4cheese.Size = new System.Drawing.Size(102, 17);
            this.checkBox4cheese.TabIndex = 3;
            this.checkBox4cheese.Text = "4 сыра 418руб.";
            this.checkBox4cheese.UseVisualStyleBackColor = true;
            this.checkBox4cheese.CheckedChanged += new System.EventHandler(this.checkBox4cheese_CheckedChanged);
            // 
            // checkBoxKorbanara
            // 
            this.checkBoxKorbanara.AutoSize = true;
            this.checkBoxKorbanara.Location = new System.Drawing.Point(6, 52);
            this.checkBoxKorbanara.Name = "checkBoxKorbanara";
            this.checkBoxKorbanara.Size = new System.Drawing.Size(122, 17);
            this.checkBoxKorbanara.TabIndex = 2;
            this.checkBoxKorbanara.Text = "Корбонара 379руб.";
            this.checkBoxKorbanara.UseVisualStyleBackColor = true;
            this.checkBoxKorbanara.CheckedChanged += new System.EventHandler(this.checkBoxKorbanara_CheckedChanged);
            // 
            // checkBoxMargarita
            // 
            this.checkBoxMargarita.AutoSize = true;
            this.checkBoxMargarita.Location = new System.Drawing.Point(6, 29);
            this.checkBoxMargarita.Name = "checkBoxMargarita";
            this.checkBoxMargarita.Size = new System.Drawing.Size(122, 17);
            this.checkBoxMargarita.TabIndex = 1;
            this.checkBoxMargarita.Text = "Маргарита 199руб.";
            this.checkBoxMargarita.UseVisualStyleBackColor = true;
            this.checkBoxMargarita.CheckedChanged += new System.EventHandler(this.checkBoxMargarita_CheckedChanged);
            // 
            // checkBoxPiperoni
            // 
            this.checkBoxPiperoni.AutoSize = true;
            this.checkBoxPiperoni.Location = new System.Drawing.Point(6, 6);
            this.checkBoxPiperoni.Name = "checkBoxPiperoni";
            this.checkBoxPiperoni.Size = new System.Drawing.Size(117, 17);
            this.checkBoxPiperoni.TabIndex = 0;
            this.checkBoxPiperoni.Text = "Пиперони 324руб.";
            this.checkBoxPiperoni.UseVisualStyleBackColor = true;
            this.checkBoxPiperoni.CheckedChanged += new System.EventHandler(this.checkBoxPiperoni_CheckedChanged);
            // 
            // tabPageDrink
            // 
            this.tabPageDrink.Controls.Add(this.checkBoxJuice);
            this.tabPageDrink.Controls.Add(this.checkBoxFanta);
            this.tabPageDrink.Controls.Add(this.checkBoxCoffe);
            this.tabPageDrink.Controls.Add(this.checkBoxCola);
            this.tabPageDrink.Location = new System.Drawing.Point(4, 22);
            this.tabPageDrink.Name = "tabPageDrink";
            this.tabPageDrink.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDrink.Size = new System.Drawing.Size(768, 279);
            this.tabPageDrink.TabIndex = 1;
            this.tabPageDrink.Text = "Напитки";
            this.tabPageDrink.UseVisualStyleBackColor = true;
            // 
            // checkBoxJuice
            // 
            this.checkBoxJuice.AutoSize = true;
            this.checkBoxJuice.Location = new System.Drawing.Point(6, 75);
            this.checkBoxJuice.Name = "checkBoxJuice";
            this.checkBoxJuice.Size = new System.Drawing.Size(84, 17);
            this.checkBoxJuice.TabIndex = 3;
            this.checkBoxJuice.Text = "Сок 0,4л 99";
            this.checkBoxJuice.UseVisualStyleBackColor = true;
            this.checkBoxJuice.CheckedChanged += new System.EventHandler(this.checkBoxJuice_CheckedChanged);
            // 
            // checkBoxFanta
            // 
            this.checkBoxFanta.AutoSize = true;
            this.checkBoxFanta.Location = new System.Drawing.Point(6, 52);
            this.checkBoxFanta.Name = "checkBoxFanta";
            this.checkBoxFanta.Size = new System.Drawing.Size(115, 17);
            this.checkBoxFanta.TabIndex = 2;
            this.checkBoxFanta.Text = "Fanta 0,5л 119руб";
            this.checkBoxFanta.UseVisualStyleBackColor = true;
            this.checkBoxFanta.CheckedChanged += new System.EventHandler(this.checkBoxFanta_CheckedChanged);
            // 
            // checkBoxCoffe
            // 
            this.checkBoxCoffe.AutoSize = true;
            this.checkBoxCoffe.Location = new System.Drawing.Point(6, 29);
            this.checkBoxCoffe.Name = "checkBoxCoffe";
            this.checkBoxCoffe.Size = new System.Drawing.Size(146, 17);
            this.checkBoxCoffe.TabIndex = 1;
            this.checkBoxCoffe.Text = "Капучино 300мл 115руб";
            this.checkBoxCoffe.UseVisualStyleBackColor = true;
            this.checkBoxCoffe.CheckedChanged += new System.EventHandler(this.checkBoxCoffe_CheckedChanged);
            // 
            // checkBoxCola
            // 
            this.checkBoxCola.AutoSize = true;
            this.checkBoxCola.Location = new System.Drawing.Point(6, 6);
            this.checkBoxCola.Name = "checkBoxCola";
            this.checkBoxCola.Size = new System.Drawing.Size(136, 17);
            this.checkBoxCola.TabIndex = 0;
            this.checkBoxCola.Text = "Coca-cola 0,5л 119руб";
            this.checkBoxCola.UseVisualStyleBackColor = true;
            this.checkBoxCola.CheckedChanged += new System.EventHandler(this.checkBoxCola_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxSumm);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxDiscount);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxSummDiscount);
            this.groupBox1.Location = new System.Drawing.Point(16, 348);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(766, 76);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Общий заказ";
            // 
            // textBoxSummDiscount
            // 
            this.textBoxSummDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSummDiscount.Location = new System.Drawing.Point(343, 39);
            this.textBoxSummDiscount.Name = "textBoxSummDiscount";
            this.textBoxSummDiscount.ReadOnly = true;
            this.textBoxSummDiscount.Size = new System.Drawing.Size(41, 13);
            this.textBoxSummDiscount.TabIndex = 0;
            this.textBoxSummDiscount.Text = "000.00";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(62, 457);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(140, 45);
            this.buttonClose.TabIndex = 3;
            this.buttonClose.Text = "Закрыть";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(541, 453);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(140, 45);
            this.buttonOrder.TabIndex = 4;
            this.buttonOrder.Text = "Заказать";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите скидку:";
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDiscount.Location = new System.Drawing.Point(97, 39);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(26, 13);
            this.textBoxDiscount.TabIndex = 2;
            this.textBoxDiscount.TextChanged += new System.EventHandler(this.textBoxDiscount_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(123, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Сумма заказа с учётом скидки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(378, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "руб.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Сумма заказа без скидки:";
            // 
            // textBoxSumm
            // 
            this.textBoxSumm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxSumm.Location = new System.Drawing.Point(595, 39);
            this.textBoxSumm.Name = "textBoxSumm";
            this.textBoxSumm.ReadOnly = true;
            this.textBoxSumm.Size = new System.Drawing.Size(36, 13);
            this.textBoxSumm.TabIndex = 7;
            this.textBoxSumm.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(625, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "руб.";
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControlProduct);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ";
            this.tabControlProduct.ResumeLayout(false);
            this.tabPageFood.ResumeLayout(false);
            this.tabPageFood.PerformLayout();
            this.tabPageDrink.ResumeLayout(false);
            this.tabPageDrink.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProduct;
        private System.Windows.Forms.TabPage tabPageFood;
        private System.Windows.Forms.TabPage tabPageDrink;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.CheckBox checkBoxSicilia;
        private System.Windows.Forms.CheckBox checkBox4cheese;
        private System.Windows.Forms.CheckBox checkBoxKorbanara;
        private System.Windows.Forms.CheckBox checkBoxMargarita;
        private System.Windows.Forms.CheckBox checkBoxPiperoni;
        private System.Windows.Forms.TextBox textBoxSummDiscount;
        private System.Windows.Forms.CheckBox checkBoxJuice;
        private System.Windows.Forms.CheckBox checkBoxFanta;
        private System.Windows.Forms.CheckBox checkBoxCoffe;
        private System.Windows.Forms.CheckBox checkBoxCola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxSumm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDiscount;
    }
}