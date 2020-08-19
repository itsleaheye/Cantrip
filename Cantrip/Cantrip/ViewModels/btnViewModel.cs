using System;
using System.Collections.Generic;
using System.Text;

namespace Cantrip.ViewModels
{
    public class btnViewModel
    {
        private bool _btnVisible;

        public bool btnVisible
        {
            get
            {
                return _btnVisible;
            }
            set
            {
                _btnVisible = value;
            }
        }

    }
}
