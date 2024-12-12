using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using WinFormsApp1.Models;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private DbRepository<Lesson> _repositoryLessons;

        public Form1()
        {
            InitializeComponent();
            var connection = new DbContextOptionsBuilder<sql8751184Context>();
            connection.UseMySql("Server=sql8.freesqldatabase.com;Database=sql8751184;User=sql8751184;Password=KFLf9dkgar;", new MySqlServerVersion(new Version(8, 0, 32)));
            _repositoryLessons = new DbRepository<Lesson>(connection.Options);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string lessonID = dataGridView1.Rows[e.RowIndex].Cells["LessonId"].Value.ToString();
            string groupID = dataGridView1.Rows[e.RowIndex].Cells["GroupId"].Value.ToString();
            string officeID = dataGridView1.Rows[e.RowIndex].Cells["OfficeId"].Value.ToString();
            string subjectID = dataGridView1.Rows[e.RowIndex].Cells["SubjectId"].Value.ToString();
            string dayID = dataGridView1.Rows[e.RowIndex].Cells["DayId"].Value.ToString();
            string lessonType = dataGridView1.Rows[e.RowIndex].Cells["LessonsType"].Value.ToString();

            var lesson = new Lesson
            {
                LessonId = Convert.ToInt32(lessonID),
                GroupId = Convert.ToInt32(groupID),
                OfficeId = Convert.ToInt32(officeID),
                SubjectId = Convert.ToInt32(subjectID),
                DayId = Convert.ToInt32(dayID),
                LessonsType = lessonType
            };

            _repositoryLessons.Add(lesson);
            dataGridView1.DataSource = _repositoryLessons;

        }
    }
}
