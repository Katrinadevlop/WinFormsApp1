using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.DbRepository;
using WinFormsApp1.Models;
using Day = WinFormsApp1.Models.Day;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private DbRepository<Semester> _repositorySemester;
        private DbRepository<Week> _repositoryWeek;
        private DbRepository<Day> _repositoryDay;
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
            _repositoryDay = new DbRepository<Day>(connection.Options);
            _repositoryTypeOffice = new DbRepository<TypeOffice>(connection.Options);
            _repositoryOffice = new DbRepository<Office>(connection.Options);
            _repositoryLessonType = new DbRepository<LessonType>(connection.Options);
            _repositoryGroup = new DbRepository<Group>(connection.Options);
            _repositoryLesssonOrder = new DbRepository<LesssonOrder>(connection.Options);
            _repositoryTeacher = new DbRepository<Teacher>(connection.Options);
            _repositorySubject = new DbRepository<Subject>(connection.Options);

            _repositoryLesson = new DbRepository<Lesson>(connection.Options);

            LoadData();
        }

        private void LoadData()
        {
            dataGridView4.DataSource = new BindingList<Semester>(_repositorySemester.GetAll());
            dataGridView3.DataSource = new BindingList<Week>(_repositoryWeek.GetAll());
            dataGridView2.DataSource = new BindingList<Day>(_repositoryDay.GetAll());
            dataGridView5.DataSource = new BindingList<Subject>(_repositorySubject.GetAll());
            dataGridView7.DataSource = new BindingList<Teacher>(_repositoryTeacher.GetAll());
            dataGridView8.DataSource = new BindingList<Group>(_repositoryGroup.GetAll());
            dataGridView9.DataSource = new BindingList<Office>(_repositoryOffice.GetAll());
            dataGridView11.DataSource = new BindingList<TypeOffice>(_repositoryTypeOffice.GetAll());
            dataGridView6.DataSource = new BindingList<LesssonOrder>(_repositoryLesssonOrder.GetAll());
            dataGridView10.DataSource = new BindingList<LessonType>(_repositoryLessonType.GetAll());

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

        private void ProcessEntity<TEntity>(DataGridView dataGrid, DbRepository<TEntity> repository, Action<TEntity> action) where TEntity : class, new()
        {
            try
            {
                var entityType = typeof(TEntity);
                var entity = new TEntity();

                foreach (DataGridViewColumn column in dataGrid.Columns)
                {
                    var property = entityType.GetProperty(column.DataPropertyName);
                    if (property != null && dataGrid.CurrentRow.Cells[column.Index].Value != null && dataGrid.CurrentRow.Cells[column.Index].Value != DBNull.Value)
                    {
                        var value = Convert.ChangeType(dataGrid.CurrentRow.Cells[column.Index].Value, property.PropertyType);
                        property.SetValue(entity, value);
                    }
                }

                action(entity);
                MessageBox.Show("Данные добавлены!");
                LoadData();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка: " + e);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
                ProcessEntity(dataGridView2, _repositoryDay, entity => _repositoryDay.Add(entity));
            else if (tabControl1.SelectedIndex == 2)
                ProcessEntity(dataGridView3, _repositoryWeek, entity => _repositoryWeek.Add(entity));
            else if (tabControl1.SelectedIndex == 3)
                ProcessEntity(dataGridView4, _repositorySemester, entity => _repositorySemester.Add(entity));
            else if (tabControl1.SelectedIndex == 4)
                ProcessEntity(dataGridView5, _repositorySubject, entity => _repositorySubject.Add(entity));
            else if (tabControl1.SelectedIndex == 9)
                ProcessEntity(dataGridView6, _repositoryLesssonOrder, entity => _repositoryLesssonOrder.Add(entity));
            else if (tabControl1.SelectedIndex == 5)
                ProcessEntity(dataGridView7, _repositoryTeacher, entity => _repositoryTeacher.Add(entity));
            else if (tabControl1.SelectedIndex == 6)
                ProcessEntity(dataGridView8, _repositoryGroup, entity => _repositoryGroup.Add(entity));
            else if (tabControl1.SelectedIndex == 7)
                ProcessEntity(dataGridView9, _repositoryOffice, entity => _repositoryOffice.Add(entity));
            else if (tabControl1.SelectedIndex == 10)
                ProcessEntity(dataGridView10, _repositoryLessonType, entity => _repositoryLessonType.Add(entity));
            else if (tabControl1.SelectedIndex == 8)
                ProcessEntity(dataGridView11, _repositoryTypeOffice, entity => _repositoryTypeOffice.Add(entity));
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
