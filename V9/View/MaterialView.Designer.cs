
namespace V9.View
{
    partial class MaterialView
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageMaterial = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.amount = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelSuplier = new System.Windows.Forms.Label();
            this.minCount = new System.Windows.Forms.Label();
            this.labelTypeAndName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageMaterial)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imageMaterial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(139, 126);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // imageMaterial
            // 
            this.imageMaterial.Location = new System.Drawing.Point(16, 13);
            this.imageMaterial.Name = "imageMaterial";
            this.imageMaterial.Size = new System.Drawing.Size(107, 99);
            this.imageMaterial.TabIndex = 0;
            this.imageMaterial.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.amount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(508, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(131, 126);
            this.panel2.TabIndex = 1;
            // 
            // amount
            // 
            this.amount.AutoSize = true;
            this.amount.Location = new System.Drawing.Point(16, 19);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(52, 13);
            this.amount.TabIndex = 0;
            this.amount.Text = "Остаток:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.labelSuplier);
            this.panel3.Controls.Add(this.minCount);
            this.panel3.Controls.Add(this.labelTypeAndName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(139, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(369, 126);
            this.panel3.TabIndex = 2;
            // 
            // labelSuplier
            // 
            this.labelSuplier.AutoSize = true;
            this.labelSuplier.Location = new System.Drawing.Point(26, 71);
            this.labelSuplier.Name = "labelSuplier";
            this.labelSuplier.Size = new System.Drawing.Size(74, 13);
            this.labelSuplier.TabIndex = 2;
            this.labelSuplier.Text = "Поставщики:";
            // 
            // minCount
            // 
            this.minCount.AutoSize = true;
            this.minCount.Location = new System.Drawing.Point(26, 46);
            this.minCount.Name = "minCount";
            this.minCount.Size = new System.Drawing.Size(142, 13);
            this.minCount.TabIndex = 1;
            this.minCount.Text = "Минимальное количество:";
            // 
            // labelTypeAndName
            // 
            this.labelTypeAndName.AutoSize = true;
            this.labelTypeAndName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTypeAndName.Location = new System.Drawing.Point(26, 19);
            this.labelTypeAndName.Name = "labelTypeAndName";
            this.labelTypeAndName.Size = new System.Drawing.Size(0, 16);
            this.labelTypeAndName.TabIndex = 0;
            // 
            // MaterialView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MaterialView";
            this.Size = new System.Drawing.Size(639, 126);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageMaterial)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imageMaterial;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label amount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelSuplier;
        private System.Windows.Forms.Label minCount;
        private System.Windows.Forms.Label labelTypeAndName;
    }
}
