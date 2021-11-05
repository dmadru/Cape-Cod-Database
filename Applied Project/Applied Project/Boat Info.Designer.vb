<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Boat_Info
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
        Me.nextBTN = New System.Windows.Forms.Button()
        Me.prevBTN = New System.Windows.Forms.Button()
        Me.colorTB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.yearTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ModelTB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.makeTB = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.boatIDTB = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.addboatBTN = New System.Windows.Forms.Button()
        Me.colorTB2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.yearTB2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.modelTB2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.makeTB2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.boatIDTB2 = New System.Windows.Forms.TextBox()
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
        Me.TabControl1.Location = New System.Drawing.Point(13, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(508, 324)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.nextBTN)
        Me.TabPage1.Controls.Add(Me.prevBTN)
        Me.TabPage1.Controls.Add(Me.colorTB)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.yearTB)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.ModelTB)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.makeTB)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.boatIDTB)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(500, 298)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Review"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'nextBTN
        '
        Me.nextBTN.Location = New System.Drawing.Point(372, 265)
        Me.nextBTN.Name = "nextBTN"
        Me.nextBTN.Size = New System.Drawing.Size(75, 23)
        Me.nextBTN.TabIndex = 11
        Me.nextBTN.Text = "Next"
        Me.nextBTN.UseVisualStyleBackColor = True
        '
        'prevBTN
        '
        Me.prevBTN.Location = New System.Drawing.Point(22, 265)
        Me.prevBTN.Name = "prevBTN"
        Me.prevBTN.Size = New System.Drawing.Size(75, 23)
        Me.prevBTN.TabIndex = 10
        Me.prevBTN.Text = "Previous"
        Me.prevBTN.UseVisualStyleBackColor = True
        '
        'colorTB
        '
        Me.colorTB.Location = New System.Drawing.Point(22, 176)
        Me.colorTB.Name = "colorTB"
        Me.colorTB.Size = New System.Drawing.Size(100, 20)
        Me.colorTB.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(37, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Color"
        '
        'yearTB
        '
        Me.yearTB.Location = New System.Drawing.Point(22, 131)
        Me.yearTB.Name = "yearTB"
        Me.yearTB.Size = New System.Drawing.Size(100, 20)
        Me.yearTB.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Year"
        '
        'ModelTB
        '
        Me.ModelTB.Location = New System.Drawing.Point(22, 87)
        Me.ModelTB.Name = "ModelTB"
        Me.ModelTB.Size = New System.Drawing.Size(100, 20)
        Me.ModelTB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Model"
        '
        'makeTB
        '
        Me.makeTB.Location = New System.Drawing.Point(22, 43)
        Me.makeTB.Name = "makeTB"
        Me.makeTB.Size = New System.Drawing.Size(100, 20)
        Me.makeTB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Make"
        '
        'boatIDTB
        '
        Me.boatIDTB.Location = New System.Drawing.Point(372, 43)
        Me.boatIDTB.Name = "boatIDTB"
        Me.boatIDTB.Size = New System.Drawing.Size(100, 20)
        Me.boatIDTB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(379, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Boat ID"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.addboatBTN)
        Me.TabPage2.Controls.Add(Me.colorTB2)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.yearTB2)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.modelTB2)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.makeTB2)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.boatIDTB2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(500, 298)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Add New"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'addboatBTN
        '
        Me.addboatBTN.Location = New System.Drawing.Point(379, 246)
        Me.addboatBTN.Name = "addboatBTN"
        Me.addboatBTN.Size = New System.Drawing.Size(75, 23)
        Me.addboatBTN.TabIndex = 10
        Me.addboatBTN.Text = "Add New"
        Me.addboatBTN.UseVisualStyleBackColor = True
        '
        'colorTB2
        '
        Me.colorTB2.Location = New System.Drawing.Point(45, 177)
        Me.colorTB2.Name = "colorTB2"
        Me.colorTB2.Size = New System.Drawing.Size(100, 20)
        Me.colorTB2.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(68, 162)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(31, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Color"
        '
        'yearTB2
        '
        Me.yearTB2.Location = New System.Drawing.Point(45, 133)
        Me.yearTB2.Name = "yearTB2"
        Me.yearTB2.Size = New System.Drawing.Size(100, 20)
        Me.yearTB2.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(65, 117)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Year"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(62, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Model"
        '
        'modelTB2
        '
        Me.modelTB2.Location = New System.Drawing.Point(45, 90)
        Me.modelTB2.Name = "modelTB2"
        Me.modelTB2.Size = New System.Drawing.Size(100, 20)
        Me.modelTB2.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(59, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Make"
        '
        'makeTB2
        '
        Me.makeTB2.Location = New System.Drawing.Point(45, 47)
        Me.makeTB2.Name = "makeTB2"
        Me.makeTB2.Size = New System.Drawing.Size(100, 20)
        Me.makeTB2.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(376, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Boat ID"
        '
        'boatIDTB2
        '
        Me.boatIDTB2.Location = New System.Drawing.Point(361, 47)
        Me.boatIDTB2.Name = "boatIDTB2"
        Me.boatIDTB2.ReadOnly = True
        Me.boatIDTB2.Size = New System.Drawing.Size(100, 20)
        Me.boatIDTB2.TabIndex = 0
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
        'Boat_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Applied_Project.My.Resources.Resources.AppBG
        Me.ClientSize = New System.Drawing.Size(533, 403)
        Me.Controls.Add(Me.menuBTN)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Boat_Info"
        Me.Text = "Boat Info"
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
    Friend WithEvents colorTB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents yearTB As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ModelTB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents makeTB As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents boatIDTB As TextBox
    Friend WithEvents colorTB2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents yearTB2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents modelTB2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents makeTB2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents boatIDTB2 As TextBox
    Friend WithEvents nextBTN As Button
    Friend WithEvents prevBTN As Button
    Friend WithEvents addboatBTN As Button
    Friend WithEvents menuBTN As Button
End Class
