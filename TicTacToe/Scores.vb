Imports System.Windows.Forms

Public Class Scores

    Public Sub New(ByVal player1 As Player, ByVal player2 As Player)
        InitializeComponent()

        Me.Player1Name_Lbl.Text = player1.Name
        Me.Player1Score_Lbl.Text = player1.Score.ToString()
        Me.Player1Piece_PicBox.BackgroundImage = player1.Piece
        Me.Player2Name_Lbl.Text = player2.Name
        Me.Player2Score_Lbl.Text = player2.Score.ToString()
        Me.Player2Piece_PicBox.BackgroundImage = player2.Piece
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Scores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
