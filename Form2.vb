Public Class Form2

    Private WithEvents bmBase As BindingManagerBase

    Const CadenaConexion As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BD1.mdb"

    Public cnn As New OleDb.OleDbConnection(CadenaConexion)

    Private Sub BtnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConfirmar.Click


        Dim ocupado As String = "ocupado"

        Dim sql As String = "update HABITACION_DIAS set ESTADO = '" & ocupado & "'  where FECHA BETWEEN '" & TxtFecha1.Text & "' and '" & TxtFecha2.Text & "' and HABITACION= '" & TxtHabitacion2.Text & "'"

        Dim cmd As New OleDb.OleDbCommand(sql, cnn)

        cnn.Open()
        Dim r As Int32 = cmd.ExecuteNonQuery
        If r <> 0 Then MessageBox.Show("Reserva Confirmada", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)

        If r = 0 Then MessageBox.Show("La Reserva no se ha efectuado, revise los datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information)

        cmd.Dispose()
        cnn.Close()


    End Sub

    Private Sub MonthCalendar1_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateChanged

        TxtFecha1.Text = MonthCalendar1.SelectionRange.Start.ToShortDateString()

    End Sub

    Private Sub MonthCalendar2_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs)

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class