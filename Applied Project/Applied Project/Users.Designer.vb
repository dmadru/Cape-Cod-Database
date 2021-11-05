<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.addUserBTN = New System.Windows.Forms.Button()
        Me.phoneTB = New System.Windows.Forms.TextBox()
        Me.addressTB = New System.Windows.Forms.TextBox()
        Me.lNameTB = New System.Windows.Forms.TextBox()
        Me.fNameTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.userIDTB = New System.Windows.Forms.TextBox()
        Me.menuBTN = New System.Windows.Forms.Button()
        Me.userIDTB1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.fnameTB1 = New System.Windows.Forms.TextBox()
        Me.lnameTB1 = New System.Windows.Forms.TextBox()
        Me.addressTB1 = New System.Windows.Forms.TextBox()
        Me.phoneTB1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.prevBTN = New System.Windows.Forms.Button()
        Me.nextBTN = New System.Windows.Forms.Button()
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
        Me.TabControl1.Size = New System.Drawing.Size(501, 334)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.nextBTN)
        Me.TabPage1.Controls.Add(Me.prevBTN)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.phoneTB1)
        Me.TabPage1.Controls.Add(Me.addressTB1)
        Me.TabPage1.Controls.Add(Me.lnameTB1)
        Me.TabPage1.Controls.Add(Me.fnameTB1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.userIDTB1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(493, 308)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Review"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.addUserBTN)
        Me.TabPage2.Controls.Add(Me.phoneTB)
        Me.TabPage2.Controls.Add(Me.addressTB)
        Me.TabPage2.Controls.Add(Me.lNameTB)
        Me.TabPage2.Controls.Add(Me.fNameTB)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.userIDTB)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(493, 308)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add New"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(362, 151)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Phone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(359, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(359, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Last Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(359, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "First Name"
        '
        'addUserBTN
        '
        Me.addUserBTN.Location = New System.Drawing.Point(24, 252)
        Me.addUserBTN.Name = "addUserBTN"
        Me.addUserBTN.Size = New System.Drawing.Size(75, 23)
        Me.addUserBTN.TabIndex = 6
        Me.addUserBTN.Text = "Add User"
        Me.addUserBTN.UseVisualStyleBackColor = True
        '
        'phoneTB
        '
        Me.phoneTB.Location = New System.Drawing.Point(359, 164)
        Me.phoneTB.Name = "phoneTB"
        Me.phoneTB.Size = New System.Drawing.Size(100, 20)
        Me.phoneTB.TabIndex = 5
        '
        'addressTB
        '
        Me.addressTB.Location = New System.Drawing.Point(359, 124)
        Me.addressTB.Name = "addressTB"
        Me.addressTB.Size = New System.Drawing.Size(100, 20)
        Me.addressTB.TabIndex = 4
        '
        'lNameTB
        '
        Me.lNameTB.Location = New System.Drawing.Point(359, 80)
        Me.lNameTB.Name = "lNameTB"
        Me.lNameTB.Size = New System.Drawing.Size(100, 20)
        Me.lNameTB.TabIndex = 3
        '
        'fNameTB
        '
        Me.fNameTB.Location = New System.Drawing.Point(359, 40)
        Me.fNameTB.Name = "fNameTB"
        Me.fNameTB.Size = New System.Drawing.Size(100, 20)
        Me.fNameTB.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "User ID"
        '
        'userIDTB
        '
        Me.userIDTB.Location = New System.Drawing.Point(31, 41)
        Me.userIDTB.Name = "userIDTB"
        Me.userIDTB.ReadOnly = True
        Me.userIDTB.Size = New System.Drawing.Size(100, 20)
        Me.userIDTB.TabIndex = 0
        '
        'menuBTN
        '
        Me.menuBTN.Location = New System.Drawing.Point(221, 368)
        Me.menuBTN.Name = "menuBTN"
        Me.menuBTN.Size = New System.Drawing.Size(75, 23)
        Me.menuBTN.TabIndex = 1
        Me.menuBTN.Text = "Main Menu"
        Me.menuBTN.UseVisualStyleBackColor = True
        '
        'userIDTB1
        '
        Me.userIDTB1.Location = New System.Drawing.Point(31, 41)
        Me.userIDTB1.Name = "userIDTB1"
        Me.userIDTB1.Size = New System.Drawing.Size(100, 20)
        Me.userIDTB1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(28, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "User ID"
        '
        'fnameTB1
        '
        Me.fnameTB1.Location = New System.Drawing.Point(359, 40)
        Me.fnameTB1.Name = "fnameTB1"
        Me.fnameTB1.Size = New System.Drawing.Size(100, 20)
        Me.fnameTB1.TabIndex = 2
        '
        'lnameTB1
        '
        Me.lnameTB1.Location = New System.Drawing.Point(359, 81)
        Me.lnameTB1.Name = "lnameTB1"
        Me.lnameTB1.Size = New System.Drawing.Size(100, 20)
        Me.lnameTB1.TabIndex = 3
        '
        'addressTB1
        '
        Me.addressTB1.Location = New System.Drawing.Point(359, 123)
        Me.addressTB1.Name = "addressTB1"
        Me.addressTB1.Size = New System.Drawing.Size(100, 20)
        Me.addressTB1.TabIndex = 4
        '
        'phoneTB1
        '
        Me.phoneTB1.Location = New System.Drawing.Point(359, 167)
        Me.phoneTB1.Name = "phoneTB1"
        Me.phoneTB1.Size = New System.Drawing.Size(100, 20)
        Me.phoneTB1.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(359, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "First Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(362, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Last Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(365, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(365, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Phone"
        '
        'prevBTN
        '
        Me.prevBTN.Location = New System.Drawing.Point(24, 252)
        Me.prevBTN.Name = "prevBTN"
        Me.prevBTN.Size = New System.Drawing.Size(75, 23)
        Me.prevBTN.TabIndex = 10
        Me.prevBTN.Text = "Previous"
        Me.prevBTN.UseVisualStyleBackColor = True
        '
        'nextBTN
        '
        Me.nextBTN.Location = New System.Drawing.Point(407, 252)
        Me.nextBTN.Name = "nextBTN"
        Me.nextBTN.Size = New System.Drawing.Size(75, 23)
        Me.nextBTN.TabIndex = 11
        Me.nextBTN.Text = "Next"
        Me.nextBTN.UseVisualStyleBackColor = True
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Applied_Project.My.Resources.Resources.AppBG
        Me.ClientSize = New System.Drawing.Size(533, 403)
        Me.Controls.Add(Me.menuBTN)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Users"
        Me.Text = "Users"
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
    Friend WithEvents phoneTB As TextBox
    Friend WithEvents addressTB As TextBox
    Friend WithEvents lNameTB As TextBox
    Friend WithEvents fNameTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents userIDTB As TextBox
    Friend WithEvents addUserBTN As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents menuBTN As Button
    Friend WithEvents nextBTN As Button
    Friend WithEvents prevBTN As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents phoneTB1 As TextBox
    Friend WithEvents addressTB1 As TextBox
    Friend WithEvents lnameTB1 As TextBox
    Friend WithEvents fnameTB1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents userIDTB1 As TextBox
End Class
