using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    internal class ToDoModel
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;
        private string _text;
        private bool _isDone;
        public bool IsDone
        {
            get { return _isDone; } 
            set { _isDone = value; }
        }
        public string Text 
        { 
            get { return _text; } 
            set { _text = value; } 
        }
    }
}
