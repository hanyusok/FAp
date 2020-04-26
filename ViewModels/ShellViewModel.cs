using Caliburn.Micro;

namespace FAp.ViewModels
{
    public class ShellViewModel : Screen
    {     
        private string firstName = "Tim";
        public string FirstName
        {   
            get 
            { 
                return firstName; 
            }
            set 
            { 
                firstName = value; 
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set 
            { 
                lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
            }
        }

        public string FullName
        {
            get 
            { 
                return $"{FirstName} {LastName}"; 
            }            
        }
        
        
        
        

    }
}