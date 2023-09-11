Imports batchRenameTool.My

Public Class Form1

    Dim files As New List(Of String)
    Dim temps As New List(Of String)
    Dim mode As Integer = 0
    Dim filesReady = False
    Private Sub btnSelectFiles_Click(sender As Object, e As EventArgs) Handles btnSelectFiles.Click

        Dim dialogResult = fileDialog.ShowDialog()

        If dialogResult = Windows.Forms.DialogResult.OK Then

            files.Clear()
            files.AddRange(fileDialog.FileNames)
            filesReady = True
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

        If (Not filesReady) Then
            Return
        End If

        Dim target = getTarget()
        Dim replacement = getReplacement()
        Dim newName = getNewName()
        Dim successful = 0
        Dim totalFiles = files.Count
        Dim successfulFiles = New List(Of String)

        For i As Integer = 0 To totalFiles - 1

            Select Case mode
                Case 0
                    If replaceName(files(i), target, replacement) Then
                        successful += 1
                        successfulFiles.Add(files(i))
                    End If
                Case 1
                    If addToName(files(i), newName, True) Then
                        successful += 1
                        successfulFiles.Add(files(i))
                    End If
                Case 2
                    If addToName(files(i), newName, False) Then
                        successful += 1
                        successfulFiles.Add(files(i))
                    End If
                Case 3
                    If setNewName(files(i), newName) Then
                        successful += 1
                        successfulFiles.Add(files(i))
                    End If

            End Select

        Next

        For Each file In successfulFiles

            files.Remove(file)

        Next

        showFiles()

        If successful = 0 Then

            MessageBox.Show("No matches found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            Dim Message As String = "Successfully renamed " & successful & "/" & totalFiles & " files:"
            MessageBox.Show(Message, "Successfully Renamed files", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub


    Private Sub showFiles()

        lstBoxFiles.Items.Clear()

        For Each file In files

            Dim fileName As String = New IO.FileInfo(file).Name
            Dim fileExtension As String = New IO.FileInfo(file).Extension
            lstBoxFiles.Items.Add(fileName.Replace(fileExtension, ""))

        Next

    End Sub

    Private Function replaceName(file As Object, target As String, replacement As String)

        If (target.Length = 0) Then
            MessageBox.Show("'Find' Field is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Dim ioFile As New IO.FileInfo(file)
        Dim ioFileExt = ioFile.Extension
        Dim ioFileName = Replace(ioFile.Name, ioFileExt, "")

        If (ioFileName.IndexOf(target) = -1) Then
            Return False
        End If

        ioFileName = Replace(ioFileName, target, replacement)
        ioFileName &= ioFileExt
        My.Computer.FileSystem.RenameFile(file, ioFileName)

        Return True

    End Function

    Private Function addToName(file As Object, newName As String, atStart As Boolean)

        If (newName.Length = 0) Then
            MessageBox.Show("'New Name' field is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

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

        Return True

    End Function

    Private Function setNewName(file As Object, newName As String)

        If (newName.Length = 0) Then
            MessageBox.Show("'New Name' field is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        Dim ioFile As New IO.FileInfo(file)
        Dim ioFileExt = ioFile.Extension
        Dim ioFileName = Replace(ioFile.Name, ioFileExt, "")
        ioFileName = newName
        ioFileName &= ioFileExt
        My.Computer.FileSystem.RenameFile(file, ioFileName)

        Return True

    End Function

    Private Sub lstBoxFiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBoxFiles.SelectedIndexChanged

        If (lstBoxFiles.SelectedItem IsNot Nothing) Then

            txtTarget.Text = lstBoxFiles.SelectedItem.ToString

        End If

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

    Private Sub btnAddTemp_Click(sender As Object, e As EventArgs) Handles btnAddTemp.Click

        addNewTemp(txtTemp.Text)
        txtTemp.Clear()

    End Sub

    Private Sub addNewTemp(newTemp As String)

        If newTemp = "" Then Return
        lstTemps.Items.Add(newTemp)
        temps.Add(newTemp)
        My.Settings.Templates = String.Join(",", temps)

    End Sub

    Private Sub removeTemp(item As Object, selectedIndex As Integer)

        lstTemps.Items.Remove(item)
        temps.RemoveAt(selectedIndex)
        My.Settings.Templates = String.Join(",", temps)

    End Sub

    Private Sub btnRemoveTemp_Click(sender As Object, e As EventArgs) Handles btnRemoveTemp.Click

        If lstTemps.SelectedItem = Nothing Then Return

        removeTemp(lstTemps.SelectedItem, lstTemps.SelectedIndex)

    End Sub

    Private Sub lstTemps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstTemps.SelectedIndexChanged

        If lstTemps.SelectedItem = Nothing Then Return

        txtreplacement.Text = lstTemps.SelectedItem.ToString

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If My.Settings.Templates IsNot "" Then

            temps.AddRange(My.Settings.Templates.Split(","))
        End If

        For Each temp As String In temps

            lstTemps.Items.Add(temp)
        Next

    End Sub
End Class
