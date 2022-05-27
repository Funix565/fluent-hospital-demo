using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4NHibernateIndividual
{
    public partial class Form2Connect : Form
    {
        private ISessionFactory _factory;
        private ISession _session;
        private Form1 _parent;

        public Form1 FormParent
        {
            set => _parent = value;
        }

        public Form2Connect()
        {
            InitializeComponent();
        }

        private ISession OpenSession(string host, int port, string database, string user, string password)
        {
            ISession session = null;

            Assembly mappingsAssembly = Assembly.GetExecutingAssembly();
            if (_factory == null)
            {
                _factory = Fluently.Configure()
                    .Database(
                        PostgreSQLConfiguration.PostgreSQL82
                        .ConnectionString(c => c
                            .Host(host)
                            .Port(port)
                            .Database(database)
                            .Username(user)
                            .Password(password))
                        .ShowSql())
                    .Mappings(m =>
                        m.FluentMappings.AddFromAssembly(mappingsAssembly))
                    .ExposeConfiguration(BuildSchema)
                    .BuildSessionFactory();
            }

            session = _factory.OpenSession();
            return session;
        }

        private static void BuildSchema(Configuration config)
        {
            new SchemaExport(config).Create(false, true);
        }

        private void connectButton1_Click(object sender, EventArgs e)
        {
            _session = OpenSession(hostTextBox1.Text, Convert.ToInt32(portTextBox2.Text), dbTextBox3.Text, userTextBox4.Text, passwordTextBox5.Text);
            Dispose();

            _parent.SetSession = _session;
            _parent.fillDocDataGridView1();
        }
    }
}
