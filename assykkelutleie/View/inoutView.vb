﻿Public Class inoutView
    Private Sub inoutView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetAllForIn()
        GetAllForOut()
    End Sub

#Region "Code for the In tab"
    Private Sub GetAllForIn()    'Gets all bicycles that has the same CurrentLocation and DefaultLocation with status "Utleid". 
        Dim bicycle As New Bicycle()
        Dim bicycleList As DataTable = DbManager.GetAll(bicycle)
        lbIn.Items.Clear()
        For Each row In bicycleList.Rows
            If row("Status") = "Utleid" And row("DefaultLocation") = row("CurrentLocation") Then
                Dim b = New Bicycle With {.BicycleID = row("BicycleID"), .BicycleType = row("BicycleType"), .DefaultLocation = row("DefaultLocation"), .CurrentLocation = row("CurrentLocation"), .Status = row("Status")}  'Oppretter sykkelobjektet og legger til i listboksen
                lbIn.Items.Add(b)
            End If
        Next
    End Sub

    Private Sub MarkerSomTilbakelevertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkerSomTilbakelevertToolStripMenuItem.Click
        If lbIn.SelectedIndices.Count > 0 Then
            If lbIn.SelectedItem.ToString.StartsWith("SykkelID") Then
                Dim bicycle As New Bicycle()
                Dim getBicycle As New DataTable
                getBicycle = DbManager.GetSpecific(bicycle, lbIn.SelectedItem.BicycleID())
                bicycle = New Bicycle(getBicycle)
                Dim result = CustomMessageBox.Show({"Ledig", "Service", "Stjålet"}, "Velg ønsket status:", "AS SykkelUtleie")
                bicycle.Status() = result
                If result <> "" Then
                    DbManager.Update(bicycle)
                End If
            End If
        Else
            MsgBox("Du må høyreklikke på et objekt")
        End If
        GetAllForIn()
    End Sub

    Private Sub BtnInUpdate_Click(sender As Object, e As EventArgs) Handles btnInUpdate.Click
        GetAllForIn()
    End Sub
#End Region

#Region "Code for the Out tab"
    Private Sub GetAllForOut()    'Gets all bicycles that meets the criteria. 
        Dim thisDate As Date = Today
        Dim rentedbicycles As New RentedBicycles()
        Dim bicycle As New Bicycle()
        Dim rentals As New Rentals()
        Dim rentedbicyclesList As DataTable = DbManager.GetAll(rentedbicycles)
        Dim bicycleList As DataTable = DbManager.GetAll(bicycle)
        Dim rentalList As DataTable = DbManager.GetAll(rentals)
        lbOut.Items.Clear()
        For Each row3 In rentalList.Rows
            For Each row2 In bicycleList.Rows
                For Each row In rentedbicyclesList.Rows
                    If row2("BicycleID") = row("BicycleID") And row("DateFrom") >= thisDate And row2("Status") = "Ledig" And row3("RentalID") = row("RentalID") And row2("CurrentLocation") = row3("PickupLocation") Then
                        Dim b = New RentedBicycles With {.BicycleID = row("BicycleID"), .RentalID = row("RentalID"), .DateFrom = row("DateFrom")}  'Creates bicycleobject and adds it to the listbox
                        lbOut.Items.Add(b)
                    End If
                Next
            Next
        Next
    End Sub

    Private Sub MarkerSomUtlevertToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MarkerSomUtlevertToolStripMenuItem.Click
        If lbOut.SelectedIndices.Count > 0 Then
            If lbOut.SelectedItem.ToString.StartsWith("SykkelID") Then
                Dim bicycle As New Bicycle()
                Dim rentedbicycles As New RentedBicycles()
                Dim rentals As New Rentals()
                Dim rentedbicyclesList As DataTable = DbManager.GetAll(rentedbicycles)
                Dim rentalList As DataTable = DbManager.GetAll(rentals)
                Dim getBicycle As New DataTable
                For Each row2 In rentalList.Rows
                    For Each row In rentedbicyclesList.Rows
                        If row2("RentalID") = row("RentalID") And row("BicycleID") = lbOut.SelectedItem.BicycleID() Then
                            getBicycle = DbManager.GetSpecific(bicycle, lbOut.SelectedItem.BicycleID())
                            bicycle = New Bicycle(getBicycle)
                            bicycle.Status() = "Utleid"
                            bicycle.CurrentLocation() = row2("DeliveryLocation")
                        End If
                    Next
                Next
                DbManager.Update(bicycle)
            End If
        Else
            MsgBox("Du må høyreklikke på et objekt")
        End If
        GetAllForOut()
    End Sub

    Private Sub BtnOutUpdate_Click(sender As Object, e As EventArgs) Handles btnOutUpdate.Click
        GetAllForOut()
    End Sub
#End Region
End Class