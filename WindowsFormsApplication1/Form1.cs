using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using System.DirectoryServices.ActiveDirectory;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DomainControllerCollection DCs;
        private Domain.Domain Domain;

        private void OnLoad(object sender, EventArgs e)
        {
            Domain = new Domain.Domain();

            DCs = Domain.GetDomainControllers();

            dgv_DomainControllers.ColumnCount = 2;
            dgv_DomainControllers.Columns[0].Name = "Name";
            dgv_DomainControllers.Columns[1].Name = "Reported";
            
            foreach (DomainController DC in DCs)
            {
                string[] row = { DC.Name, "False" };
                dgv_DomainControllers.Rows.Add(row);
            }

        }

        private void OnClick(object sender, EventArgs e)
        {
            string Username = tbx_Username.Text;

            dgv_LastLogonDate.ColumnCount = 2;
            dgv_LastLogonDate.Columns[0].Name = "Domain Controller";
            dgv_LastLogonDate.Columns[1].Name = "Last Logon Date";

            foreach (DomainController DC in DCs)
            {
                DateTime LLD =  Domain.GetLastLogonDate(Username, DC);

                //string[] row = { DC.Name, Domain.Domain. GetLastLogonDate(Username, DC).ToString() };
                //dgv_LastLogonDate.Rows.Add()
            }
        }
    }
}
