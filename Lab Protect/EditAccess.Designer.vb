<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditData))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.UsersRevoked = New System.Windows.Forms.CheckedListBox()
        Me.UsersGranted = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GrantUser = New System.Windows.Forms.Button()
        Me.RevokeUser = New System.Windows.Forms.Button()
        Me.LabsCBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.LabsRevoked = New System.Windows.Forms.CheckedListBox()
        Me.LabsGranted = New System.Windows.Forms.CheckedListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SelectName = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DoneButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(601, 151)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(111, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Access Granted:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(363, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "This module was designed to allow the modification of a user's access data."
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 176)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(575, 239)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.UsersRevoked)
        Me.TabPage1.Controls.Add(Me.UsersGranted)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.GrantUser)
        Me.TabPage1.Controls.Add(Me.RevokeUser)
        Me.TabPage1.Controls.Add(Me.LabsCBox)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(567, 213)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "By Laboratory"
        '
        'UsersRevoked
        '
        Me.UsersRevoked.FormattingEnabled = True
        Me.UsersRevoked.Location = New System.Drawing.Point(393, 59)
        Me.UsersRevoked.Name = "UsersRevoked"
        Me.UsersRevoked.Size = New System.Drawing.Size(170, 139)
        Me.UsersRevoked.TabIndex = 10
        '
        'UsersGranted
        '
        Me.UsersGranted.FormattingEnabled = True
        Me.UsersGranted.Location = New System.Drawing.Point(114, 59)
        Me.UsersGranted.Name = "UsersGranted"
        Me.UsersGranted.Size = New System.Drawing.Size(170, 139)
        Me.UsersGranted.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Permissions:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(390, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Access Revoked:"
        '
        'GrantUser
        '
        Me.GrantUser.Location = New System.Drawing.Point(290, 124)
        Me.GrantUser.Name = "GrantUser"
        Me.GrantUser.Size = New System.Drawing.Size(97, 22)
        Me.GrantUser.TabIndex = 6
        Me.GrantUser.Text = "Grant Access"
        Me.GrantUser.UseVisualStyleBackColor = True
        '
        'RevokeUser
        '
        Me.RevokeUser.Location = New System.Drawing.Point(290, 96)
        Me.RevokeUser.Name = "RevokeUser"
        Me.RevokeUser.Size = New System.Drawing.Size(97, 22)
        Me.RevokeUser.TabIndex = 4
        Me.RevokeUser.Text = "Revoke"
        Me.RevokeUser.UseVisualStyleBackColor = True
        '
        'LabsCBox
        '
        Me.LabsCBox.FormattingEnabled = True
        Me.LabsCBox.Location = New System.Drawing.Point(114, 6)
        Me.LabsCBox.Name = "LabsCBox"
        Me.LabsCBox.Size = New System.Drawing.Size(447, 21)
        Me.LabsCBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select Laboratory:"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.LabsRevoked)
        Me.TabPage2.Controls.Add(Me.LabsGranted)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.SelectName)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(567, 213)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "By Name"
        '
        'LabsRevoked
        '
        Me.LabsRevoked.FormattingEnabled = True
        Me.LabsRevoked.Location = New System.Drawing.Point(393, 59)
        Me.LabsRevoked.Name = "LabsRevoked"
        Me.LabsRevoked.Size = New System.Drawing.Size(170, 139)
        Me.LabsRevoked.TabIndex = 17
        '
        'LabsGranted
        '
        Me.LabsGranted.FormattingEnabled = True
        Me.LabsGranted.Location = New System.Drawing.Point(114, 59)
        Me.LabsGranted.Name = "LabsGranted"
        Me.LabsGranted.Size = New System.Drawing.Size(170, 139)
        Me.LabsGranted.TabIndex = 16
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Permissions:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(390, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Access Revoked:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(290, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 22)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Grant Access"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(290, 96)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 22)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Revoke"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(111, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Access Granted:"
        '
        'SelectName
        '
        Me.SelectName.FormattingEnabled = True
        Me.SelectName.Location = New System.Drawing.Point(114, 6)
        Me.SelectName.Name = "SelectName"
        Me.SelectName.Size = New System.Drawing.Size(447, 21)
        Me.SelectName.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Select Employee:"
        '
        'DoneButton
        '
        Me.DoneButton.Location = New System.Drawing.Point(492, 421)
        Me.DoneButton.Name = "DoneButton"
        Me.DoneButton.Size = New System.Drawing.Size(95, 22)
        Me.DoneButton.TabIndex = 5
        Me.DoneButton.Text = "Done"
        Me.DoneButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(391, 421)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(95, 22)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "Cancel"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'EditData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(599, 451)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DoneButton)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "EditData"
        Me.Text = "Lab Protect - Edit Access"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents LabsCBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GrantUser As System.Windows.Forms.Button
    Friend WithEvents RevokeUser As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents UsersRevoked As System.Windows.Forms.CheckedListBox
    Friend WithEvents UsersGranted As System.Windows.Forms.CheckedListBox
    Friend WithEvents LabsRevoked As System.Windows.Forms.CheckedListBox
    Friend WithEvents LabsGranted As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SelectName As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DoneButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
End Class
