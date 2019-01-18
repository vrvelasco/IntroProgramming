Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() ' Closes form
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clears form
        txtTemp.Clear()
        lblStatus.Text = "Please enter a temperature above."
        txtTemp.Focus()
        ' Reset CheckBoxes
        chkEAFreezes.Checked = False
        chkEABoils.Checked = False
        chkHgFreezes.Checked = False
        chkHgBoils.Checked = False
        chkO2Freezes.Checked = False
        chkO2Boils.Checked = False
        chkH2OFreezes.Checked = False
        chkH2OBoils.Checked = False
        ' Reset TrackBars
        trkEA.Value = trkEA.Minimum
        trkHg.Value = trkHg.Minimum
        trkO2.Value = trkO2.Minimum
        trkH2O.Value = trkH2O.Minimum
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Declare variables
        Dim decTemp As Decimal  ' For Fahrenheit
        Dim intTemp As Integer  ' For Converting to Integer
        Dim strFreezes As String = Nothing
        Dim strBoils As String = Nothing
        Dim strMessage As String = Nothing
        If Decimal.TryParse(txtTemp.Text, decTemp) Then
            intTemp = CInt(decTemp) ' Used for TrackBars
            ' ############################
            ' # Test the substance state #
            ' ############################
            ' Testing Ethyl Alcohol (EA)
            If decTemp <= -173 Then
                chkEAFreezes.Checked = True
                chkEABoils.Checked = False
                strFreezes = "[ Ethyl alcohol ] "
            ElseIf decTemp >= 172 Then
                chkEAFreezes.Checked = False
                chkEABoils.Checked = True
                strBoils = "[ Ethyl alcohol ] "
            Else
                chkEAFreezes.Checked = False
                chkEABoils.Checked = False
            End If
            ' Testing Mercury (Hg)
            If decTemp <= -38 Then
                chkHgFreezes.Checked = True
                chkHgBoils.Checked = False
                strFreezes = strFreezes & "[ Mercury ] "
            ElseIf decTemp >= 676 Then
                chkHgFreezes.Checked = False
                chkHgBoils.Checked = True
                strBoils = strBoils & "[ Mercury ] "
            Else
                chkHgFreezes.Checked = False
                chkHgBoils.Checked = False
            End If
            ' Testing Oxygen (O2)
            If decTemp <= -362 Then
                chkO2Freezes.Checked = True
                chkO2Boils.Checked = False
                strFreezes = strFreezes & "[ Oxygen ] "
            ElseIf decTemp >= -306 Then
                chkO2Freezes.Checked = False
                chkO2Boils.Checked = True
                strBoils = strBoils & "[ Oxygen ] "
            Else
                chkO2Freezes.Checked = False
                chkO2Boils.Checked = False
            End If
            ' Testing Water (H2O)
            If decTemp <= 32 Then
                chkH2OFreezes.Checked = True
                chkH2OBoils.Checked = False
                strFreezes = strFreezes & "[ Water ]"
            ElseIf decTemp >= 212 Then
                chkH2OFreezes.Checked = False
                chkH2OBoils.Checked = True
                strBoils = strBoils & "[ Water ]"
            Else
                chkH2OFreezes.Checked = False
                chkH2OBoils.Checked = False
            End If
            ' Display Message
            If strFreezes = Nothing Then
                lblStatus.Text = strBoils & " will BOIL."
            ElseIf strBoils = Nothing Then
                lblStatus.Text = strFreezes & " will FREEZE. "
            Else
                lblStatus.Text = strFreezes & " will FREEZE. " & strBoils & " will BOIL."
            End If

            txtTemp.Focus()
        Else
            lblStatus.Text = "Invalid value for the temperature. Please try again."
        End If

        ' ########################
        ' # Move the TrackBars   #
        ' ########################

        ' Movement for EA
        If intTemp <= trkEA.Minimum Then
            trkEA.Value = trkEA.Minimum
        ElseIf intTemp >= trkEA.Maximum Then
            trkEA.Value = trkEA.Maximum
        Else
            trkEA.Value = intTemp
        End If
        ' Movement for Hg
        If intTemp <= trkHg.Minimum Then
            trkHg.Value = trkHg.Minimum
        ElseIf intTemp >= trkHg.Maximum Then
            trkHg.Value = trkHg.Maximum
        Else
            trkHg.Value = intTemp
        End If
        ' Movement for O2
        If intTemp <= trkO2.Minimum Then
            trkO2.Value = trkO2.Minimum
        ElseIf intTemp >= trkO2.Maximum Then
            trkO2.Value = trkO2.Maximum
        Else
            trkO2.Value = intTemp
        End If
        ' Movement for H2O
        If intTemp <= trkH2O.Minimum Then
            trkH2O.Value = trkH2O.Minimum
        ElseIf intTemp >= trkH2O.Maximum Then
            trkH2O.Value = trkH2O.Maximum
        Else
            trkH2O.Value = intTemp
        End If
    End Sub
End Class
