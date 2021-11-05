<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FishingLicenses
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.licenseNumberTB = New System.Windows.Forms.TextBox()
        Me.beachTB = New System.Windows.Forms.TextBox()
        Me.addressTB = New System.Windows.Forms.TextBox()
        Me.lnameTB = New System.Windows.Forms.TextBox()
        Me.fnameTB = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.beachCB = New System.Windows.Forms.ComboBox()
        Me.AddBTN = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.UserIDTB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.licenseNumberTB2 = New System.Windows.Forms.TextBox()
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
        Me.TabControl1.Size = New System.Drawing.Size(509, 323)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.searchBTN)
        Me.TabPage1.Controls.Add(Me.nextBTN)
        Me.TabPage1.Controls.Add(Me.prevBTN)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.licenseNumberTB)
        Me.TabPage1.Controls.Add(Me.beachTB)
        Me.TabPage1.Controls.Add(Me.addressTB)
        Me.TabPage1.Controls.Add(Me.lnameTB)
        Me.TabPage1.Controls.Add(Me.fnameTB)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(501, 297)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Review"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'searchBTN
        '
        Me.searchBTN.Location = New System.Drawing.Point(31, 67)
        Me.searchBTN.Name = "searchBTN"
        Me.searchBTN.Size = New System.Drawing.Size(103, 36)
        Me.searchBTN.TabIndex = 12
        Me.searchBTN.Text = "Search by License Number"
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(34, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "License Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(362, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Beach"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(362, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(362, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(362, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "First Name"
        '
        'licenseNumberTB
        '
        Me.licenseNumberTB.Location = New System.Drawing.Point(34, 40)
        Me.licenseNumberTB.Name = "licenseNumberTB"
        Me.licenseNumberTB.Size = New System.Drawing.Size(100, 20)
        Me.licenseNumberTB.TabIndex = 4
        '
        'beachTB
        '
        Me.beachTB.Location = New System.Drawing.Point(359, 174)
        Me.beachTB.Name = "beachTB"
        Me.beachTB.Size = New System.Drawing.Size(100, 20)
        Me.beachTB.TabIndex = 3
        '
        'addressTB
        '
        Me.addressTB.Location = New System.Drawing.Point(359, 128)
        Me.addressTB.Name = "addressTB"
        Me.addressTB.Size = New System.Drawing.Size(100, 20)
        Me.addressTB.TabIndex = 2
        '
        'lnameTB
        '
        Me.lnameTB.Location = New System.Drawing.Point(359, 83)
        Me.lnameTB.Name = "lnameTB"
        Me.lnameTB.Size = New System.Drawing.Size(100, 20)
        Me.lnameTB.TabIndex = 1
        '
        'fnameTB
        '
        Me.fnameTB.Location = New System.Drawing.Point(359, 40)
        Me.fnameTB.Name = "fnameTB"
        Me.fnameTB.Size = New System.Drawing.Size(100, 20)
        Me.fnameTB.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.beachCB)
        Me.TabPage2.Controls.Add(Me.AddBTN)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.UserIDTB)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.licenseNumberTB2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(501, 297)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add New"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'beachCB
        '
        Me.beachCB.FormattingEnabled = True
        Me.beachCB.Items.AddRange(New Object() {"Craigville", "Veterans", "Keyes", "Seagull", "Sandy Neck"})
        Me.beachCB.Location = New System.Drawing.Point(359, 83)
        Me.beachCB.Name = "beachCB"
        Me.beachCB.Size = New System.Drawing.Size(100, 21)
        Me.beachCB.TabIndex = 11
        '
        'AddBTN
        '
        Me.AddBTN.Location = New System.Drawing.Point(31, 266)
        Me.AddBTN.Name = "AddBTN"
        Me.AddBTN.Size = New System.Drawing.Size(75, 23)
        Me.AddBTN.TabIndex = 10
        Me.AddBTN.Text = "Add License"
        Me.AddBTN.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(362, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Beach"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(362, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "UserID"
        '
        'UserIDTB
        '
        Me.UserIDTB.Location = New System.Drawing.Point(359, 40)
        Me.UserIDTB.Name = "UserIDTB"
        Me.UserIDTB.Size = New System.Drawing.Size(100, 20)
        Me.UserIDTB.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(34, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "License Number"
        '
        'licenseNumberTB2
        '
        Me.licenseNumberTB2.Location = New System.Drawing.Point(34, 40)
        Me.licenseNumberTB2.Name = "licenseNumberTB2"
        Me.licenseNumberTB2.ReadOnly = True
        Me.licenseNumberTB2.Size = New System.Drawing.Size(100, 20)
        Me.licenseNumberTB2.TabIndex = 0
        '
        'menuBTN
        '
        Me.menuBTN.Location = New System.Drawing.Point(234, 368)
        Me.menuBTN.Name = "menuBTN"
        Me.menuBTN.Size = New System.Drawing.Size(75, 23)
        Me.menuBTN.TabIndex = 1
        Me.menuBTN.Text = "Main Menu"
        Me.menuBTN.UseVisualStyleBackColor = True
        '
        'FishingLicenses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Applied_Project.My.Resources.Resources.AppBG
        Me.ClientSize = New System.Drawing.Size(533, 403)
        Me.Controls.Add(Me.menuBTN)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FishingLicenses"
        Me.Text = "Fishing Licenses"
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
    Friend WithEvents fnameTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents licenseNumberTB As TextBox
    Friend WithEvents beachTB As TextBox
    Friend WithEvents addressTB As TextBox
    Friend WithEvents lnameTB As TextBox
    Friend WithEvents prevBTN As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents nextBTN As Button
    Friend WithEvents searchBTN As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents UserIDTB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents licenseNumberTB2 As TextBox
    Friend WithEvents AddBTN As Button
    Friend WithEvents beachCB As ComboBox
    Friend WithEvents menuBTN As Button
End Class
