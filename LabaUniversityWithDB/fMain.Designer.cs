namespace LabaUniversityWithDB {
    partial class fMain {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.butAccureSalary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butAccureSalary
            // 
            this.butAccureSalary.Location = new System.Drawing.Point(98, 278);
            this.butAccureSalary.Name = "butAccureSalary";
            this.butAccureSalary.Size = new System.Drawing.Size(122, 42);
            this.butAccureSalary.TabIndex = 0;
            this.butAccureSalary.Text = "Начислить зарплату";
            this.butAccureSalary.UseVisualStyleBackColor = true;
            this.butAccureSalary.Click += new System.EventHandler(this.butAccureSalary_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 406);
            this.Controls.Add(this.butAccureSalary);
            this.Name = "fMain";
            this.Text = "Бухгалтерия";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butAccureSalary;
    }
}

