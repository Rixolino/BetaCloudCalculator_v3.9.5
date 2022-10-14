Public Class TSettings
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Me.Close()
    End Sub

    Private Sub TSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub DMode_Click(sender As Object, e As EventArgs) Handles DMode.Click
        Me.ForeColor = Color.White
        Me.BackColor = Color.MidnightBlue
        Normal.ForeColor = Color.White
        Normal.BackColor = Color.Black
        Linearequations.BackColor = Color.Black
        Linearequations.ForeColor = Color.White
        LinEquationTriple.BackColor = Color.Black
        LinEquationTriple.ForeColor = Color.White
        Scientific.exproot.ForeColor = Color.White
        Scientific.functions.ForeColor = Color.White
        Scientific.rooting.ForeColor = Color.White
        Scientific.ForeColor = Color.White
        Scientific.TextBox1.ForeColor = Color.White
        Scientific.TextBox2.ForeColor = Color.White
        Scientific.TextBox3.ForeColor = Color.White
        Scientific.TextBox1.BackColor = Color.Black
        Scientific.TextBox2.BackColor = Color.Black
        Scientific.TextBox3.BackColor = Color.Black
        Scientific.BackColor = Color.Black
        Answer.Closea.ForeColor = Color.White
        Answer.Minimizea.ForeColor = Color.White
        Answer.BackColor = Color.MidnightBlue
        Answer.ForeColor = Color.White
        Answer.TextBox1.ForeColor = Color.White
        Answer.TextBox1.BackColor = Color.Black
        Answer.Label1.ForeColor = Color.White
        Answer.Button1.BackColor = Answer.DefaultBackColor
        Answer.Button1.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.title.ForeColor = Color.White
        LinEquationTriple.x1.ForeColor = Color.White
        LinEquationTriple.x2.ForeColor = Color.White
        LinEquationTriple.x3.ForeColor = Color.White
        LinEquationTriple.y1.ForeColor = Color.White
        LinEquationTriple.y2.ForeColor = Color.White
        LinEquationTriple.y3.ForeColor = Color.White
        LinEquationTriple.z1.ForeColor = Color.White
        LinEquationTriple.z2.ForeColor = Color.White
        LinEquationTriple.z3.ForeColor = Color.White
        LinEquationTriple.Label22.ForeColor = Color.White
        LinEquationTriple.Label1.ForeColor = Color.White
        LinEquationTriple.Label8.ForeColor = Color.White
        LinEquationTriple.Label14.ForeColor = Color.White
        LinEquationTriple.Label4.ForeColor = Color.White
        LinEquationTriple.Label7.ForeColor = Color.White
        LinEquationTriple.Label13.ForeColor = Color.White
        LinEquationTriple.Label3.ForeColor = Color.White
        LinEquationTriple.Label2.ForeColor = Color.White
        LinEquationTriple.Label5.ForeColor = Color.White
        LinEquationTriple.Label9.ForeColor = Color.White
        LinEquationTriple.Label10.ForeColor = Color.White
        LinEquationTriple.Label6.ForeColor = Color.White
        LinEquationTriple.Closea.ForeColor = Color.White
        LinEquationTriple.Minimizea.ForeColor = Color.White
        LinEquationTriple.ForeColor = Color.White
        LinEquationTriple.a1.ForeColor = Color.White
        LinEquationTriple.a1.BackColor = Color.Black
        LinEquationTriple.a2.ForeColor = Color.White
        LinEquationTriple.a2.BackColor = Color.Black
        LinEquationTriple.a3.ForeColor = Color.White
        LinEquationTriple.a3.BackColor = Color.Black
        LinEquationTriple.b1.ForeColor = Color.White
        LinEquationTriple.b1.BackColor = Color.Black
        LinEquationTriple.b2.ForeColor = Color.White
        LinEquationTriple.b2.BackColor = Color.Black
        LinEquationTriple.b3.ForeColor = Color.White
        LinEquationTriple.b3.BackColor = Color.Black
        LinEquationTriple.c1.ForeColor = Color.White
        LinEquationTriple.c1.BackColor = Color.Black
        LinEquationTriple.c2.ForeColor = Color.White
        LinEquationTriple.c2.BackColor = Color.Black
        LinEquationTriple.c3.ForeColor = Color.White
        LinEquationTriple.c3.BackColor = Color.Black
        LinEquationTriple.d1.ForeColor = Color.White
        LinEquationTriple.d1.BackColor = Color.Black
        LinEquationTriple.d2.ForeColor = Color.White
        LinEquationTriple.d2.BackColor = Color.Black
        LinEquationTriple.d3.ForeColor = Color.White
        LinEquationTriple.d3.BackColor = Color.Black
        LinEquationTriple.Resultx.ForeColor = Color.White
        LinEquationTriple.Resultx.BackColor = Color.Black
        LinEquationTriple.Resulty.ForeColor = Color.White
        LinEquationTriple.Resulty.BackColor = Color.Black
        LinEquationTriple.Resultz.ForeColor = Color.White
        LinEquationTriple.Resultz.BackColor = Color.Black
        LinEquationTriple.Label1.ForeColor = Color.White
        LinEquationTriple.Button1.BackColor = Color.Black
        LinEquationTriple.Button1.ForeColor = Color.White
        Linearequations.x1.ForeColor = Color.White
        Linearequations.x2.ForeColor = Color.White
        Linearequations.y1.ForeColor = Color.White
        Linearequations.y2.ForeColor = Color.White
        Linearequations.d1.ForeColor = Color.White
        Linearequations.d2.ForeColor = Color.White
        Linearequations.x1.BackColor = Color.Black
        Linearequations.x2.BackColor = Color.Black
        Linearequations.y1.BackColor = Color.Black
        Linearequations.y2.BackColor = Color.Black
        Linearequations.d1.BackColor = Color.Black
        Linearequations.d2.BackColor = Color.Black
        Linearequations.Resultx.BackColor = Color.Black
        Linearequations.Resulty.BackColor = Color.Black
        Linearequations.Resultx.ForeColor = Color.White
        Linearequations.Resulty.ForeColor = Color.White
    End Sub

    Private Sub Lmode_Click(sender As Object, e As EventArgs) Handles Lmode.Click
        Me.ForeColor = DefaultForeColor
        Me.BackColor = Color.Gray
        Normal.ForeColor = Normal.DefaultForeColor
        Normal.BackColor = Normal.DefaultBackColor
        Linearequations.BackColor = Linearequations.DefaultBackColor
        Linearequations.ForeColor = Linearequations.DefaultForeColor
        LinEquationTriple.BackColor = LinEquationTriple.DefaultBackColor
        LinEquationTriple.ForeColor = LinEquationTriple.ForeColor
        Scientific.exproot.ForeColor = Color.Black
        Scientific.functions.ForeColor = Color.Black
        Scientific.rooting.ForeColor = Color.Black
        Scientific.ForeColor = Scientific.DefaultForeColor
        Scientific.TextBox1.ForeColor = Scientific.DefaultForeColor
        Scientific.TextBox2.ForeColor = Scientific.DefaultForeColor
        Scientific.TextBox3.ForeColor = Scientific.DefaultForeColor
        Scientific.TextBox1.BackColor = Scientific.DefaultBackColor
        Scientific.TextBox2.BackColor = Scientific.DefaultBackColor
        Scientific.TextBox3.BackColor = Scientific.DefaultBackColor
        Scientific.BackColor = Scientific.DefaultBackColor
        Answer.Closea.ForeColor = Color.White
        Answer.Minimizea.ForeColor = Color.White
        Answer.BackColor = Color.FromArgb(95, 75, 75)
        Answer.ForeColor = Answer.DefaultForeColor
        Answer.TextBox1.ForeColor = Answer.DefaultForeColor
        Answer.TextBox1.BackColor = Answer.DefaultBackColor
        Answer.Label1.ForeColor = Color.White
        Answer.Button1.BackColor = Answer.DefaultBackColor
        Answer.Button1.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.title.ForeColor = Color.Black
        LinEquationTriple.x1.ForeColor = Color.Black
        LinEquationTriple.x2.ForeColor = Color.Black
        LinEquationTriple.x3.ForeColor = Color.Black
        LinEquationTriple.y1.ForeColor = Color.Black
        LinEquationTriple.y2.ForeColor = Color.Black
        LinEquationTriple.y3.ForeColor = Color.Black
        LinEquationTriple.z1.ForeColor = Color.Black
        LinEquationTriple.z2.ForeColor = Color.Black
        LinEquationTriple.z3.ForeColor = Color.Black
        LinEquationTriple.Label22.ForeColor = Color.Black
        LinEquationTriple.Label1.ForeColor = Color.Black
        LinEquationTriple.Label8.ForeColor = Color.Black
        LinEquationTriple.Label14.ForeColor = Color.Black
        LinEquationTriple.Label4.ForeColor = Color.Black
        LinEquationTriple.Label7.ForeColor = Color.Black
        LinEquationTriple.Label13.ForeColor = Color.Black
        LinEquationTriple.Label3.ForeColor = Color.Black
        LinEquationTriple.Label2.ForeColor = Color.Black
        LinEquationTriple.Label5.ForeColor = Color.Black
        LinEquationTriple.Label9.ForeColor = Color.Black
        LinEquationTriple.Label10.ForeColor = Color.Black
        LinEquationTriple.Label6.ForeColor = Color.Black
        LinEquationTriple.Closea.ForeColor = Color.Black
        LinEquationTriple.Minimizea.ForeColor = Color.Black
        LinEquationTriple.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.a1.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.a1.BackColor = Answer.DefaultBackColor
        LinEquationTriple.a2.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.a2.BackColor = Answer.DefaultBackColor
        LinEquationTriple.a3.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.a3.BackColor = Answer.DefaultBackColor
        LinEquationTriple.b1.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.b1.BackColor = Answer.DefaultBackColor
        LinEquationTriple.b2.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.b2.BackColor = Answer.DefaultBackColor
        LinEquationTriple.b3.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.b3.BackColor = Answer.DefaultBackColor
        LinEquationTriple.c1.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.c1.BackColor = Answer.DefaultBackColor
        LinEquationTriple.c2.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.c2.BackColor = Answer.DefaultBackColor
        LinEquationTriple.c3.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.c3.BackColor = Answer.DefaultBackColor
        LinEquationTriple.d1.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.d1.BackColor = Answer.DefaultBackColor
        LinEquationTriple.d2.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.d2.BackColor = Answer.DefaultBackColor
        LinEquationTriple.d3.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.d3.BackColor = Answer.DefaultBackColor
        LinEquationTriple.Resultx.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.Resultx.BackColor = Answer.DefaultBackColor
        LinEquationTriple.Resulty.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.Resulty.BackColor = Answer.DefaultBackColor
        LinEquationTriple.Resultz.ForeColor = Answer.DefaultForeColor
        LinEquationTriple.Resultz.BackColor = Answer.DefaultBackColor
        LinEquationTriple.Label1.ForeColor = Color.White
        LinEquationTriple.Button1.BackColor = Answer.DefaultBackColor
        LinEquationTriple.Button1.ForeColor = Answer.DefaultForeColor
        Linearequations.x1.ForeColor = Linearequations.DefaultForeColor
        Linearequations.x2.ForeColor = Linearequations.DefaultForeColor
        Linearequations.y1.ForeColor = Linearequations.DefaultForeColor
        Linearequations.y2.ForeColor = Linearequations.DefaultForeColor
        Linearequations.d1.ForeColor = Linearequations.DefaultForeColor
        Linearequations.d2.ForeColor = Linearequations.DefaultForeColor
        Linearequations.x1.BackColor = Linearequations.DefaultBackColor
        Linearequations.x2.BackColor = Linearequations.DefaultBackColor
        Linearequations.y1.BackColor = Linearequations.DefaultBackColor
        Linearequations.y2.BackColor = Linearequations.DefaultBackColor
        Linearequations.d1.BackColor = Linearequations.DefaultBackColor
        Linearequations.d2.BackColor = Linearequations.DefaultBackColor
        Linearequations.Resultx.BackColor = Linearequations.DefaultBackColor
        Linearequations.Resulty.BackColor = Linearequations.DefaultBackColor
        Linearequations.Resultx.ForeColor = Linearequations.DefaultForeColor
        Linearequations.Resulty.ForeColor = Linearequations.DefaultForeColor
    End Sub
End Class