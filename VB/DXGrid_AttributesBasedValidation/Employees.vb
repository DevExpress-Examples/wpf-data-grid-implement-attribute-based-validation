Imports System.Collections.ObjectModel
Imports System.ComponentModel.DataAnnotations

Public Class Employee

    <Required(AllowEmptyStrings:=False, ErrorMessage:="The Name cannot be empty. Please correct.")>
    Public Property Name As String

    <StringLength(20)>
    Public Property Position As String

    <Required(AllowEmptyStrings:=False, ErrorMessage:="The Department cannot be empty. Please correct.")>
    Public Property Department As String
End Class

Public Module Staff

    Public Function GetStaff() As ObservableCollection(Of Employee)
        Dim staff As ObservableCollection(Of Employee) = New ObservableCollection(Of Employee)()
        staff.Add(New Employee() With {.Name = "Gregory S. Price", .Department = "", .Position = "President"})
        staff.Add(New Employee() With {.Name = "", .Department = "Marketing", .Position = "Vice President"})
        staff.Add(New Employee() With {.Name = "John C. Powell", .Department = "Operations", .Position = "Vice President"})
        staff.Add(New Employee() With {.Name = "Christian P. Laclair", .Department = "Production", .Position = "Vice President"})
        staff.Add(New Employee() With {.Name = "", .Department = "Finance", .Position = "Vice President"})
        staff.Add(New Employee() With {.Name = "Brian C. Cowling", .Department = "Marketing", .Position = "Manager"})
        staff.Add(New Employee() With {.Name = "Thomas C. Dawson", .Department = "Marketing", .Position = "Manager"})
        staff.Add(New Employee() With {.Name = "", .Department = "Marketing", .Position = "Manager"})
        staff.Add(New Employee() With {.Name = "", .Department = "Marketing", .Position = "Manager"})
        staff.Add(New Employee() With {.Name = "Harold S. Brandes", .Department = "Operations", .Position = "Manager"})
        staff.Add(New Employee() With {.Name = "Michael S. Blevins", .Department = "Operations", .Position = "Manager"})
        staff.Add(New Employee() With {.Name = "Jan K. Sisk", .Department = "Operations", .Position = "Manager"})
        staff.Add(New Employee() With {.Name = "Sidney L. Holder", .Department = "Operations", .Position = "Manager"})
        staff.Add(New Employee() With {.Name = "James L. Kelsey", .Department = "Production", .Position = "Manager"})
        staff.Add(New Employee() With {.Name = "Howard M. Carpenter", .Department = "Production", .Position = "Manager"})
        staff.Add(New Employee() With {.Name = "Jennifer T. Tapia", .Department = "Production", .Position = "Manager"})
        staff.Add(New Employee() With {.Name = "Judith P. Underhill", .Department = "Finance", .Position = "Manager"})
        staff.Add(New Employee() With {.Name = "Russell E. Belton", .Department = "Finance", .Position = "Manager"})
        Return staff
    End Function
End Module
