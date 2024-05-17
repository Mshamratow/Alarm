using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePickerDate.Value;
            string alarmName = txtAlarmName.Text;
            string periodicity = comboBoxPeriodicity.Text;

            string alarmDetails = $"{selectedDate.ToShortDateString()}  - {alarmName} ({periodicity}) ";

            Form1 mainForm = Application.OpenForms["Form1"] as Form1;
            mainForm.AddAlarmToListBox(alarmDetails);
            this.Close();

        }
    }
}
