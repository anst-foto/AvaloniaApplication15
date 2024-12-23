using System.Collections.ObjectModel;
using ReactiveUI.Fody.Helpers;

namespace AvaloniaApplication15.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    [Reactive] public PageItem SelectedPage { get; set; }
    public ObservableCollection<PageItem> Pages { get; set; } = [];

    public MainWindowViewModel()
    {
        var page1 = new Page1ViewModel();
        Pages.Add(new PageItem()
        {
            Title = page1.Title,
            Page = page1
        });
        
        var page2 = new Page2ViewModel();
        Pages.Add(new PageItem()
        {
            Title = page2.Title,
            Page = page2
        });
        
        SelectedPage = Pages[0];
    }
}