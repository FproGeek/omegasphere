Public Class Form1

    Private Sub FlatClose1_Click(sender As Object, e As EventArgs) Handles FlatClose1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Process.Start("C:\Omegasphere\Ressources\Payload\sxos\OmegaSphere-sxos.bat")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Process.Start("C:\Omegasphere\Ressources\Payload\hekate\OmegaSphere-hekate.bat")
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Process.Start("C:\Omegasphere\Ressources\Payload\reinx\OmegaSphere-reinx.bat")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("C:\Omegasphere\Ressources\Payload\atmosphere\OmegaSphere-atmosphere.bat")
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        Process.Start("C:\Omegasphere\Ressources\Logiciel\hacdiskmount\HacDiskMount.exe")
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Process.Start("C:\Omegasphere\Ressources\Logiciel\nscb\ztools\")
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        Process.Start("C:\Omegasphere\Ressources\Logiciel\nscb\NSCB.bat")
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Process.Start("C:\Omegasphere\Ressources\Logiciel\tegrarcmgui\TegraRcmGUI.exe")
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Process.Start("C:\Omegasphere\Ressources\Logiciel\fluffy\fluffy.exe")
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Process.Start("C:\Omegasphere\Ressources\Logiciel\memloader")
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        Process.Start("C:\Omegasphere\Ressources\Homebrew\choixdujour.exe")
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        Process.Start("C:\Omegasphere\Ressources\Homebrew\goldleaf.exe")
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        Process.Start("C:\Omegasphere\Ressources\Homebrew\tinfoil.exe")
    End Sub
End Class
