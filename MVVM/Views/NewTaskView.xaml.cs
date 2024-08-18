using QaTasker.MVVM.Models;

namespace QaTasker.MVVM.Views;

public partial class NewTaskView : ContentPage
{
	public NewTaskView()
	{
		InitializeComponent();
	}

	private async void AddTaskClicked(object sender, EventArgs e)
	{
		var vm = BindingContext as NewTaskViewModel;
		var selectedCategory = vm.Categories.Where(x=> x.IsSelected == true).FirstOrDefault();
		if(selectedCategory != null) 
		{
			var taks = new MyTask
			{
				TaskName = vm.Task,
				CategoryId = selectedCategory.Id,
			};
			vm.Tasks.Add(taks);
			await Navigation.PopAsync();
		} 
		else {
			await DisplayAlert("Invalid Selection", "You must select a category", "Ok");
		}
	}

	public async void AddCategoryClicked(object sender, EventArgs e)
	{
		var vm = BindingContext as NewTaskViewModel;
		string category = await DisplayPromptAsync("New Category", "Write the new category name",
									maxLength: 15,
									keyboard: Keyboard.Text);
		var r = new Random();
		if(!string.IsNullOrEmpty(category))
		{
			vm.Categories.Add(new Category 
			{
				Id = vm.Categories.Max(x => x.Id) +1,
				Color = Color.FromRgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)).ToHex(),
				CategoryName = category
			});
		}
	}
	
}