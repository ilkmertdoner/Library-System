using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Projects.Button_Classes
{
    public class buttonMaximize
    {
        bool isMaximized = false;
        int count = 0;
        int width = 0;
        int height = 0;
        public void Maximize(Form form)
        {
            if (count == 0)
            {
                count = 1;
                isMaximized = true;
                form.WindowState = FormWindowState.Maximized;
                
            }
            else
            {
                isMaximized = false;
                count = 0;
                form.WindowState = FormWindowState.Normal;
            }
        }
    }
}
