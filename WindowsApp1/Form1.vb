Public Class Form1
    Dim ValueChronoMinute As Integer = 0
    Dim ValueChronoSeconde As Integer = 0
    Dim ValueChronoC1 As Integer = 0
    Dim ValueChronoC2 As Integer = 0
    Private Sub startButton_Click(sender As Object, e As EventArgs) Handles startButton.Click

        If fighterOneChamp.Text = vbNullString Then
            erreur1.Visible = True
        Else
            erreur1.Visible = False
        End If
        If fighterTwoChamp.Text = vbNullString Then
            erreur2.Visible = True
        Else
            erreur2.Visible = False
        End If
        If choixTemps.Text = vbNullString Then
            erreur3.Visible = True
        Else
            erreur3.Visible = False
        End If
        If erreur1.Visible = False And erreur2.Visible = False And erreur3.Visible = False Then
            fighterOneChamp.Visible = False
            fighterTwoChamp.Visible = False
            choixTemps.Visible = False
            fighterOne.Text = fighterOneChamp.Text
            fighterTwo.Text = fighterTwoChamp.Text
            ValueChronoMinute = choixTemps.Text()
            fighterOne.Visible = True
            fighterTwo.Visible = True
            chronoMinutes.Visible = True
            chronoSecondes.Visible() = True
            wazariButtonC1.Visible() = True
            yukoButtonC1.Visible() = True
            osaekomiButtonC1.Visible() = True
            ipponButtonC1.Visible() = True
            wazariButtonC2.Visible() = True
            yukoButtonC2.Visible() = True
            osaekomiButtonC2.Visible() = True
            ipponButtonC2.Visible() = True
            hajimeButton.Visible() = True
            startButton.Visible() = False
            chronoC1.Visible() = True
            chronoC2.Visible() = True
            Label5.Visible() = True
            Label8.Visible() = True
            Label9.Visible() = True
            Label10.Visible() = True
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ValueChronoMinute > 0 Or ValueChronoSeconde <> 0 Then
            If ValueChronoSeconde = 0 Then
                ValueChronoMinute += -1
                ValueChronoSeconde = 60
            End If
            ValueChronoSeconde += -1
            chronoMinutes.Text() = ValueChronoMinute
            chronoSecondes.Text() = ValueChronoSeconde
        ElseIf ValueChronoMinute = 0 And ValueChronoSeconde = 0 Then
            Timer1.Stop()
            ValueChronoMinute = 0
            ValueChronoSeconde = 0
            chronoMinutes.Text() = ValueChronoMinute
            chronoSecondes.Text() = ValueChronoSeconde
            If wazariPointC1.Text() > wazariPointC2.Text() Then
                MsgBox(fighterOne.Text() + " a gagné avec " + ipponPointC1.Text() + " Ippon, " + wazariPointC1.Text() + " Wazari et " + yukoPointC1().Text() + " Yuko !")
            ElseIf wazariPointC2.Text() > wazariPointC1.Text() Then
                MsgBox(fighterTwo.Text() + " a gagné avec " + ipponPointC2.Text() + " Ippon, " + wazariPointC2.Text() + " Wazari et " + yukoPointC2().Text() + " Yuko !")
            ElseIf wazariPointC1.Text() = wazariPointC2.Text() Then
                If yukoPointC1.Text() > yukoPointC2.Text() Then
                    MsgBox(fighterOne.Text() + " a gagné avec " + ipponPointC1.Text() + " Ippon, " + wazariPointC1.Text() + " Wazari et " + yukoPointC1().Text() + " Yuko !")
                ElseIf yukoPointC2.Text() > yukoPointC1.Text() Then
                    MsgBox(fighterTwo.Text() + " a gagné avec " + ipponPointC2.Text() + " Ippon, " + wazariPointC2.Text() + " Wazari et " + yukoPointC2().Text() + " Yuko !")
                ElseIf yukoPointC1.Text() = yukoPointC2.Text() Then
                    MsgBox("HIKIWAKE ! " + fighterOne.Text() + " et " + fighterTwo.Text() + " sont à égalité avec " + ipponPointC2.Text() + " Ippon, " + wazariPointC2.Text() + " Wazari et " + yukoPointC2().Text() + " Yuko !")
                End If
            End If
        End If
        If wazariPointC1.Text() = 2 Then
            ipponPointC1.Text() += 1
        End If
        If wazariPointC2.Text() = 2 Then
            ipponPointC2.Text() += 1
        End If
        If ipponPointC1.Text() > 0 Then
            Timer1.Stop()
            MsgBox(fighterOne.Text() + " a gagné avec " + ipponPointC1.Text() + " Ippon, " + wazariPointC1.Text() + " Wazari et " + yukoPointC1().Text() + " Yuko !")
        ElseIf ipponPointC2.Text() > 0 Then
            Timer1.Stop()
            MsgBox(fighterTwo.Text() + " a gagné avec " + ipponPointC2.Text() + " Ippon, " + wazariPointC2.Text() + " Wazari et " + yukoPointC2().Text() + " Yuko !")
        End If
    End Sub

    Private Sub ipponButtonC1_Click(sender As Object, e As EventArgs) Handles ipponButtonC1.Click
        ipponPointC1.Text() += 1
    End Sub

    Private Sub osaekomiButtonC1_Click(sender As Object, e As EventArgs) Handles osaekomiButtonC1.Click
        TimerC1.Start()
    End Sub

    Private Sub TimerC1_Tick(sender As Object, e As EventArgs) Handles TimerC1.Tick
        If ValueChronoC1 < 24 Then
            ValueChronoC1 = ValueChronoC1 + 1
            chronoC1.Text = ValueChronoC1
        Else
            TimerC1.Stop()
            ipponPointC1.Text() += 1
            ValueChronoC1 = 0
            chronoC1.Text() = ValueChronoC1
        End If
    End Sub

    Private Sub toketaButton_Click(sender As Object, e As EventArgs) Handles toketaButton.Click
        TimerC1.Stop()
        TimerC2.Stop()
        If ValueChronoC1 >= 20 And ValueChronoC1 <= 24 Then
            wazariPointC1.Text() += 1
        ElseIf ValueChronoC1 >= 15 And ValueChronoC1 <= 19 Then
            yukoPointC1.Text() += 1
        End If
        If ValueChronoC2 >= 20 And ValueChronoC2 <= 24 Then
            wazariPointC2.Text() += 1
        ElseIf ValueChronoC2 >= 15 And ValueChronoC2 <= 19 Then
            yukoPointC2.Text() += 1
        End If
        ValueChronoC1 = 0
        ValueChronoC2 = 0
        chronoC1.Text() = ValueChronoC1
        chronoC2.Text() = ValueChronoC2
    End Sub

    Private Sub wazariButtonC1_Click(sender As Object, e As EventArgs) Handles wazariButtonC1.Click
        wazariPointC1.Text() += 1
    End Sub

    Private Sub yukoButtonC1_Click(sender As Object, e As EventArgs) Handles yukoButtonC1.Click
        yukoPointC1.Text() += 1
    End Sub

    Private Sub ipponButtonC2_Click(sender As Object, e As EventArgs) Handles ipponButtonC2.Click
        ipponPointC2.Text() += 1
    End Sub

    Private Sub wazariButtonC2_Click(sender As Object, e As EventArgs) Handles wazariButtonC2.Click
        wazariPointC2.Text() += 1
    End Sub

    Private Sub yukoButtonC2_Click(sender As Object, e As EventArgs) Handles yukoButtonC2.Click
        yukoPointC2.Text() += 1
    End Sub

    Private Sub osaekomiButtonC2_Click(sender As Object, e As EventArgs) Handles osaekomiButtonC2.Click
        TimerC2.Start()
    End Sub

    Private Sub TimerC2_Tick(sender As Object, e As EventArgs) Handles TimerC2.Tick
        If ValueChronoC2 < 24 Then
            ValueChronoC2 = ValueChronoC2 + 1
            chronoC2.Text = ValueChronoC2
        Else
            TimerC2.Stop()
            ipponPointC2.Text() += 1
            ValueChronoC2 = 0
            chronoC2.Text() = ValueChronoC2
        End If
    End Sub

    Private Sub matteButton_Click(sender As Object, e As EventArgs) Handles matteButton.Click
        Timer1.Stop()
    End Sub

    Private Sub quitterButton_Click(sender As Object, e As EventArgs) Handles quitterButton.Click
        Me.Close()
    End Sub

    Private Sub hajimeButton_Click(sender As Object, e As EventArgs) Handles hajimeButton.Click
        Timer1.Start()
    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        fighterOneChamp.Visible = True
        fighterTwoChamp.Visible = True
        choixTemps.Visible = True
        fighterOne.Text = Nothing
        fighterTwo.Text = Nothing
        ValueChronoMinute = 0
        ValueChronoSeconde = 0
        fighterOne.Visible = False
        fighterTwo.Visible = False
        chronoMinutes.Visible = False
        chronoSecondes.Visible() = False
        wazariButtonC1.Visible() = False
        yukoButtonC1.Visible() = False
        osaekomiButtonC1.Visible() = False
        ipponButtonC1.Visible() = False
        wazariButtonC2.Visible() = False
        yukoButtonC2.Visible() = False
        osaekomiButtonC2.Visible() = False
        ipponButtonC2.Visible() = False
        hajimeButton.Visible() = False
        startButton.Visible() = True
        chronoC1.Visible() = False
        chronoC2.Visible() = False
        Label5.Visible() = False
        Label8.Visible() = False
        Label9.Visible() = False
        Label10.Visible() = False

        Timer1.Stop()
        TimerC1.Stop()
        TimerC2.Stop()
        ValueChronoC1 = 0
        ValueChronoC2 = 0
        chronoMinutes.Text() = ValueChronoMinute
        chronoSecondes.Text() = ValueChronoSeconde
        chronoC1.Text() = ValueChronoC1
        chronoC2.Text() = ValueChronoC2
        ipponPointC1.Text() = 0
        wazariPointC1.Text() = 0
        yukoPointC1.Text() = 0
        ipponPointC2.Text() = 0
        wazariPointC2.Text() = 0
        yukoPointC2.Text() = 0

    End Sub
End Class
