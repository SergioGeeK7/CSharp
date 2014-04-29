using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DemoSeguridad
{
    public partial class RecuperarContrasena : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void PasswordRecovery1_SendingMail(object sender, MailMessageEventArgs e)
        {
            SmtpClient email = new SmtpClient();
            email.EnableSsl = true;
            email.Send(e.Message); // hay ya biene el email armado
            e.Cancel = true;
        }
    }
}