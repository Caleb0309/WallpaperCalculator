Public Class Form1
    Private Sub frmWallpaperApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For i As Integer = 10 To 35
            cbLength.Items.Add(i.ToString())
            cbWidth.Items.Add(i.ToString())
            cbHeight.Items.Add(i.ToString())
        Next


        For i As Decimal = 40 To 50 Step 0.5
            cbRollCoverage.Items.Add(i.ToString())
        Next


        cbLength.SelectedIndex = 0
        cbWidth.SelectedIndex = 0
        cbHeight.SelectedIndex = 0
        cbRollCoverage.SelectedIndex = 0
    End Sub

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        lblSingleRolls.Text = ""
        Dim roomArea As Integer = 2 * (Integer.Parse(cbHeight.SelectedItem) * Integer.Parse(cbWidth.SelectedItem) +
            Integer.Parse(cbHeight.SelectedItem) * Integer.Parse(cbLength.SelectedItem))
        Dim singleRolls As Double = roomArea / Double.Parse(cbRollCoverage.SelectedItem)
        lblSingleRolls.Text = Math.Ceiling(singleRolls).ToString()
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub



End Class