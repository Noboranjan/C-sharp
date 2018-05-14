using BookShopRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookShopApplication
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtnClicked(object sender, EventArgs e)
        {
            Employee user = new Employee();
            user.EmployeeId = idTBox.Text;
            user.Password = passTBox.Text;

            EmployeeRepository empRepo = new EmployeeRepository();

            if (empRepo.UserLoginValidation(user))
            {
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Id or Password", "Login Failed");
            }
        }

        private void ExitBtnClicked(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
