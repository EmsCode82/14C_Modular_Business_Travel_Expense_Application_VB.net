Public Class Form1
    Public Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'SubTotals
        Dim dblMaxAirFare As Double
        Dim dblLodgingPerDiem As Double
        Dim dblFoodPerDiem As Double

        'Inputs
        Dim intDays As Integer
        Dim dblAirCost As Double
        Dim dblLodgingCost As Double
        Dim dblFoodCost As Double

        'Outputs

        Dim dblTotalTravelCost As Double
        Dim dblTotalReimbursement As Double
        Dim dblTotalEmployeeDue As Double

        'Boolean Validation

        Dim blnValidated As Boolean = True

        'Get and Validate Input

        Call Get_Validate_Input(intDays, dblAirCost, dblLodgingCost, dblFoodCost, blnValidated)

        'Do Calculation and Display Output

        If blnValidated Then
            Call Determine_Reimbursement(dblMaxAirFare, dblLodgingPerDiem, dblFoodPerDiem)
            Call Calculate_Travel_Cost(dblTotalTravelCost, intDays, dblAirCost, dblLodgingCost, dblFoodCost)
            Call Calculate_Reimbursement(dblTotalReimbursement, dblFoodPerDiem, dblLodgingPerDiem, dblMaxAirFare, dblAirCost, dblLodgingCost, dblFoodCost, intDays)
            Call Calculate_Employee_Due(dblTotalTravelCost, dblTotalReimbursement, dblTotalEmployeeDue)
            Call Display_Output(dblTotalTravelCost, dblTotalReimbursement, dblTotalEmployeeDue)
        End If
    End Sub

    Public Sub Get_Validate_Input(ByRef intDays As Integer, ByRef dblAirCost As Double, ByRef dblLodgingCost As Double, ByRef dblFoodCost As Double, ByRef blnValidated As Boolean)
        Call Get_Validate_Days(intDays, blnValidated)
        If blnValidated Then
            Call Get_Validate_AirCost(dblAirCost, blnValidated)
            If blnValidated Then
                Call Get_Validate_LodgingCost(dblLodgingCost, blnValidated)
                If blnValidated Then
                    Call Get_Validate_FoodCost(dblFoodCost, blnValidated)
                End If
            End If
        End If
    End Sub

    Public Sub Get_Validate_Days(ByRef intDays As Integer, ByRef blnValidated As Boolean)
        If Integer.TryParse(txtDays.Text, intDays) Then
            intDays = txtDays.Text
        Else
            MessageBox.Show("Day is Required and Must Be Numeric")
            txtDays.Focus()
            blnValidated = False
        End If
    End Sub

    Public Sub Get_Validate_AirCost(ByRef dblAirCost As Double, ByRef blnValidated As Boolean)
        If Double.TryParse(txtAirCost.Text, dblAirCost) Then
            dblAirCost = txtAirCost.Text
        Else
            MessageBox.Show("Air Cost is Required and Must Be a Decimal")
            txtAirCost.Focus()
            blnValidated = False
        End If
    End Sub

    Public Sub Get_Validate_LodgingCost(ByRef dblLodgingCost As Double, ByRef blnValidated As Boolean)
        If Double.TryParse(txtLodgingCost.Text, dblLodgingCost) Then
            dblLodgingCost = txtLodgingCost.Text
        Else
            MessageBox.Show("Lodging Cost is Required and Must Be a Decimal")
            txtLodgingCost.Focus()
            blnValidated = False
        End If
    End Sub

    Public Sub Get_Validate_FoodCost(ByRef dblFoodCost As Double, ByRef blnValidated As Boolean)
        If Double.TryParse(txtFoodCost.Text, dblFoodCost) Then
            dblFoodCost = txtFoodCost.Text
        Else
            MessageBox.Show("Food Cost is Required and Must Be a Decimal")
            txtFoodCost.Focus()
            blnValidated = False
        End If
    End Sub

    Public Sub Determine_Reimbursement(ByRef dblMaxAirFare As Double, ByRef dblLodgingPerDiem As Double, ByRef dblFoodPerDiem As Double)
        If radManagement.Checked Then
            dblMaxAirFare = 500
            dblLodgingPerDiem = 125
            dblFoodPerDiem = 75
        Else
            dblMaxAirFare = 400
            dblLodgingPerDiem = 100
            dblFoodPerDiem = 50
        End If
    End Sub

    Public Sub Calculate_Travel_Cost(ByRef dblTotalTravelCost As Double, ByVal intDays As Integer, ByVal dblAirCost As Double, ByVal dblLodgingCost As Double, ByVal dblFoodCost As Double)
        dblTotalTravelCost = dblAirCost + (dblLodgingCost * intDays) + (dblFoodCost * intDays)
    End Sub

    Public Sub Calculate_Reimbursement(ByRef dblTotalReimbursement As Double, ByRef dblFoodPerDiem As Double, ByRef dblLodgingPerDiem As Double, ByRef dblMaxAirFare As Double, ByVal dblAirCost As Double, ByVal dblLodgingCost As Double, ByVal dblFoodCost As Double, ByVal intDays As Integer)
        If (dblAirCost * intDays) < dblMaxAirFare Then
            dblMaxAirFare = dblAirCost * intDays
        End If

        If (dblLodgingCost * intDays) < dblLodgingPerDiem Then
            dblLodgingPerDiem = dblLodgingCost * intDays
        End If

        If (dblFoodCost * intDays) < dblFoodPerDiem Then
            dblFoodPerDiem = dblFoodCost * intDays
        End If

        dblTotalReimbursement = dblMaxAirFare + dblLodgingPerDiem + dblFoodPerDiem
    End Sub

    Public Sub Calculate_Employee_Due(ByVal dblTotalTravelCost As Double, ByVal dblTotalReimbursement As Double, ByRef dblTotalEmployeeDue As Double)
        dblTotalEmployeeDue = dblTotalTravelCost - dblTotalReimbursement
    End Sub

    Public Sub Display_Output(ByVal dblTotalTravelCost As Double, ByVal dblTotalReimbursement As Double, ByVal dblTotalEmployeeDue As Double)
        lblTotalTravelCost.Text = dblTotalTravelCost.ToString("C")
        lblTotalReimbursement.Text = dblTotalReimbursement.ToString("C")
        lblTotalEmployeeDue.Text = dblTotalEmployeeDue.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear Inputs Outputs Reset
        txtDays.Clear()
        txtAirCost.Clear()
        txtLodgingCost.Clear()
        txtFoodCost.Clear()
        lblTotalTravelCost.ResetText()
        lblTotalReimbursement.ResetText()
        lblTotalEmployeeDue.ResetText()
        radManagement.Checked = False
        radNonManagement.Checked = True
        txtDays.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close Program
        Close()

    End Sub
End Class
