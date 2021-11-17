
namespace V9
{
    partial class MainView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btChangeMinCount = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sortByDesc = new System.Windows.Forms.RadioButton();
            this.radioSortAsc = new System.Windows.Forms.RadioButton();
            this.materialFilter = new System.Windows.Forms.ComboBox();
            this.sortBy = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btChangeMinCount);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.materialFilter);
            this.panel1.Controls.Add(this.sortBy);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 78);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Добавить...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btChangeMinCount
            // 
            this.btChangeMinCount.Location = new System.Drawing.Point(370, 49);
            this.btChangeMinCount.Name = "btChangeMinCount";
            this.btChangeMinCount.Size = new System.Drawing.Size(281, 23);
            this.btChangeMinCount.TabIndex = 4;
            this.btChangeMinCount.Text = "Изменить минимальное количество на...";
            this.btChangeMinCount.UseVisualStyleBackColor = true;
            this.btChangeMinCount.Visible = false;
            this.btChangeMinCount.Click += new System.EventHandler(this.btChangeMinCount_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sortByDesc);
            this.groupBox1.Controls.Add(this.radioSortAsc);
            this.groupBox1.Location = new System.Drawing.Point(370, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(149, 32);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка";
            // 
            // sortByDesc
            // 
            this.sortByDesc.AutoSize = true;
            this.sortByDesc.Location = new System.Drawing.Point(89, 11);
            this.sortByDesc.Name = "sortByDesc";
            this.sortByDesc.Size = new System.Drawing.Size(53, 17);
            this.sortByDesc.TabIndex = 1;
            this.sortByDesc.TabStop = true;
            this.sortByDesc.Text = "убыв.";
            this.sortByDesc.UseVisualStyleBackColor = true;
            this.sortByDesc.CheckedChanged += new System.EventHandler(this.sortByDesc_CheckedChanged);
            // 
            // radioSortAsc
            // 
            this.radioSortAsc.AutoSize = true;
            this.radioSortAsc.Location = new System.Drawing.Point(7, 12);
            this.radioSortAsc.Name = "radioSortAsc";
            this.radioSortAsc.Size = new System.Drawing.Size(52, 17);
            this.radioSortAsc.TabIndex = 0;
            this.radioSortAsc.TabStop = true;
            this.radioSortAsc.Text = "возр.";
            this.radioSortAsc.UseVisualStyleBackColor = true;
            this.radioSortAsc.CheckedChanged += new System.EventHandler(this.radioSortAsc_CheckedChanged);
            // 
            // materialFilter
            // 
            this.materialFilter.FormattingEnabled = true;
            this.materialFilter.Items.AddRange(new object[] {
            "Все типы"});
            this.materialFilter.Location = new System.Drawing.Point(667, 12);
            this.materialFilter.Name = "materialFilter";
            this.materialFilter.Size = new System.Drawing.Size(121, 21);
            this.materialFilter.TabIndex = 2;
            this.materialFilter.SelectedIndexChanged += new System.EventHandler(this.materialFilter_SelectedIndexChanged);
            // 
            // sortBy
            // 
            this.sortBy.FormattingEnabled = true;
            this.sortBy.Items.AddRange(new object[] {
            "Выберите сортировку",
            "Наименование",
            "Остаток на складе",
            "Стоимость"});
            this.sortBy.Location = new System.Drawing.Point(530, 12);
            this.sortBy.Name = "sortBy";
            this.sortBy.Size = new System.Drawing.Size(121, 21);
            this.sortBy.Sorted = true;
            this.sortBy.TabIndex = 1;
            this.sortBy.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(28, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 78);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(500, 0, 0, 0);
            this.flowLayoutPanel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel2.Size = new System.Drawing.Size(800, 48);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 128);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 297);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainView";
            this.Text = "Черновик";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox materialFilter;
        private System.Windows.Forms.ComboBox sortBy;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton sortByDesc;
        private System.Windows.Forms.RadioButton radioSortAsc;
        public System.Windows.Forms.Button btChangeMinCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

