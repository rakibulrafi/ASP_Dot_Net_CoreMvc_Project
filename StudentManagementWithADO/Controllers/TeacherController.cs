using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementWithADO.Models;

namespace StudentManagementWithADO.Controllers
{
    public class TeacherController : Controller
    {
        TeacherDataAccessLayer teacherDataAccessLayer = null;

        public TeacherController()
        {
             teacherDataAccessLayer = new TeacherDataAccessLayer();
        }

        // GET: Teacher
        public ActionResult Index()
        {
            IEnumerable<Teacher> teachers = teacherDataAccessLayer.GetAllTeacher();
            return View(teachers);
        }

        // GET: Teacher/Details/5
        public ActionResult Details(int id)
        {
            Teacher teacher = teacherDataAccessLayer.GetTeacherData(id);
            return View(teacher);
        }

        // GET: Teacher/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Teacher/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Teacher teacher)
        {
            try
            {
                teacherDataAccessLayer.AddTeacher(teacher);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Teacher/Edit/5
        public ActionResult Edit(int id)
        {
            Teacher teacher = teacherDataAccessLayer.GetTeacherData(id);
            return View(teacher);
        }

        // POST: Teacher/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Teacher teacher)
        {
            try
            {
                // TODO: Add update logic here
                teacherDataAccessLayer.UpdateStudent(teacher);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Teacher/Delete/5
        public ActionResult Delete(int id)
        {
            Teacher teacher = teacherDataAccessLayer.GetTeacherData(id);
            return View(teacher);
        }

        // POST: Teacher/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                teacherDataAccessLayer.DeleteTeacher(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}