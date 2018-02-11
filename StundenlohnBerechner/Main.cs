using System;
using System.Windows.Forms;
using Languages.Implementation;
using Languages.Interfaces;

namespace StundenlohnBerechner
{
    public partial class Main : Form
    {
        private readonly ILanguageManager _lm = new LanguageManager();
        private ILanguage _lang;

        public Main()
        {
            InitializeComponent();
            LoadTitleAndDescription();
            InitializeLanguageManager();
            LoadLanguagesToCombo();
        }

        private void buttonBerechne_Click(object sender, EventArgs e)
        {
            var wochenStunden = Convert.ToDouble(numericUpDownWochenstunden.Value);
            var bruttoLohn = Convert.ToDouble(numericUpDownBruttomonatslohn.Value);
            var ergebnis = Math.Round(bruttoLohn / (wochenStunden * 13 / 3), 2);
            textBoxErgebnis.Text = ergebnis + @" €";
        }

        private void LoadTitleAndDescription()
        {
            Text = Application.ProductName + @" " + Application.ProductVersion;
        }


        private void InitializeLanguageManager()
        {
            _lm.SetCurrentLanguage("de-DE");
            _lm.OnLanguageChanged += OnLanguageChanged;
        }

        private void LoadLanguagesToCombo()
        {
            foreach (var lang in _lm.GetLanguages())
                comboBoxLanguage.Items.Add(lang.Name);
            comboBoxLanguage.SelectedIndex = 0;
        }

        private void comboBoxLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            _lm.SetCurrentLanguageFromName(comboBoxLanguage.SelectedItem.ToString());
        }

        private void OnLanguageChanged(object sender, EventArgs eventArgs)
        {
            _lang = _lm.GetCurrentLanguage();
            labelWochenstunden.Text = _lang.GetWord("WeeklyHours");
            labelBruttomonatslohn.Text = _lang.GetWord("GrossMonthlySalary");
            buttonBerechne.Text = _lang.GetWord("Calculate");
        }
    }
}