using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFUI.ViewModels
{
    //screen allows prompts before closing - "do you want to save?" "are you sure"
    public class ShellViewModel : Screen
    {
        private string _firstName = "Tim" ;

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
            }
        }

    }
}
