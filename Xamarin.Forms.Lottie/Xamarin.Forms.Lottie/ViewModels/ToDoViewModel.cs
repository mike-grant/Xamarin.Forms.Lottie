using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms.Lottie.Model;

namespace Xamarin.Forms.Lottie.ViewModels
{
    public class ToDoViewModel : INotifyPropertyChanged
    {
        public ToDoViewModel()
        {
            LoadPage();
        }
        private ObservableCollection<TaskItem> _tasks;
        public ObservableCollection<TaskItem> Tasks
        {
            get => _tasks;
            set
            {
                _tasks = value;
                RaisePropertyChanged();
            }
        }

        void LoadPage()
        {
            Tasks = new ObservableCollection<TaskItem> {
                new TaskItem { Id = 1, Text="Make a checkbox" },
                new TaskItem { Id = 2, Text="Make it pretty" },
                new TaskItem { Id = 3, Text="Make it animate" }
            };
        }

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
