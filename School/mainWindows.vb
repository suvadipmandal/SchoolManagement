Public Class mainWindows

    
    Private Sub Bdataentry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bdataentry.Click
        PMain.Visible = False
        PShow.Visible = False
        PPrint.Visible = False
        PEnter.Visible = True
    End Sub

    Private Sub Bdataprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bdataprint.Click
        PMain.Visible = False
        PPrint.Visible = True
        PEnter.Visible = False
    End Sub

    Private Sub Bhome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bhome.Click
        PMain.Visible = True
        PPrint.Visible = False
        PEnter.Visible = False
    End Sub

    Private Sub mainWindows_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        CbxClass.Items.Add("5th")
        CbxClass.Items.Add("6th")
        CbxClass.Items.Add("7th")
        CbxClass.Items.Add("8th")
        CbxClass.Items.Add("9th")
        CbxClass.Items.Add("10th")
        CbxClass.Items.Add("11th")
        CbxClass.Items.Add("12th")
        CbxInternal.Items.Add("1st Summative")
        CbxInternal.Items.Add("2nd Summative")
        CbxInternal.Items.Add("3rd Summative")
    End Sub

    Private Sub CbxClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbxClass.SelectedIndexChanged
        If CbxClass.Text = "11th" Or CbxClass.Text = "12th" Then
            Lsect.Text = "Stream"
            CbxSec.Items.Clear()
            CbxSec.Items.Add("Arts")
            CbxSec.Items.Add("-----")
        Else
            Lsect.Text = "Section"
            CbxSec.Items.Clear()
            CbxSec.Items.Add("A")
            CbxSec.Items.Add("B")
            CbxSec.Items.Add("C")
            CbxSec.Items.Add("D")
        End If
        If CbxClass.Text = "7th" Or CbxClass.Text = "8th" Then
            Lsub8.Enabled = True
            Tsub8.Enabled = True
            TextBox8.Enabled = True
            Lsub8.Text = "Sanskrit"
        ElseIf CbxClass.Text = "11th" Or CbxClass.Text = "12th" Then
            Lsub8.Enabled = False
            Tsub8.Enabled = False
            TextBox8.Enabled = False
            Lsub7.Enabled = False
            Tsub7.Enabled = False
            TextBox7.Enabled = False
            Lsub3.Text = "Education"
            Lsub4.Text = "Philosophy"
            Lsub5.Text = "Sanskrit"
            Lsub6.Text = "Additional Subject"
        ElseIf CbxClass.Text = "9th" Or CbxClass.Text = "10th" Then
            Lsub8.Enabled = True
            Tsub8.Enabled = True
            TextBox8.Enabled = True
            Lsub8.Text = "Work Education"
        Else
            Lsub8.Enabled = False
            Tsub8.Enabled = False
            TextBox8.Enabled = False
            Lsub7.Enabled = True
            Tsub7.Enabled = True
            TextBox7.Enabled = True
            Lsub6.Text = "Life Science"
        End If
    End Sub

    Private Sub Tsub1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tsub8.Click, Tsub7.Click, Tsub6.Click, Tsub5.Click, Tsub4.Click, Tsub3.Click, Tsub2.Click, Tsub1.Click
        Tsub1.Clear()
        Tsub2.Clear()
        Tsub3.Clear()
        Tsub4.Clear()
        Tsub5.Clear()
        Tsub6.Clear()
        Tsub7.Clear()
        Tsub8.Clear()
    End Sub

    Private Sub Bclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bclear.Click
        Tsub1.Clear()
        Tsub2.Clear()
        Tsub3.Clear()
        Tsub4.Clear()
        Tsub5.Clear()
        Tsub6.Clear()
        Tsub7.Clear()
        Tsub8.Clear()
        CbxClass.Text = "Select"
        CbxSec.Text = "Select"
        CbxInternal.Text = "Select"
        Tfname.Clear()
        Tlname.Clear()
        TRoll.Clear()
        Taddress.Clear()
        Tpin.Clear()
        Tfatname.Clear()
        Tmotname.Clear()
    End Sub
End Class