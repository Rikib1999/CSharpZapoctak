using CSharpZapoctak.ViewModels;

namespace CSharpZapoctak.Models
{
    public class PenaltyReason : ViewModelBase
    {
        private string name = "";
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        private string code;
        public string Code
        {
            get { return code; }
            set
            {
                code = value;
                OnPropertyChanged();
            }
        }
    }
}