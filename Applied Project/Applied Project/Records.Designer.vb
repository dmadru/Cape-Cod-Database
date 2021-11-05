<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Records
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
        Me.RecordView = New System.Windows.Forms.DataGridView()
        Me.parkingBTN = New System.Windows.Forms.Button()
        Me.BoatregBTN = New System.Windows.Forms.Button()
        Me.boatLicensesBTN = New System.Windows.Forms.Button()
        Me.boatinfoBTN = New System.Windows.Forms.Button()
        Me.resBTN = New System.Windows.Forms.Button()
        Me.fishingBTN = New System.Windows.Forms.Button()
        Me.menuBTN = New System.Windows.Forms.Button()
        CType(Me.RecordView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RecordView
        '
        Me.RecordView.AllowUserToAddRows = False
        Me.RecordView.AllowUserToDeleteRows = False
        Me.RecordView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RecordView.Location = New System.Drawing.Point(12, 12)
        Me.RecordView.Name = "RecordView"
        Me.RecordView.ReadOnly = True
        Me.RecordView.Size = New System.Drawing.Size(745, 365)
        Me.RecordView.TabIndex = 0
        '
        'parkingBTN
        '
        Me.parkingBTN.Location = New System.Drawing.Point(21, 394)
        Me.parkingBTN.Name = "parkingBTN"
        Me.parkingBTN.Size = New System.Drawing.Size(102, 23)
        Me.parkingBTN.TabIndex = 1
        Me.parkingBTN.Text = "Parking Permits"
        Me.parkingBTN.UseVisualStyleBackColor = True
        '
        'BoatregBTN
        '
        Me.BoatregBTN.Location = New System.Drawing.Point(129, 394)
        Me.BoatregBTN.Name = "BoatregBTN"
        Me.BoatregBTN.Size = New System.Drawing.Size(102, 23)
        Me.BoatregBTN.TabIndex = 2
        Me.BoatregBTN.Text = "Boat Registrations"
        Me.BoatregBTN.UseVisualStyleBackColor = True
        '
        'boatLicensesBTN
        '
        Me.boatLicensesBTN.Location = New System.Drawing.Point(237, 394)
        Me.boatLicensesBTN.Name = "boatLicensesBTN"
        Me.boatLicensesBTN.Size = New System.Drawing.Size(102, 23)
        Me.boatLicensesBTN.TabIndex = 3
        Me.boatLicensesBTN.Text = "Boat Licenses"
        Me.boatLicensesBTN.UseVisualStyleBackColor = True
        '
        'boatinfoBTN
        '
        Me.boatinfoBTN.Location = New System.Drawing.Point(345, 394)
        Me.boatinfoBTN.Name = "boatinfoBTN"
        Me.boatinfoBTN.Size = New System.Drawing.Size(102, 23)
        Me.boatinfoBTN.TabIndex = 4
        Me.boatinfoBTN.Text = "Boat Information"
        Me.boatinfoBTN.UseVisualStyleBackColor = True
        '
        'resBTN
        '
        Me.resBTN.Location = New System.Drawing.Point(561, 394)
        Me.resBTN.Name = "resBTN"
        Me.resBTN.Size = New System.Drawing.Size(119, 23)
        Me.resBTN.TabIndex = 5
        Me.resBTN.Text = "Residents Information"
        Me.resBTN.UseVisualStyleBackColor = True
        '
        'fishingBTN
        '
        Me.fishingBTN.Location = New System.Drawing.Point(453, 394)
        Me.fishingBTN.Name = "fishingBTN"
        Me.fishingBTN.Size = New System.Drawing.Size(102, 23)
        Me.fishingBTN.TabIndex = 6
        Me.fishingBTN.Text = "Fishing Licenses"
        Me.fishingBTN.UseVisualStyleBackColor = True
        '
        'menuBTN
        '
        Me.menuBTN.Location = New System.Drawing.Point(354, 423)
        Me.menuBTN.Name = "menuBTN"
        Me.menuBTN.Size = New System.Drawing.Size(75, 23)
        Me.menuBTN.TabIndex = 7
        Me.menuBTN.Text = "Main Menu"
        Me.menuBTN.UseVisualStyleBackColor = True
        '
        'Records
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Applied_Project.My.Resources.Resources.AppBG
        Me.ClientSize = New System.Drawing.Size(769, 455)
        Me.Controls.Add(Me.menuBTN)
        Me.Controls.Add(Me.fishingBTN)
        Me.Controls.Add(Me.resBTN)
        Me.Controls.Add(Me.boatinfoBTN)
        Me.Controls.Add(Me.boatLicensesBTN)
        Me.Controls.Add(Me.BoatregBTN)
        Me.Controls.Add(Me.parkingBTN)
        Me.Controls.Add(Me.RecordView)
        Me.Name = "Records"
        Me.Text = "Records"
        CType(Me.RecordView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RecordView As DataGridView
    Friend WithEvents parkingBTN As Button
    Friend WithEvents BoatregBTN As Button
    Friend WithEvents boatLicensesBTN As Button
    Friend WithEvents boatinfoBTN As Button
    Friend WithEvents resBTN As Button
    Friend WithEvents fishingBTN As Button
    Friend WithEvents menuBTN As Button
End Class
