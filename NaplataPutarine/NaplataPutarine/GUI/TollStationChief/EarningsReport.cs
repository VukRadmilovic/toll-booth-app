using NaplataPutarine.Core;
using NaplataPutarine.Core.TollStations.Controllers;
using NaplataPutarine.Core.TollStations.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaplataPutarine.GUI.TollStationChief.Forms
{
    internal partial class EarningsReport : Form
    {
        private readonly NaplatnaStanica? _current;
        private readonly EarningsReportController _earningsController;

        public EarningsReport(NaplatnaStanica? current)
        {
            InitializeComponent();
            _current = current;
            _earningsController = new EarningsReportController();
        }

        private void EarningsReport_Load(object sender, EventArgs e)
        {
            yearPicker.Maximum = DateTime.Now.Year;
            yearPicker.Value = DateTime.Now.Year;
            FillMonthComboBox();
        }

        private void DayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(dayRadioButton.Checked)
            {
                dayPicker.Enabled = true;
                return;
            }
            dayPicker.Enabled = false;
        }

        private void MonthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(monthRadioButton.Checked)
            {
                monthPicker.Enabled = true;
                return;
            }
            monthPicker.Enabled = false;
        }

        private void YearRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if(yearRadioButton.Checked)
            {
                yearPicker.Enabled = true;
                return;
            }
            yearPicker.Enabled = false;
        }

        private void FillMonthComboBox()
        {
            string[] months = new string[] { "Januar", "Februar", "Mart", "April", "Maj", "Jun", "Jul", "Avgust", "Septembar", "Oktobar", "Novembar", "Decembar" };
            for(int i = 0; i < months.Length; i++)
            {
                monthPicker.Items.Add(new EnhancedComboBoxItem(months[i], new DateOnly(DateTime.Now.Year, i + 1, 1)));
            }
            monthPicker.SelectedIndex = 0;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string report = "";
            if(dayRadioButton.Checked)
            {
                report = _earningsController.GetReport(_current, "day", DateOnly.FromDateTime(dayPicker.Value));
            }
            else if(monthRadioButton.Checked)
            {
                report = _earningsController.GetReport(_current, "month",
                                                       DateOnly.FromDateTime(DateTime.Parse(((EnhancedComboBoxItem)monthPicker.SelectedItem).value.ToString())));

            }
            else if(yearRadioButton.Checked)
            {
                report = _earningsController.GetReport(_current, "year", new DateOnly((int)yearPicker.Value, 1, 1));
            }
            reportTextArea.Text = report;
        }
    }
}
