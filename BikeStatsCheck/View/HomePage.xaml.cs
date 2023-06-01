namespace BikeStatsCheck.View;
	
public partial class HomePage : ContentPage
{
	public HomePage(FieldsViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
	}
}

