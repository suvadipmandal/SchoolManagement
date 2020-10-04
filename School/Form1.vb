Public Class Form1
    Dim i, j, k As Integer

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If i < 10 Then
            P1.Location = New Point(P1.Location.X - 1, P1.Location.Y - 1)
            P1.Size = New Size(P1.Size.Height + 2, P1.Size.Width + 2)
            i += 1
        ElseIf P1.Size.Width <= 25 Then
            i = 0
        Else
            P1.Location = New Point(P1.Location.X + 1, P1.Location.Y + 1)
            P1.Size = New Size(P1.Size.Height - 2, P1.Size.Width - 2)
            i += 1
        End If
        If P1.Size.Width = 43 And Timer2.Enabled = False Then
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If j < 10 Then
            P2.Location = New Point(P2.Location.X - 1, P2.Location.Y - 1)
            P2.Size = New Size(P2.Size.Height + 2, P2.Size.Width + 2)
            j += 1
        ElseIf P2.Size.Width <= 25 Then
            j = 0
        Else
            P2.Location = New Point(P2.Location.X + 1, P2.Location.Y + 1)
            P2.Size = New Size(P2.Size.Height - 2, P2.Size.Width - 2)
        End If
        If P2.Size.Width = 43 And Timer3.Enabled = False Then
            Timer3.Start()
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If k < 10 Then
            P3.Location = New Point(P3.Location.X - 1, P3.Location.Y - 1)
            P3.Size = New Size(P3.Size.Height + 2, P3.Size.Width + 2)
            k += 1
        ElseIf P3.Size.Width <= 25 Then
            k = 0
        Else
            P3.Location = New Point(P3.Location.X + 1, P3.Location.Y + 1)
            P3.Size = New Size(P3.Size.Height - 2, P3.Size.Width - 2)
        End If
    End Sub
End Class
