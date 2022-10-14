<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Programmer
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Programmer))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Minimizea = New System.Windows.Forms.Label()
        Me.Closea = New System.Windows.Forms.Label()
        Me.Butt0 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Butt1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScientificToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammerActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BinToDec = New System.Windows.Forms.CheckBox()
        Me.DecToBin = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.F2 = New System.Windows.Forms.Label()
        Me.F1 = New System.Windows.Forms.Label()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.DecToOct = New System.Windows.Forms.CheckBox()
        Me.OctToDec = New System.Windows.Forms.CheckBox()
        Me.information = New System.Windows.Forms.Label()
        Me.OctToHex = New System.Windows.Forms.CheckBox()
        Me.OctToBin = New System.Windows.Forms.CheckBox()
        Me.DecToHex = New System.Windows.Forms.CheckBox()
        Me.BintoOct = New System.Windows.Forms.CheckBox()
        Me.BinToHex = New System.Windows.Forms.CheckBox()
        Me.HexToOct = New System.Windows.Forms.CheckBox()
        Me.HexToBin = New System.Windows.Forms.CheckBox()
        Me.HexToDec = New System.Windows.Forms.CheckBox()
        Me.ButtonC = New System.Windows.Forms.Button()
        Me.ButtonB = New System.Windows.Forms.Button()
        Me.ButtonA = New System.Windows.Forms.Button()
        Me.ButtonD = New System.Windows.Forms.Button()
        Me.ButtonF = New System.Windows.Forms.Button()
        Me.ButtonE = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 22)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Programmer Calculator"
        '
        'Minimizea
        '
        Me.Minimizea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimizea.AutoSize = True
        Me.Minimizea.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimizea.Location = New System.Drawing.Point(745, -5)
        Me.Minimizea.Name = "Minimizea"
        Me.Minimizea.Size = New System.Drawing.Size(30, 40)
        Me.Minimizea.TabIndex = 78
        Me.Minimizea.Text = "-"
        '
        'Closea
        '
        Me.Closea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Closea.AutoSize = True
        Me.Closea.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Closea.Location = New System.Drawing.Point(781, -2)
        Me.Closea.Name = "Closea"
        Me.Closea.Size = New System.Drawing.Size(37, 37)
        Me.Closea.TabIndex = 77
        Me.Closea.Text = "X"
        '
        'Butt0
        '
        Me.Butt0.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Butt0.Enabled = False
        Me.Butt0.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Butt0.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Butt0.Location = New System.Drawing.Point(360, 644)
        Me.Butt0.Name = "Butt0"
        Me.Butt0.Size = New System.Drawing.Size(96, 53)
        Me.Butt0.TabIndex = 74
        Me.Butt0.Text = "0"
        Me.Butt0.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.TextBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(188, 57)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(447, 58)
        Me.TextBox1.TabIndex = 72
        '
        'Button14
        '
        Me.Button14.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button14.Enabled = False
        Me.Button14.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Button14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button14.Location = New System.Drawing.Point(208, 723)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(400, 42)
        Me.Button14.TabIndex = 71
        Me.Button14.Text = "="
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(133, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 70
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Butt1
        '
        Me.Butt1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Butt1.Enabled = False
        Me.Butt1.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Butt1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Butt1.Location = New System.Drawing.Point(234, 424)
        Me.Butt1.Name = "Butt1"
        Me.Butt1.Size = New System.Drawing.Size(96, 53)
        Me.Butt1.TabIndex = 58
        Me.Butt1.Text = "1"
        Me.Butt1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlText
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 31)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(164, 30)
        Me.MenuStrip1.TabIndex = 75
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalActualToolStripMenuItem, Me.ScientificToolStripMenuItem, Me.ProgrammerActualToolStripMenuItem})
        Me.CalculatorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(90, 26)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'NormalActualToolStripMenuItem
        '
        Me.NormalActualToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.NormalActualToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.NormalActualToolStripMenuItem.Name = "NormalActualToolStripMenuItem"
        Me.NormalActualToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.NormalActualToolStripMenuItem.Text = "Standard"
        '
        'ScientificToolStripMenuItem
        '
        Me.ScientificToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.ScientificToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ScientificToolStripMenuItem.Name = "ScientificToolStripMenuItem"
        Me.ScientificToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.ScientificToolStripMenuItem.Text = "Scientific"
        '
        'ProgrammerActualToolStripMenuItem
        '
        Me.ProgrammerActualToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.ProgrammerActualToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ProgrammerActualToolStripMenuItem.Name = "ProgrammerActualToolStripMenuItem"
        Me.ProgrammerActualToolStripMenuItem.Size = New System.Drawing.Size(231, 26)
        Me.ProgrammerActualToolStripMenuItem.Text = "Programmer (Actual)"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InfoText
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Location = New System.Drawing.Point(188, 148)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(447, 58)
        Me.TextBox2.TabIndex = 80
        '
        'BinToDec
        '
        Me.BinToDec.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BinToDec.AutoSize = True
        Me.BinToDec.Location = New System.Drawing.Point(162, 238)
        Me.BinToDec.Name = "BinToDec"
        Me.BinToDec.Size = New System.Drawing.Size(134, 20)
        Me.BinToDec.TabIndex = 81
        Me.BinToDec.Text = "Binary -> Decimal"
        Me.BinToDec.UseVisualStyleBackColor = True
        '
        'DecToBin
        '
        Me.DecToBin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DecToBin.AutoSize = True
        Me.DecToBin.Location = New System.Drawing.Point(322, 238)
        Me.DecToBin.Name = "DecToBin"
        Me.DecToBin.Size = New System.Drawing.Size(134, 20)
        Me.DecToBin.TabIndex = 82
        Me.DecToBin.Text = "Decimal -> Binary"
        Me.DecToBin.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Location = New System.Drawing.Point(360, 424)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 53)
        Me.Button2.TabIndex = 84
        Me.Button2.Text = "2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(474, 424)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 53)
        Me.Button3.TabIndex = 83
        Me.Button3.Text = "3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button4.Enabled = False
        Me.Button4.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Button4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button4.Location = New System.Drawing.Point(234, 496)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 53)
        Me.Button4.TabIndex = 86
        Me.Button4.Text = "4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button5.Enabled = False
        Me.Button5.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button5.Location = New System.Drawing.Point(360, 496)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(96, 53)
        Me.Button5.TabIndex = 85
        Me.Button5.Text = "5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button6.Enabled = False
        Me.Button6.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Button6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button6.Location = New System.Drawing.Point(234, 575)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(96, 53)
        Me.Button6.TabIndex = 88
        Me.Button6.Text = "7"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button7.Enabled = False
        Me.Button7.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button7.Location = New System.Drawing.Point(360, 575)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(96, 53)
        Me.Button7.TabIndex = 87
        Me.Button7.Text = "8"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button8.Enabled = False
        Me.Button8.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Button8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button8.Location = New System.Drawing.Point(474, 496)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(96, 53)
        Me.Button8.TabIndex = 90
        Me.Button8.Text = "6"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button9.Enabled = False
        Me.Button9.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.Button9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button9.Location = New System.Drawing.Point(474, 575)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(96, 53)
        Me.Button9.TabIndex = 91
        Me.Button9.Text = "9"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'F2
        '
        Me.F2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.F2.AutoSize = True
        Me.F2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F2.Location = New System.Drawing.Point(661, 148)
        Me.F2.Name = "F2"
        Me.F2.Size = New System.Drawing.Size(0, 22)
        Me.F2.TabIndex = 92
        '
        'F1
        '
        Me.F1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.F1.AutoSize = True
        Me.F1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.F1.Location = New System.Drawing.Point(661, 70)
        Me.F1.Name = "F1"
        Me.F1.Size = New System.Drawing.Size(0, 22)
        Me.F1.TabIndex = 93
        '
        'Button10
        '
        Me.Button10.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button10.Location = New System.Drawing.Point(133, 453)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(75, 23)
        Me.Button10.TabIndex = 94
        Me.Button10.Tag = ""
        Me.Button10.Text = "Del1"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'DecToOct
        '
        Me.DecToOct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DecToOct.AutoSize = True
        Me.DecToOct.Location = New System.Drawing.Point(322, 266)
        Me.DecToOct.Name = "DecToOct"
        Me.DecToOct.Size = New System.Drawing.Size(127, 20)
        Me.DecToOct.TabIndex = 96
        Me.DecToOct.Text = "Decimal -> Octal"
        Me.DecToOct.UseVisualStyleBackColor = True
        '
        'OctToDec
        '
        Me.OctToDec.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OctToDec.AutoSize = True
        Me.OctToDec.Location = New System.Drawing.Point(504, 238)
        Me.OctToDec.Name = "OctToDec"
        Me.OctToDec.Size = New System.Drawing.Size(127, 20)
        Me.OctToDec.TabIndex = 95
        Me.OctToDec.Text = "Octal -> Decimal"
        Me.OctToDec.UseVisualStyleBackColor = True
        '
        'information
        '
        Me.information.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.information.AutoSize = True
        Me.information.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.information.Location = New System.Drawing.Point(120, 796)
        Me.information.Name = "information"
        Me.information.Size = New System.Drawing.Size(582, 60)
        Me.information.TabIndex = 97
        Me.information.Text = "In Binary System, numbers from 2 to 9 are disabled because is based on 0,1." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "In O" &
    "ctal System, numbers 8,9 aren't available." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The A,B,C,D,E,F letters are availabl" &
    "e only in hexadecimal numbers."
        '
        'OctToHex
        '
        Me.OctToHex.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OctToHex.AutoSize = True
        Me.OctToHex.Location = New System.Drawing.Point(504, 292)
        Me.OctToHex.Name = "OctToHex"
        Me.OctToHex.Size = New System.Drawing.Size(157, 20)
        Me.OctToHex.TabIndex = 101
        Me.OctToHex.Text = "Octal -> Hexadecimal"
        Me.OctToHex.UseVisualStyleBackColor = True
        '
        'OctToBin
        '
        Me.OctToBin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OctToBin.AutoSize = True
        Me.OctToBin.Location = New System.Drawing.Point(504, 266)
        Me.OctToBin.Name = "OctToBin"
        Me.OctToBin.Size = New System.Drawing.Size(115, 20)
        Me.OctToBin.TabIndex = 100
        Me.OctToBin.Text = "Octal -> Binary"
        Me.OctToBin.UseVisualStyleBackColor = True
        '
        'DecToHex
        '
        Me.DecToHex.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DecToHex.AutoSize = True
        Me.DecToHex.Location = New System.Drawing.Point(322, 292)
        Me.DecToHex.Name = "DecToHex"
        Me.DecToHex.Size = New System.Drawing.Size(176, 20)
        Me.DecToHex.TabIndex = 99
        Me.DecToHex.Text = "Decimal -> Hexadecimal"
        Me.DecToHex.UseVisualStyleBackColor = True
        '
        'BintoOct
        '
        Me.BintoOct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BintoOct.AutoSize = True
        Me.BintoOct.Location = New System.Drawing.Point(162, 266)
        Me.BintoOct.Name = "BintoOct"
        Me.BintoOct.Size = New System.Drawing.Size(115, 20)
        Me.BintoOct.TabIndex = 98
        Me.BintoOct.Text = "Binary -> Octal"
        Me.BintoOct.UseVisualStyleBackColor = True
        '
        'BinToHex
        '
        Me.BinToHex.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BinToHex.AutoSize = True
        Me.BinToHex.Location = New System.Drawing.Point(162, 292)
        Me.BinToHex.Name = "BinToHex"
        Me.BinToHex.Size = New System.Drawing.Size(164, 20)
        Me.BinToHex.TabIndex = 102
        Me.BinToHex.Text = "Binary -> Hexadecimal"
        Me.BinToHex.UseVisualStyleBackColor = True
        '
        'HexToOct
        '
        Me.HexToOct.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HexToOct.AutoSize = True
        Me.HexToOct.Location = New System.Drawing.Point(322, 389)
        Me.HexToOct.Name = "HexToOct"
        Me.HexToOct.Size = New System.Drawing.Size(157, 20)
        Me.HexToOct.TabIndex = 105
        Me.HexToOct.Text = "Hexadecimal -> Octal"
        Me.HexToOct.UseVisualStyleBackColor = True
        '
        'HexToBin
        '
        Me.HexToBin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HexToBin.AutoSize = True
        Me.HexToBin.Location = New System.Drawing.Point(322, 363)
        Me.HexToBin.Name = "HexToBin"
        Me.HexToBin.Size = New System.Drawing.Size(164, 20)
        Me.HexToBin.TabIndex = 104
        Me.HexToBin.Text = "Hexadecimal -> Binary"
        Me.HexToBin.UseVisualStyleBackColor = True
        '
        'HexToDec
        '
        Me.HexToDec.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.HexToDec.AutoSize = True
        Me.HexToDec.Location = New System.Drawing.Point(322, 335)
        Me.HexToDec.Name = "HexToDec"
        Me.HexToDec.Size = New System.Drawing.Size(176, 20)
        Me.HexToDec.TabIndex = 103
        Me.HexToDec.Text = "Hexadecimal -> Decimal"
        Me.HexToDec.UseVisualStyleBackColor = True
        '
        'ButtonC
        '
        Me.ButtonC.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonC.Enabled = False
        Me.ButtonC.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.ButtonC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonC.Location = New System.Drawing.Point(604, 483)
        Me.ButtonC.Name = "ButtonC"
        Me.ButtonC.Size = New System.Drawing.Size(66, 40)
        Me.ButtonC.TabIndex = 108
        Me.ButtonC.Text = "C"
        Me.ButtonC.UseVisualStyleBackColor = True
        '
        'ButtonB
        '
        Me.ButtonB.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonB.Enabled = False
        Me.ButtonB.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.ButtonB.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonB.Location = New System.Drawing.Point(694, 423)
        Me.ButtonB.Name = "ButtonB"
        Me.ButtonB.Size = New System.Drawing.Size(66, 40)
        Me.ButtonB.TabIndex = 107
        Me.ButtonB.Text = "B"
        Me.ButtonB.UseVisualStyleBackColor = True
        '
        'ButtonA
        '
        Me.ButtonA.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonA.Enabled = False
        Me.ButtonA.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonA.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonA.Location = New System.Drawing.Point(604, 423)
        Me.ButtonA.Name = "ButtonA"
        Me.ButtonA.Size = New System.Drawing.Size(66, 40)
        Me.ButtonA.TabIndex = 106
        Me.ButtonA.Text = "A"
        Me.ButtonA.UseVisualStyleBackColor = True
        '
        'ButtonD
        '
        Me.ButtonD.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonD.Enabled = False
        Me.ButtonD.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.ButtonD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonD.Location = New System.Drawing.Point(694, 483)
        Me.ButtonD.Name = "ButtonD"
        Me.ButtonD.Size = New System.Drawing.Size(66, 40)
        Me.ButtonD.TabIndex = 109
        Me.ButtonD.Text = "D"
        Me.ButtonD.UseVisualStyleBackColor = True
        '
        'ButtonF
        '
        Me.ButtonF.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonF.Enabled = False
        Me.ButtonF.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!)
        Me.ButtonF.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonF.Location = New System.Drawing.Point(694, 542)
        Me.ButtonF.Name = "ButtonF"
        Me.ButtonF.Size = New System.Drawing.Size(66, 40)
        Me.ButtonF.TabIndex = 111
        Me.ButtonF.Text = "F"
        Me.ButtonF.UseVisualStyleBackColor = True
        '
        'ButtonE
        '
        Me.ButtonE.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ButtonE.Enabled = False
        Me.ButtonE.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonE.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ButtonE.Location = New System.Drawing.Point(604, 542)
        Me.ButtonE.Name = "ButtonE"
        Me.ButtonE.Size = New System.Drawing.Size(66, 40)
        Me.ButtonE.TabIndex = 110
        Me.ButtonE.Text = "E"
        Me.ButtonE.UseVisualStyleBackColor = True
        '
        'Programmer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(820, 894)
        Me.Controls.Add(Me.ButtonF)
        Me.Controls.Add(Me.ButtonE)
        Me.Controls.Add(Me.ButtonD)
        Me.Controls.Add(Me.ButtonC)
        Me.Controls.Add(Me.ButtonB)
        Me.Controls.Add(Me.ButtonA)
        Me.Controls.Add(Me.HexToOct)
        Me.Controls.Add(Me.HexToBin)
        Me.Controls.Add(Me.HexToDec)
        Me.Controls.Add(Me.DecToHex)
        Me.Controls.Add(Me.BinToHex)
        Me.Controls.Add(Me.OctToHex)
        Me.Controls.Add(Me.OctToBin)
        Me.Controls.Add(Me.BintoOct)
        Me.Controls.Add(Me.information)
        Me.Controls.Add(Me.DecToOct)
        Me.Controls.Add(Me.OctToDec)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.F1)
        Me.Controls.Add(Me.F2)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.DecToBin)
        Me.Controls.Add(Me.BinToDec)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Minimizea)
        Me.Controls.Add(Me.Closea)
        Me.Controls.Add(Me.Butt0)
        Me.Controls.Add(Me.Button14)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Butt1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Programmer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BetaCloud Calculator (Programmer)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Minimizea As Label
    Friend WithEvents Closea As Label
    Friend WithEvents Butt0 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button14 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Butt1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScientificToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgrammerActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BinToDec As CheckBox
    Friend WithEvents DecToBin As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents F2 As Label
    Friend WithEvents F1 As Label
    Friend WithEvents Button10 As Button
    Friend WithEvents DecToOct As CheckBox
    Friend WithEvents OctToDec As CheckBox
    Friend WithEvents information As Label
    Friend WithEvents OctToHex As CheckBox
    Friend WithEvents OctToBin As CheckBox
    Friend WithEvents DecToHex As CheckBox
    Friend WithEvents BintoOct As CheckBox
    Friend WithEvents BinToHex As CheckBox
    Friend WithEvents HexToOct As CheckBox
    Friend WithEvents HexToBin As CheckBox
    Friend WithEvents HexToDec As CheckBox
    Friend WithEvents ButtonC As Button
    Friend WithEvents ButtonB As Button
    Friend WithEvents ButtonA As Button
    Friend WithEvents ButtonD As Button
    Friend WithEvents ButtonF As Button
    Friend WithEvents ButtonE As Button
End Class
