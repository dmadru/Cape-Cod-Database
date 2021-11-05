<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boat_Registration
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.prevBTN = New System.Windows.Forms.Button()
        Me.nextBTN = New System.Windows.Forms.Button()
        Me.boatIDTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userIDTB = New System.Windows.Forms.TextBox()
        Me.Model = New System.Windows.Forms.Label()
        Me.regIDTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.addregBTN = New System.Windows.Forms.Button()
        Me.boatIDTB2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.userIDTB2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.regIDTB2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.menuBTN = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(501, 331)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.prevBTN)
        Me.TabPage1.Controls.Add(Me.nextBTN)
        Me.TabPage1.Controls.Add(Me.boatIDTB)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.userIDTB)
        Me.TabPage1.Controls.Add(Me.Model)
        Me.TabPage1.Controls.Add(Me.regIDTB)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(493, 305)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Review"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'prevBTN
        '
        Me.prevBTN.Location = New System.Drawing.Point(24, 252)
        Me.prevBTN.Name = "prevBTN"
        Me.prevBTN.Size = New System.Drawing.Size(75, 23)
        Me.prevBTN.TabIndex = 19
        Me.prevBTN.Text = "Previous"
        Me.prevBTN.UseVisualStyleBackColor = True
        '
        'nextBTN
        '
        Me.nextBTN.Location = New System.Drawing.Point(407, 252)
        Me.nextBTN.Name = "nextBTN"
        Me.nextBTN.Size = New System.Drawing.Size(75, 23)
        Me.nextBTN.TabIndex = 18
        Me.nextBTN.Text = "Next"
        Me.nextBTN.UseVisualStyleBackColor = True
        '
        'boatIDTB
        '
        Me.boatIDTB.Location = New System.Drawing.Point(24, 84)
        Me.boatIDTB.Name = "boatIDTB"
        Me.boatIDTB.Size = New System.Drawing.Size(100, 20)
        Me.boatIDTB.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Boat ID"
        '
        'userIDTB
        '
        Me.userIDTB.Location = New System.Drawing.Point(24, 45)
        Me.userIDTB.Name = "userIDTB"
        Me.userIDTB.Size = New System.Drawing.Size(100, 20)
        Me.userIDTB.TabIndex = 3
        '
        'Model
        '
        Me.Model.AutoSize = True
        Me.Model.Location = New System.Drawing.Point(33, 28)
        Me.Model.Name = "Model"
        Me.Model.Size = New System.Drawing.Size(43, 13)
        Me.Model.TabIndex = 2
        Me.Model.Text = "User ID"
        '
        'regIDTB
        '
        Me.regIDTB.Location = New System.Drawing.Point(362, 46)
        Me.regIDTB.Name = "regIDTB"
        Me.regIDTB.Size = New System.Drawing.Size(100, 20)
        Me.regIDTB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(359, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registration Number"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.addregBTN)
        Me.TabPage2.Controls.Add(Me.boatIDTB2)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.userIDTB2)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.regIDTB2)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(500, 285)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add New"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'addregBTN
        '
        Me.addregBTN.Location = New System.Drawing.Point(398, 253)
        Me.addregBTN.Name = "addregBTN"
        Me.addregBTN.Size = New System.Drawing.Size(75, 23)
        Me.addregBTN.TabIndex = 6
        Me.addregBTN.Text = "Add New"
        Me.addregBTN.UseVisualStyleBackColor = True
        '
        'boatIDTB2
        '
        Me.boatIDTB2.Location = New System.Drawing.Point(33, 89)
        Me.boatIDTB2.Name = "boatIDTB2"
        Me.boatIDTB2.Size = New System.Drawing.Size(100, 20)
        Me.boatIDTB2.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(42, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Boat ID"
        '
        'userIDTB2
        '
        Me.userIDTB2.Location = New System.Drawing.Point(33, 45)
        Me.userIDTB2.Name = "userIDTB2"
        Me.userIDTB2.Size = New System.Drawing.Size(100, 20)
        Me.userIDTB2.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "User ID"
        '
        'regIDTB2
        '
        Me.regIDTB2.Location = New System.Drawing.Point(375, 45)
        Me.regIDTB2.Name = "regIDTB2"
        Me.regIDTB2.ReadOnly = True
        Me.regIDTB2.Size = New System.Drawing.Size(100, 20)
        Me.regIDTB2.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(372, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Registration Number"
        '
        'menuBTN
        '
        Me.menuBTN.Location = New System.Drawing.Point(230, 368)
        Me.menuBTN.Name = "menuBTN"
        Me.menuBTN.Size = New System.Drawing.Size(75, 23)
        Me.menuBTN.TabIndex = 1
        Me.menuBTN.Text = "Main Menu"
        Me.menuBTN.UseVisualStyleBackColor = True
        '
        'Boat_Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Applied_Project.My.Resources.Resources.AppBG
        Me.ClientSize = New System.Drawing.Size(533, 403)
        Me.Controls.Add(Me.menuBTN)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Boat_Registration"
        Me.Text = "Boat_Registration"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents boatIDTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents userIDTB As TextBox
    Friend WithEvents Model As Label
    Friend WithEvents regIDTB As TextBox
    Friend WithEvents boatIDTB2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents userIDTB2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents regIDTB2 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents prevBTN As Button
    Friend WithEvents nextBTN As Button
    Friend WithEvents addregBTN As Button
    Friend WithEvents menuBTN As Button
End Class
