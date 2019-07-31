using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementWithADO.Models;

namespace StudentManagementWithADO.Controllers
{
    public class StudentController : Controller
    {

        StudentDataAccessLayer studentDataAccessLayer = null;
        public StudentController()
        {
            studentDataAccessLayer = new StudentDataAccessLayer();
        }


        // GET: Student
        public ActionResult Index()
        {
            IEnumerable<Student> students = studentDataAccessLayer.GetAllStudent();
            return View(students);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            Student student = studentDataAccessLayer.GetStudentData(id);
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student student)
        {
            try
            {
                
                studentDataAccessLayer.AddStudent(student);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            Student student = studentDataAccessLayer.GetStudentData(id);
            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student student)
        {
            try
            {
                studentDataAccessLayer.UpdateStudent(student);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            Student student = studentDataAccessLayer.GetStudentData(id);

            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Student student)
        {
            try
            {
                studentDataAccessLayer.DeleteStudent(student.Id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}