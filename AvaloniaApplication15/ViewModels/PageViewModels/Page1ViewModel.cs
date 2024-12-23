using ReactiveUI.Fody.Helpers;

namespace AvaloniaApplication15.ViewModels;

public class Page1ViewModel : ViewModelBase
{
    [Reactive] public string Content { get; set; }
    
    public Page1ViewModel()
    {
        Title = "Page 1";
        
        Content = "This is the content of the page 1";
    }
}