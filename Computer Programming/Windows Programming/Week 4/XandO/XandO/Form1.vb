Public Class Form1
    Dim xgo As Boolean = True
    Dim counter As Integer = 0
    Dim xscore As Integer = 0
    Dim oscore As Integer = 0
    Dim Win As Boolean = False

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        'increment counter
        counter += 1
        If xgo = True Then
            btn1.Text = "X"
            'stop the user pressing this button again
            btn1.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub pricedure checkwin
            End If
            xgo = False     'allow O to take a turn
            lblGo.Text = "O Go"
        Else
            btn1.Text = "O"
            'stop the user pressing this button again
            btn1.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub procedure checkwin
            End If
            xgo = True      'allow X to take a turn
            lblGo.Text = "X Go"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        'increment counter
        counter += 1
        If xgo = True Then
            btn2.Text = "X"
            'stop the user pressing this button again
            btn2.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub pricedure checkwin
            End If
            xgo = False     'allow O to take a turn
            lblGo.Text = "O Go"
        Else
            btn2.Text = "O"
            'stop the user pressing this button again
            btn2.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub procedure checkwin
            End If
            xgo = True      'allow X to take a turn
            lblGo.Text = "X Go"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        'increment counter
        counter += 1
        If xgo = True Then
            btn3.Text = "X"
            'stop the user pressing this button again
            btn3.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub pricedure checkwin
            End If
            xgo = False     'allow O to take a turn
            lblGo.Text = "O Go"
        Else
            btn3.Text = "O"
            'stop the user pressing this button again
            btn3.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub procedure checkwin
            End If
            xgo = True      'allow X to take a turn
            lblGo.Text = "X Go"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        'increment counter
        counter += 1
        If xgo = True Then
            btn4.Text = "X"
            'stop the user pressing this button again
            btn4.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub procedure checkwin
            End If
            xgo = False     'allow O to take a turn
            lblGo.Text = "O Go"
        Else
            btn4.Text = "O"
            'stop the user pressing this button again
            btn4.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub procedure checkwin
            End If
            xgo = True      'allow X to take a turn
            lblGo.Text = "X Go"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        'increment counter
        counter += 1
        If xgo = True Then
            btn5.Text = "X"
            'stop the user pressing this button again
            btn5.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub procedure checkwin
            End If
            xgo = False     'allow O to take a turn
            lblGo.Text = "O Go"
        Else
            btn5.Text = "O"
            'stop the user pressing this button again
            btn5.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub procedure checkwin
            End If
            xgo = True      'allow X to take a turn
            lblGo.Text = "X Go"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        'increment counter
        counter += 1
        If xgo = True Then
            btn6.Text = "X"
            'stop the user pressing this button again
            btn6.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub procedure checkwin
            End If
            xgo = False     'allow O to take a turn
            lblGo.Text = "O Go"
        Else
            btn6.Text = "O"
            'stop the user pressing this button again
            btn6.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub procedure checkwin
            End If
            xgo = True      'allow X to take a turn
            lblGo.Text = "X Go"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        'increment counter
        counter += 1
        If xgo = True Then
            btn7.Text = "X"
            'stop the user pressing this button again
            btn7.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub procedure checkwin
            End If
            xgo = False     'allow O to take a turn
            lblGo.Text = "O Go"
        Else
            btn7.Text = "O"
            'stop the user pressing this button again
            btn7.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub procedure checkwin
            End If
            xgo = True      'allow X to take a turn
            lblGo.Text = "X Go"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        'increment counter
        counter += 1
        If xgo = True Then
            btn8.Text = "X"
            'stop the user pressing this button again
            btn8.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub procedure checkwin
            End If
            xgo = False     'allow O to take a turn
            lblGo.Text = "O Go"
        Else
            btn8.Text = "O"
            'stop the user pressing this button again
            btn8.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub pricedure checkwin
            End If
            xgo = True      'allow X to take a turn
            lblGo.Text = "X Go"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        'increment counter
        counter += 1
        If xgo = True Then
            btn9.Text = "X"
            'stop the user pressing this button again
            btn9.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub procedure checkwin
            End If
            xgo = False     'allow O to take a turn
            lblGo.Text = "O Go"
        Else
            btn9.Text = "O"
            'stop the user pressing this button again
            btn9.Enabled = False
            'check for a win if 5 goes or more
            If counter > 4 Then
                checkwin()  'call sub procedure checkwin
            End If
            xgo = True      'allow X to take a turn
            lblGo.Text = "X Go"
        End If
    End Sub

    Private Sub checkwin()
        'check for X win
        'CHECK HORIZONTALLY

        If btn1.Text = "X" And btn2.Text = "X" And btn3.Text = "X" Then
            'highlight the win by changing the background of the buttons
            btn1.BackColor = Color.Red
            btn2.BackColor = Color.Red
            btn3.BackColor = Color.Red
            lblWin.Text = "X Wins!"
            'increment counter
            xscore += 1
            'make lblWin visible
            lblWin.Visible = True
            'change win flag
            Win = True
            'Show the score
            lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
            lblScore.Visible = True
            'show play again button
            btnPlayAgain.Visible = True
            ResetToolStripMenuItem.Enabled = True
            'call a method to make all buttons .enabled False
            changebuttons()
            'stop checking for any more wins
            Exit Sub
        End If

        If btn4.Text = "X" And btn5.Text = "X" And btn6.Text = "X" Then
            'highlight the win by changing the background of the buttons
            btn4.BackColor = Color.Red
            btn5.BackColor = Color.Red
            btn6.BackColor = Color.Red
            lblWin.Text = "X Wins!"
            'increment counter
            xscore += 1
            'make lblWin visible
            lblWin.Visible = True
            'change win flag
            Win = True
            'Show the score
            lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
            lblScore.Visible = True
            'show play again button
            btnPlayAgain.Visible = True
            ResetToolStripMenuItem.Enabled = True
            'call a method to make all buttons .enabled False
            changebuttons()
            'stop checking for anymore wins
            Exit Sub
        End If

        If btn7.Text = "X" And btn8.Text = "X" And btn9.Text = "X" Then
            'highlight the win by changing the background of the buttons
            btn7.BackColor = Color.Red
            btn8.BackColor = Color.Red
            btn9.BackColor = Color.Red
            lblWin.Text = "X Wins!"
            'increment counter
            xscore += 1
            'make lblWin visible
            lblWin.Visible = True
            'change win flag
            Win = True
            'Show the score
            lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
            lblScore.Visible = True
            'show play again button
            btnPlayAgain.Visible = True
            ResetToolStripMenuItem.Enabled = True
            'call a method to make all buttons .enabled False
            changebuttons()
            'stop checking for anymore wins
            Exit Sub
        End If

        'CHECK X WIN VERTICALLY

        If btn1.Text = "X" And btn4.Text = "X" And btn7.Text = "X" Then
            'highlight the win by changing the background of the buttons
            btn1.BackColor = Color.Red
            btn4.BackColor = Color.Red
            btn7.BackColor = Color.Red
            lblWin.Text = "X Wins!"
            'increment counter
            xscore += 1
            'make lblWin visible
            lblWin.Visible = True
            'change win flag
            Win = True
            'Show the score
            lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
            lblScore.Visible = True
            'show play again button
            btnPlayAgain.Visible = True
            ResetToolStripMenuItem.Enabled = True
            'call a method to make all buttons .enabled False
            changebuttons()
            'stop checking for anymore wins
            Exit Sub
        End If

        If btn2.Text = "X" And btn5.Text = "X" And btn8.Text = "X" Then
            'highlight the win by changing the background of the buttons
            btn2.BackColor = Color.Red
            btn5.BackColor = Color.Red
            btn8.BackColor = Color.Red
            lblWin.Text = "X Wins!"
            'increment counter
            xscore += 1
            'make lblWin visible
            lblWin.Visible = True
            'change win flag
            Win = True
            'Show the score
            lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
            lblScore.Visible = True
            'show play again button
            btnPlayAgain.Visible = True
            ResetToolStripMenuItem.Enabled = True
            'call a method to make all buttons .enabled False
            changebuttons()
            'stop checking for anymore wins
            Exit Sub
        End If

        If btn3.Text = "X" And btn6.Text = "X" And btn9.Text = "X" Then
            'highlight the win by changing the background of the buttons
            btn3.BackColor = Color.Red
            btn6.BackColor = Color.Red
            btn9.BackColor = Color.Red
            lblWin.Text = "X Wins!"
            'increment counter
            xscore += 1
            'make lblWin visible
            lblWin.Visible = True
            'change win flag
            Win = True
            'Show the score
            lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
            lblScore.Visible = True
            'show play again button
            btnPlayAgain.Visible = True
            ResetToolStripMenuItem.Enabled = True
            'call a method to make all buttons .enabled False
            changebuttons()
            'stop checking for anymore wins
            Exit Sub
        End If

        'CHECK FOR X WIN DIAGONALLY

        If btn1.Text = "X" And btn5.Text = "X" And btn9.Text = "X" Then
            'highlight the win by changing the background of the buttons
            btn1.BackColor = Color.Red
            btn5.BackColor = Color.Red
            btn9.BackColor = Color.Red
            lblWin.Text = "X Wins!"
            'increment counter
            xscore += 1
            'make lblWin visible
            lblWin.Visible = True
            'change win flag
            Win = True
            'Show the score
            lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
            lblScore.Visible = True
            'show play again button
            btnPlayAgain.Visible = True
            ResetToolStripMenuItem.Enabled = True
            'call a method to make all buttons .enabled False
            changebuttons()
            'stop checking for anymore wins
            Exit Sub
        End If

        If btn3.Text = "X" And btn5.Text = "X" And btn7.Text = "X" Then
            'highlight the win by changing the background of the buttons
            btn3.BackColor = Color.Red
            btn5.BackColor = Color.Red
            btn7.BackColor = Color.Red
            lblWin.Text = "X Wins!"
            'increment counter
            xscore += 1
            'make lblWin visible
            lblWin.Visible = True
            'change win flag
            Win = True
            'Show the score
            lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
            lblScore.Visible = True
            'show play again button
            btnPlayAgain.Visible = True
            ResetToolStripMenuItem.Enabled = True
            'call a method to make all buttons .enabled False
            changebuttons()
            'stop checking for anymore wins
            Exit Sub
        End If

        '''''CHECK FOR AN O WIN''''''

        'CHECK FOR O WIN HORIZONTALLY

        If btn1.Text = "O" And btn2.Text = "O" And btn3.Text = "O" Then
            'highlight the win by changing the background of the buttons
            btn1.BackColor = Color.Cyan
            btn2.BackColor = Color.Cyan
            btn3.BackColor = Color.Cyan
            lblWin.Text = "O Wins!"
            'increment counter
            oscore += 1
            'make lblWin visible
            lblWin.Visible = True
            'change win flag
            Win = True
            'Show the score
            lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
            lblScore.Visible = True
            'show play again button
            btnPlayAgain.Visible = True
            ResetToolStripMenuItem.Enabled = True
            'call a method to make all buttons .enabled False
            changebuttons()
            'stop checking for anymore wins
            Exit Sub
        End If

        If btn4.Text = "O" And btn5.Text = "O" And btn6.Text = "O" Then
            'highlight the win by changing the background of the buttons
            btn4.BackColor = Color.Cyan
            btn5.BackColor = Color.Cyan
            btn6.BackColor = Color.Cyan
            lblWin.Text = "O Wins!"
            'increment counter
            oscore += 1
            'make lblWin visible
            lblWin.Visible = True
            'change win flag
            Win = True
            'Show the score
            lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
            lblScore.Visible = True
            'show play again button
            btnPlayAgain.Visible = True
            ResetToolStripMenuItem.Enabled = True
            'call a method to make all buttons .enabled False
            changebuttons()
            'stop checking for anymore wins
            Exit Sub
        End If

        If btn7.Text = "O" And btn8.Text = "O" And btn9.Text = "O" Then
            'highlight the win by changing the background of the buttons
            btn7.BackColor = Color.Cyan
            btn8.BackColor = Color.Cyan
            btn9.BackColor = Color.Cyan
            lblWin.Text = "O Wins!"
            'increment counter
            oscore += 1
            'make lblWin visible
            lblWin.Visible = True
            'change win flag
            Win = True
            'Show the score
            lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
            lblScore.Visible = True
            'show play again button
            btnPlayAgain.Visible = True
            ResetToolStripMenuItem.Enabled = True
            'call a method to make all buttons .enabled False
            changebuttons()
            'stop checking for anymore wins
            Exit Sub
        End If

        'CHECK O WIN VERTICALLY

        If btn1.Text = "O" And btn4.Text = "O" And btn7.Text = "O" Then
            'highlight the win by changing the background of the buttons
            btn1.BackColor = Color.Cyan
            btn4.BackColor = Color.Cyan
            btn7.BackColor = Color.Cyan
            lblWin.Text = "O Wins!"
            'increment counter
            oscore += 1
            'make lblWin visible
            lblWin.Visible = True
            'change win flag
            Win = True
            'Show the score
            lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
            lblScore.Visible = True
            'show play again button
            btnPlayAgain.Visible = True
            ResetToolStripMenuItem.Enabled = True
            'call a method to make all buttons .enabled False
            changebuttons()
            'stop checking for anymore wins
            Exit Sub
        End If

        If btn2.Text = "O" And btn5.Text = "O" And btn8.Text = "O" Then
            'highlight the win by changing the background of the buttons
            btn2.BackColor = Color.Cyan
            btn5.BackColor = Color.Cyan
            btn8.BackColor = Color.Cyan
            lblWin.Text = "O Wins!"
            'increment counter
            oscore += 1
            'make lblWin visible
            lblWin.Visible = True
            'change win flag
            Win = True
            'Show the score
            lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
            lblScore.Visible = True
            'show play again button
            btnPlayAgain.Visible = True
            ResetToolStripMenuItem.Enabled = True
            'call a method to make all buttons .enabled False
            changebuttons()
            'stop checking for anymore wins
            Exit Sub
        End If

        If btn3.Text = "O" And btn6.Text = "O" And btn9.Text = "O" Then
            'highlight the win by changing the background of the buttons
            btn3.BackColor = Color.Cyan
            btn6.BackColor = Color.Cyan
            btn9.BackColor = Color.Cyan
            lblWin.Text = "O Wins!"
            'increment counter
            oscore += 1
            'make lblWin visible
            lblWin.Visible = True
            'change win flag
            Win = True
            'Show the score
            lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
            lblScore.Visible = True
            'show play again button
            btnPlayAgain.Visible = True
            ResetToolStripMenuItem.Enabled = True
            'call a method to make all buttons .enabled False
            changebuttons()
            'stop checking for anymore wins
            Exit Sub
        End If

        'CHECK O WIN DIAGONALLY

        If btn1.Text = "O" And btn5.Text = "O" And btn9.Text = "O" Then
            'highlight the win by changing the background of the buttons
            btn1.BackColor = Color.Cyan
            btn5.BackColor = Color.Cyan
            btn9.BackColor = Color.Cyan
            lblWin.Text = "O Wins!"
            'increment counter
            oscore += 1
            'make lblWin visible
            lblWin.Visible = True
            'change win flag
            Win = True
            'Show the score
            lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
            lblScore.Visible = True
            'show play again button
            btnPlayAgain.Visible = True
            ResetToolStripMenuItem.Enabled = True
            'call a method to make all buttons .enabled False
            changebuttons()
            'stop checking for anymore wins
            Exit Sub
        End If

        If btn3.Text = "O" And btn5.Text = "O" And btn7.Text = "O" Then
            'highlight the win by changing the background of the buttons
            btn3.BackColor = Color.Cyan
            btn5.BackColor = Color.Cyan
            btn7.BackColor = Color.Cyan
            lblWin.Text = "O Wins!"
            'increment counter
            oscore += 1
            'make lblWin visible
            lblWin.Visible = True
            'change win flag
            Win = True
            'Show the score
            lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
            lblScore.Visible = True
            'show play again button
            btnPlayAgain.Visible = True
            ResetToolStripMenuItem.Enabled = True
            'call a method to make all buttons .enabled False
            changebuttons()
            'stop checking for anymore wins
            Exit Sub
        End If

        'check for a draw
        If counter = 9 And btnPlayAgain.Visible = False Then
            lblWin.Visible = True
            lblWin.Text = "DRAW!"
            btnPlayAgain.Visible = True
            btn1.BackColor = Color.Orange
            btn2.BackColor = Color.Orange
            btn3.BackColor = Color.Orange
            btn4.BackColor = Color.Orange
            btn5.BackColor = Color.Orange
            btn6.BackColor = Color.Orange
            btn7.BackColor = Color.Orange
            btn8.BackColor = Color.Orange
            btn9.BackColor = Color.Orange

            'changebuttons()
            'cleargrid()

            If counter = 9 Then
                ResetToolStripMenuItem.Enabled = True
            End If


        End If

    End Sub
    Private Sub changebuttons()
        If btn1.Enabled = True Then
            btn1.Enabled = False
        End If
        If btn2.Enabled = True Then
            btn2.Enabled = False
        End If
        If btn3.Enabled = True Then
            btn3.Enabled = False
        End If
        If btn4.Enabled = True Then
            btn4.Enabled = False
        End If
        If btn5.Enabled = True Then
            btn5.Enabled = False
        End If
        If btn6.Enabled = True Then
            btn6.Enabled = False
        End If
        If btn7.Enabled = True Then
            btn7.Enabled = False
        End If
        If btn8.Enabled = True Then
            btn8.Enabled = False
        End If
        If btn9.Enabled = True Then
            btn9.Enabled = False
        End If
    End Sub

    Private Sub btnPlayAgain_Click(sender As Object, e As EventArgs) Handles btnPlayAgain.Click
        cleargrid()         'call the method cleargrid
        ResetToolStripMenuItem.Enabled = False
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        xscore = 0
        oscore = 0
        lblScore.Visible = False
        'lblScore.Text = "X Score: " & xscore & vbNewLine & "O Score: " & oscore
        cleargrid()
        ResetToolStripMenuItem.Enabled = False
    End Sub

    Private Sub cleargrid()
        'clear the counters and flags
        counter = 0
        xgo = True
        lblWin.Visible = False
        lblGo.Text = "X Go"
        btnPlayAgain.Visible = False

        'make changes to the button 1
        btn1.Enabled = True
        btn1.BackColor = DefaultBackColor
        btn1.Text = ""

        'make changes to the button 2
        btn2.Enabled = True
        btn2.BackColor = DefaultBackColor
        btn2.Text = ""

        'make changes to the button 3
        btn3.Enabled = True
        btn3.BackColor = DefaultBackColor
        btn3.Text = ""

        'make changes to the button 4
        btn4.Enabled = True
        btn4.BackColor = DefaultBackColor
        btn4.Text = ""

        'make changes to the button 5
        btn5.Enabled = True
        btn5.BackColor = DefaultBackColor
        btn5.Text = ""

        'make changes to the button 6
        btn6.Enabled = True
        btn6.BackColor = DefaultBackColor
        btn6.Text = ""

        'make changes to the button 7
        btn7.Enabled = True
        btn7.BackColor = DefaultBackColor
        btn7.Text = ""

        'make changes to the button 8
        btn8.Enabled = True
        btn8.BackColor = DefaultBackColor
        btn8.Text = ""

        'make changes to the button 9
        btn9.Enabled = True
        btn9.BackColor = DefaultBackColor
        btn9.Text = ""
    End Sub
End Class
