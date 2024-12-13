namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TypeOffices = new TabPage();
            dataGridView11 = new DataGridView();
            officeTypeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            typeOfficeBindingSource = new BindingSource(components);
            TypeAssign = new TabPage();
            dataGridView10 = new DataGridView();
            typeAssignBindingSource = new BindingSource(components);
            Offices = new TabPage();
            dataGridView9 = new DataGridView();
            numberSeatsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lessonsDataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            officeBindingSource = new BindingSource(components);
            Groups = new TabPage();
            dataGridView8 = new DataGridView();
            groupNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lessonsDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            groupBindingSource = new BindingSource(components);
            Teachers = new TabPage();
            dataGridView7 = new DataGridView();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            middleNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isAvailableDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            teacherBindingSource = new BindingSource(components);
            Subjects = new TabPage();
            dataGridView5 = new DataGridView();
            subjectNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoursPerLectureDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoursPerPracticDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoursPerLaboratDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoursPerConsultDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hoursPerExamDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lessonsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            subjectBindingSource = new BindingSource(components);
            Semesters = new TabPage();
            dataGridView4 = new DataGridView();
            semesterNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            semesterBindingSource = new BindingSource(components);
            Weeks = new TabPage();
            dataGridView3 = new DataGridView();
            weekNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            daysDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            semesterDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            weekBindingSource = new BindingSource(components);
            Day = new TabPage();
            dataGridView2 = new DataGridView();
            dayIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dayNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            weekIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            lessonsDataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            weekDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dayBindingSource = new BindingSource(components);
            Lessons = new TabPage();
            dataGridView1 = new DataGridView();
            tabControl1 = new TabControl();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            TypeOffices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeOfficeBindingSource).BeginInit();
            TypeAssign.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)typeAssignBindingSource).BeginInit();
            Offices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)officeBindingSource).BeginInit();
            Groups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)groupBindingSource).BeginInit();
            Teachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)teacherBindingSource).BeginInit();
            Subjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)subjectBindingSource).BeginInit();
            Semesters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)semesterBindingSource).BeginInit();
            Weeks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weekBindingSource).BeginInit();
            Day.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dayBindingSource).BeginInit();
            Lessons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // TypeOffices
            // 
            TypeOffices.Controls.Add(dataGridView11);
            TypeOffices.Cursor = Cursors.IBeam;
            TypeOffices.Location = new Point(4, 34);
            TypeOffices.Name = "TypeOffices";
            TypeOffices.Padding = new Padding(3);
            TypeOffices.Size = new Size(1115, 664);
            TypeOffices.TabIndex = 10;
            TypeOffices.Text = "TypeOffices";
            TypeOffices.UseVisualStyleBackColor = true;
            // 
            // dataGridView11
            // 
            dataGridView11.AutoGenerateColumns = false;
            dataGridView11.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView11.Columns.AddRange(new DataGridViewColumn[] { officeTypeDataGridViewTextBoxColumn1 });
            dataGridView11.DataSource = typeOfficeBindingSource;
            dataGridView11.Location = new Point(6, 5);
            dataGridView11.Name = "dataGridView11";
            dataGridView11.RowHeadersWidth = 62;
            dataGridView11.Size = new Size(1103, 655);
            dataGridView11.TabIndex = 2;
            // 
            // officeTypeDataGridViewTextBoxColumn1
            // 
            officeTypeDataGridViewTextBoxColumn1.DataPropertyName = "OfficeType";
            officeTypeDataGridViewTextBoxColumn1.HeaderText = "OfficeType";
            officeTypeDataGridViewTextBoxColumn1.MinimumWidth = 8;
            officeTypeDataGridViewTextBoxColumn1.Name = "officeTypeDataGridViewTextBoxColumn1";
            officeTypeDataGridViewTextBoxColumn1.Width = 150;
            // 
            // typeOfficeBindingSource
            // 
            typeOfficeBindingSource.DataSource = typeof(Models.TypeOffice);
            // 
            // TypeAssign
            // 
            TypeAssign.Controls.Add(dataGridView10);
            TypeAssign.Location = new Point(4, 34);
            TypeAssign.Name = "TypeAssign";
            TypeAssign.Padding = new Padding(3);
            TypeAssign.Size = new Size(1115, 664);
            TypeAssign.TabIndex = 9;
            TypeAssign.Text = "TypeAssign";
            TypeAssign.UseVisualStyleBackColor = true;
            // 
            // dataGridView10
            // 
            dataGridView10.AutoGenerateColumns = false;
            dataGridView10.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView10.DataSource = typeAssignBindingSource;
            dataGridView10.Location = new Point(6, 5);
            dataGridView10.Name = "dataGridView10";
            dataGridView10.RowHeadersWidth = 62;
            dataGridView10.Size = new Size(1103, 655);
            dataGridView10.TabIndex = 2;
            // 
            // Offices
            // 
            Offices.Controls.Add(dataGridView9);
            Offices.Location = new Point(4, 34);
            Offices.Name = "Offices";
            Offices.Padding = new Padding(3);
            Offices.Size = new Size(1115, 664);
            Offices.TabIndex = 8;
            Offices.Text = "Offices";
            Offices.UseVisualStyleBackColor = true;
            // 
            // dataGridView9
            // 
            dataGridView9.AutoGenerateColumns = false;
            dataGridView9.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView9.Columns.AddRange(new DataGridViewColumn[] { numberSeatsDataGridViewTextBoxColumn, lessonsDataGridViewTextBoxColumn2 });
            dataGridView9.DataSource = officeBindingSource;
            dataGridView9.Location = new Point(6, 5);
            dataGridView9.Name = "dataGridView9";
            dataGridView9.RowHeadersWidth = 62;
            dataGridView9.Size = new Size(1103, 655);
            dataGridView9.TabIndex = 2;
            // 
            // numberSeatsDataGridViewTextBoxColumn
            // 
            numberSeatsDataGridViewTextBoxColumn.DataPropertyName = "NumberSeats";
            numberSeatsDataGridViewTextBoxColumn.HeaderText = "NumberSeats";
            numberSeatsDataGridViewTextBoxColumn.MinimumWidth = 8;
            numberSeatsDataGridViewTextBoxColumn.Name = "numberSeatsDataGridViewTextBoxColumn";
            numberSeatsDataGridViewTextBoxColumn.Width = 150;
            // 
            // lessonsDataGridViewTextBoxColumn2
            // 
            lessonsDataGridViewTextBoxColumn2.DataPropertyName = "Lessons";
            lessonsDataGridViewTextBoxColumn2.HeaderText = "Lessons";
            lessonsDataGridViewTextBoxColumn2.MinimumWidth = 8;
            lessonsDataGridViewTextBoxColumn2.Name = "lessonsDataGridViewTextBoxColumn2";
            lessonsDataGridViewTextBoxColumn2.Width = 150;
            // 
            // officeBindingSource
            // 
            officeBindingSource.DataSource = typeof(Models.Office);
            // 
            // Groups
            // 
            Groups.Controls.Add(dataGridView8);
            Groups.Location = new Point(4, 34);
            Groups.Name = "Groups";
            Groups.Padding = new Padding(3);
            Groups.Size = new Size(1115, 664);
            Groups.TabIndex = 7;
            Groups.Text = "Groups";
            Groups.UseVisualStyleBackColor = true;
            // 
            // dataGridView8
            // 
            dataGridView8.AutoGenerateColumns = false;
            dataGridView8.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView8.Columns.AddRange(new DataGridViewColumn[] { groupNameDataGridViewTextBoxColumn, lessonsDataGridViewTextBoxColumn1 });
            dataGridView8.DataSource = groupBindingSource;
            dataGridView8.Location = new Point(6, 5);
            dataGridView8.Name = "dataGridView8";
            dataGridView8.RowHeadersWidth = 62;
            dataGridView8.Size = new Size(1103, 655);
            dataGridView8.TabIndex = 2;
            // 
            // groupNameDataGridViewTextBoxColumn
            // 
            groupNameDataGridViewTextBoxColumn.DataPropertyName = "GroupName";
            groupNameDataGridViewTextBoxColumn.HeaderText = "GroupName";
            groupNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            groupNameDataGridViewTextBoxColumn.Name = "groupNameDataGridViewTextBoxColumn";
            groupNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lessonsDataGridViewTextBoxColumn1
            // 
            lessonsDataGridViewTextBoxColumn1.DataPropertyName = "Lessons";
            lessonsDataGridViewTextBoxColumn1.HeaderText = "Lessons";
            lessonsDataGridViewTextBoxColumn1.MinimumWidth = 8;
            lessonsDataGridViewTextBoxColumn1.Name = "lessonsDataGridViewTextBoxColumn1";
            lessonsDataGridViewTextBoxColumn1.Width = 150;
            // 
            // groupBindingSource
            // 
            groupBindingSource.DataSource = typeof(Models.Group);
            // 
            // Teachers
            // 
            Teachers.Controls.Add(dataGridView7);
            Teachers.Location = new Point(4, 34);
            Teachers.Name = "Teachers";
            Teachers.Padding = new Padding(3);
            Teachers.Size = new Size(1115, 664);
            Teachers.TabIndex = 6;
            Teachers.Text = "Teachers";
            Teachers.UseVisualStyleBackColor = true;
            // 
            // dataGridView7
            // 
            dataGridView7.AutoGenerateColumns = false;
            dataGridView7.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView7.Columns.AddRange(new DataGridViewColumn[] { firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, middleNameDataGridViewTextBoxColumn, isAvailableDataGridViewCheckBoxColumn });
            dataGridView7.DataSource = teacherBindingSource;
            dataGridView7.Location = new Point(6, 5);
            dataGridView7.Name = "dataGridView7";
            dataGridView7.RowHeadersWidth = 62;
            dataGridView7.Size = new Size(1103, 655);
            dataGridView7.TabIndex = 2;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            middleNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            middleNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // isAvailableDataGridViewCheckBoxColumn
            // 
            isAvailableDataGridViewCheckBoxColumn.DataPropertyName = "IsAvailable";
            isAvailableDataGridViewCheckBoxColumn.HeaderText = "IsAvailable";
            isAvailableDataGridViewCheckBoxColumn.MinimumWidth = 8;
            isAvailableDataGridViewCheckBoxColumn.Name = "isAvailableDataGridViewCheckBoxColumn";
            isAvailableDataGridViewCheckBoxColumn.Width = 150;
            // 
            // teacherBindingSource
            // 
            teacherBindingSource.DataSource = typeof(Models.Teacher);
            // 
            // Subjects
            // 
            Subjects.Controls.Add(dataGridView5);
            Subjects.ImeMode = ImeMode.On;
            Subjects.Location = new Point(4, 34);
            Subjects.Name = "Subjects";
            Subjects.Padding = new Padding(3);
            Subjects.Size = new Size(1115, 664);
            Subjects.TabIndex = 4;
            Subjects.Text = "Subjects";
            Subjects.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            dataGridView5.AutoGenerateColumns = false;
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Columns.AddRange(new DataGridViewColumn[] { subjectNameDataGridViewTextBoxColumn, hoursPerLectureDataGridViewTextBoxColumn, hoursPerPracticDataGridViewTextBoxColumn, hoursPerLaboratDataGridViewTextBoxColumn, hoursPerConsultDataGridViewTextBoxColumn, hoursPerExamDataGridViewTextBoxColumn, lessonsDataGridViewTextBoxColumn });
            dataGridView5.DataSource = subjectBindingSource;
            dataGridView5.Location = new Point(6, 5);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowHeadersWidth = 62;
            dataGridView5.Size = new Size(1103, 655);
            dataGridView5.TabIndex = 1;
            // 
            // subjectNameDataGridViewTextBoxColumn
            // 
            subjectNameDataGridViewTextBoxColumn.DataPropertyName = "SubjectName";
            subjectNameDataGridViewTextBoxColumn.HeaderText = "SubjectName";
            subjectNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            subjectNameDataGridViewTextBoxColumn.Name = "subjectNameDataGridViewTextBoxColumn";
            subjectNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoursPerLectureDataGridViewTextBoxColumn
            // 
            hoursPerLectureDataGridViewTextBoxColumn.DataPropertyName = "HoursPerLecture";
            hoursPerLectureDataGridViewTextBoxColumn.HeaderText = "HoursPerLecture";
            hoursPerLectureDataGridViewTextBoxColumn.MinimumWidth = 8;
            hoursPerLectureDataGridViewTextBoxColumn.Name = "hoursPerLectureDataGridViewTextBoxColumn";
            hoursPerLectureDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoursPerPracticDataGridViewTextBoxColumn
            // 
            hoursPerPracticDataGridViewTextBoxColumn.DataPropertyName = "HoursPerPractic";
            hoursPerPracticDataGridViewTextBoxColumn.HeaderText = "HoursPerPractic";
            hoursPerPracticDataGridViewTextBoxColumn.MinimumWidth = 8;
            hoursPerPracticDataGridViewTextBoxColumn.Name = "hoursPerPracticDataGridViewTextBoxColumn";
            hoursPerPracticDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoursPerLaboratDataGridViewTextBoxColumn
            // 
            hoursPerLaboratDataGridViewTextBoxColumn.DataPropertyName = "HoursPerLaborat";
            hoursPerLaboratDataGridViewTextBoxColumn.HeaderText = "HoursPerLaborat";
            hoursPerLaboratDataGridViewTextBoxColumn.MinimumWidth = 8;
            hoursPerLaboratDataGridViewTextBoxColumn.Name = "hoursPerLaboratDataGridViewTextBoxColumn";
            hoursPerLaboratDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoursPerConsultDataGridViewTextBoxColumn
            // 
            hoursPerConsultDataGridViewTextBoxColumn.DataPropertyName = "HoursPerConsult";
            hoursPerConsultDataGridViewTextBoxColumn.HeaderText = "HoursPerConsult";
            hoursPerConsultDataGridViewTextBoxColumn.MinimumWidth = 8;
            hoursPerConsultDataGridViewTextBoxColumn.Name = "hoursPerConsultDataGridViewTextBoxColumn";
            hoursPerConsultDataGridViewTextBoxColumn.Width = 150;
            // 
            // hoursPerExamDataGridViewTextBoxColumn
            // 
            hoursPerExamDataGridViewTextBoxColumn.DataPropertyName = "HoursPerExam";
            hoursPerExamDataGridViewTextBoxColumn.HeaderText = "HoursPerExam";
            hoursPerExamDataGridViewTextBoxColumn.MinimumWidth = 8;
            hoursPerExamDataGridViewTextBoxColumn.Name = "hoursPerExamDataGridViewTextBoxColumn";
            hoursPerExamDataGridViewTextBoxColumn.Width = 150;
            // 
            // lessonsDataGridViewTextBoxColumn
            // 
            lessonsDataGridViewTextBoxColumn.DataPropertyName = "Lessons";
            lessonsDataGridViewTextBoxColumn.HeaderText = "Lessons";
            lessonsDataGridViewTextBoxColumn.MinimumWidth = 8;
            lessonsDataGridViewTextBoxColumn.Name = "lessonsDataGridViewTextBoxColumn";
            lessonsDataGridViewTextBoxColumn.Width = 150;
            // 
            // subjectBindingSource
            // 
            subjectBindingSource.DataSource = typeof(Models.Subject);
            // 
            // Semesters
            // 
            Semesters.Controls.Add(dataGridView4);
            Semesters.Location = new Point(4, 34);
            Semesters.Name = "Semesters";
            Semesters.Padding = new Padding(3);
            Semesters.Size = new Size(1115, 664);
            Semesters.TabIndex = 3;
            Semesters.Text = "Semesters";
            Semesters.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            dataGridView4.AllowUserToOrderColumns = true;
            dataGridView4.AutoGenerateColumns = false;
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Columns.AddRange(new DataGridViewColumn[] { semesterNumberDataGridViewTextBoxColumn });
            dataGridView4.DataSource = semesterBindingSource;
            dataGridView4.Location = new Point(6, 5);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.Size = new Size(1103, 655);
            dataGridView4.TabIndex = 1;
            // 
            // semesterNumberDataGridViewTextBoxColumn
            // 
            semesterNumberDataGridViewTextBoxColumn.DataPropertyName = "SemesterNumber";
            semesterNumberDataGridViewTextBoxColumn.HeaderText = "SemesterNumber";
            semesterNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            semesterNumberDataGridViewTextBoxColumn.Name = "semesterNumberDataGridViewTextBoxColumn";
            semesterNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // semesterBindingSource
            // 
            semesterBindingSource.DataSource = typeof(Models.Semester);
            // 
            // Weeks
            // 
            Weeks.Controls.Add(dataGridView3);
            Weeks.Location = new Point(4, 34);
            Weeks.Name = "Weeks";
            Weeks.Padding = new Padding(3);
            Weeks.Size = new Size(1115, 664);
            Weeks.TabIndex = 2;
            Weeks.Text = "Weeks";
            Weeks.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoGenerateColumns = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Columns.AddRange(new DataGridViewColumn[] { weekNumberDataGridViewTextBoxColumn, daysDataGridViewTextBoxColumn, semesterDataGridViewTextBoxColumn });
            dataGridView3.DataSource = weekBindingSource;
            dataGridView3.Location = new Point(6, 5);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowHeadersWidth = 62;
            dataGridView3.Size = new Size(1103, 655);
            dataGridView3.TabIndex = 1;
            // 
            // weekNumberDataGridViewTextBoxColumn
            // 
            weekNumberDataGridViewTextBoxColumn.DataPropertyName = "WeekNumber";
            weekNumberDataGridViewTextBoxColumn.HeaderText = "WeekNumber";
            weekNumberDataGridViewTextBoxColumn.MinimumWidth = 8;
            weekNumberDataGridViewTextBoxColumn.Name = "weekNumberDataGridViewTextBoxColumn";
            weekNumberDataGridViewTextBoxColumn.Width = 150;
            // 
            // daysDataGridViewTextBoxColumn
            // 
            daysDataGridViewTextBoxColumn.DataPropertyName = "Days";
            daysDataGridViewTextBoxColumn.HeaderText = "Days";
            daysDataGridViewTextBoxColumn.MinimumWidth = 8;
            daysDataGridViewTextBoxColumn.Name = "daysDataGridViewTextBoxColumn";
            daysDataGridViewTextBoxColumn.Width = 150;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            semesterDataGridViewTextBoxColumn.MinimumWidth = 8;
            semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            semesterDataGridViewTextBoxColumn.Width = 150;
            // 
            // weekBindingSource
            // 
            weekBindingSource.DataSource = typeof(Models.Week);
            // 
            // Day
            // 
            Day.Controls.Add(dataGridView2);
            Day.Location = new Point(4, 34);
            Day.Name = "Day";
            Day.Padding = new Padding(3);
            Day.Size = new Size(1115, 664);
            Day.TabIndex = 1;
            Day.Text = "Day";
            Day.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dayIDDataGridViewTextBoxColumn, dayNameDataGridViewTextBoxColumn, weekIDDataGridViewTextBoxColumn1, lessonsDataGridViewTextBoxColumn3, weekDataGridViewTextBoxColumn });
            dataGridView2.DataSource = dayBindingSource;
            dataGridView2.Location = new Point(6, 5);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.Size = new Size(1103, 655);
            dataGridView2.TabIndex = 1;
            // 
            // dayIDDataGridViewTextBoxColumn
            // 
            dayIDDataGridViewTextBoxColumn.DataPropertyName = "DayID";
            dayIDDataGridViewTextBoxColumn.HeaderText = "DayID";
            dayIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            dayIDDataGridViewTextBoxColumn.Name = "dayIDDataGridViewTextBoxColumn";
            dayIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // dayNameDataGridViewTextBoxColumn
            // 
            dayNameDataGridViewTextBoxColumn.DataPropertyName = "DayName";
            dayNameDataGridViewTextBoxColumn.HeaderText = "DayName";
            dayNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            dayNameDataGridViewTextBoxColumn.Name = "dayNameDataGridViewTextBoxColumn";
            dayNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // weekIDDataGridViewTextBoxColumn1
            // 
            weekIDDataGridViewTextBoxColumn1.DataPropertyName = "WeekID";
            weekIDDataGridViewTextBoxColumn1.HeaderText = "WeekID";
            weekIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            weekIDDataGridViewTextBoxColumn1.Name = "weekIDDataGridViewTextBoxColumn1";
            weekIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // lessonsDataGridViewTextBoxColumn3
            // 
            lessonsDataGridViewTextBoxColumn3.DataPropertyName = "Lessons";
            lessonsDataGridViewTextBoxColumn3.HeaderText = "Lessons";
            lessonsDataGridViewTextBoxColumn3.MinimumWidth = 8;
            lessonsDataGridViewTextBoxColumn3.Name = "lessonsDataGridViewTextBoxColumn3";
            lessonsDataGridViewTextBoxColumn3.Width = 150;
            // 
            // weekDataGridViewTextBoxColumn
            // 
            weekDataGridViewTextBoxColumn.DataPropertyName = "Week";
            weekDataGridViewTextBoxColumn.HeaderText = "Week";
            weekDataGridViewTextBoxColumn.MinimumWidth = 8;
            weekDataGridViewTextBoxColumn.Name = "weekDataGridViewTextBoxColumn";
            weekDataGridViewTextBoxColumn.Width = 150;
            // 
            // dayBindingSource
            // 
            dayBindingSource.DataSource = typeof(Models.Day);
            // 
            // Lessons
            // 
            Lessons.Controls.Add(dataGridView1);
            Lessons.Location = new Point(4, 34);
            Lessons.Name = "Lessons";
            Lessons.Padding = new Padding(3);
            Lessons.Size = new Size(1115, 664);
            Lessons.TabIndex = 0;
            Lessons.Text = "Lessons";
            Lessons.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1103, 655);
            dataGridView1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Lessons);
            tabControl1.Controls.Add(Day);
            tabControl1.Controls.Add(Weeks);
            tabControl1.Controls.Add(Semesters);
            tabControl1.Controls.Add(Subjects);
            tabControl1.Controls.Add(Teachers);
            tabControl1.Controls.Add(Groups);
            tabControl1.Controls.Add(Offices);
            tabControl1.Controls.Add(TypeAssign);
            tabControl1.Controls.Add(TypeOffices);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1123, 702);
            tabControl1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(1185, 75);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnAdd_Click;
            // 
            // button2
            // 
            button2.Location = new Point(1185, 125);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 4;
            button2.Text = "Изменить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnEdit_Click;
            // 
            // button3
            // 
            button3.Location = new Point(1185, 181);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 5;
            button3.Text = "Удалить";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 728);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            TypeOffices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView11).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeOfficeBindingSource).EndInit();
            TypeAssign.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView10).EndInit();
            ((System.ComponentModel.ISupportInitialize)typeAssignBindingSource).EndInit();
            Offices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView9).EndInit();
            ((System.ComponentModel.ISupportInitialize)officeBindingSource).EndInit();
            Groups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView8).EndInit();
            ((System.ComponentModel.ISupportInitialize)groupBindingSource).EndInit();
            Teachers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView7).EndInit();
            ((System.ComponentModel.ISupportInitialize)teacherBindingSource).EndInit();
            Subjects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ((System.ComponentModel.ISupportInitialize)subjectBindingSource).EndInit();
            Semesters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ((System.ComponentModel.ISupportInitialize)semesterBindingSource).EndInit();
            Weeks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ((System.ComponentModel.ISupportInitialize)weekBindingSource).EndInit();
            Day.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dayBindingSource).EndInit();
            Lessons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage TypeOffices;
        private DataGridView dataGridView11;
        private TabPage TypeAssign;
        private DataGridView dataGridView10;
        private TabPage Offices;
        private DataGridView dataGridView9;
        private TabPage Groups;
        private DataGridView dataGridView8;
        private TabPage Teachers;
        private DataGridView dataGridView7;
        private TabPage Subjects;
        private DataGridView dataGridView5;
        private TabPage Semesters;
        private DataGridView dataGridView4;
        private TabPage Weeks;
        private DataGridView dataGridView3;
        private TabPage Day;
        private DataGridView dataGridView2;
        private TabPage Lessons;
        private DataGridView dataGridView1;
        private TabControl tabControl1;
        private DataGridViewTextBoxColumn dayIdDataGridViewTextBoxColumn;
        private BindingSource semesterBindingSource;
        private DataGridViewTextBoxColumn weekIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weekNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn semesterIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private BindingSource weekBindingSource;
        private BindingSource dayBindingSource;
        private DataGridViewTextBoxColumn lessonIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn officeIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn subjectIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dayIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lessonsTypeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn subjectIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn subjectNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoursPerLectureDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoursPerPracticDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoursPerLaboratDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoursPerConsultDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hoursPerExamDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lessonsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teachersDataGridViewTextBoxColumn;
        private BindingSource subjectBindingSource;
        private DataGridViewTextBoxColumn officeTypeIdDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn officeTypeDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn typeAssignsDataGridViewTextBoxColumn1;
        private BindingSource typeOfficeBindingSource;
        private DataGridViewTextBoxColumn assignmentIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn officeIdDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn officeTypeIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn officeTypeDataGridViewTextBoxColumn;
        private BindingSource typeAssignBindingSource;
        private DataGridViewTextBoxColumn officeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn officeTypeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn numberSeatsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lessonsDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn typeAssignsDataGridViewTextBoxColumn;
        private BindingSource officeBindingSource;
        private DataGridViewTextBoxColumn groupIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn groupNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lessonsDataGridViewTextBoxColumn1;
        private BindingSource groupBindingSource;
        private DataGridViewTextBoxColumn teacherIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isAvailableDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn subjectsDataGridViewTextBoxColumn;
        private BindingSource teacherBindingSource;
        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn semesterIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn semesterNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dayIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dayNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn weekIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn lessonsDataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn weekDataGridViewTextBoxColumn;
    }
}
