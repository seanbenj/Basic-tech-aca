using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            List<Course> courses = new List<Course>()
            {
                new Course {CourseId = 1, Name = "Biology", Students = new List<Student>()
                {
                    new Student {StudentId = 101, Name = "Bob"},
                    new Student {StudentId = 102, Name = "Rebecca"},
                } },
                new Course {CourseId = 2, Name = "Chemistry", Students = new List<Student>()
                {
                    new Student {StudentId = 101, Name = "Bob"},
                    new Student {StudentId = 103, Name = "Sam" },
                } },
                new Course {CourseId = 3, Name = "Gouald Studies", Students = new List<Student>()
                {
                    new Student {StudentId = 103, Name = "Sam"},
                    new Student {StudentId = 104, Name = "Lucy" },
                } },

            };
            string result = "";

            foreach (var course in courses)
            {
                result += String.Format
                ("<br>Course Id: {0} -- Course Name: {1} -- Course Students: <br><hr/>",
                course.CourseId, course.Name);
                foreach (var student in course.Students)
                {
                    result += String.Format("Student Id: {0} Student Name: {1} <br>", student.StudentId, student.Name);

                }

            }
            resultLabel.Text = result;

            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */


        }

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            Dictionary<int, Student> students = new Dictionary<int, Student>()
            {
                {1, new Student{StudentId = 1, Name = "Lucy", Courses = new List<Course>()
                {
                new Course {CourseId = 101, Name = "Sewing 101"},
                new Course {CourseId = 102, Name = "Caligraphy"},
                } } },
                {2, new Student{StudentId = 2, Name = "Tigerlily", Courses = new List<Course>()
                {
                new Course {CourseId = 102, Name = "Caligraphy"},
                new Course {CourseId = 103, Name = "Pet Shop" },
                } } },
                {3, new Student{StudentId = 3, Name = "Thisbe", Courses = new List<Course>()
                {
                new Course {CourseId = 101, Name = "Sewing 101"},
                new Course {CourseId = 103, Name = "Pet Shop" },
                } } },
            };

            string result = "";
            foreach (var student in students)
            {
                result += string.Format("Student's ID: {0} -- Student's Name: {1} -- Student's Courses: <br><hr/>",
                student.Value.StudentId, student.Value.Name);
                foreach (var course in student.Value.Courses)
                {
                    result += string.Format("Course ID: {0} Course Name: {1}",
                    course.CourseId, course.Name);
                }
            }
            resultLabel.Text = result;
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */ 


        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>()
            {
                new Student {StudentId = 1, Name = "Toodloo", Courses = new List<Course>()
                {
                    new Course {CourseId = 101, Name = "Voodoo", grade = new Grade() {GPA = 100}},
                    new Course {CourseId = 102, Name = "Splinter Science", grade = new Grade() {GPA = 65}},
                } },
                new Student {StudentId = 2, Name = "Lola", Courses = new List<Course>()
                {
                    new Course {CourseId = 102, Name = "Splinter Science", grade = new Grade() {GPA = 75}},
                    new Course {CourseId = 103, Name = "Tree Planting", grade = new Grade() {GPA = 80}},
                } },
                new Student {StudentId = 3, Name = "Dot", Courses = new List<Course>()
                {
                    new Course {CourseId = 103, Name = "Tree Planting", grade = new Grade() {GPA = 70 }},
                    new Course {CourseId = 101, Name = "Voodoo", grade = new Grade() {GPA = 90}},
                } },
            };

            string result = "";
            foreach (var student in students)
            {
                result += string.Format("Student ID: {0} -- Student Name: {1} -- Student Courses:<br><hr/>",
                student.StudentId, student.Name);
                foreach (var course in student.Courses)
                {
                    result += string.Format("Course ID: {0}, Course Name: {1}, Course Grade: {2}<br>",
                    course.CourseId, course.Name, course.grade.GPA);
                }
            }
            resultLabel.Text = result;
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */ 


        }
    }
}