﻿Imports System
Imports System.Globalization
Imports System.Runtime.Serialization.Formatters
Imports System.Threading


Public Class Programmer

    Public Shared Function HexadecimalToDecimal(hex As String) As Integer
        hex = hex.ToUpper()

        Dim hexLength As Integer = hex.Length
        Dim dec As Double = 0

        For i As Integer = 0 To hexLength - 1
            Dim b As Byte = CByte(AscW(hex(i)))

            If b >= 48 AndAlso b <= 57 Then
                b -= 48
            ElseIf b >= 65 AndAlso b <= 70 Then
                b -= 55
            End If

            dec += b * Math.Pow(16, ((hexLength - i) - 1))
        Next

        Return CInt(Math.Truncate(dec))
    End Function
    Public Shared Function DecimalToHexadecimal(dec As Integer) As String
        If dec < 1 Then Return "0"

        Dim hex As Integer = dec
        Dim hexStr As String = String.Empty

        While dec > 0
            hex = dec Mod 16

            If hex < 10 Then
                hexStr = hexStr.Insert(0, Convert.ToChar(hex + 48).ToString())
            Else
                hexStr = hexStr.Insert(0, Convert.ToChar(hex + 55).ToString())
            End If

            dec = Int(dec / 16)
        End While

        Return hexStr
    End Function
    Private Function BinToHexa(ByVal BinVal As String) As String
        Dim FourBits As String
        Dim BinValPosition As Integer
        Dim BitPosition As Integer
        Dim DigitValue As Integer

        BinVal = StrReverse(BinVal)

        For BinValPosition = 1 To Len(BinVal) Step 4
            FourBits = Mid(BinVal, BinValPosition, 4)
            DigitValue = 0
            For BitPosition = 1 To Len(FourBits)
                If Mid(FourBits, BitPosition, 1) = "1" Then
                    DigitValue = DigitValue + 2 ^ (BitPosition - 1)
                End If
            Next BitPosition
            BinToHexa = Mid("0123456789ABCDEF", DigitValue + 1, 1) & BinToHexa
        Next BinValPosition

    End Function
    Private Function OctToBinary(octal As String) As String
        Return Convert.ToString(Convert.ToInt32(octal, 8), 2)
    End Function

    Public Shared Function DecimalToOctal(dec As Integer) As String
        If dec < 1 Then Return "0"

        Dim octStr As String = String.Empty

        While dec > 0
            octStr = octStr.Insert(0, (dec Mod 8).ToString())
            dec = Int(dec / 8)
        End While

        Return octStr
    End Function

    Public Shared Function OctalToDecimal(octal As String) As Integer
        Dim octLength As Integer = octal.Length
        Dim dec As Double = 0

        For i As Integer = 0 To octLength - 1
            dec += (CByte(AscW(octal(i))) - 48) * Math.Pow(8, ((octLength - i) - 1))
        Next

        Return CInt(Math.Truncate(dec))
    End Function

    Public Function ConvertFromBinary(ByVal input As String) As Integer
        Dim ret As Integer = 0
        Dim splitInput As Char() = input.ToCharArray
        Dim modifier As Integer = 1
        For i As Integer = splitInput.Length - 1 To 0 Step -1
            Dim thisChar As Integer = Val(splitInput(i))
            If thisChar = 1 Then
                ret += thisChar * modifier
            End If
            modifier *= 2
        Next

        Return ret
    End Function
    Public Shared Function DecimalToBinary(dec As Integer) As String
        If dec < 1 Then Return "0"

        Dim binStr As String = String.Empty

        While dec > 0
            binStr = binStr.Insert(0, (dec Mod 2).ToString())
            dec = Int(dec / 2)
        End While

        Return binStr
    End Function
    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.ResizeRedraw, True)

    End Sub

    Private Const cGrip As Integer = 16
    Private Const cCaption As Integer = 32

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = &H84 Then
            Dim pos As Point = New Point(m.LParam.ToInt32())
            pos = Me.PointToClient(pos)

            If pos.Y < cCaption Then
                m.Result = CType(2, IntPtr)
                Return
            End If

            If pos.X >= Me.ClientSize.Width - cGrip AndAlso pos.Y >= Me.ClientSize.Height - cGrip Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If
        MyBase.WndProc(m)
    End Sub
    Private Sub NormalActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalActualToolStripMenuItem.Click
        Normal.Show()
        Me.Close()
    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
        Scientific.Show()
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Application.Exit()
    End Sub

    Private Sub Minimizea_Click(sender As Object, e As EventArgs) Handles Minimizea.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If (DecToBin.Checked = True) Then
            TextBox2.Text = DecimalToBinary(TextBox1.Text)
        Else
            If (BinToDec.Checked = True) Then
                TextBox2.Text = ConvertFromBinary(TextBox1.Text)
            Else
                If (OctToDec.Checked = True) Then
                    TextBox2.Text = OctalToDecimal(TextBox1.Text)
                Else
                    If (DecToOct.Checked = True) Then
                        TextBox2.Text = DecimalToOctal(TextBox1.Text)
                    Else
                        If (OctToBin.Checked = True) Then
                            TextBox2.Text = OctToBinary(TextBox1.Text)
                        Else
                            If (BinToHex.Checked = True) Then
                                TextBox2.Text = BinToHexa(TextBox1.Text)
                            Else
                                If (DecToHex.Checked = True) Then
                                    TextBox2.Text = DecimalToHexadecimal(TextBox1.Text)
                                Else
                                    If (HexToDec.Checked = True) Then
                                        TextBox2.Text = HexadecimalToDecimal(TextBox1.Text)
                                    Else
                                        If (HexToBin.Checked = True) Then
                                            TextBox2.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text, 16), 2)
                                        Else
                                            If (HexToOct.Checked = True) Then
                                                TextBox2.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text, 16), 8)
                                            Else
                                                If (OctToHex.Checked = True) Then
                                                    TextBox2.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text, 8), 16)
                                                Else
                                                    If (BintoOct.Checked = True) Then
                                                        TextBox2.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text, 2), 8)
                                                    End If
                                                End If
                                            End If
                                            End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub Butt1_Click(sender As Object, e As EventArgs) Handles Butt1.Click
        TextBox1.Text = TextBox1.Text & “1”
    End Sub

    Private Sub Butt0_Click(sender As Object, e As EventArgs) Handles Butt0.Click
        TextBox1.Text = TextBox1.Text & “0”
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        F2.Text = ""
        F1.Text = ""
        DecToBin.Checked = False
        BinToDec.Checked = False
        Butt0.Enabled = False
        Butt1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button14.Enabled = False
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles BinToDec.CheckedChanged
        Butt0.Enabled = True
        Butt1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button14.Enabled = True
        DecToBin.Checked = False
        OctToDec.Checked = False
        DecToOct.Checked = False
        F1.Text = "BIN"
        F2.Text = "DEC"
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Programer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles DecToBin.CheckedChanged
        Butt0.Enabled = True
        Butt1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button14.Enabled = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        BinToDec.Checked = False
        OctToDec.Checked = False
        DecToOct.Checked = False
        F1.Text = "DEC"
        F2.Text = "BIN"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & “3”
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & “4”
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & “5”
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & “6”
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & “7”
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & “8”
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & “9”
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & “2”
    End Sub

    Private Sub DectoOct_CheckedChanged(sender As Object, e As EventArgs) Handles DecToOct.CheckedChanged
        ButtonA.Enabled = False
        ButtonB.Enabled = False
        ButtonC.Enabled = False
        ButtonD.Enabled = False
        ButtonE.Enabled = False
        ButtonF.Enabled = False
        Butt0.Enabled = True
        Butt1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Button14.Enabled = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        BinToDec.Checked = False
        DecToBin.Checked = False
        OctToDec.Checked = False
        F1.Text = "DEC"
        F2.Text = "OCT"
    End Sub

    Private Sub OctaltoDec_CheckedChanged(sender As Object, e As EventArgs) Handles OctToDec.CheckedChanged
        ButtonA.Enabled = False
        ButtonB.Enabled = False
        ButtonC.Enabled = False
        ButtonD.Enabled = False
        ButtonE.Enabled = False
        ButtonF.Enabled = False
        Butt0.Enabled = True
        Butt1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = False
        Button8.Enabled = True
        Button9.Enabled = False
        Button14.Enabled = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        BinToDec.Checked = False
        DecToBin.Checked = False
        DecToOct.Checked = False
        F1.Text = "OCT"
        F2.Text = "DEC"
    End Sub

    Private Sub BinToHex_CheckedChanged(sender As Object, e As EventArgs) Handles BinToHex.CheckedChanged
        ButtonA.Enabled = False
        ButtonB.Enabled = False
        ButtonC.Enabled = False
        ButtonD.Enabled = False
        ButtonE.Enabled = False
        ButtonF.Enabled = False
        Butt0.Enabled = True
        Butt1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button14.Enabled = True
        'ALL CONVERTIONS'
        DecToBin.Checked = False
        OctToDec.Checked = False
        DecToOct.Checked = False
        BinToDec.Checked = False
        BintoOct.Checked = False
        OctToBin.Checked = False
        OctToHex.Checked = False
        DecToHex.Checked = False
        F1.Text = "BIN"
        F2.Text = "HEX"
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub BintoOct_CheckedChanged(sender As Object, e As EventArgs) Handles BintoOct.CheckedChanged
        ButtonA.Enabled = False
        ButtonB.Enabled = False
        ButtonC.Enabled = False
        ButtonD.Enabled = False
        ButtonE.Enabled = False
        ButtonF.Enabled = False
        Butt0.Enabled = True
        Butt1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Button14.Enabled = True
        'ALL CONVERTIONS'
        DecToBin.Checked = False
        OctToDec.Checked = False
        DecToOct.Checked = False
        BinToDec.Checked = False
        BinToHex.Checked = False
        OctToBin.Checked = False
        OctToHex.Checked = False
        DecToHex.Checked = False
        F1.Text = "BIN"
        F2.Text = "OCT"
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub OctToBin_CheckedChanged(sender As Object, e As EventArgs) Handles OctToBin.CheckedChanged
        ButtonA.Enabled = False
        ButtonB.Enabled = False
        ButtonC.Enabled = False
        ButtonD.Enabled = False
        ButtonE.Enabled = False
        ButtonF.Enabled = False
        Butt0.Enabled = True
        Butt1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = False
        Button8.Enabled = True
        Button9.Enabled = False
        Button14.Enabled = True
        'ALL CONVERTIONS'
        DecToBin.Checked = False
        OctToDec.Checked = False
        DecToOct.Checked = False
        BinToDec.Checked = False
        BinToHex.Checked = False
        BintoOct.Checked = False
        OctToHex.Checked = False
        DecToHex.Checked = False
        F1.Text = "OCT"
        F2.Text = "BIN"
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub DecToHex_CheckedChanged(sender As Object, e As EventArgs) Handles DecToHex.CheckedChanged
        ButtonA.Enabled = False
        ButtonB.Enabled = False
        ButtonC.Enabled = False
        ButtonD.Enabled = False
        ButtonE.Enabled = False
        ButtonF.Enabled = False
        Butt0.Enabled = True
        Butt1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = False
        Button8.Enabled = True
        Button9.Enabled = False
        Button14.Enabled = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        DecToBin.Checked = False
        OctToDec.Checked = False
        DecToOct.Checked = False
        BinToDec.Checked = False
        BintoOct.Checked = False
        OctToBin.Checked = False
        OctToHex.Checked = False
        BinToHex.Checked = False
        F1.Text = "DEC"
        F2.Text = "HEX"
    End Sub

    Private Sub HexToOct_CheckedChanged(sender As Object, e As EventArgs) Handles HexToOct.CheckedChanged
        ButtonA.Enabled = True
        ButtonB.Enabled = True
        ButtonC.Enabled = True
        ButtonD.Enabled = True
        ButtonE.Enabled = True
        ButtonF.Enabled = True
        Butt0.Enabled = True
        Butt1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = False
        Button8.Enabled = True
        Button9.Enabled = False
        Button14.Enabled = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        DecToBin.Checked = False
        OctToDec.Checked = False
        DecToOct.Checked = False
        BinToDec.Checked = False
        BintoOct.Checked = False
        OctToBin.Checked = False
        OctToHex.Checked = False
        BinToHex.Checked = False
        HexToDec.Checked = False
        HexToBin.Checked = False
        F1.Text = "HEX"
        F2.Text = "OCT"
    End Sub

    Private Sub HexToDec_CheckedChanged(sender As Object, e As EventArgs) Handles HexToDec.CheckedChanged
        ButtonA.Enabled = True
        ButtonB.Enabled = True
        ButtonC.Enabled = True
        ButtonD.Enabled = True
        ButtonE.Enabled = True
        ButtonF.Enabled = True
        Butt0.Enabled = True
        Butt1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = False
        Button8.Enabled = True
        Button9.Enabled = False
        Button14.Enabled = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        DecToBin.Checked = False
        OctToDec.Checked = False
        DecToOct.Checked = False
        BinToDec.Checked = False
        BintoOct.Checked = False
        OctToBin.Checked = False
        OctToHex.Checked = False
        BinToHex.Checked = False
        F1.Text = "HEX"
        F2.Text = "DEC"
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles ButtonA.Click
        TextBox1.Text = TextBox1.Text & "A"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles ButtonB.Click
        TextBox1.Text = TextBox1.Text & "B"
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        TextBox1.Text = TextBox1.Text & "C"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles ButtonD.Click
        TextBox1.Text = TextBox1.Text & "D"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles ButtonE.Click
        TextBox1.Text = TextBox1.Text & "E"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles ButtonF.Click
        TextBox1.Text = TextBox1.Text & "F"
    End Sub

    Private Sub HexToBin_CheckedChanged(sender As Object, e As EventArgs) Handles HexToBin.CheckedChanged
        ButtonA.Enabled = True
        ButtonB.Enabled = True
        ButtonC.Enabled = True
        ButtonD.Enabled = True
        ButtonE.Enabled = True
        ButtonF.Enabled = True
        Butt0.Enabled = True
        Butt1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = False
        Button8.Enabled = True
        Button9.Enabled = False
        Button14.Enabled = True
        TextBox1.Text = ""
        TextBox2.Text = ""
        DecToBin.Checked = False
        OctToDec.Checked = False
        DecToOct.Checked = False
        BinToDec.Checked = False
        BintoOct.Checked = False
        OctToBin.Checked = False
        OctToHex.Checked = False
        BinToHex.Checked = False
        HexToDec.Checked = False
        HexToOct.Checked = False
        F1.Text = "HEX"
        F2.Text = "BIN"
    End Sub

    Private Sub OctToHex_CheckedChanged(sender As Object, e As EventArgs) Handles OctToHex.CheckedChanged
        ButtonA.Enabled = False
        ButtonB.Enabled = False
        ButtonC.Enabled = False
        ButtonD.Enabled = False
        ButtonE.Enabled = False
        ButtonF.Enabled = False
        Butt0.Enabled = True
        Butt1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = False
        Button8.Enabled = True
        Button9.Enabled = False
        Button14.Enabled = True
        'ALL CONVERTIONS'
        DecToBin.Checked = False
        OctToDec.Checked = False
        DecToOct.Checked = False
        BinToDec.Checked = False
        BinToHex.Checked = False
        BintoOct.Checked = False
        OctToBin.Checked = False
        DecToHex.Checked = False
        HexToDec.Checked = False
        HexToOct.Checked = False
        F1.Text = "OCT"
        F2.Text = "HEX"
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class