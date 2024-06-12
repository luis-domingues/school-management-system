using System;
using modelo_teste.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n=======================================");
        Console.WriteLine("SISTEMA DE GERENCIAMENTO DE ESTUDANTES\n");

        Console.Write("Nome do estudante: ");
        string studentName = Console.ReadLine();
        Console.Write("E-mail do estudante: ");
        string studentEmail = Console.ReadLine();

        Student student = new Student();
        student.Name = studentName;
        student.Email = studentEmail;

        Course course_1 = new Course();
        course_1.Name = "Curso de CSharp";
        course_1.Teacher = new Teacher() { Name = "Fulano de Tal", Age = 40, Salary = 5000 };
        course_1.Duration = 52;
        Course course_2 = new Course();
        course_2.Name = "Curso de Java";
        course_2.Teacher = new Teacher() { Name = "Beltrano de Tal", Age = 48, Salary = 5800 };
        course_2.Duration = 58;
        Course course_3 = new Course();
        course_3.Name = "Curso de Modelagem de Dados";
        course_3.Teacher = new Teacher() { Name = "Sicrano de Tal", Age = 37, Salary = 4200 };
        course_3.Duration = 30;

        while (true)
        {
            Console.Write("Selecione os cursos desejados (separados por vírgula): ");
            string selectedCoursesStr = Console.ReadLine();
            string[] selectedCoursesArr = selectedCoursesStr.Split(',');
            foreach (string courseName in selectedCoursesArr)
            {
                if (courseName.Trim().ToLower() == "csharp")
                {
                    student.AddCourse(courseName, course_1);
                }
                else if (courseName.Trim().ToLower() == "java")
                {
                    student.AddCourse(courseName, course_2);
                }
                else if (courseName.Trim().ToLower() == "dados")
                {
                    student.AddCourse(courseName, course_3);
                }
                else
                {
                    Console.WriteLine("\nCurso não encontrado.");
                }
            }

            Console.WriteLine("\nInformações do aluno\n");
            Console.WriteLine($"Nome: {student.Name}");
            Console.WriteLine($"Email: {student.Email}");

            foreach (Course course in student.SelectedCourses.Values)
            {
                Console.WriteLine($"Nome: {course.Name}");
                Console.WriteLine($"Professor: {course.Teacher.Name}");
                Console.WriteLine($"Carga Horária: {course.Duration} horas");
                Console.WriteLine("---------------------------------------");
            }
        }
    }
}