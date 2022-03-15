using Reactive.Bindings;
using System.Linq;
using System.Reactive.Linq;
using WpfApp1.Models;

namespace WpfApp1.ViewModels
{
    public class MainWindowViewModel
    {
        public ReactiveProperty<int> SumA { get; } = new ReactiveProperty<int>();
        public ReactiveProperty<int> SumB { get; } = new ReactiveProperty<int>();
        public ReactiveProperty<int> SumResult { get; }

        public ReactiveProperty<int> ProductA { get; } = new ReactiveProperty<int>();
        public ReactiveProperty<int> ProductB { get; } = new ReactiveProperty<int>();
        public ReactiveProperty<int> ProductResult { get; }

        public MainWindowViewModel(ICalcService calcService)
        {
            SumResult = ObservableEx.CombineLatest(SumA, SumB)
                .Select(x => calcService.Sum(x.First, x.Second))
                .ToReactiveProperty();

            ProductResult = ObservableEx.CombineLatest(ProductA, ProductB)
                .Select(x => calcService.Product(x.First, x.Second))
                .ToReactiveProperty();
        }
    }
}
