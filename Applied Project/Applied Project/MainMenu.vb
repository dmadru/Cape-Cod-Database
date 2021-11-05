Public Class MainMenu
    Private Sub permitBTN_Click(sender As Object, e As EventArgs) Handles permitBTN.Click
        Me.Hide()
        ParkingPermits.Show()

    End Sub

    Private Sub fishingBTN_Click(sender As Object, e As EventArgs) Handles fishingBTN.Click
        Me.Hide()
        FishingLicenses.Show()

    End Sub

    Private Sub boatBTN_Click(sender As Object, e As EventArgs) Handles boatBTN.Click
        Me.Hide()
        Boat_Registration.Show()
    End Sub

    Private Sub boatInfoBTN_Click(sender As Object, e As EventArgs) Handles boatInfoBTN.Click
        Me.Hide()
        Boat_Info.Show()
    End Sub

    Private Sub boatLicenseBTN_Click(sender As Object, e As EventArgs) Handles boatLicenseBTN.Click
        Me.Hide()
        BoatLicenses.Show()
    End Sub

    Private Sub userBTN_Click(sender As Object, e As EventArgs) Handles userBTN.Click
        Me.Hide()
        Users.Show()
    End Sub

    Private Sub RecordsBTN_Click(sender As Object, e As EventArgs) Handles RecordsBTN.Click
        Me.Hide()
        Records.Show()
    End Sub
End Class