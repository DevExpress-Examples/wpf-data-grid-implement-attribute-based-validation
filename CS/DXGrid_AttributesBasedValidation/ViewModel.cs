using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace DXGrid_AttributesBasedValidation {
    public class ViewModel : ViewModelBase {
        public ViewModel() {
            Source = Staff.GetStaff();
        }
        public ObservableCollection<Employee> Source { get; set; }
    }
}
