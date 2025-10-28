using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
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
    public partial class MainWindow : Window
    {
        private const string FilePath = "SpellLibrary.json";
        private List<SpellData> spells = new List<SpellData>();

        public MainWindow()
        {
            InitializeComponent();
            LoadSpells();
        }

        private void LoadSpells()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                spells = JsonSerializer.Deserialize<List<SpellData>>(json);
            }
            else spells = new List<SpellData>();
        }

        private void SaveSpells()
        {
            string json = JsonSerializer.Serialize(spells, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        private void ShowUserSpells_Click(object sender, RoutedEventArgs e)
        {
            DisplaySpells(spells.FindAll(s => s.IsUserSpell == true));
        }

        private void ShowAllSpells_Click(object sender, RoutedEventArgs e)
        {
            DisplaySpells(spells);
        }

        private void AddSpell_Click(object sender, RoutedEventArgs e)
        {
            var addWindow = new AddSpellWindow();
            if (addWindow.ShowDialog() == true)
            {
                spells.Add(new SpellData
                {
                    Name = addWindow.SpellName,
                    Description = addWindow.SpellDescription,
                    IsUserSpell = false
                });
                SaveSpells();
                DisplaySpells(spells);
            }
        }

        private void DisplaySpells(List<SpellData> list)
        {
            SpellContainer.Children.Clear();

            foreach (var spell in list)
            {
                var card = new SpellCardTemplate
                {
                    SpellName = spell.Name,
                    SpellDescription = spell.Description,
                    CardBackground = spell.IsUserSpell ? Brushes.LightGoldenrodYellow : Brushes.LightGray,
                };

                SpellContainer.Children.Add(card);
            }
        }
    }
}
