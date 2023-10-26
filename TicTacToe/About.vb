Public NotInheritable Class About

    Private Sub About_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = My.Application.Info.CompanyName
        Me.TextBoxDescription.Text = My.Application.Info.Description
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        System.Diagnostics.Process.Start("http://heribertolugo.com")
    End Sub

    Private Sub Link_Clicked(sender As Object, e As System.Windows.Forms.LinkClickedEventArgs) Handles License_RchTxtBox.LinkClicked
        System.Diagnostics.Process.Start(e.LinkText)
    End Sub

    Private Sub LogoPictureBox_Click(sender As System.Object, e As System.EventArgs) Handles LogoPictureBox.Click
        MsgBox("Stop poking me!", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Give my facebook a like :)")
        System.Diagnostics.Process.Start("http://facebook.com/heribertolugo.applications")
    End Sub
End Class
