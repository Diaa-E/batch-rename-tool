Public Class Form1

    Dim files() As String
    Dim mode As Integer = 0
    Private Sub btnSelectFiles_Click(sender As Object, e As EventArgs) Handles btnSelectFiles.Click

        Dim dialogResult = fileDialog.ShowDialog()

        If dialogResult = Windows.Forms.DialogResult.OK Then

            files = fileDialog.FileNames
            showFiles()

        End If
    End Sub

    Private Function getTarget()

        Return txtTarget.Text

    End Function

    Private Function getReplacement()

        Return txtreplacement.Text

    End Function

    Private Function getNewName()

        Return txtNewName.Text

    End Function

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click

        Dim target = getTarget()
        Dim replacement = getReplacement()
        Dim newName = getNewName()

        For Each file In files

            Select Case mode
                Case 0
                    replaceName(file, target, replacement)
                Case 1
                    addToName(file, newName, True)
                Case 2
                    addToName(file, newName, False)
                Case 3
                    setNewName(file, newName)
            End Select

        Next

    End Sub

    Private Sub showFiles()

        lstBoxFiles.Items.Clear()

        For Each file In files

            lstBoxFiles.Items.Add(New IO.FileInfo(file).Name)

        Next

    End Sub

    Private Sub replaceName(file As Object, target As String, replacement As String)

        Dim ioFile As New IO.FileInfo(file)
        Dim ioFileExt = ioFile.Extension
        Dim ioFileName = Replace(ioFile.Name, ioFileExt, "")
        ioFileName = Replace(ioFileName, target, replacement)
        ioFileName &= ioFileExt
        My.Computer.FileSystem.RenameFile(file, ioFileName)

    End Sub

    Private Sub addToName(file As Object, newName As String, atStart As Boolean)

        Dim ioFile As New IO.FileInfo(file)
        Dim ioFileExt = ioFile.Extension
        Dim ioFileName = Replace(ioFile.Name, ioFileExt, "")

        If atStart Then

            ioFileName = newName & ioFileName

        Else

            ioFileName = ioFileName & newName

        End If

        ioFileName &= ioFileExt
        My.Computer.FileSystem.RenameFile(file, ioFileName)

    End Sub

    Private Sub setNewName(file As Object, newName As String)

        Dim ioFile As New IO.FileInfo(file)
        Dim ioFileExt = ioFile.Extension
        Dim ioFileName = Replace(ioFile.Name, ioFileExt, "")
        ioFileName = newName
        ioFileName &= ioFileExt
        My.Computer.FileSystem.RenameFile(file, ioFileName)

    End Sub

    Private Sub lstBoxFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxFiles.SelectedIndexChanged

        txtTarget.Text = lstBoxFiles.SelectedItem.ToString

    End Sub

    Private Sub rdReplace_CheckedChanged(sender As Object, e As EventArgs) Handles rdReplace.CheckedChanged

        If rdReplace.Checked Then

            mode = 0
            enableReplace()
            disableNewName()

        End If

    End Sub

    Private Sub enableNewName()

        txtNewName.Enabled = True
        lblNewName.Enabled = True

    End Sub

    Private Sub disableNewName()

        txtNewName.Enabled = False
        lblNewName.Enabled = False

    End Sub

    Private Sub enableReplace()

        txtTarget.Enabled = True
        lblTarget.Enabled = True
        txtreplacement.Enabled = True
        lblReplacement.Enabled = True

    End Sub

    Private Sub disableReplace()

        txtTarget.Enabled = False
        lblTarget.Enabled = False
        txtreplacement.Enabled = False
        lblReplacement.Enabled = False

    End Sub

    Private Sub rdStart_CheckedChanged(sender As Object, e As EventArgs) Handles rdStart.CheckedChanged

        If rdStart.Checked Then

            mode = 1
            enableNewName()
            disableReplace()

        End If

    End Sub

    Private Sub rdEnd_CheckedChanged(sender As Object, e As EventArgs) Handles rdEnd.CheckedChanged

        If rdEnd.Checked Then

            mode = 2
            enableNewName()
            disableReplace()

        End If

    End Sub

    Private Sub rdNew_CheckedChanged(sender As Object, e As EventArgs) Handles rdNew.CheckedChanged

        If rdNew.Checked Then

            mode = 3
            enableNewName()
            disableReplace()

        End If

    End Sub
End Class
