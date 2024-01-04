// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Main.cs" company="Hämmer Electronics">
//   Copyright (c) All rights reserved.
// </copyright>
// <summary>
//   The main form.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace StundenlohnBerechner;

/// <summary>
/// The main form.
/// </summary>
public partial class Main : Form
{
    /// <summary>
    /// The language manager.
    /// </summary>
    private readonly ILanguageManager languageManager = new LanguageManager();

    /// <summary>
    /// The language.
    /// </summary>
    private ILanguage? language;

    /// <summary>
    /// Initializes a new instance of the <see cref="Main"/> class.
    /// </summary>
    public Main()
    {
        this.InitializeComponent();
        this.LoadTitleAndDescription();
        this.InitializeLanguageManager();
        this.LoadLanguagesToCombo();
    }

    /// <summary>
    /// Handles the calculate click.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void ButtonCalculateClick(object sender, EventArgs e)
    {
        var weeklyHours = Convert.ToDouble(this.numericUpDownWochenstunden.Value);
        var wage = Convert.ToDouble(this.numericUpDownBruttomonatslohn.Value);
        var result = Math.Round(wage / (weeklyHours * 13 / 3), 2);
        this.textBoxErgebnis.Text = result + @" €";
    }

    /// <summary>
    /// Loads the title and description.
    /// </summary>
    private void LoadTitleAndDescription()
    {
        this.Text = Application.ProductName + @" " + Application.ProductVersion;
    }

    /// <summary>
    /// Initializes the language manager.
    /// </summary>
    private void InitializeLanguageManager()
    {
        this.languageManager.SetCurrentLanguage("de-DE");
        this.languageManager.OnLanguageChanged += this.OnLanguageChanged!;
    }

    /// <summary>
    /// Loads the languages to the combo box.
    /// </summary>
    private void LoadLanguagesToCombo()
    {
        foreach (var lang in this.languageManager.GetLanguages())
        {
            this.comboBoxLanguage.Items.Add(lang.Name);
        }

        this.comboBoxLanguage.SelectedIndex = 0;
    }

    /// <summary>
    /// Handles the language changed event.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void ComboBoxLanguageSelectedIndexChanged(object sender, EventArgs e)
    {
        var selectedItem = this.comboBoxLanguage.SelectedItem?.ToString();

        if (string.IsNullOrEmpty(selectedItem))
        {
            return;
        }

        this.languageManager.SetCurrentLanguageFromName(selectedItem);
    }

    /// <summary>
    /// Handles the language changed event.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The event args.</param>
    private void OnLanguageChanged(object sender, EventArgs e)
    {
        this.language = this.languageManager.GetCurrentLanguage();
        this.labelWochenstunden.Text = this.language.GetWord("WeeklyHours");
        this.labelBruttomonatslohn.Text = this.language.GetWord("GrossMonthlySalary");
        this.buttonBerechne.Text = this.language.GetWord("Calculate");
    }
}
