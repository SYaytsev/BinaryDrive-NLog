using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Drive.WebHost.Models
{
    public class LogEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Date { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
    }
}