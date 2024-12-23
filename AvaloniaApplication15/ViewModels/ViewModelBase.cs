using ReactiveUI;

namespace AvaloniaApplication15.ViewModels;

public abstract class ViewModelBase : ReactiveObject
{
    public string? Title { get; protected set; }
}