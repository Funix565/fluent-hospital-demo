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
    public partial class Form5Consultation : Form
    {
        private ISession _session;
        private Form1 _parent;

        // Doctor Name
        private string _key1DocName;

        // Insurance Id -- We need them to find target Doctor and target Patient
        private int _key2InsId;

        // Target consulation id.
        private long _key3ConsultationId;

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

        public int Key2InsId
        {
            set => _key2InsId = value;
        }

        public long Key3ConsultationId
        {
            set => _key3ConsultationId = value;
        }

        public void SetAllComponents(string t1, string t2, bool v1, bool v2)
        {
            dateTimePicker1.Text = t1;
            roomTextBox1.Text = t2;
            addButton1.Visible = v1;
            editButton2.Visible = v2;
        }

        public Form5Consultation()
        {
            InitializeComponent();
        }

        // We can create additional Consultations for selected Doctor and Patient
        private void addButton1_Click(object sender, EventArgs e)
        {
            NHibernateDAOFactory nHibernateDAOFactory = new NHibernateDAOFactory(_session);
            Doctor doctor = nHibernateDAOFactory.GetDoctorDAO().GetDoctorByName(_key1DocName);
            Patient patient = nHibernateDAOFactory.GetPatientDAO().GetPatientByInsuranceId(_key2InsId);

            Consultation consultation = new Consultation()
            {
                GetConsultationTime = DateTime.SpecifyKind(dateTimePicker1.Value, DateTimeKind.Utc),
                RoomNumber = int.Parse(roomTextBox1.Text),
                GetDoctor = doctor,
                GetPatient = patient
            };

            doctor.ConsultationList.Add(consultation);
            patient.ConsultationList.Add(consultation);

            nHibernateDAOFactory.GetConsultationDAO().SaveOrUpdate(consultation);

            _parent.fillConsultDataGridView3(patient, false);

            Dispose();
        }

        private void editButton2_Click(object sender, EventArgs e)
        {
            DAOFactory dao = new NHibernateDAOFactory(_session);
            IConsultationDAO consultationDAO = dao.GetConsultationDAO();
            Consultation consultation = consultationDAO.GetById(_key3ConsultationId);
            Patient patient = consultation.GetPatient;

            consultation.GetConsultationTime = DateTime.SpecifyKind(dateTimePicker1.Value, DateTimeKind.Utc);
            consultation.RoomNumber = int.Parse(roomTextBox1.Text);
            consultationDAO.SaveOrUpdate(consultation);
            _parent.fillConsultDataGridView3(patient, false);

            Dispose();
        }
    }
}
