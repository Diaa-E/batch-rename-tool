<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtTarget = New TextBox()
        txtreplacement = New TextBox()
        lblTarget = New Label()
        lblReplacement = New Label()
        fileDialog = New OpenFileDialog()
        btnSelectFiles = New Button()
        btnRename = New Button()
        lstBoxFiles = New ListBox()
        txtNewName = New TextBox()
        lblNewName = New Label()
        grpMode = New GroupBox()
        rdEnd = New RadioButton()
        rdStart = New RadioButton()
        rdNew = New RadioButton()
        rdReplace = New RadioButton()
        lstTemps = New ListBox()
        lblTemps = New Label()
        btnAddTemp = New Button()
        btnRemoveTemp = New Button()
        txtTemp = New TextBox()
        grpMode.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtTarget
        ' 
        txtTarget.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtTarget.Location = New Point(10, 62)
        txtTarget.Margin = New Padding(2, 3, 2, 3)
        txtTarget.Name = "txtTarget"
        txtTarget.Size = New Size(796, 39)
        txtTarget.TabIndex = 0
        ' 
        ' txtreplacement
        ' 
        txtreplacement.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtreplacement.Location = New Point(10, 135)
        txtreplacement.Margin = New Padding(2, 3, 2, 3)
        txtreplacement.Name = "txtreplacement"
        txtreplacement.Size = New Size(796, 39)
        txtreplacement.TabIndex = 1
        ' 
        ' lblTarget
        ' 
        lblTarget.AutoSize = True
        lblTarget.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblTarget.Location = New Point(10, 29)
        lblTarget.Margin = New Padding(2, 0, 2, 0)
        lblTarget.Name = "lblTarget"
        lblTarget.Size = New Size(60, 32)
        lblTarget.TabIndex = 2
        lblTarget.Text = "Find"
        ' 
        ' lblReplacement
        ' 
        lblReplacement.AutoSize = True
        lblReplacement.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblReplacement.Location = New Point(10, 102)
        lblReplacement.Margin = New Padding(2, 0, 2, 0)
        lblReplacement.Name = "lblReplacement"
        lblReplacement.Size = New Size(153, 32)
        lblReplacement.TabIndex = 3
        lblReplacement.Text = "Replace With"
        ' 
        ' fileDialog
        ' 
        fileDialog.FileName = "OpenFileDialog1"
        fileDialog.Multiselect = True
        ' 
        ' btnSelectFiles
        ' 
        btnSelectFiles.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnSelectFiles.Location = New Point(10, 470)
        btnSelectFiles.Margin = New Padding(2, 3, 2, 3)
        btnSelectFiles.Name = "btnSelectFiles"
        btnSelectFiles.Size = New Size(290, 76)
        btnSelectFiles.TabIndex = 4
        btnSelectFiles.Text = "Select Files"
        btnSelectFiles.UseVisualStyleBackColor = True
        ' 
        ' btnRename
        ' 
        btnRename.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnRename.Location = New Point(10, 552)
        btnRename.Margin = New Padding(2, 3, 2, 3)
        btnRename.Name = "btnRename"
        btnRename.Size = New Size(290, 74)
        btnRename.TabIndex = 5
        btnRename.Text = "Rename"
        btnRename.UseVisualStyleBackColor = True
        ' 
        ' lstBoxFiles
        ' 
        lstBoxFiles.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lstBoxFiles.FormattingEnabled = True
        lstBoxFiles.ItemHeight = 28
        lstBoxFiles.Location = New Point(10, 256)
        lstBoxFiles.Margin = New Padding(2)
        lstBoxFiles.Name = "lstBoxFiles"
        lstBoxFiles.Size = New Size(796, 200)
        lstBoxFiles.TabIndex = 6
        ' 
        ' txtNewName
        ' 
        txtNewName.Enabled = False
        txtNewName.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtNewName.Location = New Point(10, 208)
        txtNewName.Margin = New Padding(2, 3, 2, 3)
        txtNewName.Name = "txtNewName"
        txtNewName.Size = New Size(796, 39)
        txtNewName.TabIndex = 1
        txtNewName.Tag = ""
        ' 
        ' lblNewName
        ' 
        lblNewName.AutoSize = True
        lblNewName.Enabled = False
        lblNewName.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblNewName.Location = New Point(8, 174)
        lblNewName.Margin = New Padding(2, 0, 2, 0)
        lblNewName.Name = "lblNewName"
        lblNewName.Size = New Size(133, 32)
        lblNewName.TabIndex = 3
        lblNewName.Text = "New Name"
        ' 
        ' grpMode
        ' 
        grpMode.Controls.Add(rdEnd)
        grpMode.Controls.Add(rdStart)
        grpMode.Controls.Add(rdNew)
        grpMode.Controls.Add(rdReplace)
        grpMode.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        grpMode.Location = New Point(304, 470)
        grpMode.Margin = New Padding(2)
        grpMode.Name = "grpMode"
        grpMode.Padding = New Padding(2)
        grpMode.Size = New Size(501, 154)
        grpMode.TabIndex = 7
        grpMode.TabStop = False
        grpMode.Text = "Mode"
        ' 
        ' rdEnd
        ' 
        rdEnd.AutoSize = True
        rdEnd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rdEnd.Location = New Point(5, 90)
        rdEnd.Margin = New Padding(2)
        rdEnd.Name = "rdEnd"
        rdEnd.Size = New Size(132, 32)
        rdEnd.TabIndex = 0
        rdEnd.Text = "Add to End"
        rdEnd.UseVisualStyleBackColor = True
        ' 
        ' rdStart
        ' 
        rdStart.AutoSize = True
        rdStart.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rdStart.Location = New Point(5, 62)
        rdStart.Margin = New Padding(2)
        rdStart.Name = "rdStart"
        rdStart.Size = New Size(140, 32)
        rdStart.TabIndex = 0
        rdStart.Text = "Add to Start"
        rdStart.UseVisualStyleBackColor = True
        ' 
        ' rdNew
        ' 
        rdNew.AutoSize = True
        rdNew.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rdNew.Location = New Point(5, 118)
        rdNew.Margin = New Padding(2)
        rdNew.Name = "rdNew"
        rdNew.Size = New Size(162, 32)
        rdNew.TabIndex = 0
        rdNew.Text = "Set New Name"
        rdNew.UseVisualStyleBackColor = True
        ' 
        ' rdReplace
        ' 
        rdReplace.AutoSize = True
        rdReplace.Checked = True
        rdReplace.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        rdReplace.Location = New Point(5, 34)
        rdReplace.Margin = New Padding(2)
        rdReplace.Name = "rdReplace"
        rdReplace.Size = New Size(181, 32)
        rdReplace.TabIndex = 0
        rdReplace.TabStop = True
        rdReplace.Text = "Find and Replace"
        rdReplace.UseVisualStyleBackColor = True
        ' 
        ' lstTemps
        ' 
        lstTemps.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        lstTemps.FormattingEnabled = True
        lstTemps.ItemHeight = 28
        lstTemps.Location = New Point(827, 60)
        lstTemps.Margin = New Padding(2)
        lstTemps.Name = "lstTemps"
        lstTemps.Size = New Size(292, 396)
        lstTemps.TabIndex = 8
        ' 
        ' lblTemps
        ' 
        lblTemps.AutoSize = True
        lblTemps.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lblTemps.Location = New Point(827, 26)
        lblTemps.Margin = New Padding(2, 0, 2, 0)
        lblTemps.Name = "lblTemps"
        lblTemps.Size = New Size(122, 32)
        lblTemps.TabIndex = 9
        lblTemps.Text = "Templates"
        ' 
        ' btnAddTemp
        ' 
        btnAddTemp.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        btnAddTemp.Location = New Point(827, 532)
        btnAddTemp.Margin = New Padding(2, 3, 2, 3)
        btnAddTemp.Name = "btnAddTemp"
        btnAddTemp.Size = New Size(141, 96)
        btnAddTemp.TabIndex = 10
        btnAddTemp.Text = "Add"
        btnAddTemp.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveTemp
        ' 
        btnRemoveTemp.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        btnRemoveTemp.Location = New Point(978, 532)
        btnRemoveTemp.Margin = New Padding(2, 3, 2, 3)
        btnRemoveTemp.Name = "btnRemoveTemp"
        btnRemoveTemp.Size = New Size(141, 96)
        btnRemoveTemp.TabIndex = 11
        btnRemoveTemp.Text = "Remove"
        btnRemoveTemp.UseVisualStyleBackColor = True
        ' 
        ' txtTemp
        ' 
        txtTemp.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        txtTemp.Location = New Point(827, 470)
        txtTemp.Margin = New Padding(2, 3, 2, 3)
        txtTemp.Name = "txtTemp"
        txtTemp.Size = New Size(292, 39)
        txtTemp.TabIndex = 12
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1130, 646)
        Controls.Add(txtTemp)
        Controls.Add(btnRemoveTemp)
        Controls.Add(btnAddTemp)
        Controls.Add(lblTemps)
        Controls.Add(lstTemps)
        Controls.Add(grpMode)
        Controls.Add(lstBoxFiles)
        Controls.Add(btnRename)
        Controls.Add(btnSelectFiles)
        Controls.Add(lblNewName)
        Controls.Add(lblReplacement)
        Controls.Add(lblTarget)
        Controls.Add(txtNewName)
        Controls.Add(txtreplacement)
        Controls.Add(txtTarget)
        Margin = New Padding(2, 3, 2, 3)
        Name = "Form1"
        ShowIcon = False
        Text = "Batch Rename Tool"
        grpMode.ResumeLayout(False)
        grpMode.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtTarget As TextBox
    Friend WithEvents txtreplacement As TextBox
    Friend WithEvents lblTarget As Label
    Friend WithEvents lblReplacement As Label
    Friend WithEvents fileDialog As OpenFileDialog
    Friend WithEvents btnSelectFiles As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents lstBoxFiles As ListBox
    Friend WithEvents txtNewName As TextBox
    Friend WithEvents lblNewName As Label
    Friend WithEvents grpMode As GroupBox
    Friend WithEvents rdEnd As RadioButton
    Friend WithEvents rdStart As RadioButton
    Friend WithEvents rdNew As RadioButton
    Friend WithEvents rdReplace As RadioButton
    Friend WithEvents lstTemps As ListBox
    Friend WithEvents lblTemps As Label
    Friend WithEvents btnAddTemp As Button
    Friend WithEvents btnRemoveTemp As Button
    Friend WithEvents txtTemp As TextBox
End Class
