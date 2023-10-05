using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterDetail
{
    class SecondPageViewModel : BaseVM
    {
        public SecondPageViewModel()
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
