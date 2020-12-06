using System;

namespace HW_11_Task1
{
    /*Task 1 • Create a new project, and include the class Person in the project you just 
created.
• Create a class "Student" and another class "Teacher", both descendants of 
"Person".
• The class "Student" will have a public method "GoToClasses", which will write on 
screen "I’m going to class."
• The class "Teacher" will have a public method "Explain", which will show on 
screen "Explanation begins". Also, it will have a private attribute "subject", a 
string.
• The class Person must have a method "SetAge (int n)" which will indicate the 
value of their age (eg, 20 years old).
• The student will have a public method "ShowAge" which will write on the screen 
"My age is: 20 years old" (or the corresponding number).
• You must create another test class called "StudentAndTeacherTest" that will 
contain "Main" and:
o Create a Person and make it say hello
o Create a student, set his age to 21, tell him to Greet and display his age
o Create a teacher, 30 years old, ask him to say hello and then explain.*/
    class StudentAndTeacherTest
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SayHello();
            Console.WriteLine(new string('-',35));

            Student student = new Student();
            int studentAge = 21;
            student.SayHello();
            student.ShowAge(studentAge);
            student.GoToClasses();
            Console.WriteLine(new string('-',35));

            Teacher teacher = new Teacher();
            teacher.SayHello();
            Console.WriteLine("Teacher age is {0}", teacher.SetAge(30));
            string teacherSubject = "Information Technologies";
            teacher.Explain(teacherSubject);

            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
