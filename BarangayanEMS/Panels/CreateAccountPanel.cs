using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarangayanEMS.Panels
{
    internal class CreateAccountPanel
    {
        // ---------------- CREATE ACCOUNT PANEL -------------------

        private RoundedPanel pnlCreateAccount;
        private Label lblCreateHeader;

        // Personal Info Controls
        private TextBox txtFirstName, txtLastName, txtMiddleName, txtSuffix;
        private DateTimePicker dtBirthDate;
        private ComboBox cbGender;

        private TextBox txtContactNumber, txtAddress;

        // Account Security Controls
        private TextBox txtCAEmail, txtCAPassword, txtCAConfirm;
        private CheckBox chkTerms;
        private Button btnCreateAccount;
        private LinkLabel linkBackToLogin;

        
    }
}
