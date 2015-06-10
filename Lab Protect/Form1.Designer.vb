<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Request = New System.Windows.Forms.Button()
        Me.Edit = New System.Windows.Forms.Button()
        Me.Manage = New System.Windows.Forms.Button()
        Me.View = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(601, 151)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Manage)
        Me.GroupBox1.Controls.Add(Me.View)
        Me.GroupBox1.Controls.Add(Me.Edit)
        Me.GroupBox1.Controls.Add(Me.Request)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 157)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(578, 168)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lab Protect Main Menu"
        '
        'Request
        '
        Me.Request.Location = New System.Drawing.Point(6, 19)
        Me.Request.Name = "Request"
        Me.Request.Size = New System.Drawing.Size(281, 68)
        Me.Request.TabIndex = 0
        Me.Request.Text = "Request Access For User"
        Me.Request.UseVisualStyleBackColor = True
        '
        'Edit
        '
        Me.Edit.Location = New System.Drawing.Point(293, 19)
        Me.Edit.Name = "Edit"
        Me.Edit.Size = New System.Drawing.Size(279, 68)
        Me.Edit.TabIndex = 1
        Me.Edit.Text = "Edit Access For User (Restricted)"
        Me.Edit.UseVisualStyleBackColor = True
        '
        'Manage
        '
        Me.Manage.Location = New System.Drawing.Point(293, 93)
        Me.Manage.Name = "Manage"
        Me.Manage.Size = New System.Drawing.Size(279, 68)
        Me.Manage.TabIndex = 3
        Me.Manage.Text = "Manage Database (Restricted)"
        Me.Manage.UseVisualStyleBackColor = True
        '
        'View
        '
        Me.View.Location = New System.Drawing.Point(6, 93)
        Me.View.Name = "View"
        Me.View.Size = New System.Drawing.Size(281, 68)
        Me.View.TabIndex = 2
        Me.View.Text = "View Current Access Permissions (Restricted)"
        Me.View.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 334)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Lab Protect - Home"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Manage As System.Windows.Forms.Button
    Friend WithEvents View As System.Windows.Forms.Button
    Friend WithEvents Edit As System.Windows.Forms.Button
    Friend WithEvents Request As System.Windows.Forms.Button

End Class
