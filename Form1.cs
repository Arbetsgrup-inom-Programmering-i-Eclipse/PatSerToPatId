using System;
using System.Data;
using System.Windows.Forms;

namespace Form
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            long patientSer;
            if (long.TryParse(textBox1.Text, out patientSer))
            {
                try
                {

                    DataTable patient = GetPatientId(patientSer);

                    if (patient.Rows.Count == 1)
                    {
                        Clipboard.SetText(patient.Rows[0].ItemArray[0].ToString());
                        label1.Text = "Patient Namn: " + patient.Rows[0].ItemArray[1].ToString() + " " + patient.Rows[0].ItemArray[2].ToString() + "\r\n" + "\r\n" + "PatientId: " + patient.Rows[0].ItemArray[0].ToString() + "\r\n" + "\r\n" + "Id kopierades automatiskt till Clipboard ";
                    }
                    else
                    {
                        label1.Text = "Patienten hittades inte";
                    }
                }

                catch (Exception exception)
                {
                    MessageBox.Show("Kunde inte hämta PatientId\r\n" + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Felaktigt format på PatientSer", "PatientSer To PatientId", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        static private DataTable GetPatientId(long patientSer)
        {
            (DataTable datatable, Exception exception) = AriaInterface.Query(AriaDatabase.Clinical, @"SELECT 
	                                                        Patient.PatientId,
                                                            Patient.FirstName,
                                                            Patient.LastName
                                                        FROM 
	                                                        Patient
                                                        WHERE 		           
                                                            Patient.PatientSer LIKE @patientSer", ("patientSer", patientSer.ToString()));
            return datatable;
        }

    }
}
