using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePay_Client_Forms
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool check = CheckData();

            if(check)
            {
                CreateDataArray();
            }
        }

        private void CreateDataArray()
        {
            var dataRegistration = new Dictionary<string, object>();
        }

        private bool CheckData()
        {
            //true - data is correct
            //false - data is not correct
            bool validation = true;

            //Login
            if (txtLogin.Text.Length > 14)
            {
                vldLogin.Visible = true;
                validation = false;
            }
            else
            {
                vldLogin.Visible = false;
            }

            //Password
            if (txtPassword.Text.Length > 50)
            {
                vldPassword.Visible = true;
                validation = false;
            }
            else
            {
                vldPassword.Visible = false;
            }

            //Name
            if (txtName.Text.Length > 40)
            {
                vldName.Visible = true;
                validation = false;
            }
            else
            {
                vldName.Visible = false;
            }

            //Surname
            if (txtSurname.Text.Length > 40)
            {
                vldSurname.Visible = true;
                validation = false;
            }
            else
            {
                vldSurname.Visible = false;
            }

            //Email
            if (txtEmail.Text.Length > 17)
            {
                vldEmail.Visible = true;
                validation = false;
            }
            else
            {
                vldEmail.Visible = false;
            }

            //Phone
            if (txtPhone.Text.Length > 50)
            {
                vldPhone.Visible = true;
                validation = false;
            }
            else
            {
                vldPhone.Visible = false;
            }

            //Address
            if (txtAddress.Text.Length > 50)
            {
                vldAddress.Visible = true;
                validation = false;
            }
            else
            {
                vldAddress.Visible = false;
            }

            return validation;
        }
    }
}
