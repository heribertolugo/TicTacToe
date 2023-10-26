<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.GameBoard_TblLayoutPnl = New System.Windows.Forms.TableLayoutPanel()
        Me.Row3Col3Piece_Pnl = New System.Windows.Forms.Panel()
        Me.Row3Col2Piece_Pnl = New System.Windows.Forms.Panel()
        Me.Row3Col1Piece_Pnl = New System.Windows.Forms.Panel()
        Me.Row2Col3Piece_Pnl = New System.Windows.Forms.Panel()
        Me.Row2Col2Piece_Pnl = New System.Windows.Forms.Panel()
        Me.Row2Col1Piece_Pnl = New System.Windows.Forms.Panel()
        Me.Row1Col3Piece_Pnl = New System.Windows.Forms.Panel()
        Me.Row1Col2Piece_Pnl = New System.Windows.Forms.Panel()
        Me.Row1Col1Piece_Pnl = New System.Windows.Forms.Panel()
        Me.MessageDisplay_Pnl = New System.Windows.Forms.Label()
        Me.GameMenu_ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.NewGame_But = New System.Windows.Forms.ToolStripButton()
        Me.GiveUp_But = New System.Windows.Forms.ToolStripButton()
        Me.Scores_But = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.AutoShowScore_TStripItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.About_But = New System.Windows.Forms.ToolStripButton()
        Me.GameBoard_TblLayoutPnl.SuspendLayout()
        Me.GameMenu_ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'GameBoard_TblLayoutPnl
        '
        Me.GameBoard_TblLayoutPnl.BackColor = System.Drawing.Color.White
        Me.GameBoard_TblLayoutPnl.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.GameBoard_TblLayoutPnl.ColumnCount = 3
        Me.GameBoard_TblLayoutPnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33111!))
        Me.GameBoard_TblLayoutPnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33778!))
        Me.GameBoard_TblLayoutPnl.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33112!))
        Me.GameBoard_TblLayoutPnl.Controls.Add(Me.Row3Col3Piece_Pnl, 2, 2)
        Me.GameBoard_TblLayoutPnl.Controls.Add(Me.Row3Col2Piece_Pnl, 1, 2)
        Me.GameBoard_TblLayoutPnl.Controls.Add(Me.Row3Col1Piece_Pnl, 0, 2)
        Me.GameBoard_TblLayoutPnl.Controls.Add(Me.Row2Col3Piece_Pnl, 2, 1)
        Me.GameBoard_TblLayoutPnl.Controls.Add(Me.Row2Col2Piece_Pnl, 1, 1)
        Me.GameBoard_TblLayoutPnl.Controls.Add(Me.Row2Col1Piece_Pnl, 0, 1)
        Me.GameBoard_TblLayoutPnl.Controls.Add(Me.Row1Col3Piece_Pnl, 2, 0)
        Me.GameBoard_TblLayoutPnl.Controls.Add(Me.Row1Col2Piece_Pnl, 1, 0)
        Me.GameBoard_TblLayoutPnl.Controls.Add(Me.Row1Col1Piece_Pnl, 0, 0)
        Me.GameBoard_TblLayoutPnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GameBoard_TblLayoutPnl.Location = New System.Drawing.Point(0, 46)
        Me.GameBoard_TblLayoutPnl.Name = "GameBoard_TblLayoutPnl"
        Me.GameBoard_TblLayoutPnl.RowCount = 3
        Me.GameBoard_TblLayoutPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.GameBoard_TblLayoutPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.34!))
        Me.GameBoard_TblLayoutPnl.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33!))
        Me.GameBoard_TblLayoutPnl.Size = New System.Drawing.Size(284, 216)
        Me.GameBoard_TblLayoutPnl.TabIndex = 0
        '
        'Row3Col3Piece_Pnl
        '
        Me.Row3Col3Piece_Pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Row3Col3Piece_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row3Col3Piece_Pnl.Location = New System.Drawing.Point(192, 146)
        Me.Row3Col3Piece_Pnl.Name = "Row3Col3Piece_Pnl"
        Me.Row3Col3Piece_Pnl.Size = New System.Drawing.Size(88, 66)
        Me.Row3Col3Piece_Pnl.TabIndex = 8
        '
        'Row3Col2Piece_Pnl
        '
        Me.Row3Col2Piece_Pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Row3Col2Piece_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row3Col2Piece_Pnl.Location = New System.Drawing.Point(98, 146)
        Me.Row3Col2Piece_Pnl.Name = "Row3Col2Piece_Pnl"
        Me.Row3Col2Piece_Pnl.Size = New System.Drawing.Size(87, 66)
        Me.Row3Col2Piece_Pnl.TabIndex = 7
        '
        'Row3Col1Piece_Pnl
        '
        Me.Row3Col1Piece_Pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Row3Col1Piece_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row3Col1Piece_Pnl.Location = New System.Drawing.Point(4, 146)
        Me.Row3Col1Piece_Pnl.Name = "Row3Col1Piece_Pnl"
        Me.Row3Col1Piece_Pnl.Size = New System.Drawing.Size(87, 66)
        Me.Row3Col1Piece_Pnl.TabIndex = 6
        '
        'Row2Col3Piece_Pnl
        '
        Me.Row2Col3Piece_Pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Row2Col3Piece_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row2Col3Piece_Pnl.Location = New System.Drawing.Point(192, 75)
        Me.Row2Col3Piece_Pnl.Name = "Row2Col3Piece_Pnl"
        Me.Row2Col3Piece_Pnl.Size = New System.Drawing.Size(88, 64)
        Me.Row2Col3Piece_Pnl.TabIndex = 5
        '
        'Row2Col2Piece_Pnl
        '
        Me.Row2Col2Piece_Pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Row2Col2Piece_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row2Col2Piece_Pnl.Location = New System.Drawing.Point(98, 75)
        Me.Row2Col2Piece_Pnl.Name = "Row2Col2Piece_Pnl"
        Me.Row2Col2Piece_Pnl.Size = New System.Drawing.Size(87, 64)
        Me.Row2Col2Piece_Pnl.TabIndex = 4
        '
        'Row2Col1Piece_Pnl
        '
        Me.Row2Col1Piece_Pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Row2Col1Piece_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row2Col1Piece_Pnl.Location = New System.Drawing.Point(4, 75)
        Me.Row2Col1Piece_Pnl.Name = "Row2Col1Piece_Pnl"
        Me.Row2Col1Piece_Pnl.Size = New System.Drawing.Size(87, 64)
        Me.Row2Col1Piece_Pnl.TabIndex = 3
        '
        'Row1Col3Piece_Pnl
        '
        Me.Row1Col3Piece_Pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Row1Col3Piece_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row1Col3Piece_Pnl.Location = New System.Drawing.Point(192, 4)
        Me.Row1Col3Piece_Pnl.Name = "Row1Col3Piece_Pnl"
        Me.Row1Col3Piece_Pnl.Size = New System.Drawing.Size(88, 64)
        Me.Row1Col3Piece_Pnl.TabIndex = 2
        '
        'Row1Col2Piece_Pnl
        '
        Me.Row1Col2Piece_Pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Row1Col2Piece_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row1Col2Piece_Pnl.Location = New System.Drawing.Point(98, 4)
        Me.Row1Col2Piece_Pnl.Name = "Row1Col2Piece_Pnl"
        Me.Row1Col2Piece_Pnl.Size = New System.Drawing.Size(87, 64)
        Me.Row1Col2Piece_Pnl.TabIndex = 1
        '
        'Row1Col1Piece_Pnl
        '
        Me.Row1Col1Piece_Pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Row1Col1Piece_Pnl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Row1Col1Piece_Pnl.Location = New System.Drawing.Point(4, 4)
        Me.Row1Col1Piece_Pnl.Name = "Row1Col1Piece_Pnl"
        Me.Row1Col1Piece_Pnl.Size = New System.Drawing.Size(87, 64)
        Me.Row1Col1Piece_Pnl.TabIndex = 0
        '
        'MessageDisplay_Pnl
        '
        Me.MessageDisplay_Pnl.BackColor = System.Drawing.Color.Khaki
        Me.MessageDisplay_Pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MessageDisplay_Pnl.Dock = System.Windows.Forms.DockStyle.Top
        Me.MessageDisplay_Pnl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MessageDisplay_Pnl.Location = New System.Drawing.Point(0, 25)
        Me.MessageDisplay_Pnl.Name = "MessageDisplay_Pnl"
        Me.MessageDisplay_Pnl.Size = New System.Drawing.Size(284, 21)
        Me.MessageDisplay_Pnl.TabIndex = 2
        Me.MessageDisplay_Pnl.Text = "Player1's turn"
        Me.MessageDisplay_Pnl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GameMenu_ToolStrip
        '
        Me.GameMenu_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.GameMenu_ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewGame_But, Me.GiveUp_But, Me.Scores_But, Me.ToolStripSplitButton1, Me.About_But})
        Me.GameMenu_ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.GameMenu_ToolStrip.Name = "GameMenu_ToolStrip"
        Me.GameMenu_ToolStrip.Padding = New System.Windows.Forms.Padding(0)
        Me.GameMenu_ToolStrip.Size = New System.Drawing.Size(284, 25)
        Me.GameMenu_ToolStrip.TabIndex = 3
        Me.GameMenu_ToolStrip.Text = "ToolStrip1"
        '
        'NewGame_But
        '
        Me.NewGame_But.AutoToolTip = False
        Me.NewGame_But.Checked = True
        Me.NewGame_But.CheckState = System.Windows.Forms.CheckState.Checked
        Me.NewGame_But.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.NewGame_But.Image = CType(resources.GetObject("NewGame_But.Image"), System.Drawing.Image)
        Me.NewGame_But.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewGame_But.Margin = New System.Windows.Forms.Padding(3, 1, 0, 2)
        Me.NewGame_But.Name = "NewGame_But"
        Me.NewGame_But.Size = New System.Drawing.Size(69, 22)
        Me.NewGame_But.Text = "New Game"
        '
        'GiveUp_But
        '
        Me.GiveUp_But.AutoSize = False
        Me.GiveUp_But.AutoToolTip = False
        Me.GiveUp_But.Checked = True
        Me.GiveUp_But.CheckState = System.Windows.Forms.CheckState.Checked
        Me.GiveUp_But.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GiveUp_But.Image = CType(resources.GetObject("GiveUp_But.Image"), System.Drawing.Image)
        Me.GiveUp_But.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GiveUp_But.Name = "GiveUp_But"
        Me.GiveUp_But.Size = New System.Drawing.Size(69, 22)
        Me.GiveUp_But.Text = "Give Up"
        '
        'Scores_But
        '
        Me.Scores_But.AutoSize = False
        Me.Scores_But.AutoToolTip = False
        Me.Scores_But.Checked = True
        Me.Scores_But.CheckState = System.Windows.Forms.CheckState.Checked
        Me.Scores_But.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Scores_But.Image = CType(resources.GetObject("Scores_But.Image"), System.Drawing.Image)
        Me.Scores_But.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Scores_But.Name = "Scores_But"
        Me.Scores_But.Size = New System.Drawing.Size(69, 22)
        Me.Scores_But.Text = "Scores"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AutoShowScore_TStripItem})
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(16, 22)
        Me.ToolStripSplitButton1.Text = "Scores"
        '
        'AutoShowScore_TStripItem
        '
        Me.AutoShowScore_TStripItem.Checked = True
        Me.AutoShowScore_TStripItem.CheckOnClick = True
        Me.AutoShowScore_TStripItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AutoShowScore_TStripItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AutoShowScore_TStripItem.Name = "AutoShowScore_TStripItem"
        Me.AutoShowScore_TStripItem.Size = New System.Drawing.Size(222, 22)
        Me.AutoShowScore_TStripItem.Text = "Show score after each game"
        '
        'About_But
        '
        Me.About_But.AutoSize = False
        Me.About_But.AutoToolTip = False
        Me.About_But.Checked = True
        Me.About_But.CheckState = System.Windows.Forms.CheckState.Checked
        Me.About_But.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.About_But.Image = CType(resources.GetObject("About_But.Image"), System.Drawing.Image)
        Me.About_But.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.About_But.Name = "About_But"
        Me.About_But.Size = New System.Drawing.Size(56, 22)
        Me.About_But.Text = "About"
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.GameBoard_TblLayoutPnl)
        Me.Controls.Add(Me.MessageDisplay_Pnl)
        Me.Controls.Add(Me.GameMenu_ToolStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(300, 300)
        Me.Name = "Main_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tic-Tac-Toe"
        Me.GameBoard_TblLayoutPnl.ResumeLayout(False)
        Me.GameMenu_ToolStrip.ResumeLayout(False)
        Me.GameMenu_ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GameBoard_TblLayoutPnl As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Row1Col1Piece_Pnl As System.Windows.Forms.Panel
    Friend WithEvents MessageDisplay_Pnl As System.Windows.Forms.Label
    Friend WithEvents Row3Col3Piece_Pnl As System.Windows.Forms.Panel
    Friend WithEvents Row3Col2Piece_Pnl As System.Windows.Forms.Panel
    Friend WithEvents Row3Col1Piece_Pnl As System.Windows.Forms.Panel
    Friend WithEvents Row2Col3Piece_Pnl As System.Windows.Forms.Panel
    Friend WithEvents Row2Col2Piece_Pnl As System.Windows.Forms.Panel
    Friend WithEvents Row2Col1Piece_Pnl As System.Windows.Forms.Panel
    Friend WithEvents Row1Col3Piece_Pnl As System.Windows.Forms.Panel
    Friend WithEvents Row1Col2Piece_Pnl As System.Windows.Forms.Panel
    Friend WithEvents GameMenu_ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents NewGame_But As System.Windows.Forms.ToolStripButton
    Friend WithEvents GiveUp_But As System.Windows.Forms.ToolStripButton
    Friend WithEvents Scores_But As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents AutoShowScore_TStripItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents About_But As System.Windows.Forms.ToolStripButton

End Class
