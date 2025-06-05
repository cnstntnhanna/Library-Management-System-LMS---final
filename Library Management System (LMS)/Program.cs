using LibraryDashboard;
using MemberManagementApp;
using System;
using System.Windows.Forms;

namespace Library_Management_System__LMS_
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DashboardForm());
            Application.Run(new Login());

            //Application.Run(new AddMember());
        }
    }
}
