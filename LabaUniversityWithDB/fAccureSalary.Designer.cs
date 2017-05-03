using System;
using System.Reflection.Emit;
using System.Runtime.Remoting.Channels;

namespace LabaUniversityWithDB {
    partial class fAccrueSalary {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPageInsert = new System.Windows.Forms.TabPage();
            this.labelExeptionInsert = new System.Windows.Forms.Label();
            this.tbDepartmentInsert = new System.Windows.Forms.TextBox();
            this.tbSalaryInsert = new System.Windows.Forms.TextBox();
            this.tbPostInsert = new System.Windows.Forms.TextBox();
            this.tbSecondNameInsert = new System.Windows.Forms.TextBox();
            this.tbFirstNameInsert = new System.Windows.Forms.TextBox();
            this.tbLastNameInsert = new System.Windows.Forms.TextBox();
            this.butAddDB = new System.Windows.Forms.Button();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelPost = new System.Windows.Forms.Label();
            this.labelSecondName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastNameInsert = new System.Windows.Forms.Label();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.labelExceptionUpdate = new System.Windows.Forms.Label();
            this.labelIdDelete = new System.Windows.Forms.Label();
            this.tbIdUpdate = new System.Windows.Forms.TextBox();
            this.tbSalaryUpdate = new System.Windows.Forms.TextBox();
            this.butUpdateData = new System.Windows.Forms.Button();
            this.labelSalaryUpdate = new System.Windows.Forms.Label();
            this.tabPageDelete = new System.Windows.Forms.TabPage();
            this.labelExceptionDelete = new System.Windows.Forms.Label();
            this.labelData = new System.Windows.Forms.Label();
            this.tbDeleteData = new System.Windows.Forms.TextBox();
            this.butDelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            this.tabPageInsert.SuspendLayout();
            this.tabPageUpdate.SuspendLayout();
            this.tabPageDelete.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageSelect);
            this.tabControl.Controls.Add(this.tabPageInsert);
            this.tabControl.Controls.Add(this.tabPageUpdate);
            this.tabControl.Controls.Add(this.tabPageDelete);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl.Location = new System.Drawing.Point(107, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(542, 361);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.listBox1);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(534, 335);
            this.tabPageSelect.TabIndex = 0;
            this.tabPageSelect.Text = "SELECT";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(528, 329);
            this.listBox1.TabIndex = 0;
            // 
            // tabPageInsert
            // 
            this.tabPageInsert.Controls.Add(this.labelExeptionInsert);
            this.tabPageInsert.Controls.Add(this.tbDepartmentInsert);
            this.tabPageInsert.Controls.Add(this.tbSalaryInsert);
            this.tabPageInsert.Controls.Add(this.tbPostInsert);
            this.tabPageInsert.Controls.Add(this.tbSecondNameInsert);
            this.tabPageInsert.Controls.Add(this.tbFirstNameInsert);
            this.tabPageInsert.Controls.Add(this.tbLastNameInsert);
            this.tabPageInsert.Controls.Add(this.butAddDB);
            this.tabPageInsert.Controls.Add(this.labelDepartment);
            this.tabPageInsert.Controls.Add(this.labelSalary);
            this.tabPageInsert.Controls.Add(this.labelPost);
            this.tabPageInsert.Controls.Add(this.labelSecondName);
            this.tabPageInsert.Controls.Add(this.labelFirstName);
            this.tabPageInsert.Controls.Add(this.labelLastNameInsert);
            this.tabPageInsert.Location = new System.Drawing.Point(4, 22);
            this.tabPageInsert.Name = "tabPageInsert";
            this.tabPageInsert.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInsert.Size = new System.Drawing.Size(534, 335);
            this.tabPageInsert.TabIndex = 1;
            this.tabPageInsert.Text = "INSERT";
            this.tabPageInsert.UseVisualStyleBackColor = true;
            // 
            // labelExeptionInsert
            // 
            this.labelExeptionInsert.AutoSize = true;
            this.labelExeptionInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExeptionInsert.ForeColor = System.Drawing.Color.Red;
            this.labelExeptionInsert.Location = new System.Drawing.Point(142, 85);
            this.labelExeptionInsert.Name = "labelExeptionInsert";
            this.labelExeptionInsert.Size = new System.Drawing.Size(60, 24);
            this.labelExeptionInsert.TabIndex = 19;
            this.labelExeptionInsert.Text = "label1";
            this.labelExeptionInsert.Visible = false;
            // 
            // tbDepartmentInsert
            // 
            this.tbDepartmentInsert.Location = new System.Drawing.Point(8, 281);
            this.tbDepartmentInsert.Name = "tbDepartmentInsert";
            this.tbDepartmentInsert.Size = new System.Drawing.Size(100, 20);
            this.tbDepartmentInsert.TabIndex = 18;
            // 
            // tbSalaryInsert
            // 
            this.tbSalaryInsert.Location = new System.Drawing.Point(8, 233);
            this.tbSalaryInsert.Name = "tbSalaryInsert";
            this.tbSalaryInsert.Size = new System.Drawing.Size(100, 20);
            this.tbSalaryInsert.TabIndex = 17;
            // 
            // tbPostInsert
            // 
            this.tbPostInsert.Location = new System.Drawing.Point(8, 182);
            this.tbPostInsert.Name = "tbPostInsert";
            this.tbPostInsert.Size = new System.Drawing.Size(100, 20);
            this.tbPostInsert.TabIndex = 16;
            // 
            // tbSecondNameInsert
            // 
            this.tbSecondNameInsert.Location = new System.Drawing.Point(5, 134);
            this.tbSecondNameInsert.Name = "tbSecondNameInsert";
            this.tbSecondNameInsert.Size = new System.Drawing.Size(100, 20);
            this.tbSecondNameInsert.TabIndex = 15;
            // 
            // tbFirstNameInsert
            // 
            this.tbFirstNameInsert.Location = new System.Drawing.Point(8, 85);
            this.tbFirstNameInsert.Name = "tbFirstNameInsert";
            this.tbFirstNameInsert.Size = new System.Drawing.Size(100, 20);
            this.tbFirstNameInsert.TabIndex = 14;
            // 
            // tbLastNameInsert
            // 
            this.tbLastNameInsert.Location = new System.Drawing.Point(8, 37);
            this.tbLastNameInsert.Name = "tbLastNameInsert";
            this.tbLastNameInsert.Size = new System.Drawing.Size(100, 20);
            this.tbLastNameInsert.TabIndex = 13;
            // 
            // butAddDB
            // 
            this.butAddDB.Location = new System.Drawing.Point(146, 30);
            this.butAddDB.Name = "butAddDB";
            this.butAddDB.Size = new System.Drawing.Size(105, 33);
            this.butAddDB.TabIndex = 12;
            this.butAddDB.Text = "Добавить";
            this.butAddDB.UseVisualStyleBackColor = true;
            this.butAddDB.Click += new System.EventHandler(this.butAddDB_Click);
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(5, 265);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(63, 13);
            this.labelDepartment.TabIndex = 5;
            this.labelDepartment.Text = "Факультет";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(5, 217);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(55, 13);
            this.labelSalary.TabIndex = 4;
            this.labelSalary.Text = "Зарплата";
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Location = new System.Drawing.Point(5, 166);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(65, 13);
            this.labelPost.TabIndex = 3;
            this.labelPost.Text = "Должность";
            // 
            // labelSecondName
            // 
            this.labelSecondName.AutoSize = true;
            this.labelSecondName.Location = new System.Drawing.Point(5, 118);
            this.labelSecondName.Name = "labelSecondName";
            this.labelSecondName.Size = new System.Drawing.Size(54, 13);
            this.labelSecondName.TabIndex = 2;
            this.labelSecondName.Text = "Отчество";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(5, 69);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(29, 13);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "Имя";
            // 
            // labelLastNameInsert
            // 
            this.labelLastNameInsert.AutoSize = true;
            this.labelLastNameInsert.Location = new System.Drawing.Point(5, 21);
            this.labelLastNameInsert.Name = "labelLastNameInsert";
            this.labelLastNameInsert.Size = new System.Drawing.Size(56, 13);
            this.labelLastNameInsert.TabIndex = 0;
            this.labelLastNameInsert.Text = "Фамилия";
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.labelExceptionUpdate);
            this.tabPageUpdate.Controls.Add(this.labelIdDelete);
            this.tabPageUpdate.Controls.Add(this.tbIdUpdate);
            this.tabPageUpdate.Controls.Add(this.tbSalaryUpdate);
            this.tabPageUpdate.Controls.Add(this.butUpdateData);
            this.tabPageUpdate.Controls.Add(this.labelSalaryUpdate);
            this.tabPageUpdate.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Size = new System.Drawing.Size(534, 335);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "UPDATE";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // labelExceptionUpdate
            // 
            this.labelExceptionUpdate.AutoSize = true;
            this.labelExceptionUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExceptionUpdate.ForeColor = System.Drawing.Color.Red;
            this.labelExceptionUpdate.Location = new System.Drawing.Point(139, 76);
            this.labelExceptionUpdate.Name = "labelExceptionUpdate";
            this.labelExceptionUpdate.Size = new System.Drawing.Size(60, 24);
            this.labelExceptionUpdate.TabIndex = 34;
            this.labelExceptionUpdate.Text = "label1";
            this.labelExceptionUpdate.Visible = false;
            // 
            // labelIdDelete
            // 
            this.labelIdDelete.AutoSize = true;
            this.labelIdDelete.Location = new System.Drawing.Point(3, 9);
            this.labelIdDelete.Name = "labelIdDelete";
            this.labelIdDelete.Size = new System.Drawing.Size(18, 13);
            this.labelIdDelete.TabIndex = 33;
            this.labelIdDelete.Text = "ID";
            this.labelIdDelete.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbIdUpdate
            // 
            this.tbIdUpdate.Location = new System.Drawing.Point(6, 25);
            this.tbIdUpdate.Name = "tbIdUpdate";
            this.tbIdUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbIdUpdate.TabIndex = 32;
            // 
            // tbSalaryUpdate
            // 
            this.tbSalaryUpdate.Location = new System.Drawing.Point(6, 73);
            this.tbSalaryUpdate.Name = "tbSalaryUpdate";
            this.tbSalaryUpdate.Size = new System.Drawing.Size(100, 20);
            this.tbSalaryUpdate.TabIndex = 30;
            // 
            // butUpdateData
            // 
            this.butUpdateData.Location = new System.Drawing.Point(143, 16);
            this.butUpdateData.Name = "butUpdateData";
            this.butUpdateData.Size = new System.Drawing.Size(102, 36);
            this.butUpdateData.TabIndex = 25;
            this.butUpdateData.Text = "Исправить";
            this.butUpdateData.UseVisualStyleBackColor = true;
            this.butUpdateData.Click += new System.EventHandler(this.butUpdateData_Click);
            // 
            // labelSalaryUpdate
            // 
            this.labelSalaryUpdate.AutoSize = true;
            this.labelSalaryUpdate.Location = new System.Drawing.Point(3, 57);
            this.labelSalaryUpdate.Name = "labelSalaryUpdate";
            this.labelSalaryUpdate.Size = new System.Drawing.Size(55, 13);
            this.labelSalaryUpdate.TabIndex = 23;
            this.labelSalaryUpdate.Text = "Зарплата";
            // 
            // tabPageDelete
            // 
            this.tabPageDelete.Controls.Add(this.labelExceptionDelete);
            this.tabPageDelete.Controls.Add(this.labelData);
            this.tabPageDelete.Controls.Add(this.tbDeleteData);
            this.tabPageDelete.Controls.Add(this.butDelete);
            this.tabPageDelete.Location = new System.Drawing.Point(4, 22);
            this.tabPageDelete.Name = "tabPageDelete";
            this.tabPageDelete.Size = new System.Drawing.Size(534, 335);
            this.tabPageDelete.TabIndex = 3;
            this.tabPageDelete.Text = "DELETE";
            this.tabPageDelete.UseVisualStyleBackColor = true;
            // 
            // labelExceptionDelete
            // 
            this.labelExceptionDelete.AutoSize = true;
            this.labelExceptionDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelExceptionDelete.ForeColor = System.Drawing.Color.Red;
            this.labelExceptionDelete.Location = new System.Drawing.Point(3, 82);
            this.labelExceptionDelete.Name = "labelExceptionDelete";
            this.labelExceptionDelete.Size = new System.Drawing.Size(60, 24);
            this.labelExceptionDelete.TabIndex = 37;
            this.labelExceptionDelete.Text = "label1";
            this.labelExceptionDelete.Visible = false;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(3, 14);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(18, 13);
            this.labelData.TabIndex = 36;
            this.labelData.Text = "ID";
            this.labelData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbDeleteData
            // 
            this.tbDeleteData.Location = new System.Drawing.Point(6, 30);
            this.tbDeleteData.Name = "tbDeleteData";
            this.tbDeleteData.Size = new System.Drawing.Size(100, 20);
            this.tbDeleteData.TabIndex = 35;
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(143, 21);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(102, 36);
            this.butDelete.TabIndex = 34;
            this.butDelete.Text = "Удалить";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инструментыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(101, 361);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(88, 19);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.ToolTipText = "Выход из соединения базы данных!";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обновитьToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(88, 19);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // fAccrueSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 361);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fAccrueSalary";
            this.Text = "Начисление зарплаты";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fAccrueSalary_FormClosing);
            this.Load += new System.EventHandler(this.fAccrueSalary_Load_1);
            this.tabControl.ResumeLayout(false);
            this.tabPageSelect.ResumeLayout(false);
            this.tabPageInsert.ResumeLayout(false);
            this.tabPageInsert.PerformLayout();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.tabPageDelete.ResumeLayout(false);
            this.tabPageDelete.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butAddDB;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label labelSecondName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastNameInsert;
        private System.Windows.Forms.TabPage tabPageDelete;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.TabPage tabPageInsert;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TextBox tbDepartmentInsert;
        private System.Windows.Forms.TextBox tbPostInsert;
        private System.Windows.Forms.TextBox tbSecondNameInsert;
        private System.Windows.Forms.TextBox tbFirstNameInsert;
        private System.Windows.Forms.TextBox tbLastNameInsert;
        private System.Windows.Forms.TextBox tbSalaryUpdate;
        private System.Windows.Forms.Label labelSalaryUpdate;
        private System.Windows.Forms.Button butUpdateData;
        private System.Windows.Forms.TextBox tbSalaryInsert;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Label labelIdDelete;
        private System.Windows.Forms.TextBox tbIdUpdate;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox tbDeleteData;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.Label labelExeptionInsert;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.Label labelExceptionUpdate;
        private System.Windows.Forms.Label labelExceptionDelete;
    }
}