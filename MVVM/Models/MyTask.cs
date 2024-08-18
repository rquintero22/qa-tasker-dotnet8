using System;
using PropertyChanged;

namespace QaTasker.MVVM.Models;

[AddINotifyPropertyChangedInterface]
public class MyTask
{
    public string TaskName { get; set; }
    public bool Completed { get; set; }
    public int CategoryId { get; set; }
    public string TaskColor { get; set; }
}
