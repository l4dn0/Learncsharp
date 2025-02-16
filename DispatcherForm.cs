using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task15_1
{
    public partial class DispatcherForm : Form
    {
        WritesHandler cruisesListHandler;

        public DispatcherForm()
        {
            InitializeComponent();
            cruisesListHandler = new WritesHandler("cruises");
        }

        private void DispatcherForm_Load(object sender, EventArgs e)
        {
            var lw = new List<Write> { };
            lw.AddRange(cruisesListHandler.GetAllWrites());
            listBox1.DataSource = lw;
            listBox1.ValueMember = "Id";
            listBox1.DisplayMember = "DisplayName";

            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;

            driverListbox.DataSource = lw;
            driverListbox.ValueMember = "Id";
            driverListbox.DisplayMember = "DisplayName";

            driverListbox.SelectedIndexChanged += DriverListbox_SelectedIndexChanged;

        }

        private void DriverListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (Write)listBox1.SelectedItem;
            driverFromToBox.Text = selectedItem.FromTo;
            driverDriverBox.Text = selectedItem.Driver;
            driverCarBox.Text = selectedItem.Car;
            driverDateTimePicker.Text = selectedItem.Date;
            driverCompletedCruiseCheckbox.Checked = selectedItem.Completed;
            driverCarBrokenCheckbox.Checked = selectedItem.CarBroken;
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (Write)listBox1.SelectedItem;
            fromToBox.Text = selectedItem.FromTo;
            driverBox.Text = selectedItem.Driver;
            carBox.Text = selectedItem.Car;
            cruiseDatePicker.Text = selectedItem.Date;
            completedCruiseCheckbox.Checked = selectedItem.Completed;
            carBrokenCheckbox.Checked = selectedItem.CarBroken;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Write selectedItem = (Write)listBox1.SelectedItem;
            selectedItem.FromTo = fromToBox.Text;
            selectedItem.Driver = driverBox.Text;
            selectedItem.Car = carBox.Text;
            selectedItem.Date = cruiseDatePicker.Text;
            selectedItem.Completed = completedCruiseCheckbox.Checked;
            selectedItem.CarBroken = carBrokenCheckbox.Checked;
            selectedItem.DisplayName = selectedItem.Id + ") " + fromToBox.Text + " | " + cruiseDatePicker.Text;

            cruisesListHandler.EditWrite(selectedItem);
            MessageBox.Show("Успешно обновлено", "Уведомление");

            var lw = new List<Write> { };
            lw.AddRange(cruisesListHandler.GetAllWrites());
            listBox1.DataSource = lw;

        }

        private void driverEditButton_Click(object sender, EventArgs e)
        {
            Write selectedItem = (Write)driverListbox.SelectedItem;
            selectedItem.FromTo = driverFromToBox.Text;
            selectedItem.Driver = driverDriverBox.Text;
            selectedItem.Car = driverCarBox.Text;
            selectedItem.Date = driverDateTimePicker.Text;
            selectedItem.Completed = driverCompletedCruiseCheckbox.Checked;
            selectedItem.CarBroken = driverCarBrokenCheckbox.Checked;
            selectedItem.DisplayName = selectedItem.Id + ") " + driverFromToBox.Text + " | " + driverDateTimePicker.Text;

            cruisesListHandler.EditWrite(selectedItem);
            MessageBox.Show("Успешно обновлено", "Уведомление");

            var lw = new List<Write> { };
            lw.AddRange(cruisesListHandler.GetAllWrites());
            driverListbox.DataSource = lw;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var hasPreviousWrites = cruisesListHandler.GetAllWrites();
            Write newWrite = new Write()
            {
                Id = cruisesListHandler.GetAllWrites().Any() ? cruisesListHandler.GetAllWrites().Last().Id + 1 : 1,
                FromTo = addFromToBox.Text,
                Date = addCruiseDatePicker.Text,
                Driver = addDriverBox.Text,
                Car = addCarBox.Text,
                Completed = addCompletedCruiseCheckbox.Checked,
                CarBroken = false,
                DisplayName = ""
            };

            cruisesListHandler.AddWrite(newWrite);
            MessageBox.Show("Рейс успешено добавлен", "Уведомление");

            var lw = new List<Write> { };
            lw.AddRange(cruisesListHandler.GetAllWrites());
            listBox1.DataSource = lw;
            listBox1.Update();
        }
    }
}
