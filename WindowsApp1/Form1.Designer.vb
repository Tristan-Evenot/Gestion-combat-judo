<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.startButton = New System.Windows.Forms.Button()
        Me.fighterOne = New System.Windows.Forms.Label()
        Me.fighterTwo = New System.Windows.Forms.Label()
        Me.chronoMinutes = New System.Windows.Forms.Label()
        Me.fighterOneChamp = New System.Windows.Forms.TextBox()
        Me.fighterTwoChamp = New System.Windows.Forms.TextBox()
        Me.erreur1 = New System.Windows.Forms.Label()
        Me.erreur2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.choixTemps = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.yukoPointC1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ipponPointC1 = New System.Windows.Forms.Label()
        Me.wazariPointC1 = New System.Windows.Forms.Label()
        Me.wazariPointC2 = New System.Windows.Forms.Label()
        Me.ipponPointC2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.yukoPointC2 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.yukoButtonC1 = New System.Windows.Forms.Button()
        Me.osaekomiButtonC1 = New System.Windows.Forms.Button()
        Me.wazariButtonC1 = New System.Windows.Forms.Button()
        Me.ipponButtonC1 = New System.Windows.Forms.Button()
        Me.ipponButtonC2 = New System.Windows.Forms.Button()
        Me.wazariButtonC2 = New System.Windows.Forms.Button()
        Me.osaekomiButtonC2 = New System.Windows.Forms.Button()
        Me.yukoButtonC2 = New System.Windows.Forms.Button()
        Me.toketaButton = New System.Windows.Forms.Button()
        Me.matteButton = New System.Windows.Forms.Button()
        Me.quitterButton = New System.Windows.Forms.Button()
        Me.erreur3 = New System.Windows.Forms.Label()
        Me.TimerC1 = New System.Windows.Forms.Timer(Me.components)
        Me.TimerC2 = New System.Windows.Forms.Timer(Me.components)
        Me.chronoC1 = New System.Windows.Forms.Label()
        Me.chronoC2 = New System.Windows.Forms.Label()
        Me.hajimeButton = New System.Windows.Forms.Button()
        Me.resetButton = New System.Windows.Forms.Button()
        Me.chronoSecondes = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'startButton
        '
        Me.startButton.Location = New System.Drawing.Point(328, 209)
        Me.startButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(121, 48)
        Me.startButton.TabIndex = 0
        Me.startButton.Text = "Start"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'fighterOne
        '
        Me.fighterOne.AutoSize = True
        Me.fighterOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fighterOne.Location = New System.Drawing.Point(13, 43)
        Me.fighterOne.Name = "fighterOne"
        Me.fighterOne.Size = New System.Drawing.Size(71, 25)
        Me.fighterOne.TabIndex = 1
        Me.fighterOne.Text = "Label1"
        Me.fighterOne.Visible = False
        '
        'fighterTwo
        '
        Me.fighterTwo.AutoSize = True
        Me.fighterTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fighterTwo.Location = New System.Drawing.Point(596, 48)
        Me.fighterTwo.Name = "fighterTwo"
        Me.fighterTwo.Size = New System.Drawing.Size(71, 25)
        Me.fighterTwo.TabIndex = 2
        Me.fighterTwo.Text = "Label2"
        Me.fighterTwo.Visible = False
        '
        'chronoMinutes
        '
        Me.chronoMinutes.AutoSize = True
        Me.chronoMinutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chronoMinutes.Location = New System.Drawing.Point(347, 167)
        Me.chronoMinutes.Name = "chronoMinutes"
        Me.chronoMinutes.Size = New System.Drawing.Size(26, 29)
        Me.chronoMinutes.TabIndex = 3
        Me.chronoMinutes.Text = "0"
        Me.chronoMinutes.Visible = False
        '
        'fighterOneChamp
        '
        Me.fighterOneChamp.Location = New System.Drawing.Point(19, 48)
        Me.fighterOneChamp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fighterOneChamp.Name = "fighterOneChamp"
        Me.fighterOneChamp.Size = New System.Drawing.Size(100, 22)
        Me.fighterOneChamp.TabIndex = 4
        '
        'fighterTwoChamp
        '
        Me.fighterTwoChamp.Location = New System.Drawing.Point(600, 49)
        Me.fighterTwoChamp.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fighterTwoChamp.Name = "fighterTwoChamp"
        Me.fighterTwoChamp.Size = New System.Drawing.Size(100, 22)
        Me.fighterTwoChamp.TabIndex = 5
        '
        'erreur1
        '
        Me.erreur1.AutoSize = True
        Me.erreur1.ForeColor = System.Drawing.Color.Red
        Me.erreur1.Location = New System.Drawing.Point(16, 68)
        Me.erreur1.Name = "erreur1"
        Me.erreur1.Size = New System.Drawing.Size(169, 17)
        Me.erreur1.TabIndex = 6
        Me.erreur1.Text = "Veuillez remplir ce champ"
        Me.erreur1.Visible = False
        '
        'erreur2
        '
        Me.erreur2.AutoSize = True
        Me.erreur2.ForeColor = System.Drawing.Color.Red
        Me.erreur2.Location = New System.Drawing.Point(597, 71)
        Me.erreur2.Name = "erreur2"
        Me.erreur2.Size = New System.Drawing.Size(169, 17)
        Me.erreur2.TabIndex = 7
        Me.erreur2.Text = "Veuillez remplir ce champ"
        Me.erreur2.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'choixTemps
        '
        Me.choixTemps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.choixTemps.FormattingEnabled = True
        Me.choixTemps.Items.AddRange(New Object() {"2", "3", "4", "5"})
        Me.choixTemps.Location = New System.Drawing.Point(333, 169)
        Me.choixTemps.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.choixTemps.Name = "choixTemps"
        Me.choixTemps.Size = New System.Drawing.Size(121, 24)
        Me.choixTemps.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 32)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Combattant 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(595, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(185, 32)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Combattant 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(327, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 32)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Chrono :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 29)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Y"
        '
        'yukoPointC1
        '
        Me.yukoPointC1.AutoSize = True
        Me.yukoPointC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yukoPointC1.Location = New System.Drawing.Point(19, 149)
        Me.yukoPointC1.Name = "yukoPointC1"
        Me.yukoPointC1.Size = New System.Drawing.Size(26, 29)
        Me.yukoPointC1.TabIndex = 13
        Me.yukoPointC1.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(133, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 29)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "I"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(75, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 29)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "W"
        '
        'ipponPointC1
        '
        Me.ipponPointC1.AutoSize = True
        Me.ipponPointC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ipponPointC1.Location = New System.Drawing.Point(133, 149)
        Me.ipponPointC1.Name = "ipponPointC1"
        Me.ipponPointC1.Size = New System.Drawing.Size(26, 29)
        Me.ipponPointC1.TabIndex = 16
        Me.ipponPointC1.Text = "0"
        '
        'wazariPointC1
        '
        Me.wazariPointC1.AutoSize = True
        Me.wazariPointC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wazariPointC1.Location = New System.Drawing.Point(75, 149)
        Me.wazariPointC1.Name = "wazariPointC1"
        Me.wazariPointC1.Size = New System.Drawing.Size(26, 29)
        Me.wazariPointC1.TabIndex = 17
        Me.wazariPointC1.Text = "0"
        '
        'wazariPointC2
        '
        Me.wazariPointC2.AutoSize = True
        Me.wazariPointC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wazariPointC2.Location = New System.Drawing.Point(665, 149)
        Me.wazariPointC2.Name = "wazariPointC2"
        Me.wazariPointC2.Size = New System.Drawing.Size(26, 29)
        Me.wazariPointC2.TabIndex = 23
        Me.wazariPointC2.Text = "0"
        '
        'ipponPointC2
        '
        Me.ipponPointC2.AutoSize = True
        Me.ipponPointC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ipponPointC2.Location = New System.Drawing.Point(725, 149)
        Me.ipponPointC2.Name = "ipponPointC2"
        Me.ipponPointC2.Size = New System.Drawing.Size(26, 29)
        Me.ipponPointC2.TabIndex = 22
        Me.ipponPointC2.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(665, 102)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 29)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "W"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(725, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 29)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "I"
        '
        'yukoPointC2
        '
        Me.yukoPointC2.AutoSize = True
        Me.yukoPointC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yukoPointC2.Location = New System.Drawing.Point(611, 149)
        Me.yukoPointC2.Name = "yukoPointC2"
        Me.yukoPointC2.Size = New System.Drawing.Size(26, 29)
        Me.yukoPointC2.TabIndex = 19
        Me.yukoPointC2.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(611, 102)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 29)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Y"
        '
        'yukoButtonC1
        '
        Me.yukoButtonC1.Location = New System.Drawing.Point(24, 233)
        Me.yukoButtonC1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.yukoButtonC1.Name = "yukoButtonC1"
        Me.yukoButtonC1.Size = New System.Drawing.Size(136, 34)
        Me.yukoButtonC1.TabIndex = 24
        Me.yukoButtonC1.Text = "YUKO"
        Me.yukoButtonC1.UseVisualStyleBackColor = True
        Me.yukoButtonC1.Visible = False
        '
        'osaekomiButtonC1
        '
        Me.osaekomiButtonC1.Location = New System.Drawing.Point(24, 274)
        Me.osaekomiButtonC1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.osaekomiButtonC1.Name = "osaekomiButtonC1"
        Me.osaekomiButtonC1.Size = New System.Drawing.Size(136, 34)
        Me.osaekomiButtonC1.TabIndex = 25
        Me.osaekomiButtonC1.Text = "OSAEKOMI"
        Me.osaekomiButtonC1.UseVisualStyleBackColor = True
        Me.osaekomiButtonC1.Visible = False
        '
        'wazariButtonC1
        '
        Me.wazariButtonC1.Location = New System.Drawing.Point(24, 315)
        Me.wazariButtonC1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.wazariButtonC1.Name = "wazariButtonC1"
        Me.wazariButtonC1.Size = New System.Drawing.Size(136, 34)
        Me.wazariButtonC1.TabIndex = 26
        Me.wazariButtonC1.Text = "WAZARI"
        Me.wazariButtonC1.UseVisualStyleBackColor = True
        Me.wazariButtonC1.Visible = False
        '
        'ipponButtonC1
        '
        Me.ipponButtonC1.Location = New System.Drawing.Point(24, 356)
        Me.ipponButtonC1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ipponButtonC1.Name = "ipponButtonC1"
        Me.ipponButtonC1.Size = New System.Drawing.Size(136, 34)
        Me.ipponButtonC1.TabIndex = 27
        Me.ipponButtonC1.Text = "IPPON"
        Me.ipponButtonC1.UseVisualStyleBackColor = True
        Me.ipponButtonC1.Visible = False
        '
        'ipponButtonC2
        '
        Me.ipponButtonC2.Location = New System.Drawing.Point(615, 356)
        Me.ipponButtonC2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ipponButtonC2.Name = "ipponButtonC2"
        Me.ipponButtonC2.Size = New System.Drawing.Size(136, 34)
        Me.ipponButtonC2.TabIndex = 31
        Me.ipponButtonC2.Text = "IPPON"
        Me.ipponButtonC2.UseVisualStyleBackColor = True
        Me.ipponButtonC2.Visible = False
        '
        'wazariButtonC2
        '
        Me.wazariButtonC2.Location = New System.Drawing.Point(615, 315)
        Me.wazariButtonC2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.wazariButtonC2.Name = "wazariButtonC2"
        Me.wazariButtonC2.Size = New System.Drawing.Size(136, 34)
        Me.wazariButtonC2.TabIndex = 30
        Me.wazariButtonC2.Text = "WAZARI"
        Me.wazariButtonC2.UseVisualStyleBackColor = True
        Me.wazariButtonC2.Visible = False
        '
        'osaekomiButtonC2
        '
        Me.osaekomiButtonC2.Location = New System.Drawing.Point(615, 274)
        Me.osaekomiButtonC2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.osaekomiButtonC2.Name = "osaekomiButtonC2"
        Me.osaekomiButtonC2.Size = New System.Drawing.Size(136, 34)
        Me.osaekomiButtonC2.TabIndex = 29
        Me.osaekomiButtonC2.Text = "OSAEKOMI"
        Me.osaekomiButtonC2.UseVisualStyleBackColor = True
        Me.osaekomiButtonC2.Visible = False
        '
        'yukoButtonC2
        '
        Me.yukoButtonC2.Location = New System.Drawing.Point(615, 233)
        Me.yukoButtonC2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.yukoButtonC2.Name = "yukoButtonC2"
        Me.yukoButtonC2.Size = New System.Drawing.Size(136, 34)
        Me.yukoButtonC2.TabIndex = 28
        Me.yukoButtonC2.Text = "YUKO"
        Me.yukoButtonC2.UseVisualStyleBackColor = True
        Me.yukoButtonC2.Visible = False
        '
        'toketaButton
        '
        Me.toketaButton.Location = New System.Drawing.Point(328, 286)
        Me.toketaButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.toketaButton.Name = "toketaButton"
        Me.toketaButton.Size = New System.Drawing.Size(121, 30)
        Me.toketaButton.TabIndex = 32
        Me.toketaButton.Text = "TOKETA"
        Me.toketaButton.UseVisualStyleBackColor = True
        '
        'matteButton
        '
        Me.matteButton.Location = New System.Drawing.Point(328, 321)
        Me.matteButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.matteButton.Name = "matteButton"
        Me.matteButton.Size = New System.Drawing.Size(121, 30)
        Me.matteButton.TabIndex = 33
        Me.matteButton.Text = "MATTE"
        Me.matteButton.UseVisualStyleBackColor = True
        '
        'quitterButton
        '
        Me.quitterButton.Location = New System.Drawing.Point(315, 441)
        Me.quitterButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.quitterButton.Name = "quitterButton"
        Me.quitterButton.Size = New System.Drawing.Size(151, 43)
        Me.quitterButton.TabIndex = 34
        Me.quitterButton.Text = "Quitter"
        Me.quitterButton.UseVisualStyleBackColor = True
        '
        'erreur3
        '
        Me.erreur3.AutoSize = True
        Me.erreur3.ForeColor = System.Drawing.Color.Red
        Me.erreur3.Location = New System.Drawing.Point(312, 134)
        Me.erreur3.Name = "erreur3"
        Me.erreur3.Size = New System.Drawing.Size(169, 17)
        Me.erreur3.TabIndex = 35
        Me.erreur3.Text = "Veuillez remplir ce champ"
        Me.erreur3.Visible = False
        '
        'TimerC1
        '
        Me.TimerC1.Interval = 1000
        '
        'TimerC2
        '
        Me.TimerC2.Interval = 1000
        '
        'chronoC1
        '
        Me.chronoC1.AutoSize = True
        Me.chronoC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chronoC1.Location = New System.Drawing.Point(201, 282)
        Me.chronoC1.Name = "chronoC1"
        Me.chronoC1.Size = New System.Drawing.Size(26, 29)
        Me.chronoC1.TabIndex = 36
        Me.chronoC1.Text = "0"
        Me.chronoC1.Visible = False
        '
        'chronoC2
        '
        Me.chronoC2.AutoSize = True
        Me.chronoC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chronoC2.Location = New System.Drawing.Point(533, 282)
        Me.chronoC2.Name = "chronoC2"
        Me.chronoC2.Size = New System.Drawing.Size(26, 29)
        Me.chronoC2.TabIndex = 37
        Me.chronoC2.Text = "0"
        Me.chronoC2.Visible = False
        '
        'hajimeButton
        '
        Me.hajimeButton.Location = New System.Drawing.Point(328, 209)
        Me.hajimeButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.hajimeButton.Name = "hajimeButton"
        Me.hajimeButton.Size = New System.Drawing.Size(121, 48)
        Me.hajimeButton.TabIndex = 38
        Me.hajimeButton.Text = "HAJIME"
        Me.hajimeButton.UseVisualStyleBackColor = True
        Me.hajimeButton.Visible = False
        '
        'resetButton
        '
        Me.resetButton.Location = New System.Drawing.Point(315, 391)
        Me.resetButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.resetButton.Name = "resetButton"
        Me.resetButton.Size = New System.Drawing.Size(151, 43)
        Me.resetButton.TabIndex = 39
        Me.resetButton.Text = "Reset"
        Me.resetButton.UseVisualStyleBackColor = True
        '
        'chronoSecondes
        '
        Me.chronoSecondes.AutoSize = True
        Me.chronoSecondes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chronoSecondes.Location = New System.Drawing.Point(403, 169)
        Me.chronoSecondes.Name = "chronoSecondes"
        Me.chronoSecondes.Size = New System.Drawing.Size(26, 29)
        Me.chronoSecondes.TabIndex = 40
        Me.chronoSecondes.Text = "0"
        Me.chronoSecondes.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(233, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 29)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = """"
        Me.Label5.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(565, 274)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 29)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = """"
        Me.Label8.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(368, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(17, 29)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "'"
        Me.Label9.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(425, 153)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 29)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = """"
        Me.Label10.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 484)
        Me.Controls.Add(Me.resetButton)
        Me.Controls.Add(Me.hajimeButton)
        Me.Controls.Add(Me.chronoC2)
        Me.Controls.Add(Me.chronoC1)
        Me.Controls.Add(Me.erreur3)
        Me.Controls.Add(Me.quitterButton)
        Me.Controls.Add(Me.matteButton)
        Me.Controls.Add(Me.toketaButton)
        Me.Controls.Add(Me.ipponButtonC2)
        Me.Controls.Add(Me.wazariButtonC2)
        Me.Controls.Add(Me.osaekomiButtonC2)
        Me.Controls.Add(Me.yukoButtonC2)
        Me.Controls.Add(Me.ipponButtonC1)
        Me.Controls.Add(Me.wazariButtonC1)
        Me.Controls.Add(Me.osaekomiButtonC1)
        Me.Controls.Add(Me.yukoButtonC1)
        Me.Controls.Add(Me.wazariPointC2)
        Me.Controls.Add(Me.ipponPointC2)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.yukoPointC2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.wazariPointC1)
        Me.Controls.Add(Me.ipponPointC1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.yukoPointC1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.choixTemps)
        Me.Controls.Add(Me.erreur2)
        Me.Controls.Add(Me.erreur1)
        Me.Controls.Add(Me.chronoMinutes)
        Me.Controls.Add(Me.fighterTwo)
        Me.Controls.Add(Me.fighterOne)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.fighterOneChamp)
        Me.Controls.Add(Me.fighterTwoChamp)
        Me.Controls.Add(Me.chronoSecondes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents startButton As Button
    Friend WithEvents fighterOne As Label
    Friend WithEvents fighterTwo As Label
    Friend WithEvents chronoMinutes As Label
    Friend WithEvents fighterOneChamp As TextBox
    Friend WithEvents fighterTwoChamp As TextBox
    Friend WithEvents erreur1 As Label
    Friend WithEvents erreur2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents choixTemps As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents yukoPointC1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ipponPointC1 As Label
    Friend WithEvents wazariPointC1 As Label
    Friend WithEvents wazariPointC2 As Label
    Friend WithEvents ipponPointC2 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents yukoPointC2 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents yukoButtonC1 As Button
    Friend WithEvents osaekomiButtonC1 As Button
    Friend WithEvents wazariButtonC1 As Button
    Friend WithEvents ipponButtonC1 As Button
    Friend WithEvents ipponButtonC2 As Button
    Friend WithEvents wazariButtonC2 As Button
    Friend WithEvents osaekomiButtonC2 As Button
    Friend WithEvents yukoButtonC2 As Button
    Friend WithEvents toketaButton As Button
    Friend WithEvents matteButton As Button
    Friend WithEvents quitterButton As Button
    Friend WithEvents erreur3 As Label
    Friend WithEvents TimerC1 As Timer
    Friend WithEvents TimerC2 As Timer
    Friend WithEvents chronoC1 As Label
    Friend WithEvents chronoC2 As Label
    Friend WithEvents hajimeButton As Button
    Friend WithEvents resetButton As Button
    Friend WithEvents chronoSecondes As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
