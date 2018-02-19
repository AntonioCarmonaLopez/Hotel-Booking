
Imports System.Data.OleDb
Imports ADODB

Public Class Form1
    Private WithEvents bmBase As BindingManagerBase

    Const CadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BD1.mdb"

    Public cnn As New OleDb.OleDbConnection(CadenaConexion)

    Private Sub BtnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnVer.Click

        Dim libre As String = "libre"

        Dim cnn As New OleDb.OleDbConnection(CadenaConexion)
        Dim SQL As String = "SELECT * FROM HABITACION_DIAS where fecha BETWEEN '" & TxtInicio.Text & "' and '" & TxtFin.Text & "' and estado= '" & libre & "'"

        Dim DA As New OleDbDataAdapter(SQL, cnn)
        Dim DS As New DataSet

        cnn.Open()

        DA.Fill(DS, "HABITACION_DIAS")

        LblHabitacion.DataBindings.Clear()
        Me.LblHabitacion.DataBindings.Add("text", DS, "HABITACION_DIAS.HABITACION")
        Me.TxtEstado2.DataBindings.Add("text", DS, "HABITACION_DIAS.ESTADO")
        Me.TxtFecha.DataBindings.Add("text", DS, "HABITACION_DIAS.FECHA")


        bmBase = Me.BindingContext(DS, "HABITACION_DIAS")

        If bmBase.Count > 0 Then
            bmBase.Position = bmBase.Count
            bmBase.Position = 0
        End If

        If TxtEstado2.Text = "libre" Then
            TxtEstado2.BackColor = Color.Green
            BtnHacer.Enabled = True
        Else
            TxtEstado2.BackColor = Color.Red
            BtnHacer.Enabled = False
            MessageBox.Show("Ninguna habitacion libre estas fechas", "Mensaje")
        End If

        cnn.Close()
    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged

        TxtInicio.Text = MonthCalendar1.SelectionRange.Start.ToShortDateString()

    End Sub

    Private Sub MonthCalendar2_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar2.DateChanged

        TxtFin.Text = MonthCalendar2.SelectionRange.Start.ToShortDateString()

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        TxtInicio.Enabled = False
        TxtFin.Enabled = False

    End Sub

    Private Sub BtnFinal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        bmBase.Position = bmBase.Count

    End Sub

    Private Sub BtnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        bmBase.Position = bmBase.Position + 1

    End Sub

    Private Sub BtnAnterior_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        bmBase.Position = bmBase.Position - 1

    End Sub

    Private Sub BtnPrincipio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        bmBase.Position = 0

    End Sub

    Private Sub BtnHacer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Form2.Show()

    End Sub
End Class
