using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DnD_SpellBook
{
    /// <summary>
    /// Логика взаимодействия для AddSpellWindow.xaml
    /// </summary>
    public partial class AddSpellWindow : Window
    {
        public string SpellName { get; private set; }
        public string SpellLevel { get; private set; }
        public string SpellSchool { get; private set; }
        public string SpellCastTime { get; private set; }
        public string SpellRange { get; private set; }
        public string SpellComponents { get; private set; }
        public string SpellDuration { get; private set; }
        public string SpellClasses { get; private set; }
        public string SpellDescription { get; private set; }

        public AddSpellWindow()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            var selectedComponents = ComponentBox.SelectedItems.Cast<string>();
            var selectedClasses = ClassesBox.SelectedItems.Cast<string>();

            SpellName = NameBox.Text;
            SpellLevel = LevelBox.Text;
            SpellSchool = SchoolBox.Text;
            SpellCastTime = CastTimeBox.Text;
            SpellRange = RangeBox.Text;
            SpellComponents = string.Join(", ", selectedComponents);
            SpellDuration = DurationBox.Text;
            SpellClasses = string.Join(", ", selectedClasses);
            SpellDescription = DescriptionBox.Text;

            if (string.IsNullOrWhiteSpace(SpellName))
            {
                MessageBox.Show("Введите название заклинания!");
                return;
            }

            DialogResult = true;
            Close();
        }
    }
}
