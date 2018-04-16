Public Class Form1
    Dim counter1 As Integer = 5
    Dim counter2 As Integer = 5
    Dim counter3 As Integer = 5
    Dim counter4 As Integer = 5

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub btnDMC_Click(sender As Object, e As EventArgs) Handles btnDMC.Click
        If counter1 > 0 Then
            counter1 -= 1
        End If

        btnDMC.Text = "Devil May Cry [" & counter1 & "]"

        If counter1 < 1 Then
            btnDMC.Enabled = False
        End If
    End Sub

    Private Sub btnCrash_Click(sender As Object, e As EventArgs) Handles btnCrash.Click
        If counter2 > 0 Then
            counter2 -= 1
        End If

        btnCrash.Text = "Crash Bandicoot [" & counter2 & "]"

        If counter2 < 1 Then
            btnCrash.Enabled = False
        End If

    End Sub

    Private Sub btnRE_Click(sender As Object, e As EventArgs) Handles btnRE.Click
        If counter3 > 0 Then
            counter3 -= 1
        End If

        btnRE.Text = "Resident Evil [" & counter3 & "]"

        If counter3 < 1 Then
            btnRE.Enabled = False
        End If

    End Sub

    Private Sub btnMK_Click(sender As Object, e As EventArgs) Handles btnMK.Click
        If counter4 > 0 Then
            counter4 -= 1
        End If

        btnMK.Text = "Mortal Kombat [" & counter4 & "]"

        If counter4 < 1 Then
            btnMK.Enabled = False
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Now
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Program Created by Joseph Tierney", "Alert")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        MessageBox.Show("Program Ending", "Alert")
        End
    End Sub

    Private Sub ResetToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem1.Click
        counter1 = 5
        counter2 = 5
        counter3 = 5
        counter4 = 5

        btnDMC.Enabled = True
        btnCrash.Enabled = True
        btnRE.Enabled = True
        btnMK.Enabled = True

        btnDMC.Text = "Devil May Cry [" & counter1 & "]"
        btnCrash.Text = "Crash Bandicoot [" & counter2 & "]"
        btnRE.Text = "Resident Evil [" & counter3 & "]"
        btnMK.Text = "Mortal Kombat [" & counter4 & "]"

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        MessageBox.Show("Program Ending", "Alert")
    End Sub
End Class
