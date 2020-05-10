﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using Check_n_Cheer.Models;
using Microsoft.AspNetCore.Mvc;
using Check_n_Cheer.Interfaces;
using Microsoft.Extensions.Logging;

namespace Check_n_Cheer.Controllers
{
    public class TaskController :Controller
    {
        private readonly ILogger<TestController> _logger;
        private IUserRepository _userRepo;
        private ITestRepository _testRepo;
        private ITaskRepository _taskRepo;

        public TaskController(ILogger<TestController> logger, IUserRepository repo, ITestRepository testRepo, ITaskRepository taskRepo)
        {
            _logger = logger;
            _userRepo = repo;
            _testRepo = testRepo;
            _taskRepo = taskRepo;
        }       

        [HttpGet]
        public ActionResult UpdateTask(Guid taskId, Guid testId, string condition,double mark)
        {
            _logger.LogInformation("GET Task/UpdateTasks");
            var task = _taskRepo.GetTask(taskId);
            task.Name = condition;
            task.Mark = mark;
            _taskRepo.UpdateTask(taskId, task);
            return RedirectToAction("ManageTask", "Test", new { testId });
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
