Public Class Form1

    Dim files() As String
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

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click

        Dim target = getTarget()
        Dim replacement = getReplacement()

        For Each file In files

            Dim ioFile As New IO.FileInfo(file)
            Dim ioFileExt = ioFile.Extension
            Dim ioFileName = Replace(ioFile.Name, ioFileExt, "")
            ioFileName = Replace(ioFileName, target, replacement)
            ioFileName = ioFileName & ioFileExt
            My.Computer.FileSystem.RenameFile(file, ioFileName)

        Next

    End Sub

    Private Sub showFiles()

        lstBoxFiles.Items.Clear()

        For Each file In files

            lstBoxFiles.Items.Add(New IO.FileInfo(file).Name)

        Next

    End Sub

End Class
