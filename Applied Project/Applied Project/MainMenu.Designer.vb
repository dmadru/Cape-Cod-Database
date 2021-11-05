<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
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
        Me.permitBTN = New System.Windows.Forms.Button()
        Me.fishingBTN = New System.Windows.Forms.Button()
        Me.boatBTN = New System.Windows.Forms.Button()
        Me.boatInfoBTN = New System.Windows.Forms.Button()
        Me.boatLicenseBTN = New System.Windows.Forms.Button()
        Me.userBTN = New System.Windows.Forms.Button()
        Me.RecordsBTN = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'permitBTN
        '
        Me.permitBTN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.permitBTN.Location = New System.Drawing.Point(36, 250)
        Me.permitBTN.Name = "permitBTN"
        Me.permitBTN.Size = New System.Drawing.Size(110, 23)
        Me.permitBTN.TabIndex = 0
        Me.permitBTN.Text = "Parking Permits"
        Me.permitBTN.UseVisualStyleBackColor = True
        '
        'fishingBTN
        '
        Me.fishingBTN.Location = New System.Drawing.Point(208, 250)
        Me.fishingBTN.Name = "fishingBTN"
        Me.fishingBTN.Size = New System.Drawing.Size(110, 23)
        Me.fishingBTN.TabIndex = 1
        Me.fishingBTN.Text = "Fishing Licenses"
        Me.fishingBTN.UseVisualStyleBackColor = True
        '
        'boatBTN
        '
        Me.boatBTN.Location = New System.Drawing.Point(384, 250)
        Me.boatBTN.Name = "boatBTN"
        Me.boatBTN.Size = New System.Drawing.Size(110, 23)
        Me.boatBTN.TabIndex = 2
        Me.boatBTN.Text = "Boat Registrations"
        Me.boatBTN.UseVisualStyleBackColor = True
        '
        'boatInfoBTN
        '
        Me.boatInfoBTN.Location = New System.Drawing.Point(36, 305)
        Me.boatInfoBTN.Name = "boatInfoBTN"
        Me.boatInfoBTN.Size = New System.Drawing.Size(110, 23)
        Me.boatInfoBTN.TabIndex = 3
        Me.boatInfoBTN.Text = "Boat Info"
        Me.boatInfoBTN.UseVisualStyleBackColor = True
        '
        'boatLicenseBTN
        '
        Me.boatLicenseBTN.Location = New System.Drawing.Point(208, 305)
        Me.boatLicenseBTN.Name = "boatLicenseBTN"
        Me.boatLicenseBTN.Size = New System.Drawing.Size(110, 23)
        Me.boatLicenseBTN.TabIndex = 4
        Me.boatLicenseBTN.Text = "Boat Licenses"
        Me.boatLicenseBTN.UseVisualStyleBackColor = True
        '
        'userBTN
        '
        Me.userBTN.Location = New System.Drawing.Point(384, 305)
        Me.userBTN.Name = "userBTN"
        Me.userBTN.Size = New System.Drawing.Size(110, 23)
        Me.userBTN.TabIndex = 5
        Me.userBTN.Text = "Users"
        Me.userBTN.UseVisualStyleBackColor = True
        '
        'RecordsBTN
        '
        Me.RecordsBTN.Location = New System.Drawing.Point(208, 360)
        Me.RecordsBTN.Name = "RecordsBTN"
        Me.RecordsBTN.Size = New System.Drawing.Size(110, 23)
        Me.RecordsBTN.TabIndex = 6
        Me.RecordsBTN.Text = "View Records"
        Me.RecordsBTN.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Applied_Project.My.Resources.Resources.AppBG2
        Me.ClientSize = New System.Drawing.Size(533, 403)
        Me.Controls.Add(Me.RecordsBTN)
        Me.Controls.Add(Me.userBTN)
        Me.Controls.Add(Me.boatLicenseBTN)
        Me.Controls.Add(Me.boatInfoBTN)
        Me.Controls.Add(Me.boatBTN)
        Me.Controls.Add(Me.fishingBTN)
        Me.Controls.Add(Me.permitBTN)
        Me.Name = "MainMenu"
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents permitBTN As Button
    Friend WithEvents fishingBTN As Button
    Friend WithEvents boatBTN As Button
    Friend WithEvents boatInfoBTN As Button
    Friend WithEvents boatLicenseBTN As Button
    Friend WithEvents userBTN As Button
    Friend WithEvents RecordsBTN As Button
End Class
