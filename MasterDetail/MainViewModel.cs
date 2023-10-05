using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail
{
    internal class MainViewModel : BaseVM
    {

        public ObservableCollection<MenuItemViewModel> MenuItems { get; set; }

        public MainViewModel()
        {
            MenuItems = new ObservableCollection<MenuItemViewModel>()
            {
                new MenuItemViewModel("Страница 1", new FirstPageViewModel()),
                new MenuItemViewModel("Страница 2", new SecondPageViewModel())
            };
        }

        private BaseVM currentContent;
        public BaseVM CurrentContent
        {
            get => currentContent;
            set
            {
                currentContent = value;
                RaisePropertyChanged();
            }
        }

        private MenuItemViewModel selectedMenu;
        public MenuItemViewModel SelectedMenu
        {
            get => selectedMenu;
            set
            {
                selectedMenu = value;
                CurrentContent = value.ViewModel;
                RaisePropertyChanged();
            }
        }

    }
}
