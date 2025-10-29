using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_SpellBook
{
    public class SpellData : INotifyPropertyChanged
    {
        private string _name;
        private string _description;
        private bool _isUserSpell;

        public string Name
        {
            get => _name;
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }

        public string Description
        {
            get => _description;
            set { _description = value; OnPropertyChanged(nameof(Description)); }
        }

        public bool IsUserSpell
        {
            get => _isUserSpell;
            set { _isUserSpell = value; OnPropertyChanged(nameof(IsUserSpell)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
