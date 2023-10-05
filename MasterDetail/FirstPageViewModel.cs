using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail
{
    class FirstPageViewModel : BaseVM
    {
        public FirstPageViewModel()
        {
            Text = "Первая страница";
        }

        private string text;
        public string Text
        {
            get => text;
            set
            {
                text = value;
                RaisePropertyChanged();
            }
        }
    }
}
