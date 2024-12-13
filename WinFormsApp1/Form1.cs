using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private DbRepository<Semester> _repositorySemester;

        public Form1()
        {
            InitializeComponent();
            var connection = new DbContextOptionsBuilder<sql8751184Context>();
            connection.UseMySql("Server=sql8.freesqldatabase.com;Database=sql8751184;User=sql8751184;Password=KFLf9dkgar;",
                new MySqlServerVersion(new Version(8, 0, 32)));
            _repositorySemester = new DbRepository<Semester>(connection.Options);

            LoadData();
            dataGridView4.AutoGenerateColumns = true;
        }

        private void LoadData()
        {

            dataGridView4.DataSource = new BindingList<Semester>(_repositorySemester.GetAll().ToList());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView4.CurrentRow == null) return;

                int semesterId = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value);
                int semesterNumber = Convert.ToInt32(dataGridView4.CurrentRow.Cells[1].Value);

                var newSemester = new Semester
                {
                    SemesterId = semesterId,
                    SemesterNumber = semesterNumber
                };
                _repositorySemester.Add(newSemester);
                MessageBox.Show("Семестр добавлен!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView4.CurrentRow == null) return;

                int semesterId = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value);
                int semesterNumber = Convert.ToInt32(dataGridView4.CurrentRow.Cells[1].Value);

                var existingSemester = _repositorySemester.GetAll().FirstOrDefault(s => s.SemesterId == semesterId);

                if (existingSemester != null)
                {
                    existingSemester.SemesterNumber = semesterNumber;
                    _repositorySemester.Update(existingSemester);
                    MessageBox.Show("Данные обновлены!");
                }
                else
                {
                    MessageBox.Show("Семестр не найден!");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView4.CurrentRow == null) return;

                int semesterId = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value);

                var semesterToDelete = _repositorySemester.GetAll().FirstOrDefault(s => s.SemesterId == semesterId);

                if (semesterToDelete != null)
                {
                    _repositorySemester.Delete(semesterToDelete);
                    MessageBox.Show("Семестр удалён!");
                }
                else
                {
                    MessageBox.Show("Семестр не найден!");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления: " + ex.Message);
            }
        }
    }
}
