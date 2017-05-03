using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;

namespace LabaUniversityWithDB {
    public partial class fAccrueSalary : Form {
        SqlConnection sqlConnection;

        public fAccrueSalary() {
            InitializeComponent();
        }

        private async void fAccrueSalary_Load_1(object sender, EventArgs e) {
            string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Kiril\onedrive\документы\visual studio 2015\Projects\LabaUniversityWithDB\LabaUniversityWithDB\DatabaseBookkeeping.mdf;Integrated Security = True";

            sqlConnection = new SqlConnection(connectionString);
            // Открываем соединение с базой данных
            await sqlConnection.OpenAsync();

            SqlDataReader sqlDataReader = null;
            // Дальше мы должны написать скрипт, для того чтобы подкачать из базы данных данные))
            // 1) можно это сделать через скрипт 2) можно через SqlCommand
            listBox1.Items.Clear();
            SqlCommand command = new SqlCommand("SELECT * FROM [EmployeesSalary]", sqlConnection);

            try {
                //ExecuteReaderAsync - считывает таблицу
                sqlDataReader = await command.ExecuteReaderAsync();
                //command.ExecuteNonQuery() - метод ничего не возращает (работаем в одну сторону)
                while (await sqlDataReader.ReadAsync()) {
                    listBox1.Items.Add(Convert.ToString(sqlDataReader["Id"]) + "        " + Convert.ToString(sqlDataReader["LastName"]) +
                        "       " + Convert.ToString(sqlDataReader["FirstName"]) + "      " + Convert.ToString(sqlDataReader["SecondName"]) +
                        "       " + Convert.ToString(sqlDataReader["Post"]) + "         " + Convert.ToString(sqlDataReader["Salary"]) +
                        "       " + Convert.ToString(sqlDataReader["Department"]));
                }
            }
            catch (Exception ex) {
                // 1)текст 2) Заголовок 3)кнопка 4) иконка
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                if (sqlDataReader != null) {
                    sqlDataReader.Close();
                }
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e) {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) {
                // Чтобы не было утечки памяти
                sqlConnection.Close();
                this.Close();
            }
        }

        private void fAccrueSalary_FormClosing(object sender, FormClosingEventArgs e) {
            if (sqlConnection != null && sqlConnection.State != ConnectionState.Closed) {
                // Чтобы не было утечки памяти
                sqlConnection.Close();
            }
        }

        private async void butAddDB_Click(object sender, EventArgs e) {
            if (labelExeptionInsert.Visible) {
                labelExeptionInsert.Visible = false;
            }

            if (!string.IsNullOrEmpty(tbLastNameInsert.Text) && !string.IsNullOrWhiteSpace(tbLastNameInsert.Text)
                && !string.IsNullOrEmpty(tbFirstNameInsert.Text) && !string.IsNullOrWhiteSpace(tbFirstNameInsert.Text)
                && !string.IsNullOrEmpty(tbSecondNameInsert.Text) && !string.IsNullOrWhiteSpace(tbSecondNameInsert.Text)
                && !string.IsNullOrEmpty(tbPostInsert.Text) && !string.IsNullOrWhiteSpace(tbPostInsert.Text)
                && !string.IsNullOrEmpty(tbSalaryInsert.Text) && !string.IsNullOrWhiteSpace(tbSalaryInsert.Text)
                && !string.IsNullOrEmpty(tbDepartmentInsert.Text) && !string.IsNullOrWhiteSpace(tbDepartmentInsert.Text)) {
                SqlCommand command =
                    new SqlCommand(
                        "INSERT INTO [EmployeesSalary] (LastName,FirstName,SecondName,Post,Salary,Department)" +
                        "VALUES(@LastName, @FirstName, @SecondName, @Post, @Salary, @Department)", sqlConnection);

                command.Parameters.AddWithValue("LastName", tbLastNameInsert.Text);
                command.Parameters.AddWithValue("FirstName", tbFirstNameInsert.Text);
                command.Parameters.AddWithValue("SecondName", tbSecondNameInsert.Text);
                command.Parameters.AddWithValue("Post", tbPostInsert.Text);
                command.Parameters.AddWithValue("Salary", tbSalaryInsert.Text);
                command.Parameters.AddWithValue("Department", tbDepartmentInsert.Text);

                await command.ExecuteNonQueryAsync();
                }
            else {
                labelExeptionInsert.Visible = true;
                labelExeptionInsert.Text = "Поля должны быть заполнены!";
            }
            ClearTextBoxInsert();
        }
        private async void обновитьToolStripMenuItem_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();

