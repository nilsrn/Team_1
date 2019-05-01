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

    Private Sub GetAllEqipmentForRepair()    'Gets all bicycles that has the same CurrentLocation and DefaultLocation with status "Utleid". 
        Dim equipment As New Equipment()
        Dim equipmentList As DataTable = DbManager.GetAll(equipment)
        lbEquipmentRepairs.Items.Clear()
        For Each row In equipmentList.Rows
            If row("Status") = "Service" Then
                Dim b = New Equipment With {.EquipmentID = row("EquipmentID"), .EquipmentType = row("EquipmentType"), .DefaultLocation = row("DefaultLocation"), .CurrentLocation = row("CurrentLocation"), .Status = row("Status")}
                lbEquipmentRepairs.Items.Add(b)
            End If
        Next
    End Sub


    Private Sub UpdateBicycle(status As String)    'Updates the status on a chosen bicycleobject
        Dim setStatus As New Bicycle()
        Dim getBicycle As DataTable = DbManager.GetSpecific(setStatus, lbBicycleRepairs.SelectedValue)
        setStatus = New Bicycle(getBicycle)
        setStatus.Status() = status
        DbManager.Update(setStatus)
        GetAllBicyclesForRepair()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        UpdateBicycle("Ledig")
    End Sub
End Class