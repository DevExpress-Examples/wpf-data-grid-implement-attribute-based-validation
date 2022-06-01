using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

public class Employee {
    [Required(AllowEmptyStrings = false, ErrorMessage = "The Name cannot be empty. Please correct.")]
    public string Name { get; set; }
    [StringLength(20)]
    public string Position { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "The Department cannot be empty. Please correct.")]
    public string Department { get; set; }
}

public static class Staff {
    public static ObservableCollection<Employee> GetStaff() {
        ObservableCollection<Employee> staff = new ObservableCollection<Employee>();
        staff.Add(new Employee() {Name = "Gregory S. Price", Department = "", Position = "President"});
        staff.Add(new Employee() {Name = "", Department = "Marketing", Position = "Vice President"});
        staff.Add(new Employee() {Name = "John C. Powell", Department = "Operations", Position = "Vice President"});
        staff.Add(new Employee() {Name = "Christian P. Laclair", Department = "Production", Position = "Vice President"});
        staff.Add(new Employee() {Name = "", Department = "Finance", Position = "Vice President"});

        staff.Add(new Employee() {Name = "Brian C. Cowling", Department = "Marketing", Position = "Manager"});
        staff.Add(new Employee() {Name = "Thomas C. Dawson", Department = "Marketing", Position = "Manager"});
        staff.Add(new Employee() {Name = "", Department = "Marketing", Position = "Manager"});
        staff.Add(new Employee() {Name = "", Department = "Marketing", Position = "Manager"});

        staff.Add(new Employee() {Name = "Harold S. Brandes", Department = "Operations", Position = "Manager"});
        staff.Add(new Employee() {Name = "Michael S. Blevins", Department = "Operations", Position = "Manager"});
        staff.Add(new Employee() {Name = "Jan K. Sisk", Department = "Operations", Position = "Manager"});
        staff.Add(new Employee() {Name = "Sidney L. Holder", Department = "Operations", Position = "Manager"});

        staff.Add(new Employee() {Name = "James L. Kelsey", Department = "Production", Position = "Manager"});
        staff.Add(new Employee() {Name = "Howard M. Carpenter", Department = "Production", Position = "Manager"});
        staff.Add(new Employee() {Name = "Jennifer T. Tapia", Department = "Production", Position = "Manager"});

        staff.Add(new Employee() {Name = "Judith P. Underhill", Department = "Finance", Position = "Manager"});
        staff.Add(new Employee() {Name = "Russell E. Belton", Department = "Finance", Position = "Manager"});
        return staff;
    }
}
