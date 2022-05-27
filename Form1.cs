using Lab4NHibernateIndividual.dao;
using Lab4NHibernateIndividual.domain;
using NHibernate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4NHibernateIndividual
{
    public partial class Form1 : Form
    {
        private ISession _session;

        private Form2Connect _form2 = null;
        private Form3Doctor _form3 = null;
        private Form4Patient _form4 = null;
        private Form5Consultation _form5 = null;

        public ISession SetSession
        {
            set => _session = value;
        }

        public Form2Connect GetForm2
        {
            get
            {
                if (_form2 == null || _form2.IsDisposed)
                {
                    _form2 = new Form2Connect();
                }
                _form2.FormParent = this;
                return _form2;
            }
        }

        public Form3Doctor GetForm3
        {
            get
            {
                if (_form3 == null || _form3.IsDisposed)
                {
                    _form3 = new Form3Doctor();
                }
                _form3.SetSession = _session;
                _form3.FormParent = this;
                return _form3;
            }
        }

        public Form4Patient GetForm4
        {
            get
            {
                if (_form4 == null || _form4.IsDisposed)
                {
                    _form4 = new Form4Patient();
                }
                _form4.SetSession = _session;
                _form4.FormParent = this;
                return _form4;
            }
        }

        public Form5Consultation GetForm5
        {
            get
            {
                if (_form5 == null || _form5.IsDisposed)
                {
                    _form5 = new Form5Consultation();
                }
                _form5.SetSession = _session;
                _form5.FormParent = this;
                return _form5;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void addDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetForm3.SetAllComponents("", "", true, false);
            GetForm3.Show();
        }

        private void removeDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Know which doctor was selected to remove
            int selectedRow = docDataGridView1.SelectedCells[0].RowIndex;
            string key = (string)docDataGridView1.Rows[selectedRow].Cells[0].Value;

            IDoctorDAO doctorDAO = new NHibernateDAOFactory(_session).GetDoctorDAO();

            DialogResult dr = MessageBox.Show("Remove docotr?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    doctorDAO.DeleteDoctorByName(key);
                    fillDocDataGridView1();
                    patDataGridView2.Rows.Clear();
                    consultDataGridView3.Rows.Clear();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception");
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void editDocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Know which doctor was selected to edit
            int selectedRow = docDataGridView1.SelectedCells[0].RowIndex;
            string key = (string)docDataGridView1.Rows[selectedRow].Cells[0].Value;

            IDoctorDAO doctorDAO = new NHibernateDAOFactory(_session).GetDoctorDAO();

            Doctor doctor = doctorDAO.GetDoctorByName(key);
            GetForm3.SetAllComponents(doctor.DoctorName, doctor.JobTitle, false, true);
            GetForm3.KeyDoc = doctor;
            GetForm3.Show();
        }

        private void addPatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Know to which Doctor add Patient
            int selectedRow = docDataGridView1.SelectedCells[0].RowIndex;
            string key = (string)docDataGridView1.Rows[selectedRow].Cells[0].Value;

            GetForm4.Key1DocName = key;
            GetForm4.SetAllComponents("", "", "", true, false);
            GetForm4.Show();
        }

        private void removePatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Know from which Doctor remove Patient
            int selectedRow = docDataGridView1.SelectedCells[0].RowIndex;
            string key1 = (string)docDataGridView1.Rows[selectedRow].Cells[0].Value;

            // And what Patient to remove
            selectedRow = patDataGridView2.SelectedCells[0].RowIndex;
            int key2 = (int)patDataGridView2.Rows[selectedRow].Cells[1].Value;

            NHibernateDAOFactory nHibernateDAOFactory = new NHibernateDAOFactory(_session);

            IPatientDAO patientDAO = nHibernateDAOFactory.GetPatientDAO();
            Patient patient = patientDAO.GetPatientByInsuranceId(key2);

            foreach (Doctor d in patient.DoctorList)
            {
                // Remove this Patient from its Doctors
                d.PatientList.Remove(patient);

                // And remove this Patient's consultations from its Doctors
                d.ConsultationList = d.ConsultationList.Except(patient.ConsultationList).ToList();
            }

            try
            {
                patientDAO.Delete(patient);
                fillPatDataGridView2(key1);
                consultDataGridView3.Rows.Clear();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception");
                Console.WriteLine(ex.ToString());
            }
        }

        private void editPatToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Know from which Doctor edit Patient
            int selectedRow = docDataGridView1.SelectedCells[0].RowIndex;
            string key1 = (string)docDataGridView1.Rows[selectedRow].Cells[0].Value;

            // And what Patient to edit
            selectedRow = patDataGridView2.SelectedCells[0].RowIndex;
            int key2 = (int)patDataGridView2.Rows[selectedRow].Cells[1].Value;

            IPatientDAO patientDAO = new NHibernateDAOFactory(_session).GetPatientDAO();
            Patient patient = patientDAO.GetPatientByInsuranceId(key2);

            GetForm4.SetAllComponents(patient.PatientName, patient.InsuranceId.ToString(), patient.Diagnosis, false, true);
            GetForm4.Key1DocName = key1;
            GetForm4.Key2Patient = patient;
            GetForm4.Show();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetForm2.Show();
        }

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _session.Close();
            docDataGridView1.Rows.Clear();
            patDataGridView2.Rows.Clear();
        }

        public void fillDocDataGridView1()
        {
            docDataGridView1.Rows.Clear();

            IDoctorDAO doctorDAO = new NHibernateDAOFactory(_session).GetDoctorDAO();
            IList<Doctor> doctorList = doctorDAO.GetAll();

            foreach (Doctor d in doctorList)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();

                cell1.ValueType = typeof(string);
                cell1.Value = d.DoctorName;
                cell2.ValueType = typeof(string);
                cell2.Value = d.JobTitle;

                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                docDataGridView1.Rows.Add(row);
            }
        }

        public void fillPatDataGridView2(string docKey)
        {
            patDataGridView2.Rows.Clear();

            IDoctorDAO doctorDAO = new NHibernateDAOFactory(_session).GetDoctorDAO();
            IList<Patient> patientList = doctorDAO.GetAllPatientsOfDoctor(docKey);

            foreach (Patient p in patientList)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();

                cell1.ValueType = typeof(string);
                cell1.Value = p.PatientName;
                cell2.ValueType = typeof(int);
                cell2.Value = p.InsuranceId;
                cell3.ValueType = typeof(string);
                cell3.Value = p.Diagnosis;

                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);

                patDataGridView2.Rows.Add(row);
            }
        }

        // true  -> Doctor
        // false -> Patient
        // This means whose Consultations to display
        public void fillConsultDataGridView3(EntityBase whoEntity, bool flag)
        {
            consultDataGridView3.Rows.Clear();

            NHibernateDAOFactory nHibernateDAOFactory = new NHibernateDAOFactory(_session);
            IList<Consultation> consultationList;

            if (flag)
            {
                consultationList = nHibernateDAOFactory.GetDoctorDAO().GetAllConsultationsOfDoctor((Doctor)whoEntity);
            }
            else
            {
                consultationList = nHibernateDAOFactory.GetPatientDAO().GetAllConsultationsOfPatient((Patient)whoEntity);
            }

            foreach (Consultation c in consultationList)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();

                cell1.ValueType = typeof(long);
                cell1.Value = c.Id;
                cell2.ValueType = typeof(DateTime);
                cell2.Value = c.GetConsultationTime;
                cell3.ValueType = typeof(int);
                cell3.Value = c.RoomNumber;

                row.Cells.Add(cell1);
                row.Cells.Add(cell2);
                row.Cells.Add(cell3);

                consultDataGridView3.Rows.Add(row);
            }
        }

        private void docDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = docDataGridView1.SelectedCells[0].RowIndex;
            string key = (string)docDataGridView1.Rows[selectedRow].Cells[0].Value;
            fillPatDataGridView2(key);

            IDoctorDAO doctorDAO = new NHibernateDAOFactory(_session).GetDoctorDAO();
            Doctor doctor = doctorDAO.GetDoctorByName(key);
            fillConsultDataGridView3(doctor, true);
        }

        private void patDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = docDataGridView1.SelectedCells[0].RowIndex;
            string docKey = (string)docDataGridView1.Rows[selectedRow].Cells[0].Value;
            selectedRow = patDataGridView2.SelectedCells[0].RowIndex;
            int patKey = (int)patDataGridView2.Rows[selectedRow].Cells[1].Value;

            IPatientDAO patientDAO = new NHibernateDAOFactory(_session).GetPatientDAO();
            Patient patient = patientDAO.GetPatientByInsuranceId(patKey);
            fillConsultDataGridView3(patient, false);
        }

        private void addConsultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (docDataGridView1.SelectedCells.Count != 0)
            {
                int selectedDocRow = docDataGridView1.SelectedCells[0].RowIndex;
                string docKey = (string)docDataGridView1.Rows[selectedDocRow].Cells[0].Value;

                if (patDataGridView2.SelectedCells.Count != 0)
                {
                    int selectedPatRow = patDataGridView2.SelectedCells[0].RowIndex;
                    int patKey = (int)patDataGridView2.Rows[selectedPatRow].Cells[1].Value;
                    GetForm5.SetAllComponents("", "", true, false);

                    GetForm5.Key1DocName = docKey;
                    GetForm5.Key2InsId = patKey;

                    GetForm5.Show();
                }
            }
        }

        private void removeConsultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedConsRow = consultDataGridView3.SelectedCells[0].RowIndex;
            long consKey = (long)consultDataGridView3.Rows[selectedConsRow].Cells[0].Value;

            DAOFactory dao = new NHibernateDAOFactory(_session);
            IConsultationDAO consultationDAO = dao.GetConsultationDAO();
            Consultation consultation = consultationDAO.GetById(consKey);

            // Remove this Consultation from collections
            consultation.GetDoctor.ConsultationList.Remove(consultation);
            consultation.GetPatient.ConsultationList.Remove(consultation);
            consultationDAO.Delete(consultation);

            consultDataGridView3.Rows.Clear();
        }

        private void editConsultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedConsRow = consultDataGridView3.SelectedCells[0].RowIndex;
            long consKey = (long)consultDataGridView3.Rows[selectedConsRow].Cells[0].Value;

            DAOFactory dao = new NHibernateDAOFactory(_session);
            IConsultationDAO consultationDAO = dao.GetConsultationDAO();
            Consultation consultation = consultationDAO.GetById(consKey);

            GetForm5.SetAllComponents(consultation.GetConsultationTime.ToString(), consultation.RoomNumber.ToString(), false, true);
            GetForm5.Key3ConsultationId = consultation.Id;

            GetForm5.Show();
        }
    }
}
