using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MasterDetail
{
    internal class MenuItemViewModel
    {
        public MenuItemViewModel(string name, BaseVM viewModel)
        {
            Name = name;
            ViewModel = viewModel;
        }
        public string Name { get; set; }
        public BaseVM ViewModel { get; set; }

        public override string ToString() => Name;
    }
}
