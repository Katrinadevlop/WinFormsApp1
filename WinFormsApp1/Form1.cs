using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Windows.Forms;
using WinFormsApp1.DbRepository;
using WinFormsApp1.Models;
using Day = WinFormsApp1.Models.Day;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        ComboBox comboBoxGroup = new ComboBox();
        ComboBox comboBoxTeacher = new ComboBox();
        ComboBox comboBoxOffice = new ComboBox();

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

            ConfigureDataGridView();
            LoadData();
        }

        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            // Колонка для кабинета
            var officeColumn = new DataGridViewTextBoxColumn
            {
                Name = "OfficeName",
                HeaderText = "Кабинет",
                DataPropertyName = "OfficeName",
                ReadOnly = true
            };

            // Колонка для комбобокса с группами, преподавателями и предметами
            var comboBoxColumn = new DataGridViewComboBoxColumn
            {
                Name = "GroupTeacherSubject",
                HeaderText = "Группа, Преподаватель, Предмет",
                DisplayMember = "DisplayName", // свойство для отображения
                ValueMember = "Value", // значение, которое будет использоваться
                DataPropertyName = "GroupTeacherSubject", // имя свойства для привязки
            };

            // Заполняем комбобоксы для столбца с группами, преподавателями и предметами
            var comboData = _repositoryGroup.GetAll().Join(_repositoryTeacher.GetAll(),
                group => group.GroupID,
                teacher => teacher.TeacherID,
                (group, teacher) => new
                {
                    DisplayName = $"{group.GroupName} - {teacher.LastName} ({teacher.TeacherID})",
                    Value = group.GroupID // или другое значение, в зависимости от ваших требований
                }).ToList();

            comboBoxColumn.DataSource = comboData;

            // Добавляем столбцы в DataGridView
            dataGridView1.Columns.AddRange(officeColumn, comboBoxColumn);
        }


        private void LoadData()
        {
            try
            {
                var semesterData = _repositorySemester.GetAll();
                var weekData = _repositoryWeek.GetAll();
                var dayData = _repositoryDay.GetAll();
                var subjectData = _repositorySubject.GetAll();
                var teacherData = _repositoryTeacher.GetAll();
                var groupData = _repositoryGroup.GetAll();
                var officeData = _repositoryOffice.GetAll();
                var typeOfficeData = _repositoryTypeOffice.GetAll();
                var lesssonOrderData = _repositoryLesssonOrder.GetAll();
                var lessonTypeData = _repositoryLessonType.GetAll();
                var lessonData = _repositoryLesson.GetAll();
                var lessonInfo = (from Lesson in lessonData
                                    join Office in officeData on Lesson.OfficeID equals Office.OfficeID
                                    join Group in groupData on Lesson.GroupID equals Group.GroupID
                                    join Subject in subjectData on Lesson.SubjectID equals Subject.SubjectID
                                    join Teacher in teacherData on Lesson.TeacherID equals Teacher.TeacherID
                                    select new LessonInfo
                                    {
                                        LessonID = Lesson.LessonID,
                                        GroupName = Group.GroupName,
                                        TeacherName = Teacher.LastName,
                                        OfficeName = Office.OfficeID.ToString(),
                                        SubjectName = Subject.SubjectName,
                                    }).ToList();

                dataGridView1.DataSource = new BindingList<LessonInfo>(lessonInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0) 
            {
                if (e.RowIndex % 3 == 0)
                {
                    int mergeHeight = dataGridView1.Rows[e.RowIndex].Height * 3;

                    Rectangle rect = new Rectangle(e.CellBounds.Left, e.CellBounds.Top, e.CellBounds.Width, mergeHeight);
                    using (Brush backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                    {
                        e.Graphics.FillRectangle(backColorBrush, rect);
                    }
                    e.Graphics.DrawRectangle(Pens.Black, rect);

                    if (e.RowIndex % 3 == 0)
                    {
                        string groupText = 1.ToString(); 
                        TextRenderer.DrawText(e.Graphics, groupText, e.CellStyle.Font, rect, e.CellStyle.ForeColor);
                    }

                    e.Handled = true;
                }
                else
                {
                    e.Handled = true; 
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var semesterId = Convert.ToInt16(dataGridView4.CurrentRow.Cells[0].Value);
            var semesterNumber = Convert.ToInt16(dataGridView4.CurrentRow.Cells[1].Value);

            try
            {
                var newSemester = new Semester
                {
                    SemesterID = semesterId,
                    SemesterNumber = semesterNumber
                };
                _repositorySemester.Add(newSemester);
                MessageBox.Show("Данные сохранились!");
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

        //Изменение недели
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView3.CurrentRow == null) return;

                int weekId = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);
                int numberWeek = Convert.ToInt32(dataGridView3.CurrentRow.Cells[1].Value);

                var existingWeek = _repositoryWeek.GetAll().FirstOrDefault(s => s.WeekID == weekId);

                if (existingWeek != null)
                {
                    existingWeek.WeekNumber = numberWeek;
                    _repositoryWeek.Update(existingWeek);
                    MessageBox.Show("Неделя обновлена!");
                }
                else
                {
                    MessageBox.Show("Неделя не найдена!");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления: " + ex.Message);
            }
        }

        //Добавление недели
        private void button6_Click(object sender, EventArgs e)
        {
            int numberWeek = Convert.ToInt32(dataGridView3.CurrentRow.Cells[1].Value);
            int semesterId = Convert.ToInt32(dataGridView3.CurrentRow.Cells[2].Value);
            try
            {
                var newWeek = new Week
                {
                    WeekNumber = numberWeek,
                    SemesterID = semesterId
                };
                _repositoryWeek.Add(newWeek);
                MessageBox.Show("Неделя сохранилась!");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка обновления: " + ex.Message);
            }
        }

        //Удаление недели
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView3.CurrentRow == null) return;

                int weekId = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);

                var weekToDelete = _repositoryWeek.GetAll().FirstOrDefault(w => w.WeekID == weekId);

                if (weekToDelete != null)
                {
                    _repositoryWeek.Delete(weekToDelete);
                    MessageBox.Show("Неделя удалёна!");
                }
                else
                {
                    MessageBox.Show("Неделя не найдена!");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления: " + ex.Message);
            }
        }

        //Добавление дня недели
        private void button9_Click(object sender, EventArgs e)
        {
            var dayId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            var nameDay = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            var weekId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[2].Value);

            try
            {
                var day = new Day
                {
                    DayID = dayId,
                    DayName = nameDay,
                    WeekID = weekId
                };

                _repositoryDay.Add(day);
                MessageBox.Show("День недели сохранился");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("День недели не сохранился" + ex);
            }
        }

        //Обновление дня недели
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.CurrentRow == null) return;

                var dayId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                var excistingDay = _repositoryDay.GetAll().FirstOrDefault(d => d.DayID == dayId);

                if (excistingDay != null)
                {
                    _repositoryDay.Update(excistingDay);
                    MessageBox.Show("День недели обновлён!");
                }
                else
                {
                    MessageBox.Show("День недели не найден!");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("День недели не изменился" + ex);
            }
        }

        //Удаление дня недели
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.CurrentRow == null) return;

                var dayId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
                var excistingDay = _repositoryDay.GetAll().FirstOrDefault(d => d.DayID == dayId);

                if (excistingDay != null)
                {
                    _repositoryDay.Delete(excistingDay);
                    MessageBox.Show("День недели удалён!");
                }
                else
                {
                    MessageBox.Show("День недели не найден!");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("День недели не удалился" + ex);
            }
        }

        //Добавление предмета
        private void button15_Click(object sender, EventArgs e)
        {
            var subjectId = Convert.ToInt32(dataGridView5.CurrentRow.Cells[0].Value);
            var subjectscol = dataGridView5.CurrentRow.Cells[1].Value.ToString();
            var subjectName = dataGridView5.CurrentRow.Cells[2].Value.ToString();
            var hoursPerLecture = Convert.ToInt32(dataGridView5.CurrentRow.Cells[3].Value);
            var hoursPerPractic = Convert.ToInt32(dataGridView5.CurrentRow.Cells[4].Value);
            var hoursPerLaborat = Convert.ToInt32(dataGridView5.CurrentRow.Cells[5].Value);
            var hoursPerConsult = Convert.ToInt32(dataGridView5.CurrentRow.Cells[6].Value);
            var hoursPerExam = Convert.ToInt32(dataGridView5.CurrentRow.Cells[7].Value);

            try
            {
                var subject = new Subject
                {
                    SubjectID = subjectId,
                    SubjectName = subjectName,
                    HoursPerLecture = hoursPerLecture,
                    HoursPerPractic = hoursPerPractic,
                    HoursPerLaborat = hoursPerLaborat,
                    HoursPerConsult = hoursPerConsult,
                    HoursPerExam = hoursPerExam,
                    Subjectscol = subjectscol
                };

                _repositorySubject.Add(subject);
                MessageBox.Show("Предмет сохранился");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Предмет не сохранился" + ex);
            }
        }

        //Изменение предмета
        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView5.CurrentRow == null) return;

                var subjectId = Convert.ToInt32(dataGridView5.CurrentRow.Cells[0].Value);
                var existingSubject = _repositorySubject.GetAll().FirstOrDefault(s => s.SubjectID == subjectId);

                if (existingSubject != null)
                {
                    _repositorySubject.Update(existingSubject);
                    MessageBox.Show("Предмет изменился");
                }
                else
                {
                    MessageBox.Show("Предмет не найден");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Предмет не изменился" + ex);
            }
        }

        //Удаление предмета
        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView5.CurrentRow == null) return;

                var subjectId = Convert.ToInt32(dataGridView5.CurrentRow.Cells[0].Value);
                var existingSubject = _repositorySubject.GetAll().FirstOrDefault(s => s.SubjectID == subjectId);

                if (existingSubject != null)
                {
                    _repositorySubject.Delete(existingSubject);
                    MessageBox.Show("Предмет удалился");
                }
                else
                {
                    MessageBox.Show("Предмет не найден");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Предмет не удалился" + ex);
            }
        }

        //Добавление преподавателя
        private void button18_Click(object sender, EventArgs e)
        {
            var teacherId = Convert.ToInt32(dataGridView7.CurrentRow.Cells[0].Value);
            var firstName = dataGridView7.CurrentRow.Cells[1].Value.ToString();
            var lastName = dataGridView7.CurrentRow.Cells[2].Value.ToString();
            var middleName = dataGridView7.CurrentRow.Cells[3].Value.ToString();
            var isAvailable = Convert.ToBoolean(dataGridView7.CurrentRow.Cells[4].Value);

            try
            {
                var teacher = new Teacher()
                {
                    TeacherID = teacherId,
                    FirstName = firstName,
                    LastName = lastName,
                    MiddleName = middleName,
                    IsAvailable = isAvailable
                };

                _repositoryTeacher.Add(teacher);
                MessageBox.Show("Преподаватель сохранился");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Преподаватель не добавлен " + ex);
            }
        }

        //Изменение преподавателя
        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView7.CurrentRow == null) return;

                var teacherId = Convert.ToInt32(dataGridView7.CurrentRow.Cells[0].Value);
                var existingTeacher = _repositoryTeacher.GetAll().FirstOrDefault(t => t.TeacherID == teacherId);

                if (existingTeacher != null)
                {
                    _repositoryTeacher.Update(existingTeacher);
                    MessageBox.Show("Преподаватель изменился");
                }
                else
                {
                    MessageBox.Show("Предмет не найден");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Преподаватель не изменился" + ex);
            }
        }

        //Удаление преподавателя
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView7.CurrentRow == null) return;

                var teacherId = Convert.ToInt32(dataGridView7.CurrentRow.Cells[0].Value);
                var existingTeacher = _repositoryTeacher.GetAll().FirstOrDefault(t => t.TeacherID == teacherId);

                if (existingTeacher != null)
                {
                    _repositoryTeacher.Delete(existingTeacher);
                    MessageBox.Show("Преподаватель удалился");
                }
                else
                {
                    MessageBox.Show("Преподаватель не найден");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Предмет не удалился" + ex);
            }
        }

        //Добавление группы
        private void button21_Click(object sender, EventArgs e)
        {
            var groudId = Convert.ToInt32(dataGridView8.CurrentRow.Cells[0].Value);
            var groupName = dataGridView8.CurrentRow.Cells[1].Value.ToString();

            try
            {
                var group = new Group()
                {
                    GroupID = groudId,
                    GroupName = groupName
                };

                _repositoryGroup.Add(group);
                MessageBox.Show("Группа добавлена");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Группа не сохранилась " + ex);
            }
        }

        //Изменение группы
        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView8.CurrentRow == null) return;

                var groupId = Convert.ToInt32(dataGridView8.CurrentRow.Cells[0].Value);
                var existingGroup = _repositoryGroup.GetAll().FirstOrDefault(g => g.GroupID == groupId);

                if (existingGroup != null)
                {
                    _repositoryGroup.Update(existingGroup);
                    MessageBox.Show("Группа изменена");
                }
                else
                {
                    MessageBox.Show("Группа не найдена");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Группа не изменена" + ex);
            }
        }

        //Удаление группы
        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView8.CurrentRow == null) return;

                var groupId = Convert.ToInt32(dataGridView8.CurrentRow.Cells[0].Value);
                var existingGroup = _repositoryGroup.GetAll().FirstOrDefault(g => g.GroupID == groupId);

                if (existingGroup != null)
                {
                    _repositoryGroup.Delete(existingGroup);
                    MessageBox.Show("Группа удалена");
                }
                else
                {
                    MessageBox.Show("Группа не найдена");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Группа не удалилась" + ex);
            }
        }

        //Добавление кабинета
        private void button24_Click(object sender, EventArgs e)
        {
            try
            {
                var officeId = Convert.ToInt32(dataGridView9.CurrentRow.Cells[0].Value);
                var numberSeats = Convert.ToInt32(dataGridView9.CurrentRow.Cells[1].Value);

                var office = new Office()
                {
                    OfficeID = officeId,
                    NumberSeats = numberSeats
                };

                _repositoryOffice.Add(office);
                MessageBox.Show("Офис добавлен");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Офис не сохранился " + ex);
            }
        }

        //Изменение кабинета
        private void button23_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView9.CurrentRow == null) return;

                var officeId = Convert.ToInt32(dataGridView9.CurrentRow.Cells[0].Value);
                var existingOffice = _repositoryOffice.GetAll().FirstOrDefault(o => o.OfficeID == officeId);

                if (existingOffice != null)
                {
                    _repositoryOffice.Update(existingOffice);
                    MessageBox.Show("Офис изменен");
                }
                else
                {
                    MessageBox.Show("Офис не найден");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Офис не изменен " + ex);
            }
        }

        //Удаление кабинета
        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView9.CurrentRow == null) return;

                var officeId = Convert.ToInt32(dataGridView9.CurrentRow.Cells[0].Value);
                var existingOffice = _repositoryOffice.GetAll().FirstOrDefault(o => o.OfficeID == officeId);

                if (existingOffice != null)
                {
                    _repositoryOffice.Delete(existingOffice);
                    MessageBox.Show("Офис удален");
                }
                else
                {
                    MessageBox.Show("Офис не найден");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Офис не удален " + ex);
            }
        }

        //Добавление типа кабинета
        private void button27_Click(object sender, EventArgs e)
        {
            try
            {
                var officeTypeId = Convert.ToInt32(dataGridView11.CurrentRow.Cells[0].Value);
                var officeTypeName = dataGridView11.CurrentRow.Cells[1].Value.ToString();

                var officeType = new TypeOffice()
                {
                    OfficeTypeID = officeTypeId,
                    OfficeType = officeTypeName
                };

                _repositoryTypeOffice.Add(officeType);
                MessageBox.Show("Тип офиса добавлен");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Тип офиса не сохранился " + ex);
            }
        }

        //Изменение типа кабинета
        private void button26_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView11.CurrentRow == null) return;

                var officeTypeId = Convert.ToInt32(dataGridView11.CurrentRow.Cells[0].Value);
                var existingTypeOffice = _repositoryTypeOffice.GetAll().FirstOrDefault(o => o.OfficeTypeID == officeTypeId);

                if (existingTypeOffice != null)
                {
                    _repositoryTypeOffice.Update(existingTypeOffice);
                    MessageBox.Show("Тип офиса изменен");
                }
                else
                {
                    MessageBox.Show("Тип офиса не найден");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Тип офиса не изменен " + ex);
            }
        }

        //Удаление типа кабинета
        private void button25_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView11.CurrentRow == null) return;

                var officeTypeId = Convert.ToInt32(dataGridView11.CurrentRow.Cells[0].Value);
                var existingTypeOffice = _repositoryTypeOffice.GetAll().FirstOrDefault(o => o.OfficeTypeID == officeTypeId);

                if (existingTypeOffice != null)
                {
                    _repositoryTypeOffice.Delete(existingTypeOffice);
                    MessageBox.Show("Тип офиса удален");
                }
                else
                {
                    MessageBox.Show("Тип офиса не найден");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Тип офиса не удален " + ex);
            }
        }

        //Добавление LesssonOrder
        private void button30_Click(object sender, EventArgs e)
        {
            try
            {
                var lessonOrderId = Convert.ToInt32(dataGridView6.CurrentRow.Cells[0].Value);
                var lessonOrderNumber = Convert.ToInt32(dataGridView6.CurrentRow.Cells[1].Value);

                var lessonOrder = new LesssonOrder()
                {
                    LesssonOrderID = lessonOrderId,
                    LesssonOrder1 = lessonOrderNumber
                };

                _repositoryLesssonOrder.Add(lessonOrder);
                MessageBox.Show("Заказ урока добавлен");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заказ урока не сохранился " + ex);
            }
        }

        //Изменение LesssonOrder
        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView6.CurrentRow == null) return;

                var lessonOrderId = Convert.ToInt32(dataGridView6.CurrentRow.Cells[0].Value);
                var existingLessonOrder = _repositoryLesssonOrder.GetAll().FirstOrDefault(lo => lo.LesssonOrderID == lessonOrderId);

                if (existingLessonOrder != null)
                {
                    _repositoryLesssonOrder.Update(existingLessonOrder);
                    MessageBox.Show("Заказ урока изменен");
                }
                else
                {
                    MessageBox.Show("Заказ урока не найден");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заказ урока не изменен " + ex);
            }
        }

        //Удаление LesssonOrder
        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView6.CurrentRow == null) return;

                var lessonOrderId = Convert.ToInt32(dataGridView6.CurrentRow.Cells[0].Value);
                var existingLessonOrder = _repositoryLesssonOrder.GetAll().FirstOrDefault(lo => lo.LesssonOrderID == lessonOrderId);

                if (existingLessonOrder != null)
                {
                    _repositoryLesssonOrder.Delete(existingLessonOrder);
                    MessageBox.Show("Заказ урока удален");
                }
                else
                {
                    MessageBox.Show("Заказ урока не найден");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Заказ урока не удален " + ex);
            }
        }

        //Добаление типа пары
        private void button33_Click(object sender, EventArgs e)
        {
            try
            {
                var lessonTypeId = Convert.ToInt32(dataGridView10.CurrentRow.Cells[0].Value);
                var lessonTypeName = dataGridView10.CurrentRow.Cells[1].Value.ToString();

                var lessonType = new LessonType()
                {
                    LessonTypesID = lessonTypeId,
                    LessonTypes = lessonTypeName
                };

                _repositoryLessonType.Add(lessonType);
                MessageBox.Show("Тип пары добавлен");
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Тип пары не сохранился " + ex);
            }
        }

        //Изменение типа пары
        private void button32_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView10.CurrentRow == null) return;

                var lessonTypeId = Convert.ToInt32(dataGridView10.CurrentRow.Cells[0].Value);
                var existingLessonType = _repositoryLessonType.GetAll().FirstOrDefault(l => l.LessonTypesID == lessonTypeId);

                if (existingLessonType != null)
                {
                    _repositoryLessonType.Update(existingLessonType);
                    MessageBox.Show("Тип пары изменен");
                }
                else
                {
                    MessageBox.Show("Тип пары не найден");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Тип пары не изменен " + ex);
            }
        }

        //Удаление типа пары
        private void button31_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView10.CurrentRow == null) return;

                var lessonTypeId = Convert.ToInt32(dataGridView10.CurrentRow.Cells[0].Value);
                var existingLessonType = _repositoryLessonType.GetAll().FirstOrDefault(l => l.LessonTypesID == lessonTypeId);

                if (existingLessonType != null)
                {
                    _repositoryLessonType.Delete(existingLessonType);
                    MessageBox.Show("Тип пары удален");
                }
                else
                {
                    MessageBox.Show("Тип пары не найден");
                }
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Тип пары не удален " + ex);
            }
        }
    }
}
