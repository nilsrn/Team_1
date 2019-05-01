Public Class repairView
    Private Sub repairView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAllBicyclesForRepair()
        GetAllEqipmentForRepair()
    End Sub


    Private Sub GetAllBicyclesForRepair()    'Gets all bicycles that has the status "Service". 
        Dim bicycles As New Bicycle()
        Dim bicycleList As DataTable = DbManager.GetAll(bicycles)
        lbBicycleRepairs.Items.Clear()
        For Each row In bicycleList.Rows
            If row("Status") = "Service" Then
                Dim b = New Bicycle With {.BicycleID = row("BicycleID"), .BicycleType = row("BicycleType"), .DefaultLocation = row("DefaultLocation"), .CurrentLocation = row("CurrentLocation"), .Status = row("Status")}
                lbBicycleRepairs.Items.Add(b)
            End If
        Next
    End Sub

    Private Sub GetAllEqipmentForRepair()    'Gets all bicycles that has the status "Service". 
        Dim equipment As New Equipment()
        Dim equipmentList As DataTable = DbManager.GetAll(equipment)
        lbEquipmentRepairs.Items.Clear()
        For Each row In equipmentList.Rows
            If row("Status") = "Service" Then
                Dim x = New Equipment With {.EquipmentID = row("EquipmentID"), .EquipmentType = row("EquipmentType"), .DefaultLocation = row("DefaultLocation"), .CurrentLocation = row("CurrentLocation"), .Status = row("Status")}
                lbEquipmentRepairs.Items.Add(x)
            End If
        Next
    End Sub

    Private Sub repairUpdate_Click(sender As Object, e As EventArgs) Handles repairUpdate.Click 'If a bicycle or an equipment is selected it will give the possibility to update the status of the object. 
        If lbBicycleRepairs.SelectedIndices.Count > 0 Then
            If lbBicycleRepairs.SelectedItem.ToString.StartsWith("SykkelID") Then
                Dim bicycle As New Bicycle()
                Dim getBicycle As New DataTable
                getBicycle = DbManager.GetSpecific(bicycle, lbBicycleRepairs.SelectedItem.BicycleID())
                bicycle = New Bicycle(getBicycle)
                Dim result = CustomMessageBox.Show({"Ledig", "Stjålet"}, "Velg ønsket status:", "AS SykkelUtleie")
                bicycle.Status() = result
                If result <> "" Then
                    DbManager.Update(bicycle)
                    GetAllBicyclesForRepair()
                End If
            End If
        End If

        If lbEquipmentRepairs.SelectedIndices.Count > 0 Then
            If lbEquipmentRepairs.SelectedItem.ToString.StartsWith("UtstyrID") Then
                Dim equipment As New Equipment()
                Dim getEquipment As New DataTable
                getEquipment = DbManager.GetSpecific(equipment, lbEquipmentRepairs.SelectedItem.EquipmentID())
                equipment = New Equipment(getEquipment)
                Dim result = CustomMessageBox.Show({"Ledig", "Stjålet"}, "Velg ønsket status:", "AS SykkelUtleie")
                equipment.Status() = result
                If result <> "" Then
                    DbManager.Update(equipment)
                    GetAllEqipmentForRepair()
                End If
            End If
        End If
    End Sub


    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click 'Updates the listboxes.
        GetAllBicyclesForRepair()
        GetAllEqipmentForRepair()
    End Sub
End Class