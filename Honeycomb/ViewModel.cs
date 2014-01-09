using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honeycomb
{
    class ViewModel
    {
        private ObservableCollection<int> _cells = new ObservableCollection<int>();

        public ViewModel()
        {
            for (int i = 0; i < 20; ++i)
                _cells.Add(i);
        }

        public IEnumerable<int> Cells
        {
            get { return _cells; }
        }
    }
}
