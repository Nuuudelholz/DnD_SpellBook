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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DnD_SpellBook
{
    /// <summary>
    /// Логика взаимодействия для SpellCardTemplate.xaml
    /// </summary>
    public partial class SpellCardTemplate : UserControl
    {
        public SpellCardTemplate()
        {
            InitializeComponent();
        }

        public string SpellName
        {
            get => SpellNameText.Text;
            set => SpellNameText.Text = value;
        }

        public string SpellDescription
        {
            get => SpellDescriptionText.Text;
            set => SpellDescriptionText.Text = value;
        }

        public Brush CardBackground
        {
            get => CardBorder.Background;
            set => CardBorder.Background = value;
        }
    }
}
