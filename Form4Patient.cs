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
    public partial class Form4Patient : Form
    {
        private ISession _session;
        private Form1 _parent;

        // Doctor Name
        private string _key1DocName;

        private Patient _key2Patient;

        public ISession SetSession
        {
            set => _session = value;
        }

        public Form1 FormParent
        {
            set => _parent = value;
        }

        public string Key1DocName
        {
            set => _key1DocName = value;
        }

        public Patient Key2Patient
        {
            set => _key2Patient = value;
        }

        public void SetAllComponents(string t1, string t2, string t3, bool v1, bool v2)
        {
            nameTextBox1.Text = t1;
            insuranceTextBox2.Text = t2;
            diagnosisTextBox3.Text = t3;
            addButton1.Visible = v1;
            editButton2.Visible = v2;

            // If we add, we fill combobox
            if (v1)
            {
                IPatientDAO patientDAO = new NHibernateDAOFactory(_session).GetPatientDAO();
                IDoctorDAO doctorDAO = new NHibernateDAOFactory(_session).GetDoctorDAO();
                Doctor doctor = doctorDAO.GetDoctorByName(_key1DocName);

                // Display only those Patients which don't belong to the selected Doctor
                IList<Patient> notSelectedDocPatients = patientDAO.GetAll().Except(doctor.PatientList).ToList();

                // Don't show combobox if it wasn't filled
                if (notSelectedDocPatients.Count == 0)
                {
                    avlbComboBox1.Visible = false;
                    avlbLabel2.Visible = false;
                }
                else
                {
                    avlbComboBox1.DataSource = notSelectedDocPatients;
                }
            }
            else
            {
                avlbComboBox1.Visible = false;
                avlbLabel2.Visible = false;
            }
        }

        public Form4Patient()
        {
            InitializeComponent();
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            NHibernateDAOFactory nHibernateDAOFactory = new NHibernateDAOFactory(_session);
            IPatientDAO patientDAO = nHibernateDAOFactory.GetPatientDAO();
            IDoctorDAO doctorDAO = nHibernateDAOFactory.GetDoctorDAO();
            Doctor doctor = doctorDAO.GetDoctorByName(_key1DocName);

            Patient patient;

            // When textboxes are disabled then we selected something from the combobox
            if (!(nameTextBox1.Enabled && insuranceTextBox2.Enabled && diagnosisTextBox3.Enabled))
            {
                patient = (Patient)avlbComboBox1.SelectedValue;
                patient.DoctorList.Add(doctor);
                doctor.PatientList.Add(patient);
            }
            else
            {
                patient = new Patient()
                {
                    PatientName = nameTextBox1.Text,
                    InsuranceId = int.Parse(insuranceTextBox2.Text),
                    Diagnosis = diagnosisTextBox3.Text,
                };

                patient.DoctorList.Add(doctor);
                doctor.PatientList.Add(patient);
            }

            // Patients and Doctors are connected by a Consultation. So create one for them with default values
            // Then edit manually
            Consultation consultation = new Consultation()
            {
                GetConsultationTime = DateTime.UtcNow,
                RoomNumber = -1,
                GetDoctor = doctor,
                GetPatient = patient,
            };

            doctor.ConsultationList.Add(consultation);
            patient.ConsultationList.Add(consultation);

            patientDAO.SaveOrUpdate(patient);

            _parent.fillPatDataGridView2(_key1DocName);
            _parent.fillConsultDataGridView3(patient, false);

            Dispose();
        }

        private void editButton2_Click(object sender, EventArgs e)
        {
            IPatientDAO patientDAO = new NHibernateDAOFactory(_session).GetPatientDAO();

            Patient patient = _key2Patient;
            patient.PatientName = nameTextBox1.Text;
            patient.InsuranceId = int.Parse(insuranceTextBox2.Text);
            patient.Diagnosis = diagnosisTextBox3.Text;
            patientDAO.SaveOrUpdate(patient);

            _parent.fillPatDataGridView2(_key1DocName);
            Dispose();
        }

        // When we decide to select a Patient from the combobox that means we don't want to create a new one.
        // If we don't find the needed one, simply close and open the dialog again.
        private void avlbComboBox1_Click(object sender, EventArgs e)
        {
            nameTextBox1.Enabled = false;
            insuranceTextBox2.Enabled = false;
            diagnosisTextBox3.Enabled = false;
        }
    }
}
