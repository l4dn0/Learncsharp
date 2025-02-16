using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task15_1
{
    internal class WritesHandler
    {
        string name;
        List<Write> writes { get; set; }
        string[] rawitems;
        FileHandler f;

        public WritesHandler(string name)
        {
            this.name = name;
            writes = new List<Write> { };
            f = new FileHandler(name + ".csv");
            string[] items = f.GetAllLines();
            setWrites(items);
        }

        private void setWrites(string[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                string[] item = items[i].Split(';');

                writes.Add(new Write
                {
                    Id = int.Parse(item[0]),
                    FromTo = item[1],
                    Date = item[2],
                    Driver = item[3],
                    Car = item[4],
                    Completed = Boolean.Parse(item[5]),
                    CarBroken = Boolean.Parse(item[6]),
                    DisplayName = item[0] + ") " + item[1] + " | " + item[2]
                });
            }
        }

        public List<Write> GetAllWrites()
        {
            return writes;
        }

        public void EditWrite(Write editedWrite)
        {
            for (int i = 0; i < writes.Count; i++)
            {
                if (editedWrite.Id == writes[i].Id)
                {
                    writes[i] = editedWrite;
                    f.AddLine(ConvertWriteToLine(editedWrite), i);
                }
            }
        }

        private static string ConvertWriteToLine(Write w)
        {
            return String.Format("{0};{1};{2};{3};{4};{5};{6}", w.Id, w.FromTo, w.Date, w.Driver, w.Car, w.Completed, w.CarBroken);
        }

        public void AddWrite(Write newWrite)
        {
            string newLine = ConvertWriteToLine(newWrite);
            f.AddLine(newLine);
        }
    }
}
