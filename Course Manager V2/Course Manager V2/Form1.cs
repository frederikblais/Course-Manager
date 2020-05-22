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
    public partial class mainForm : Form
    {
        // List of courses
        List<Course> courseList = new List<Course>();

        // Inclass and online objects
        InClass inClass = new InClass();
        Online online = new Online();

        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            // Disable sections
            onlineGroupBox.Enabled = false;
            inclassGroupBox.Enabled = false;
        }

        private void onlineRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // If online R_button == true, enable its groupBox
            onlineGroupBox.Enabled = true;
            inclassGroupBox.Enabled = false;
        }

        private void inClassRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            // If inClass R_button == true, enable its groupBox
            inclassGroupBox.Enabled = true;
            onlineGroupBox.Enabled = false;
        }

        private void GetinClass(InClass inClass)
        {
            // Temp var to check type of input
            int tempInt;

            if (int.TryParse(yearTextBox.Text, out tempInt) &&
                int.TryParse(hoursTextBox.Text, out tempInt))
            {
                inClass.Year = yearTextBox.Text;
                inClass.Hours = hoursTextBox.Text;
                inClass.Number = numberTextBox.Text;
                inClass.Name = nameTextBox.Text;
                inClass.Semester = semTextBox.Text;
                inClass.Description = desTextBox.Text;
                inClass.Teacher = teacherTextBox.Text;
                inClass.ClassRoom = classTextBox.Text;
                inClass.Finals = examTextBox.Text;
                inClass.TeacherOffice = teacherRoomTextBox.Text;
            }
            else
            {
                MessageBox.Show("You must enter integer values for YEAR and HOURS");
            }
            
        }
        private void GetOnline(Online online)
        {
            int tempInt;

            if (int.TryParse(yearTextBox.Text, out tempInt))
            {
                online.Number = numberTextBox.Text;
                online.Name = nameTextBox.Text;
                online.Year = yearTextBox.Text;
                online.Semester = semTextBox.Text;
                online.Description = desTextBox.Text;
                online.Teacher = teacherTextBox.Text;
                online.Link = linkTextBox.Text;
                online.Pass = passTextBox.Text;
                online.YT = ytTextBox.Text;
            }
        }

        // ADD COURSE
        private void addButton_Click(object sender, EventArgs e)
        {
            // Create objects
            Online myOnline = new Online();
            InClass myInClass = new InClass();

            // Check which type of class the user input
            if (onlineRadioButton.Checked == true)
            {
                GetOnline(myOnline);
                courseList.Add(myOnline);

                // Display Data
                classesListBox.Items.Add(myOnline.Number + "\t" + myOnline.Name);
            }
            else
            {
                GetinClass(myInClass);
                courseList.Add(myInClass);
                // Display Data
                classesListBox.Items.Add(myInClass.Number + "\t" + myInClass.Name);
            }

            // Clear TextBoxes
            numberTextBox.Clear();
            nameTextBox.Clear();
            yearTextBox.Clear();
            semTextBox.Clear();
            desTextBox.Clear();
            teacherTextBox.Clear();
            classTextBox.Clear();
            hoursTextBox.Clear();
            examTextBox.Clear();
            teacherRoomTextBox.Clear();
            linkTextBox.Clear();
            passTextBox.Clear();
            ytTextBox.Clear();
        }
        private void DisplayCourseList()
        {
            classesListBox.Items.Clear();

            for (int i = 0; i < courseList.Count; i++)
            {
                classesListBox.Items.Add(courseList[i].Number + "\t" + courseList[i].Name);
            }
        }

        // DISPLAY DATA TO DISPLAYFORM
        private void displayButton_Click(object sender, EventArgs e)
        {
            if (classesListBox.SelectedIndex != -1)
            {
                //Creates and displays a second form
                DisplayForm df = new DisplayForm(courseList[classesListBox.SelectedIndex]);

                courseList[classesListBox.SelectedIndex] = df.MyCourse;

                df.ShowDialog();

                // Check if online or in class
                if(df.MyCourse is Online)
                {
                    courseList[classesListBox.SelectedIndex] = df.editedOn;
                }
                else
                {
                    courseList[classesListBox.SelectedIndex] = df.editedIn;
                }

                DisplayCourseList();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
