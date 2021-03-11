﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using Todo.Models;
using H3VRModInstaller.Avalonia;
using ModInstaller.Avalonia;

namespace Todo.ViewModels
{
    public class TodoListViewModel : ViewModelBase
    {
        public TodoListViewModel(IEnumerable<TodoItem> items)
        {
            Items = new ObservableCollection<TodoItem>(items);
        }

        public ObservableCollection<TodoItem> Items { get; }
    }
}