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
        private string _level;
        private string _school;
        private string _castTime;
        private string _range;
        private string _components;
        private string _duration;
        private string _description;
        private string _classes;
        private bool _isUserSpell;
        private bool _isAddedByUser;

        public string Name
        {
            get => _name;
            set { _name = value; OnPropertyChanged(nameof(Name)); }
        }

        public string Level
        {
            get => _level;
            set { _level = value; OnPropertyChanged(nameof(Level)); }
        }

        public string School
        {
            get => _school;
            set { _school = value; OnPropertyChanged(nameof(School)); }
        }

        public string CastTime
        {
            get => _castTime;
            set { _castTime = value; OnPropertyChanged(nameof(CastTime)); }
        }

        public string Range
        {
            get => _range;
            set { _range = value; OnPropertyChanged(nameof(Range)); }
        }

        public string Components
        {
            get => _components;
            set { _components = value; OnPropertyChanged(nameof(Components)); }
        }

        public string Duration
        {
            get => _duration;
            set { _duration = value; OnPropertyChanged(nameof(Duration)); }
        }

        public string Description
        {
            get => _description;
            set { _description = value; OnPropertyChanged(nameof(Description)); }
        }

        public string Classes
        {
            get => _classes;
            set { _classes = value; OnPropertyChanged(nameof(Classes)); }
        }

        public bool IsUserSpell
        {
            get => _isUserSpell;
            set { _isUserSpell = value; OnPropertyChanged(nameof(IsUserSpell)); }
        }

        public bool IsAddedByUser
        {
            get => _isAddedByUser;
            set { _isAddedByUser = value; OnPropertyChanged(nameof(IsAddedByUser)); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