            SqlDataReader sqlDataReader = null;
            // Дальше мы должны написать скрипт, для того чтобы подкачать из базы данных данные))
            // 1) можно это сделать через скрипт 2) можно через SqlCommand
            SqlCommand command = new SqlCommand("SELECT * FROM [EmployeesSalary]", sqlConnection);

            try {
                //ExecuteReaderAsync - считывает таблицу
                sqlDataReader = await command.ExecuteReaderAsync();
                //command.ExecuteNonQuery() - метод ничего не возращает (работаем в одну сторону)
                while (await sqlDataReader.ReadAsync()) {
                    listBox1.Items.Add(Convert.ToString(sqlDataReader["Id"]) + "        " + Convert.ToString(sqlDataReader["LastName"]) +
                        "       " + Convert.ToString(sqlDataReader["FirstName"]) + "      " + Convert.ToString(sqlDataReader["SecondName"]) +
                        "       " + Convert.ToString(sqlDataReader["Post"]) + " " + Convert.ToString(sqlDataReader["Salary"]) +
                        "       " + Convert.ToString(sqlDataReader["Department"]));
                }
            }
            catch (Exception ex) {
                // 1)текст 2) Заголовок 3)кнопка 4) иконка
                MessageBox.Show(ex.Message.ToString(), ex.Source.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                if (sqlDataReader != null) {
                    sqlDataReader.Close();
                }
            }
        }

        private async void butUpdateData_Click(object sender, EventArgs e) {
            if (labelExceptionUpdate.Visible) {
                labelExeptionInsert.Visible = false;
            }

            if (!string.IsNullOrEmpty(tbIdUpdate.Text) && !string.IsNullOrWhiteSpace(tbIdUpdate.Text)
                && !string.IsNullOrEmpty(tbSalaryUpdate.Text) && !string.IsNullOrWhiteSpace(tbSalaryUpdate.Text))
            {
                SqlCommand command = new SqlCommand("UPDATE [EmployeesSalary] SET Salary = @Salary WHERE [Id] = @Id", sqlConnection);

                command.Parameters.AddWithValue("Id", tbIdUpdate.Text);
                //command.Parameters.AddWithValue("LastName", tbLastNameUpdate.Text);
                //command.Parameters.AddWithValue("FirstName", tbFirstNameUpdate.Text);
                //command.Parameters.AddWithValue("SecondName", tbSecondNameUpdate.Text);
                //command.Parameters.AddWithValue("Post", tbPostUpdate.Text);
                command.Parameters.AddWithValue("Salary", tbSalaryUpdate.Text);
                //command.Parameters.AddWithValue("Department", tbDepartmentUpdate.Text);

                await command.ExecuteNonQueryAsync();
            }
            else if (!string.IsNullOrEmpty(tbIdUpdate.Text) && !string.IsNullOrWhiteSpace(tbIdUpdate.Text))
            {
                labelExceptionUpdate.Visible = true;
                labelExceptionUpdate.Text = "Id должен быть заполнен!";
            }
            else
            {
                labelExceptionUpdate.Visible = true;
                labelExceptionUpdate.Text = "Проверте остальные поля, они должны быть заполнены!";
            }
            ClearTextBoxUpdate();
        }

        private async void butDelete_Click(object sender, EventArgs e)
        {
            if (labelExceptionDelete.Visible)
            {
                labelExceptionDelete.Visible = false;
            }

            if (!string.IsNullOrEmpty(tbDeleteData.Text) && !string.IsNullOrWhiteSpace(tbDeleteData.Text))
            {
                SqlCommand command = new SqlCommand("DELETE FROM [EmployeesSalary] WHERE [Id]=@Id", sqlConnection);

                command.Parameters.AddWithValue("Id", tbDeleteData.Text);

                await command.ExecuteNonQueryAsync();
            }
            else
            {
                labelExceptionDelete.Visible = true;
                labelExceptionDelete.Text = "Заполните поле Id";
            }
            ClearTextBoxDelete();
        }

        // TODO: КАК сделать без повторений спомощью EVENT?
        private void ClearTextBoxInsert()
        {
            tbLastNameInsert.Text = "";
            tbFirstNameInsert.Text = "";
            tbSecondNameInsert.Text = "";
            tbPostInsert.Text = "";
            tbSalaryInsert.Text = "";
            tbDepartmentInsert.Text = "";
        }
        private void ClearTextBoxUpdate()
        {
            tbIdUpdate.Text = "";
            //tbLastNameUpdate.Text = "";
            //tbFirstNameUpdate.Text = "";
            //tbSecondNameUpdate.Text = "";
            //tbPostUpdate.Text = "";
            tbSalaryUpdate.Text = "";
            //tbDepartmentUpdate.Text = "";
        }
        private void ClearTextBoxDelete() {
            tbDeleteData.Text = "";
        }
    }
}
