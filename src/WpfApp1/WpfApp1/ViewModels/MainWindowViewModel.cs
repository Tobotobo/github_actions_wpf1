using Reactive.Bindings;
using System.Linq;
using System.Reactive.Linq;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class MainWindowViewModel
    {
        public ReactiveProperty<int> A { get; }
        public ReactiveProperty<int> B { get; }
        public ReactiveProperty<int> Result { get; }

        public MainWindowViewModel(ICalcService calcService)
        {
            A = new ReactiveProperty<int>();
            B = new ReactiveProperty<int>();
            Result = ObservableEx.CombineLatest(A, B)
                .Select(x => calcService.Sum(x.First, x.Second))
                .ToReactiveProperty();
        }
    }
}
