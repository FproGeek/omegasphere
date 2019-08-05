Public Class Form1

    Private Sub FlatClose1_Click(sender As Object, e As EventArgs) Handles FlatClose1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If My.Computer.FileSystem.FileExists("C:\Omegasphere\Ressources\Payload\sxos\OmegaSphere-sxos.bat") Then
            Process.Start("C:\Omegasphere\Ressources\Payload\sxos\OmegaSphere-sxos.bat")
        Else
            MsgBox("ERREUR : Le fichier est introuvable")
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        If My.Computer.FileSystem.FileExists("C:\Omegasphere\Ressources\Payload\hekate\OmegaSphere-hekate.bat") Then
            Process.Start("C:\Omegasphere\Ressources\Payload\hekate\OmegaSphere-hekate.bat")
        Else
            MsgBox("ERREUR : Le fichier est introuvable")
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If My.Computer.FileSystem.FileExists("C:\Omegasphere\Ressources\Payload\reinx\OmegaSphere-reinx.bat") Then
            Process.Start("C:\Omegasphere\Ressources\Payload\reinx\OmegaSphere-reinx.bat")
        Else
            MsgBox("ERREUR : Le fichier est introuvable")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If My.Computer.FileSystem.FileExists("C:\Omegasphere\Ressources\Payload\atmosphere\OmegaSphere-atmosphere.bat") Then
            Process.Start("C:\Omegasphere\Ressources\Payload\atmosphere\OmegaSphere-atmosphere.bat")
        Else
            MsgBox("ERREUR : Le fichier est introuvable")
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If System.Environment.Is64BitOperatingSystem <> True Then
            MsgBox("ERREUR : Le programme requiert 64 bits")
        ElseIf My.Computer.FileSystem.FileExists("C:\Omegasphere\Ressources\Logiciel\hacdiskmount\HacDiskMount.exe") Then
            Process.Start("C:\Omegasphere\Ressources\Logiciel\hacdiskmount\HacDiskMount.exe")
        Else
            MsgBox("ERREUR : Le fichier est introuvable")
        End If
    End Sub

    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click
        Process.Start("C:\Omegasphere\Ressources\Logiciel\nscb\ztools\")
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        If My.Computer.FileSystem.FileExists("C:\Omegasphere\Ressources\Logiciel\nscb\NSCB.bat") Then
            Process.Start("C:\Omegasphere\Ressources\Logiciel\nscb\NSCB.bat")
        Else
            MsgBox("ERREUR : Le fichier est introuvable")
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If My.Computer.FileSystem.FileExists("C:\Omegasphere\Ressources\Logiciel\tegrarcmgui\TegraRcmGUI.exe") Then
            Process.Start("C:\Omegasphere\Ressources\Logiciel\tegrarcmgui\TegraRcmGUI.exe")
        Else
            MsgBox("ERREUR : Le fichier est introuvable")
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        If My.Computer.FileSystem.FileExists("C:\Omegasphere\Ressources\Logiciel\fluffy\fluffy.exe") Then
            Process.Start("C:\Omegasphere\Ressources\Logiciel\fluffy\fluffy.exe")
        Else
            MsgBox("ERREUR : Le fichier est introuvable")
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        Process.Start("C:\Omegasphere\Ressources\Logiciel\memloader")
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If My.Computer.FileSystem.FileExists("C:\Omegasphere\Ressources\Homebrew\choixdujour.exe") Then
            Process.Start("C:\Omegasphere\Ressources\Homebrew\choixdujour.exe")
        Else
            MsgBox("ERREUR : Le fichier est introuvable")
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        If My.Computer.FileSystem.FileExists("C:\Omegasphere\Ressources\Homebrew\goldleaf.exe") Then
            Process.Start("C:\Omegasphere\Ressources\Homebrew\goldleaf.exe")
        Else
            MsgBox("ERREUR : Le fichier est introuvable")
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        If My.Computer.FileSystem.FileExists("C:\Omegasphere\Ressources\Homebrew\tinfoil.exe") Then
            Process.Start("C:\Omegasphere\Ressources\Homebrew\tinfoil.exe")
        Else
            MsgBox("ERREUR : Le fichier est introuvable")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        Dim dossier As String = Application.StartupPath & "\version.txt"
        If Dir(dossier, FileAttribute.Normal) <> "" Then
            Kill(dossier)
        End If
        My.Computer.Network.DownloadFile("https://fprogeek.yj.fr/omegasphere/Mise%20a%20jour.txt?=" & Rnd(404), dossier)
        Dim sr As New IO.StreamReader(dossier)
        Dim contenu As String = sr.ReadLine
        sr.Close()
        If contenu <> Application.ProductVersion Then
            MsgBox("Une nouvelle mise à jour est disponible ! (" & contenu & ")")
            MsgBox("Une fois le fichier de mise a jour télechargé et installé, relancer OmegaSphere.", MsgBoxStyle.Information, Process.Start("https://github.com/FproGeek/omegasphere/releases/tag/4.0.5"))
        Else
            MsgBox("OmegaSphere est à jour (" & contenu & ")")
        End If
    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        If My.Computer.FileSystem.FileExists("C:\Omegasphere\Ressources\Logiciel\switchthemeinjector\SwitchThemes.exe") Then
            Process.Start("C:\Omegasphere\Ressources\Logiciel\switchthemeinjector\SwitchThemes.exe")
        Else
            MsgBox("ERREUR : Le fichier est introuvable")
        End If
    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        If My.Computer.FileSystem.FileExists("C:\Omegasphere\Ressources\Homebrew\NxThemesinstaller.exe") Then
            Process.Start("C:\Omegasphere\Ressources\Homebrew\NxThemesinstaller.exe")
        Else
            MsgBox("ERREUR : Le fichier est introuvable")
        End If
    End Sub

    Private Sub Omegasphere_Click(sender As Object, e As EventArgs) Handles Omegasphere.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
