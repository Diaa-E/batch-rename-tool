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
        Me.SuspendLayout()
        '
        'txtTarget
        '
        Me.txtTarget.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTarget.Location = New System.Drawing.Point(284, 81)
        Me.txtTarget.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtTarget.Name = "txtTarget"
        Me.txtTarget.Size = New System.Drawing.Size(708, 45)
        Me.txtTarget.TabIndex = 0
        '
        'txtreplacement
        '
        Me.txtreplacement.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtreplacement.Location = New System.Drawing.Point(284, 161)
        Me.txtreplacement.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtreplacement.Name = "txtreplacement"
        Me.txtreplacement.Size = New System.Drawing.Size(708, 45)
        Me.txtreplacement.TabIndex = 1
        '
        'lblTarget
        '
        Me.lblTarget.AutoSize = True
        Me.lblTarget.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTarget.Location = New System.Drawing.Point(31, 84)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(70, 38)
        Me.lblTarget.TabIndex = 2
        Me.lblTarget.Text = "Find"
        '
        'lblReplacement
        '
        Me.lblReplacement.AutoSize = True
        Me.lblReplacement.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblReplacement.Location = New System.Drawing.Point(31, 164)
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
        Me.btnSelectFiles.Location = New System.Drawing.Point(31, 339)
        Me.btnSelectFiles.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSelectFiles.Name = "btnSelectFiles"
        Me.btnSelectFiles.Size = New System.Drawing.Size(198, 76)
        Me.btnSelectFiles.TabIndex = 4
        Me.btnSelectFiles.Text = "Select Files"
        Me.btnSelectFiles.UseVisualStyleBackColor = True
        '
        'btnRename
        '
        Me.btnRename.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRename.Location = New System.Drawing.Point(31, 245)
        Me.btnRename.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(198, 76)
        Me.btnRename.TabIndex = 5
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'lstBoxFiles
        '
        Me.lstBoxFiles.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lstBoxFiles.FormattingEnabled = True
        Me.lstBoxFiles.ItemHeight = 32
        Me.lstBoxFiles.Location = New System.Drawing.Point(284, 245)
        Me.lstBoxFiles.Name = "lstBoxFiles"
        Me.lstBoxFiles.Size = New System.Drawing.Size(708, 324)
        Me.lstBoxFiles.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 708)
        Me.Controls.Add(Me.lstBoxFiles)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.btnSelectFiles)
        Me.Controls.Add(Me.lblReplacement)
        Me.Controls.Add(Me.lblTarget)
        Me.Controls.Add(Me.txtreplacement)
        Me.Controls.Add(Me.txtTarget)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Batch Rename Tool"
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
End Class
