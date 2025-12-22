using System;

namespace ReminderApi.Models
{
    public class Reminder
    {
        // Уникальный идентификатор напоминания
        public int Id { get; set; }

        // Название напоминания
        public string Title { get; set; }

        // Описание напоминания
        public string Description { get; set; }

        // Дата и время, когда должно сработать напоминание
        public DateTime DateTime { get; set; }

        // Приоритет напоминания (например: низкий, средний, высокий)
        public string Priority { get; set; }

        // Статус напоминания (создано, выполнено и т.д.)
        public string Status { get; set; }
    }
}