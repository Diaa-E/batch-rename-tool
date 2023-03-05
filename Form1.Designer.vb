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
        Me.txtTarget = New System.Windows.Forms.TextBox()
        Me.txtreplacement = New System.Windows.Forms.TextBox()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.lblReplacement = New System.Windows.Forms.Label()
        Me.fileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.btnSelectFiles = New System.Windows.Forms.Button()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.lstBoxFiles = New System.Windows.Forms.ListBox()
        Me.txtNewName = New System.Windows.Forms.TextBox()
        Me.lblNewName = New System.Windows.Forms.Label()
        Me.grpMode = New System.Windows.Forms.GroupBox()
        Me.rdEnd = New System.Windows.Forms.RadioButton()
        Me.rdStart = New System.Windows.Forms.RadioButton()
        Me.rdNew = New System.Windows.Forms.RadioButton()
        Me.rdReplace = New System.Windows.Forms.RadioButton()
        Me.grpMode.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTarget
        '
        Me.txtTarget.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTarget.Location = New System.Drawing.Point(12, 78)
        Me.txtTarget.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Size = New System.Drawing.Size(994, 45)
        Me.txtTarget.TabIndex = 0
        '
        'txtreplacement
        '
        Me.txtreplacement.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtreplacement.Location = New System.Drawing.Point(12, 169)
        Me.txtreplacement.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtreplacement.Name = "txtreplacement"
        Me.txtreplacement.Size = New System.Drawing.Size(994, 45)
        Me.txtreplacement.TabIndex = 1
        '
        'lblTarget
        '
        Me.lblTarget.AutoSize = True
        Me.lblTarget.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTarget.Location = New System.Drawing.Point(12, 36)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(70, 38)
        Me.lblTarget.TabIndex = 2
        Me.lblTarget.Text = "Find"
        '
        'lblReplacement
        '
        Me.lblReplacement.AutoSize = True
        Me.lblReplacement.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblReplacement.Location = New System.Drawing.Point(12, 127)
        Me.lblReplacement.Name = "lblReplacement"
        Me.lblReplacement.Size = New System.Drawing.Size(179, 38)
        Me.lblReplacement.TabIndex = 3
        Me.lblReplacement.Text = "Replace With"
        '
        'fileDialog
        '
        Me.fileDialog.FileName = "OpenFileDialog1"
        Me.fileDialog.Multiselect = True
        '
        'btnSelectFiles
        '
        Me.btnSelectFiles.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSelectFiles.Location = New System.Drawing.Point(12, 587)
        Me.btnSelectFiles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSelectFiles.Name = "btnSelectFiles"
        Me.btnSelectFiles.Size = New System.Drawing.Size(362, 95)
        Me.btnSelectFiles.TabIndex = 4
        Me.btnSelectFiles.Text = "Select Files"
        Me.btnSelectFiles.UseVisualStyleBackColor = True
        '
        'btnRename
        '
        Me.btnRename.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRename.Location = New System.Drawing.Point(12, 690)
        Me.btnRename.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(362, 93)
        Me.btnRename.TabIndex = 5
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'lstBoxFiles
        '
        Me.lstBoxFiles.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstBoxFiles.FormattingEnabled = True
        Me.lstBoxFiles.ItemHeight = 32
        Me.lstBoxFiles.Location = New System.Drawing.Point(12, 320)
        Me.lstBoxFiles.Name = "lstBoxFiles"
        Me.lstBoxFiles.Size = New System.Drawing.Size(994, 260)
        Me.lstBoxFiles.TabIndex = 6
        '
        'txtNewName
        '
        Me.txtNewName.Enabled = False
        Me.txtNewName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNewName.Location = New System.Drawing.Point(12, 260)
        Me.txtNewName.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.Size = New System.Drawing.Size(994, 45)
        Me.txtNewName.TabIndex = 1
        Me.txtNewName.Tag = ""
        '
        'lblNewName
        '
        Me.lblNewName.AutoSize = True
        Me.lblNewName.Enabled = False
        Me.lblNewName.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNewName.Location = New System.Drawing.Point(10, 218)
        Me.lblNewName.Name = "lblNewName"
        Me.lblNewName.Size = New System.Drawing.Size(155, 38)
        Me.lblNewName.TabIndex = 3
        Me.lblNewName.Text = "New Name"
        '
        'grpMode
        '
        Me.grpMode.Controls.Add(Me.rdEnd)
        Me.grpMode.Controls.Add(Me.rdStart)
        Me.grpMode.Controls.Add(Me.rdNew)
        Me.grpMode.Controls.Add(Me.rdReplace)
        Me.grpMode.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.grpMode.Location = New System.Drawing.Point(380, 587)
        Me.grpMode.Name = "grpMode"
        Me.grpMode.Size = New System.Drawing.Size(626, 192)
        Me.grpMode.TabIndex = 7
        Me.grpMode.TabStop = False
        Me.grpMode.Text = "Mode"
        '
        'rdEnd
        '
        Me.rdEnd.AutoSize = True
        Me.rdEnd.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdEnd.Location = New System.Drawing.Point(6, 113)
        Me.rdEnd.Name = "rdEnd"
        Me.rdEnd.Size = New System.Drawing.Size(158, 36)
        Me.rdEnd.TabIndex = 0
        Me.rdEnd.Text = "Add to End"
        Me.rdEnd.UseVisualStyleBackColor = True
        '
        'rdStart
        '
        Me.rdStart.AutoSize = True
        Me.rdStart.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdStart.Location = New System.Drawing.Point(6, 78)
        Me.rdStart.Name = "rdStart"
        Me.rdStart.Size = New System.Drawing.Size(166, 36)
        Me.rdStart.TabIndex = 0
        Me.rdStart.Text = "Add to Start"
        Me.rdStart.UseVisualStyleBackColor = True
        '
        'rdNew
        '
        Me.rdNew.AutoSize = True
        Me.rdNew.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdNew.Location = New System.Drawing.Point(6, 148)
        Me.rdNew.Name = "rdNew"
        Me.rdNew.Size = New System.Drawing.Size(199, 36)
        Me.rdNew.TabIndex = 0
        Me.rdNew.Text = "Set New Name"
        Me.rdNew.UseVisualStyleBackColor = True
        '
        'rdReplace
        '
        Me.rdReplace.AutoSize = True
        Me.rdReplace.Checked = True
        Me.rdReplace.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.rdReplace.Location = New System.Drawing.Point(6, 43)
        Me.rdReplace.Name = "rdReplace"
        Me.rdReplace.Size = New System.Drawing.Size(221, 36)
        Me.rdReplace.TabIndex = 0
        Me.rdReplace.TabStop = True
        Me.rdReplace.Text = "Find and Replace"
        Me.rdReplace.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 807)
        Me.Controls.Add(Me.grpMode)
        Me.Controls.Add(Me.lstBoxFiles)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.btnSelectFiles)
        Me.Controls.Add(Me.lblNewName)
        Me.Controls.Add(Me.lblReplacement)
        Me.Controls.Add(Me.lblTarget)
        Me.Controls.Add(Me.txtNewName)
        Me.Controls.Add(Me.txtreplacement)
        Me.Controls.Add(Me.txtTarget)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Batch Rename Tool"
        Me.grpMode.ResumeLayout(False)
        Me.grpMode.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
End Class
