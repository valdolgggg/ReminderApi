using Microsoft.AspNetCore.Mvc;
using ReminderApi.Models;
using System.Collections.Generic;

namespace ReminderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReminderController : ControllerBase
    {
        // Временное хранилище напоминаний
        private static List<Reminder> reminders = new List<Reminder>();

        // Получение списка всех напоминаний
        [HttpGet]
        public ActionResult<List<Reminder>> GetAllReminders()
        {
            return Ok(reminders);
        }

        // Создание нового напоминания
        [HttpPost]
        public ActionResult<Reminder> CreateReminder(Reminder reminder)
        {
            reminders.Add(reminder);
            return Ok(reminder);
        }
    }
}