using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DnD_SpellBook
{
    public partial class SpellCardTemplate : UserControl
    {
        private ScaleTransform scaleTransform;
        public SpellData Spell { get; private set; }
        public SpellCardTemplate(SpellData spell)
        {
            InitializeComponent();
            Spell = spell;

            DataContext = spell;
            UserSpellCheckBox.IsChecked = spell.IsUserSpell;

            scaleTransform = new ScaleTransform(1, 1);
            CardBorder.RenderTransform = scaleTransform;
            CardBorder.RenderTransformOrigin = new Point(0.5, 0.5);
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

        private Popup hoverPopup;

        private void CardBorder_MouseEnter(object sender, MouseEventArgs e)
        {
            Panel.SetZIndex(this, 100);
            AnimateScale(1.2);
        }

        private void CardBorder_MouseLeave(object sender, MouseEventArgs e)
        {
            Panel.SetZIndex(this, 0);
            AnimateScale(1.0);
        }

        private void AnimateScale(double target)
        {
            var anim = new DoubleAnimation
            {
                To = target,
                Duration = TimeSpan.FromMilliseconds(150),
                AccelerationRatio = 0.3,
                DecelerationRatio = 0.3
            };

            scaleTransform.BeginAnimation(ScaleTransform.ScaleXProperty, anim);
            scaleTransform.BeginAnimation(ScaleTransform.ScaleYProperty, anim);
        }

        public event Action<SpellData> SpellChanged;

        private void UserSpellCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Spell.IsUserSpell = true;
            UpdateCardStyle();
            SpellChanged?.Invoke(Spell);
        }

        private void UserSpellCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Spell.IsUserSpell = false;
            UpdateCardStyle();
            SpellChanged?.Invoke(Spell);
        }

        private void UpdateCardStyle()
        {
            CardBackground = Spell.IsUserSpell ? Brushes.MediumAquamarine : Brushes.LightGray;
        }
    }
}
