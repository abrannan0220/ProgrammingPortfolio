Public Class frmMain

    Dim player As String
    Dim player1 As String = "X"
    Dim player2 As String = "O"
    Dim numTurns As Integer
    Dim gameOver As Boolean = False


    Sub lockBoard()

        btn1AA.Enabled = False
        btn2AB.Enabled = False
        btn3AC.Enabled = False
        btn4BA.Enabled = False
        btn5BB.Enabled = False
        btn6BC.Enabled = False
        btn7CA.Enabled = False
        btn8CB.Enabled = False
        btn9CC.Enabled = False


    End Sub

    Sub unlockBoard()
        btn1AA.Enabled = True
        btn2AB.Enabled = True
        btn3AC.Enabled = True
        btn4BA.Enabled = True
        btn5BB.Enabled = True
        btn6BC.Enabled = True
        btn7CA.Enabled = True
        btn8CB.Enabled = True
        btn9CC.Enabled = True

    End Sub
    Sub clearBoard()
        btn1AA.Text = "$"
        btn2AB.Text = "$"
        btn3AC.Text = "$"
        btn4BA.Text = "$"
        btn5BB.Text = "$"
        btn6BC.Text = "$"
        btn7CA.Text = "$"
        btn8CB.Text = "$"
        btn9CC.Text = "$"

    End Sub
    Sub switchPlayer()
        If gameOver = False Then
            If player = player1 Then
                player = player2
            Else
                player = player1
            End If
        End If
    End Sub
    Sub rowAWinTest()
        If numTurns >= 5 And gameOver = False Then
            If btn1AA.Text = btn2AB.Text And btn2AB.Text = btn3AC.Text Then
                lblStatus.Text() = "Winner Found"
                winnerFound()
            End If
        End If
    End Sub
    Sub rowBWinTest()
        If numTurns >= 5 And gameOver = False Then
            If btn4BA.Text = btn5BB.Text And btn5BB.Text = btn6BC.Text Then
                lblStatus.Text() = "Winner Found"
                winnerFound()
            End If
        End If
    End Sub
    Sub rowCWinTest()
        If numTurns >= 5 And gameOver = False Then
            If btn7CA.Text = btn8CB.Text And btn8CB.Text = btn9CC.Text Then
                lblStatus.Text() = "Winner Found"
                winnerFound()
            End If
        End If
    End Sub
    Sub colAWinTest()
        If numTurns >= 5 And gameOver = False Then
            If btn1AA.Text = btn4BA.Text And btn4BA.Text = btn7CA.Text Then
                lblStatus.Text() = "Winner Found"
                winnerFound()
            End If
        End If
    End Sub
    Sub colBWinTest()
        If numTurns >= 5 And gameOver = False Then
            If btn2AB.Text = btn5BB.Text And btn5BB.Text = btn8CB.Text Then
                lblStatus.Text() = "Winner Found"
                winnerFound()
            End If
        End If
    End Sub
    Sub colCWinTest()
        If numTurns >= 5 And gameOver = False Then
            If btn3AC.Text = btn6BC.Text And btn6BC.Text = btn9CC.Text Then
                lblStatus.Text() = "Winner Found"
                winnerFound()
            End If
        End If
    End Sub
    Sub diaAAWinTest()
        If numTurns >= 5 And gameOver = False Then
            If btn1AA.Text = btn5BB.Text And btn5BB.Text = btn9CC.Text Then
                lblStatus.Text() = "Winner Found"
                winnerFound()
            End If
        End If
    End Sub
    Sub diaACWinTest()
        If numTurns >= 5 And gameOver = False Then
            If btn3AC.Text = btn5BB.Text And btn5BB.Text = btn7CA.Text Then
                lblStatus.Text() = "Winner Found"
                winnerFound()
            End If
        End If
    End Sub
    Sub catTest()
        If gameOver = False Then
            If numTurns = 9 And gameOver = False Then
                catGame()
            End If
        End If
    End Sub
    Sub winnerFound()
        lblStatus.Text = (player & " wins the game!")
        lockBoard()
        gameOver = True
        btnStart.Enabled = True
        btnStart.Text = "New Game"
    End Sub
    Sub catGame()
        If numTurns >= 9 And gameOver = False Then
            lblStatus.Text = "You Both Suck!"
            lockBoard()
            gameOver = True
            btnStart.Enabled = True
            btnStart.Text = "New Game"
        End If
    End Sub
    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lockBoard()
        clearBoard()
        lblStatus.Text = "Welcome to Tic Tac Toe. Better Press Start!"
    End Sub


    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        unlockBoard()
        clearBoard()
        numTurns = 0
        player = player1
        lblStatus.Text = player & " selects a square"
        btnStart.Enabled = False
        gameOver = False
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub


    Private Sub btn1AA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1AA.Click
        btn1AA.Text = player
        numTurns = numTurns + 1
        btn1AA.Enabled = False
        rowAWinTest()
        colAWinTest()
        diaAAWinTest()
        catTest()
        switchPlayer()
        catGame()
        lblStatus.Text = player & " selects a square"

    End Sub


    Private Sub btn2AB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2AB.Click
        btn2AB.Text = player
        numTurns = numTurns + 1
        btn2AB.Enabled = False
        rowAWinTest()
        colBWinTest()
        catGame()
        catTest()
        switchPlayer()
        lblStatus.Text = player & " selects a square"
    End Sub


    Private Sub btn3AC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3AC.Click
        btn3AC.Text = player
        numTurns = numTurns + 1
        btn3AC.Enabled = False
        rowAWinTest()
        colCWinTest()
        diaACWinTest()
        catTest()
        catGame()
        switchPlayer()
        lblStatus.Text = player & " selects a square"

    End Sub


    Private Sub btn4BA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4BA.Click
        btn4BA.Text = player
        numTurns = numTurns + 1
        btn4BA.Enabled = False
        rowBWinTest()
        colAWinTest()
        catTest()
        catGame()
        switchPlayer()
        lblStatus.Text = player & " selects a square"
    End Sub


    Private Sub btn5BB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5BB.Click
        btn5BB.Text = player
        numTurns = numTurns + 1
        btn5BB.Enabled = False
        rowBWinTest()
        colBWinTest()
        diaACWinTest()
        catTest()
        catGame()
        switchPlayer()
        lblStatus.Text = player & " selecets a square"
    End Sub


    Private Sub btn6BC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6BC.Click
        btn6BC.Text = player
        numTurns = numTurns + 1
        btn6BC.Enabled = False
        rowBWinTest()
        colCWinTest()
        catTest()
        catGame()
        switchPlayer()
        lblStatus.Text = player & " selects a square"
    End Sub


    Private Sub btn7CA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7CA.Click
        btn7CA.Text = player
        numTurns = numTurns + 1
        btn7CA.Enabled = False
        rowCWinTest()
        colAWinTest()
        diaACWinTest()
        catTest()
        catGame()
        switchPlayer()
        lblStatus.Text = player & " selects a square"

    End Sub


    Private Sub btn8CB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8CB.Click
        btn8CB.Text = player
        numTurns = numTurns + 1
        btn8CB.Enabled = False
        rowCWinTest()
        colBWinTest()
        catTest()
        catGame()
        switchPlayer()
        lblStatus.Text = player & " selects a square"
    End Sub


    Private Sub btn9CC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9CC.Click
        btn9CC.Text = player
        numTurns = numTurns + 1
        btn9CC.Enabled = False
        rowCWinTest()
        colCWinTest()
        diaAAWinTest()
        catTest()
        catGame()
        switchPlayer()
        lblStatus.Text = player & " selects a square"
    End Sub

End Class
