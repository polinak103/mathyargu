using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Project.Models
{
    internal class ToDoModel : INotifyPropertyChanged

    {
        public DateTime CreationDate { get; set; } = DateTime.Now;
        private string _text;
        private bool _isDone;
        private DateTime _deadline = DateTime.Now;



        public bool IsDone
        {
            get { return _isDone; }
            set
            {
                if (_isDone == value)
                    return;
                _isDone = value;
                OnPropertyChanged("IsDone");
            }
        }
        public string Text
        {
            get { return _text; }
            set
            {
                if (_text == value)
                    return;
                _text = value;
                OnPropertyChanged("Text");
            }
        }
        public DateTime Deadline
        {
            get { return _deadline; }
            set
            {
                if (_deadline == value)
                    return;
                _deadline = value;
                OnPropertyChanged("Deadline");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}


       


    

