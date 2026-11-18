using BusinessLayer;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    static internal class ActiveMain
    {
        public static string PrevTitle = null;
        static public frmMain Main;
        static public void AppendTitle(string title)
        {
            title =  "\\" + title;
            if (Main.lblFormTitle.Text.Contains(title)) return;
            PrevTitle = Main.lblFormTitle.Text;
            Main.lblFormTitle.Text +=  title;
        }
        static public void SetTitle(string title)
        {
            PrevTitle = Main.lblFormTitle.Text;
            Main.lblFormTitle.Text = title;
        }
        static public void Undo()
        {
            Main.lblFormTitle.Text = PrevTitle;
        }
    }
    static internal class ActiveUser
    {
        private static clsUser _User;
        public static clsUser User
        {
            set
            {
                _User = value;
                UpdateActiveUser?.Invoke();
                //if (UpdateActiveUser != null)
                //{
                //    Task task = Task.Run(UpdateActiveUser.Invoke);
                //    //task.();
                //}
            }
            get
            {
                return _User;
            }
        }
        public static Action UpdateActiveUser;



    }
}
