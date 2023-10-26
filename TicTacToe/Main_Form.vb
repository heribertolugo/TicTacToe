Public Class Main_Form

    Private players() As Player
    Private currentPlayer As String
    Private piecesPlayed As Integer

#Region "Event Handlers"

    Private Sub Main_Form_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.players = {New Player("Player1"), New Player("Player2")}

        Dim changeNames As MsgBoxResult = MsgBox("Do you want to set the player names?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "PreGame setup")

        If changeNames = MsgBoxResult.Yes Then Me.SetPlayerNames()
        Me.players(0).Piece = My.Resources.x
        Me.players(1).Piece = My.Resources.o

        Me.currentPlayer = players(0).Name

        Me.NewGame()
    End Sub



    '/****************************************************************************************'
    '************** GAME PIECE EVENT HANDLERS ************************************************'
    '*****************************************************************************************'
    '****************************************************************************************/'

    Private Sub GamePieceHighlightOn(sender As System.Object, e As EventArgs) ' Dynamically added handler
        CType(sender, Panel).BackColor = Color.PowderBlue
    End Sub

    Private Sub GamePieceHighlightOff(sender As System.Object, e As EventArgs) ' Dynamically added handler
        CType(sender, Panel).BackColor = Color.Transparent
    End Sub


    Private Sub GamePieceClick(sender As System.Object, e As EventArgs) ' Dynamically added handler

        Dim gamePiece As Control = CType(sender, Control)
        Dim winningPieces As IEnumerable(Of TableLayoutPanelCellPosition) = {}
        Dim gamePiecePosition As TableLayoutPanelCellPosition = Me.GameBoard_TblLayoutPnl.GetCellPosition(gamePiece)

        If Me.players.Where(Function(p) p.Piece Is gamePiece.BackgroundImage).Count > 0 Then Exit Sub
        If Not Me.players.Where(Function(p) p.Name = Me.currentPlayer).Count > 0 Then
            MsgBox("Game is broken. try to restart", MsgBoxStyle.OkOnly Or MsgBoxStyle.Critical, "Major error!")
            Exit Sub
        End If

        Me.piecesPlayed += 1

        ' Set the clicked gamePiece to the players game piece
        gamePiece.BackgroundImage = Me.players.Where(Function(p) p.Name = Me.currentPlayer)(0).Piece

        ' Make the piece look disabled
        Me.DisablePiece(gamePiece)

        ' Check for a winning row, column or diagonal - seperated conditional test for win8 bug
        If RowMatch(gamePiecePosition.Row, winningPieces) Then
            Me.DeclareWinner(Me.players.Where(Function(p) p.Name = Me.currentPlayer)(0), winningPieces)
        ElseIf ColumnMatch(gamePiecePosition.Column, winningPieces) Then
            Me.DeclareWinner(Me.players.Where(Function(p) p.Name = Me.currentPlayer)(0), winningPieces)
        ElseIf DiagMatch(gamePiece, winningPieces) Then
            Me.DeclareWinner(Me.players.Where(Function(p) p.Name = Me.currentPlayer)(0), winningPieces)
        Else
            Me.currentPlayer = Me.players.Where(Function(p) p.Name <> Me.currentPlayer)(0).Name
            Me.MessageDisplay_Pnl.Text = currentPlayer & "'s turn"

            If Me.piecesPlayed >= 9 Then
                Dim nobody As New Player("Nobody")
                Me.DeclareWinner(nobody, {})
                Exit Sub
            End If
        End If
    End Sub


    '/****************************************************************************************'
    '************** MENU ITEMS EVENT HANDLERS ************************************************'
    '*****************************************************************************************'
    '****************************************************************************************/'

    Private Sub NewGame_But_Click(sender As System.Object, e As System.EventArgs) Handles NewGame_But.Click
        Me.NewGame()
    End Sub

    Private Sub GiveUp(sender As System.Object, e As System.EventArgs) Handles GiveUp_But.Click
        Me.DeclareWinner(Me.players.Where(Function(p) p.Name <> currentPlayer)(0), {})
    End Sub

    Private Sub Scores_But_Click(sender As System.Object, e As System.EventArgs) Handles Scores_But.Click
        ShowScores()
    End Sub


    Private Sub About_But_Click(sender As System.Object, e As System.EventArgs) Handles About_But.Click
        Dim about As New About()
        about.ShowDialog()
    End Sub
#End Region




#Region "Logic"

    ''' <summary>
    ''' Initiates GameBoard and Pieces for a new game.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub NewGame()

        For Each piece As Control In Me.GameBoard_TblLayoutPnl.Controls
            piece.BackColor = Color.Transparent
            piece.BackgroundImage = Me.BackgroundImage
            Me.EnablePiece(piece)
        Next

        Me.GiveUp_But.Enabled = True
        Me.piecesPlayed = 0

        Me.MessageDisplay_Pnl.Text = currentPlayer & "'s turn"
    End Sub

    ''' <summary>
    ''' Displays a window to show player scores
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ShowScores()
        Dim scoreBoard As Scores = New Scores(players(0), players(1))
        scoreBoard.ShowDialog()
    End Sub

    ''' <summary>
    ''' Provides a means to change the Name of each Player
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub SetPlayerNames()
        For pIndex As Integer = 0 To (players.Count - 1) Step +1
            Dim newName As String

            newName = InputBox("Enter name for " & players(pIndex).Name, "Set player name", " ")

            If Not newName.Trim() = String.Empty Then
                If Me.players.Where(Function(p) p.Name = newName).Count > 0 Then
                    MsgBox("Someone already has that name", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Error")
                    pIndex -= 1
                    Continue For
                End If

                Me.players(pIndex).Name = newName
            End If
        Next
    End Sub

    ''' <summary>
    ''' Checks GameBoard for a win at the specified row.
    ''' </summary>
    ''' <param name="row">Integer: The index of the row to check</param>
    ''' <param name="winningPieces">IEnumerable: List which will be populated with winning TableLayoutPanelCellPosition</param>
    ''' <returns>Boolean: True if the row contains game pieces of equal value.</returns>
    ''' <remarks></remarks>
    Private Function RowMatch(ByVal row As Integer, ByRef winningPieces As IEnumerable(Of TableLayoutPanelCellPosition)) As Boolean
        Dim winners As New List(Of TableLayoutPanelCellPosition)
        Dim gamePiece As Control = Nothing

        For col As Integer = 0 To 2 Step +1
            If Me.GameBoard_TblLayoutPnl.GetControlFromPosition(col, row) IsNot Nothing Then ' There is a piece at this location
                If gamePiece Is Nothing Then gamePiece = Me.GameBoard_TblLayoutPnl.GetControlFromPosition(col, row) ' If we do not have a game piece to compare, use the one at the beginning of row
                ' Piece is the same type and Piece isnt already in list of winning pieces
                Dim it_col As Integer = row
                If Me.GameBoard_TblLayoutPnl.GetControlFromPosition(col, row).BackgroundImage Is gamePiece.BackgroundImage _
                        And winningPieces.Where(Function(p) p.Column = it_col And p.Row = row).Count = 0 Then
                    winners.Add(New TableLayoutPanelCellPosition(col, row))
                End If
            End If
        Next

        If winners.Count = 3 Then
            winningPieces = winners
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Checks GameBoard for a win at the specified column.
    ''' </summary>
    ''' <param name="column">Integer: The index of the column to check</param>
    ''' <param name="winningPieces">IEnumerable: List which will be populated with winning TableLayoutPanelCellPosition</param>
    ''' <returns>Boolean: True if the column contains game pieces of equal value.</returns>
    ''' <remarks></remarks>
    Private Function ColumnMatch(ByVal column As Integer, ByRef winningPieces As IEnumerable(Of TableLayoutPanelCellPosition)) As Boolean
        Dim winners As New List(Of TableLayoutPanelCellPosition)
        Dim gamePiece As Control = Nothing

        For row As Integer = 0 To 2 Step +1
            If Me.GameBoard_TblLayoutPnl.GetControlFromPosition(column, row) IsNot Nothing Then ' There is a piece at this location
                If gamePiece Is Nothing Then gamePiece = Me.GameBoard_TblLayoutPnl.GetControlFromPosition(column, row) ' If we do not have a game piece to compare, use the one at the beginning of row
                ' Piece is the same type and Piece isnt already in list of winning pieces
                Dim it_row As Integer = row
                If Me.GameBoard_TblLayoutPnl.GetControlFromPosition(column, row).BackgroundImage Is gamePiece.BackgroundImage _
                        And winningPieces.Where(Function(p) p.Column = column And p.Row = it_row).Count = 0 Then
                    winners.Add(New TableLayoutPanelCellPosition(column, row))
                End If
            End If
        Next

        If winners.Count = 3 Then
            winningPieces = winners
            Return True
        End If

        Return False
    End Function

    ''' <summary>
    ''' Checks GameBoard for a win at the diagonals.
    ''' </summary>
    ''' <param name="gamePiece">Control: The gamePiece to check</param>
    ''' <param name="winningPieces">IEnumerable: List which will be populated with winning TableLayoutPanelCellPosition</param>
    ''' <returns>Boolean: True if a diagonal contains game pieces of equal value.</returns>
    ''' <remarks></remarks>
    Private Function DiagMatch(ByVal gamePiece As Control, ByRef winningPieces As IEnumerable(Of TableLayoutPanelCellPosition)) As Boolean
        Dim winners As New List(Of TableLayoutPanelCellPosition)
        Dim curGamePiece As Control = Nothing ' the current piece we are checking for a match in our loop
        Dim row As Integer = 0 ' the current row we are at in our loop
        Dim column As Integer = 0 ' the current column we are at in our loop


        For iterator As Integer = 0 To 5 Step +1
            If Me.GameBoard_TblLayoutPnl.GetControlFromPosition(column, row) IsNot Nothing Then ' There is a piece at this location
                If curGamePiece Is Nothing Then curGamePiece = Me.GameBoard_TblLayoutPnl.GetControlFromPosition(column, row) ' If we do not have a game piece to compare, use the one at the beginning of row
                ' Piece is of the same type as gamePiece passed in parameter
                If Me.GameBoard_TblLayoutPnl.GetControlFromPosition(column, row).BackgroundImage Is gamePiece.BackgroundImage Then
                    ' Piece is the same type ' Piece isnt already in list of winning pieces
                    If Me.GameBoard_TblLayoutPnl.GetControlFromPosition(column, row).BackgroundImage Is curGamePiece.BackgroundImage _
                        And winningPieces.Where(Function(p) p.Column = column And p.Row = row).Count = 0 Then
                        winners.Add(New TableLayoutPanelCellPosition(column, row))
                    End If
                End If
            End If

            If winners.Count = 3 Then
                winningPieces = winners
                Return True
            End If

            If iterator < 2 Then ' We are almost done with first diagonal
                column += 1
                row += 1
            ElseIf iterator = 2 Then ' We are done with first diagonal, set up for second one
                winners.Clear()
                curGamePiece = Nothing
                row = 0
                column = 2
            Else ' we are at second diagonal
                column -= 1
                row += 1
            End If
        Next

        Return False
    End Function

    ''' <summary>
    ''' Declare a winner, disable GameBoard and highlight winning pieces if any
    ''' </summary>
    ''' <param name="winner"></param>
    ''' <param name="winningPieces"></param>
    ''' <remarks></remarks>
    Private Sub DeclareWinner(ByRef winner As Player, ByVal winningPieces As IEnumerable(Of TableLayoutPanelCellPosition))
        Me.MessageDisplay_Pnl.Text = winner.Name & " is the winner!"

        winner.Score += 1

        For Each piece As Control In Me.GameBoard_TblLayoutPnl.Controls
            Me.DisablePiece(piece)

            Me.GiveUp_But.Enabled = False
        Next

        For Each piece As TableLayoutPanelCellPosition In winningPieces
            Me.GameBoard_TblLayoutPnl.GetControlFromPosition(piece.Column, piece.Row).BackColor = Color.Gold
        Next

        If Me.AutoShowScore_TStripItem.Checked Then Me.ShowScores()
    End Sub

    ''' <summary>
    ''' Disabled game piece from play.
    ''' </summary>
    ''' <param name="gamePiece">Control: Game Piece to disable from play</param>
    ''' <remarks>Removes click, mouseover and mouseleave event handlers</remarks>
    Private Sub DisablePiece(ByRef gamePiece As Control)
        Me.GamePieceHighlightOff(gamePiece, EventArgs.Empty)
        RemoveHandler gamePiece.Click, AddressOf Me.GamePieceClick
        RemoveHandler gamePiece.MouseHover, AddressOf Me.GamePieceHighlightOn
        RemoveHandler gamePiece.MouseLeave, AddressOf Me.GamePieceHighlightOff
    End Sub

    ''' <summary>
    ''' Enables game piece into play.
    ''' </summary>
    ''' <param name="gamePiece">Control: Game Piece to enable into play</param>
    ''' <remarks>Adds click, mouseover and mouseleave event handlers</remarks>
    Private Sub EnablePiece(ByRef gamePiece As Control)
        AddHandler gamePiece.Click, AddressOf Me.GamePieceClick
        AddHandler gamePiece.MouseHover, AddressOf Me.GamePieceHighlightOn
        AddHandler gamePiece.MouseLeave, AddressOf Me.GamePieceHighlightOff
    End Sub
#End Region
End Class

