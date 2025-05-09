﻿using Microsoft.AspNetCore.Mvc;
using PortfolioCore7.Context;
using PortfolioCore7.Entities;

namespace PortfolioCore7.Controllers
{
    public class ExperienceController : Controller
    {
        PortfolioContext context = new();

        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();

            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();

            return RedirectToAction("ExperienceList");
        }

        public IActionResult DeleteExperience(int id)
        {
            var value = context.Experiences.Find(id);
            context.Experiences.Remove(value);
            context.SaveChanges();

            return RedirectToAction("ExperienceList");
        }
        
        public IActionResult UpdateExperience(int id)
        {
            var value = context.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            context.Experiences.Update(experience);
            context.SaveChanges();

            return RedirectToAction("ExperienceList");
        }
    }
}
