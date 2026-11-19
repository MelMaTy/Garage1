using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;

namespace Garage1
{
    public class GarageSearchViewModel
    {
        public ObservableCollection<GarageSearch> GarageSearch { get; set; }

        public GarageSearchViewModel()
        {
            GarageSearch = new ObservableCollection<GarageSearch>
        {
            new GarageSearch { Name = "Улица Новая 23", ID = 0 },
            new GarageSearch { Name = "Улица Дуси-Ковальчук 198", ID = 1 },
            new GarageSearch { Name = "Улица Дуси-Ковальчук 198", ID = 2 },

        };
        }
    }
}
