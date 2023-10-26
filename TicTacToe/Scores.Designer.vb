<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scores
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Player2Piece_PicBox = New System.Windows.Forms.PictureBox()
        Me.Player2Score_Lbl = New System.Windows.Forms.Label()
        Me.Player1Score_Lbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Player1Piece_PicBox = New System.Windows.Forms.PictureBox()
        Me.Player1Name_Lbl = New System.Windows.Forms.Label()
        Me.Player2Name_Lbl = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.Player2Piece_PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.Player1Piece_PicBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(154, 151)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(76, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Player2Score_Lbl, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Player1Score_Lbl, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.90076!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.09924!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(285, 133)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightBlue
        Me.Panel2.Controls.Add(Me.Player2Name_Lbl)
        Me.Panel2.Controls.Add(Me.Player2Piece_PicBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(146, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(134, 23)
        Me.Panel2.TabIndex = 5
        '
        'Player2Piece_PicBox
        '
        Me.Player2Piece_PicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player2Piece_PicBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.Player2Piece_PicBox.Location = New System.Drawing.Point(111, 0)
        Me.Player2Piece_PicBox.Name = "Player2Piece_PicBox"
        Me.Player2Piece_PicBox.Size = New System.Drawing.Size(23, 23)
        Me.Player2Piece_PicBox.TabIndex = 1
        Me.Player2Piece_PicBox.TabStop = False
        '
        'Player2Score_Lbl
        '
        Me.Player2Score_Lbl.AutoSize = True
        Me.Player2Score_Lbl.BackColor = System.Drawing.Color.White
        Me.Player2Score_Lbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Player2Score_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player2Score_Lbl.ForeColor = System.Drawing.Color.Red
        Me.Player2Score_Lbl.Location = New System.Drawing.Point(146, 33)
        Me.Player2Score_Lbl.Name = "Player2Score_Lbl"
        Me.Player2Score_Lbl.Size = New System.Drawing.Size(134, 98)
        Me.Player2Score_Lbl.TabIndex = 3
        Me.Player2Score_Lbl.Text = "0"
        Me.Player2Score_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Player1Score_Lbl
        '
        Me.Player1Score_Lbl.AutoSize = True
        Me.Player1Score_Lbl.BackColor = System.Drawing.Color.White
        Me.Player1Score_Lbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Player1Score_Lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Player1Score_Lbl.ForeColor = System.Drawing.Color.Red
        Me.Player1Score_Lbl.Location = New System.Drawing.Point(5, 33)
        Me.Player1Score_Lbl.Name = "Player1Score_Lbl"
        Me.Player1Score_Lbl.Size = New System.Drawing.Size(133, 98)
        Me.Player1Score_Lbl.TabIndex = 2
        Me.Player1Score_Lbl.Text = "0"
        Me.Player1Score_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightBlue
        Me.Panel1.Controls.Add(Me.Player1Name_Lbl)
        Me.Panel1.Controls.Add(Me.Player1Piece_PicBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(5, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(133, 23)
        Me.Panel1.TabIndex = 4
        '
        'Player1Piece_PicBox
        '
        Me.Player1Piece_PicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Player1Piece_PicBox.Dock = System.Windows.Forms.DockStyle.Right
        Me.Player1Piece_PicBox.Location = New System.Drawing.Point(110, 0)
        Me.Player1Piece_PicBox.Name = "Player1Piece_PicBox"
        Me.Player1Piece_PicBox.Size = New System.Drawing.Size(23, 23)
        Me.Player1Piece_PicBox.TabIndex = 1
        Me.Player1Piece_PicBox.TabStop = False
        '
        'Player1Name_Lbl
        '
        Me.Player1Name_Lbl.BackColor = System.Drawing.Color.LightBlue
        Me.Player1Name_Lbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Player1Name_Lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Player1Name_Lbl.Location = New System.Drawing.Point(0, 0)
        Me.Player1Name_Lbl.Name = "Player1Name_Lbl"
        Me.Player1Name_Lbl.Size = New System.Drawing.Size(110, 23)
        Me.Player1Name_Lbl.TabIndex = 0
        Me.Player1Name_Lbl.Text = "Player1"
        Me.Player1Name_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Player2Name_Lbl
        '
        Me.Player2Name_Lbl.BackColor = System.Drawing.Color.LightBlue
        Me.Player2Name_Lbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Player2Name_Lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Player2Name_Lbl.Location = New System.Drawing.Point(0, 0)
        Me.Player2Name_Lbl.Name = "Player2Name_Lbl"
        Me.Player2Name_Lbl.Size = New System.Drawing.Size(111, 23)
        Me.Player2Name_Lbl.TabIndex = 1
        Me.Player2Name_Lbl.Text = "Player2"
        Me.Player2Name_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Scores
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 192)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Scores"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Scores"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.Player2Piece_PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.Player1Piece_PicBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents OK_Button As System.Windows.Forms.Button
    Private WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents Player2Score_Lbl As System.Windows.Forms.Label
    Private WithEvents Player1Score_Lbl As System.Windows.Forms.Label
    Private WithEvents Player2Name_Lbl As System.Windows.Forms.Label
    Private WithEvents Player1Name_Lbl As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Player2Piece_PicBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Player1Piece_PicBox As System.Windows.Forms.PictureBox

End Class
