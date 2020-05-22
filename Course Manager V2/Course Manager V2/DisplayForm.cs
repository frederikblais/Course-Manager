using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Manager_V2
{
    public partial class DisplayForm : Form
    {
        public Course MyCourse { get; set; }
        public InClass InClassCourse { get; set; }
        public Online OnlineCourse { get; set; }

        public InClass editedIn = new InClass();
        public Online editedOn = new Online();

        public DisplayForm(Course course)
        {
            InitializeComponent();
            MyCourse = course;
        }
        private void DisplayForm_Load(object sender, EventArgs e)
        {
            if (MyCourse is InClass)
            {
                InClassCourse = (InClass)MyCourse;

                // Courses Labels
                numberLabel.Text = InClassCourse.Number;
                nameLabel.Text = InClassCourse.Name;
                semLabel.Text = InClassCourse.Semester;
                yearLabel.Text = InClassCourse.Year;
                desLabel.Text = InClassCourse.Description;
                teacherLabel.Text = InClassCourse.Teacher;

                // InClass Labels
                classLabel.Text = InClassCourse.ClassRoom;
                hoursLabel.Text = InClassCourse.Hours;
                examLabel.Text = InClassCourse.Finals;
                officeLabel.Text = InClassCourse.TeacherOffice;

                MyCourse = InClassCourse;
            }
            else if (MyCourse is Online)
            {
                OnlineCourse = (Online)MyCourse;

                // Courses Labels
                numberLabel.Text = OnlineCourse.Number;
                nameLabel.Text = OnlineCourse.Name;
                semLabel.Text = OnlineCourse.Semester;
                yearLabel.Text = OnlineCourse.Year;
                desLabel.Text = OnlineCourse.Description;
                teacherLabel.Text = OnlineCourse.Teacher;

                // Online Labels
                linkLabel.Text = OnlineCourse.Link;
                passLabel.Text = OnlineCourse.Pass;
                ytLabel.Text = OnlineCourse.YT;

                MyCourse = OnlineCourse;
            }

            if(classLabel.Text != "")
            {
                onlineGB.Enabled = false;
            }
            else if (linkLabel.Text != "")
            {
                inClassGB.Enabled = false;
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (classLabel.Text != "")
            {
                // Courses TextBoxes
                editedIn.Number = numberTextBox.Text;
                editedIn.Name = nameTextBox.Text;
                editedIn.Semester = semesterTextBox.Text;
                editedIn.Year = yearTextBox.Text;
                editedIn.Description = descriptionTextBox.Text;
                editedIn.Teacher = teacherTextBox.Text;

                // InClass TextBoxes
                editedIn.ClassRoom = classroomTextBox.Text;
                editedIn.Hours = hoursTextBox.Text;
                editedIn.Finals = examTextBox.Text;
                editedIn.TeacherOffice = officeTextBox.Text;

                // Courses Labels
                numberLabel.Text = editedIn.Number;
                nameLabel.Text = editedIn.Name;
                semLabel.Text = editedIn.Semester;
                yearLabel.Text = editedIn.Year;
                desLabel.Text = editedIn.Description;
                teacherLabel.Text = editedIn.Teacher;

                // InClass Labels
                classLabel.Text = editedIn.ClassRoom;
                hoursLabel.Text = editedIn.Hours;
                examLabel.Text = editedIn.Finals;
                officeLabel.Text = editedIn.TeacherOffice;
            }
            else if(linkLabel.Text != "")
            {
                // Courses TextBoxes
                editedOn.Number = numberTextBox.Text;
                editedOn.Name = nameTextBox.Text;
                editedOn.Semester = semesterTextBox.Text;
                editedOn.Year = yearTextBox.Text;
                editedOn.Description = descriptionTextBox.Text;
                editedOn.Teacher = teacherTextBox.Text;

                // Online TextBoxes
                editedOn.Link = linkTextBox.Text;
                editedOn.Pass = passTextBox.Text;
                editedOn.YT = ytTextBox.Text;

                // Courses Labels
                numberLabel.Text = editedOn.Number;
                nameLabel.Text = editedOn.Name;
                semLabel.Text = editedOn.Semester;
                yearLabel.Text = editedOn.Year;
                desLabel.Text = editedOn.Description;
                teacherLabel.Text = editedOn.Teacher;

                // Online Labels
                linkLabel.Text = editedOn.Link;
                passLabel.Text = editedOn.Pass;
                ytLabel.Text = editedOn.YT;
            }
            else
            {
                MessageBox.Show("You have to choose if the class is online or in-class.");
            }
        }
    }
}
