using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive;
using ReactiveUI;

namespace AvaloniaApplication1.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        string input = "";
        public MainWindowViewModel()
        {
            ChangeInput = ReactiveCommand.Create((string x) => Input += x);
            ClearInput = ReactiveCommand.Create(() => Input = "");
        }
        public string Input
        {
            set
            {
                this.RaiseAndSetIfChanged(ref input, value);
            }
            get
            {
                return this.input;
            }
        }
        public ReactiveCommand<string, string> ChangeInput { get; }
        public ReactiveCommand<Unit, string> ClearInput { get; }
    }
}
