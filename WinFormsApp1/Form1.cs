using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.DbRepository;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private DbRepository<Semester> _repositorySemester;
        private DbRepository<Week> _repositoryWeek;
        private DbRepository<Models.Day> _repositoryDay;
        private DbRepository<TypeOffice> _repositoryTypeOffice;
        private DbRepository<Office> _repositoryOffice;
        private DbRepository<LessonType> _repositoryLessonType;
        private DbRepository<Group> _repositoryGroup;
        private DbRepository<LesssonOrder> _repositoryLesssonOrder;
        private DbRepository<Teacher> _repositoryTeacher;
        private DbRepository<Subject> _repositorySubject;

        private DbRepository<Lesson> _repositoryLesson;

        public Form1()
        {
            InitializeComponent();
            var connection = new DbContextOptionsBuilder<sql8751184Context>();
            connection.UseMySql("Server=sql8.freesqldatabase.com;Database=sql8751184;User=sql8751184;Password=KFLf9dkgar;",
                new MySqlServerVersion(new Version(8, 0, 32)));
            _repositorySemester = new DbRepository<Semester>(connection.Options);
            _repositoryWeek = new DbRepository<Week>(connection.Options);
            _repositoryDay = new DbRepository<Models.Day>(connection.Options);
            _repositoryTypeOffice = new DbRepository<TypeOffice>(connection.Options);
            _repositoryOffice = new DbRepository<Office>(connection.Options);
            _repositoryLessonType = new DbRepository<LessonType>(connection.Options);
            _repositoryGroup = new DbRepository<Group>(connection.Options);
            _repositoryLesssonOrder = new DbRepository<LesssonOrder>(connection.Options);
            _repositoryTeacher = new DbRepository<Teacher>(connection.Options);
            _repositorySubject = new DbRepository<Subject>(connection.Options);

            _repositoryLesson = new DbRepository<Lesson>(connection.Options);

            LoadData();
            dataGridView4.AutoGenerateColumns = true;
        }

        private void LoadData()
        {
            dataGridView1.DataSource = new BindingList<LessonInfo>(
                (from Lesson in _repositoryLesson.GetAll()
                 join Office in _repositoryOffice.GetAll() on Lesson.OfficeID equals Office.OfficeID
                 join Group in _repositoryGroup.GetAll() on Lesson.GroupID equals Group.GroupID
                 join Subject in _repositorySubject.GetAll() on Lesson.SubjectID equals Subject.SubjectID
                 join Teacher in _repositoryTeacher.GetAll() on Lesson.TeacherID equals Teacher.TeacherID
                 select new LessonInfo
                 {
                     OfficeName = Office.OfficeID,
                     GroupName = Group.GroupName,
                     SubjectName = Subject.SubjectName,
                     TeacherName = Teacher.LastName
                 }).ToList());
        }

        public class LessonInfo
        {
            public int OfficeName { get; set; }
            public string GroupName { get; set; }
            public string SubjectName { get; set; }
            public string TeacherName { get; set; }
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
                    SemesterID = semesterId,
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

                var existingSemester = _repositorySemester.GetAll().FirstOrDefault(s => s.SemesterID == semesterId);

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

                var semesterToDelete = _repositorySemester.GetAll().FirstOrDefault(s => s.SemesterID == semesterId);

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
