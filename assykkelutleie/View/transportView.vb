Imports MySql.Data.MySqlClient
Public Class transportView
    Private Sub GetAllForTransport()    'Gets all bicycles and equipment that has a different CurrentLocation then the DefaultLocation. 
        Dim bicycle As New Bicycle()
        Dim bicycleList As DataTable = DbManager.GetAll(bicycle)
        Dim equipmentSearch As New Equipment()
        Dim equipmentList As DataTable = DbManager.GetAll(equipmentSearch)
        lbTransportation.Items.Clear()
        For Each row In bicycleList.Rows
            If Not row("DefaultLocation") = row("CurrentLocation") Then
                Dim b = New Bicycle With {.BicycleID = row("BicycleID"), .BicycleType = row("BicycleType"), .DefaultLocation = row("DefaultLocation"), .CurrentLocation = row("CurrentLocation")}
                lbTransportation.Items.Add(b)
            End If
        Next
        For Each row In equipmentList.Rows
            If Not row("DefaultLocation") = row("CurrentLocation") Then
                Dim e = New Equipment With {.EquipmentID = row("EquipmentID"), .EquipmentType = row("EquipmentType"), .DefaultLocation = row("DefaultLocation"), .CurrentLocation = row("CurrentLocation")}
                lbTransportation.Items.Add(e)
            End If
        Next
    End Sub

    Private Sub ContextMenuStrip1_Click(sender As Object, e As EventArgs) Handles ContextMenuStrip1.Click ' Sub for the ContextMenuStrip that updates the CurrentLocation to the DefaultLocation when an item has been transported. Checks if it is a bicycle or equipment before updating.
        If lbTransportation.SelectedIndices.Count > 0 Then
            If lbTransportation.SelectedItem.ToString.StartsWith("SykkelID") Then
                Dim bicycle As New Bicycle()
                Dim getBicycle As New DataTable
                getBicycle = DbManager.GetSpecific(bicycle, lbTransportation.SelectedItem.BicycleID())
                bicycle = New Bicycle(getBicycle)
                bicycle.CurrentLocation() = bicycle.DefaultLocation()
                DbManager.Update(bicycle)
            Else
                Dim equipment As New Equipment()
                Dim utstyrTable As DataTable = DbManager.GetSpecific(equipment, lbTransportation.SelectedItem.EquipmentID())
                equipment = New Equipment(utstyrTable)
                equipment.CurrentLocation() = equipment.DefaultLocation()
                DbManager.Update(equipment)
            End If
        Else
            MsgBox("Du må høyreklikke på et objekt for å returnere det")
        End If
        GetAllForTransport()
    End Sub

    Private Sub btnTransportUpdate_Click(sender As Object, e As EventArgs) Handles btnTransportUpdate.Click ' Button for generating the transportlist.
        GetAllForTransport()
    End Sub

    Private Sub TransportView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAllForTransport()
    End Sub

End Class