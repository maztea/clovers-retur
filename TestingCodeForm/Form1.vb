Public Class Form1
    Dim dtInput As DataTable
    Dim dtPOCustD As DataTable
    Dim dtResult As DataTable

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitData()

        DGInput.DataSource = dtInput
        DGPoCustD.DataSource = dtPOCustD
        DGResult.DataSource = dtResult

        DGInput.Columns("Urut").Width = 60
        DGPoCustD.Columns("RecD").Width = 60
        DGPoCustD.Columns("QtyPromo").Width = 60
        DGPoCustD.Columns("QtyProduk").Width = 60
        DGPoCustD.Columns("QtyRetur").Width = 60
        DGPoCustD.Columns("QtySisaRetur").Width = 60
    End Sub

    Private Sub InitData()
        dtInput = New DataTable
        dtInput.Clear()
        dtInput.Columns.Add("Urut", GetType(Int16))
        dtInput.Columns.Add("Kode", GetType(String))
        dtInput.Columns.Add("Nama", GetType(String))
        dtInput.Columns.Add("Qty", GetType(Decimal))
        dtInput.Columns.Add("Promo", GetType(Boolean))
        dtInput.Columns.Add("NoSO", GetType(String))

        dtInput.Rows.Add(1, "T00112", "TOTO CW421JW/F WHITE", 4, True, "SO/01/22060001")
        dtInput.Rows.Add(2, "PROD001", "PROD001", 3, False, "SO/01/22060001")

        dtPOCustD = New DataTable
        dtPOCustD.Clear()
        dtPOCustD.Columns.Add("RecD", GetType(Int16))
        dtPOCustD.Columns.Add("KodePromo", GetType(String))
        dtPOCustD.Columns.Add("NamaPromo", GetType(String))
        dtPOCustD.Columns.Add("KodeProduk", GetType(String))
        dtPOCustD.Columns.Add("QtyPromo", GetType(Decimal))
        dtPOCustD.Columns.Add("QtyProduk", GetType(Decimal))
        dtPOCustD.Columns.Add("QtyRetur", GetType(Decimal))
        dtPOCustD.Columns.Add("QtySisaRetur", GetType(Decimal))
        dtPOCustD.Columns.Add("UrutSO", GetType(Int16))
        dtPOCustD.Columns.Add("NoSO", GetType(String))

        dtPOCustD.Rows.Add(1, "T00112", "TOTO CW421JW/F WHITE", "TOTO CW421JW/F WHITE", 5, 4, 0, 4, 1, "SO/01/22060001")
        dtPOCustD.Rows.Add(2, "T00112", "TOTO CW421JW/F WHITE", "TOTO CW421JW/F WHITE", 5, 1, 0, 1, 1, "SO/01/22060001")
        dtPOCustD.Rows.Add(3, "T00112", "TOTO CW421JW/F WHITE", "TOTO TC505S", 5, 5, 0, 5, 1, "SO/01/22060001")
        dtPOCustD.Rows.Add(4, "PROD001", "PROD001", "PROD001", 3, 2, 0, 2, 2, "SO/01/22060001")
        dtPOCustD.Rows.Add(5, "PROD001", "PROD001", "PROD001", 3, 1, 0, 1, 2, "SO/01/22060001")

        dtResult = New DataTable
        dtResult.Columns.Add("Urut", GetType(Int16))
        dtResult.Columns.Add("KodePromo", GetType(String))
        dtResult.Columns.Add("KodeProduk", GetType(String))
        dtResult.Columns.Add("QtyPromo", GetType(Decimal))
        dtResult.Columns.Add("QtyProduk", GetType(Decimal))
        dtResult.Columns.Add("RecDSO", GetType(Int16))

    End Sub

    Private Sub SaveToolStripButton_Click(sender As Object, e As EventArgs) Handles SaveToolStripButton.Click

    End Sub
End Class
