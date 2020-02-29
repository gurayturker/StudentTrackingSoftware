using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentTrackinSoftware.Common.Message
{
   public  class Messages
    {
        public static void ErrorMessage(string errorMassage)
        {
            XtraMessageBox.Show(errorMassage,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public static DialogResult YesSelectedYesNo(string message,string title)
        {
            return XtraMessageBox.Show(message, title, MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button1);
        }
        public static DialogResult NoSelectedYesNo(string message, string title)
        {
            return XtraMessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }
        public static DialogResult DeleteMessage(string cardName)
        {
            return NoSelectedYesNo($"Selected {cardName} will be delete.Do you accept?", "Delete Confirmation");
        }
    }
}
