<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParkingPermits
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
        Me.searchBTN = New System.Windows.Forms.Button()
        Me.nextBTN = New System.Windows.Forms.Button()
        Me.prevBTN = New System.Windows.Forms.Button()
        Me.lPlateTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.permitTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addressTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lNameTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fNameTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.beachNameCB = New System.Windows.Forms.ComboBox()
        Me.updateBTN = New System.Windows.Forms.Button()
        Me.permitTB2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.plateTB = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.userIDTB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
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
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(509, 336)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.searchBTN)
        Me.TabPage1.Controls.Add(Me.nextBTN)
        Me.TabPage1.Controls.Add(Me.prevBTN)
        Me.TabPage1.Controls.Add(Me.lPlateTB)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.permitTB)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.addressTB)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.lNameTB)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.fNameTB)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(501, 310)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Review"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'searchBTN
        '
        Me.searchBTN.Location = New System.Drawing.Point(323, 71)
        Me.searchBTN.Name = "searchBTN"
        Me.searchBTN.Size = New System.Drawing.Size(100, 36)
        Me.searchBTN.TabIndex = 12
        Me.searchBTN.Text = "Search by Permit Number"
        Me.searchBTN.UseVisualStyleBackColor = True
        '
        'nextBTN
        '
        Me.nextBTN.Location = New System.Drawing.Point(382, 266)
        Me.nextBTN.Name = "nextBTN"
        Me.nextBTN.Size = New System.Drawing.Size(75, 23)
        Me.nextBTN.TabIndex = 11
        Me.nextBTN.Text = "Next"
        Me.nextBTN.UseVisualStyleBackColor = True
        '
        'prevBTN
        '
        Me.prevBTN.Location = New System.Drawing.Point(31, 266)
        Me.prevBTN.Name = "prevBTN"
        Me.prevBTN.Size = New System.Drawing.Size(75, 23)
        Me.prevBTN.TabIndex = 10
        Me.prevBTN.Text = "Previous"
        Me.prevBTN.UseVisualStyleBackColor = True
        '
        'lPlateTB
        '
        Me.lPlateTB.Location = New System.Drawing.Point(31, 158)
        Me.lPlateTB.Name = "lPlateTB"
        Me.lPlateTB.Size = New System.Drawing.Size(100, 20)
        Me.lPlateTB.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "License Plate"
        '
        'permitTB
        '
        Me.permitTB.Location = New System.Drawing.Point(323, 41)
        Me.permitTB.Name = "permitTB"
        Me.permitTB.Size = New System.Drawing.Size(100, 20)
        Me.permitTB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Permit Number"
        '
        'addressTB
        '
        Me.addressTB.Location = New System.Drawing.Point(31, 119)
        Me.addressTB.Name = "addressTB"
        Me.addressTB.Size = New System.Drawing.Size(100, 20)
        Me.addressTB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Address"
        '
        'lNameTB
        '
        Me.lNameTB.Location = New System.Drawing.Point(31, 80)
        Me.lNameTB.Name = "lNameTB"
        Me.lNameTB.Size = New System.Drawing.Size(100, 20)
        Me.lNameTB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'fNameTB
        '
        Me.fNameTB.Location = New System.Drawing.Point(31, 41)
        Me.fNameTB.Name = "fNameTB"
        Me.fNameTB.Size = New System.Drawing.Size(100, 20)
        Me.fNameTB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.beachNameCB)
        Me.TabPage2.Controls.Add(Me.updateBTN)
        Me.TabPage2.Controls.Add(Me.permitTB2)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.plateTB)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.userIDTB)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(501, 310)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add New"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'beachNameCB
        '
        Me.beachNameCB.FormattingEnabled = True
        Me.beachNameCB.Items.AddRange(New Object() {"Craigville", "Veterans", "Keyes", "Seagull", "Sandy Neck"})
        Me.beachNameCB.Location = New System.Drawing.Point(31, 77)
        Me.beachNameCB.Name = "beachNameCB"
        Me.beachNameCB.Size = New System.Drawing.Size(100, 21)
        Me.beachNameCB.TabIndex = 24
        '
        'updateBTN
        '
        Me.updateBTN.Location = New System.Drawing.Point(382, 266)
        Me.updateBTN.Name = "updateBTN"
        Me.updateBTN.Size = New System.Drawing.Size(75, 23)
        Me.updateBTN.TabIndex = 23
        Me.updateBTN.Text = "Add Permit"
        Me.updateBTN.UseVisualStyleBackColor = True
        '
        'permitTB2
        '
        Me.permitTB2.Location = New System.Drawing.Point(323, 41)
        Me.permitTB2.Name = "permitTB2"
        Me.permitTB2.ReadOnly = True
        Me.permitTB2.Size = New System.Drawing.Size(100, 20)
        Me.permitTB2.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(320, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Permit Number"
        '
        'plateTB
        '
        Me.plateTB.Location = New System.Drawing.Point(31, 117)
        Me.plateTB.Name = "plateTB"
        Me.plateTB.Size = New System.Drawing.Size(100, 20)
        Me.plateTB.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(34, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "License Plate"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Beach"
        '
        'userIDTB
        '
        Me.userIDTB.Location = New System.Drawing.Point(31, 41)
        Me.userIDTB.Name = "userIDTB"
        Me.userIDTB.Size = New System.Drawing.Size(100, 20)
        Me.userIDTB.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(34, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "User ID"
        '
        'menuBTN
        '
        Me.menuBTN.Location = New System.Drawing.Point(231, 368)
        Me.menuBTN.Name = "menuBTN"
        Me.menuBTN.Size = New System.Drawing.Size(75, 23)
        Me.menuBTN.TabIndex = 1
        Me.menuBTN.Text = "Main Menu"
        Me.menuBTN.UseVisualStyleBackColor = True
        '
        'ParkingPermits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Applied_Project.My.Resources.Resources.AppBG
        Me.ClientSize = New System.Drawing.Size(533, 403)
        Me.Controls.Add(Me.menuBTN)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "ParkingPermits"
        Me.Text = "Parking Permits"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents nextBTN As Button
    Friend WithEvents prevBTN As Button
    Friend WithEvents lPlateTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents permitTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents addressTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lNameTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fNameTB As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents searchBTN As Button
    Friend WithEvents permitTB2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents plateTB As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents userIDTB As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents updateBTN As Button
    Friend WithEvents beachNameCB As ComboBox
    Friend WithEvents menuBTN As Button
End Class
