using ReactiveUI.Fody.Helpers;

namespace AvaloniaApplication15.ViewModels;

public class Page2ViewModel : ViewModelBase
{
    [Reactive] public string Content { get; set; }
    
    public Page2ViewModel()
    {
        Title = "Page 2";
        
        Content = "This is the content of the page 2";
    }
}