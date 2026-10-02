using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using BusinessLogic.Repository;

namespace BusinessLogic.Controller
{
    public class StudentController
    {
        private readonly StudentRepository _studentRepository;
        public StudentController()
        {
            _studentRepository = new StudentRepository();
        }
        public void AddStudent(Student student)
        {
            _studentRepository.AddStudent(student);
        }
        public List<Student> GetStudents(string searchText)
        {
            return _studentRepository.GetStudents(searchText);
        }
        public void UpdateStudent (Student student)
        {
            _studentRepository.UpdateStudent(student);
        }

        public void DeleteStudent (int studentId)
        {
            _studentRepository.DeleteStudent(studentId);
        }
    }
}
