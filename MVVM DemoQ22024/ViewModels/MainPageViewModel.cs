
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MVVM_DemoQ22024.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        // Se declaran en minusculas
        [ObservableProperty]
        private int _count;

        [RelayCommand]
        public void Incrementar()
        {
            Count++;
        }
    }
}
