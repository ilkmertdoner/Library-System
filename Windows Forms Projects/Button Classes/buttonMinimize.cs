using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Forms_Projects.Button_Classes
{
    public class buttonMinimize
    {
        public void Minimize(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }
    }
}
