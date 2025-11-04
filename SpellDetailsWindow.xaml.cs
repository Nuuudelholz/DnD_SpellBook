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
    /// Логика взаимодействия для SpellDetailsWindow.xaml
    /// </summary>
    public partial class SpellDetailsWindow : Window
    {
        public SpellDetailsWindow(SpellData spell)
        {
            InitializeComponent();
            DataContext = spell;
        }
    }
}
