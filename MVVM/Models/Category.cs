using System;
using PropertyChanged;

namespace QaTasker.MVVM.Models;

[AddINotifyPropertyChangedInterface]
public class Category
{
    public int Id { get; set;}
    public string? CategoryName { get; set;}
    public string? Color { get; set;}
    public int PendingTasks { get; set;}
    public float Percentage { get; set;}
    public bool IsSelected { get; set; }
}
