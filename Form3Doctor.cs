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
    public partial class Form3Doctor : Form
    {
        private ISession _session;
        private Form1 _parent;

        private Doctor _keyDoc;

        public ISession SetSession
        {
            set => _session = value;
        }

        public Form1 FormParent
        {
            set => _parent = value;
        }

        public Doctor KeyDoc
        {
            set => _keyDoc = value;
        }

        public void SetAllComponents(string t1, string t2, bool v1, bool v2)
        {
            nameTextBox1.Text = t1;
            jobTextBox2.Text = t2;
            addButton1.Visible = v1;
            editButton2.Visible = v2;
        }

        public Form3Doctor()
        {
            InitializeComponent();
        }

        private void addButton1_Click(object sender, EventArgs e)
        {
            IDoctorDAO doctorDAO = new NHibernateDAOFactory(_session).GetDoctorDAO();

            Doctor doctor = new Doctor()
            {
                DoctorName = nameTextBox1.Text,
                JobTitle = jobTextBox2.Text
            };

            doctorDAO.SaveOrUpdate(doctor);
            _parent.fillDocDataGridView1();
            Dispose();
        }

        private void editButton2_Click(object sender, EventArgs e)
        {
            IDoctorDAO doctorDAO = new NHibernateDAOFactory(_session).GetDoctorDAO();

            Doctor doctor = _keyDoc;

            doctor.DoctorName = nameTextBox1.Text;
            doctor.JobTitle = jobTextBox2.Text;

            doctorDAO.SaveOrUpdate(doctor);
            _parent.fillDocDataGridView1();
            Dispose();
        }
    }
}
