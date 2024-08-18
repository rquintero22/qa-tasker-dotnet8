using System;
using System.Collections.ObjectModel;
using QaTasker.MVVM.Models;

namespace QaTasker;

public class NewTaskViewModel
{
    public string Task { get; set; }
    public ObservableCollection<MyTask> Tasks { get; set; }
    public ObservableCollection<Category> Categories { get; set; }
}
