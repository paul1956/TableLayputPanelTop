Public Class TableLayoutPanelTopEx
    Inherits TableLayoutPanel

    Private WithEvents Button1 As Button

    Private ReadOnly _label As Label

    Public Sub New()
        MyBase.New
        Me.Button1 = New Button
        _label = New Label
        Me.AutoSize = True
        Me.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
        Me.ColumnCount = 2
        Me.ColumnStyles.Add(New ColumnStyle())
        Me.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0!))
        Me.Controls.Add(Me.Button1, 0, 0)
        Me.Controls.Add(_label, 1, 0)
        Me.Dock = DockStyle.Fill
        Me.Location = New Point(3, 3)
        Me.Name = ""
        Me.RowCount = 1
        Me.RowStyles.Add(New RowStyle())
        Me.Size = New Size(1364, 37)
        Me.TabIndex = 1

        Me.Button1.AutoSize = True
        Me.Button1.Location = New Point(6, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New Size(142, 25)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Return To Summary Tab"

        _label.AutoSize = True
        _label.Dock = DockStyle.Fill
        _label.Location = New Point(157, 6)
        _label.Margin = New Padding(3)
        _label.Name = "Label"
        _label.Size = New Size(1201, 25)
        _label.TabIndex = 1
        _label.Text = ""
        _label.TextAlign = ContentAlignment.MiddleCenter

    End Sub

    Public Event ButtonClick(sender As Object, e As EventArgs)

    Public Property ButtonText As String
        Get
            Return Me.Button1.Text
        End Get
        Set
            Me.Button1.Text = Value
        End Set
    End Property

    Public Property LabelText As String
        Get
            Return _label.Text
        End Get
        Set
            _label.Text = Value
        End Set
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RaiseEvent ButtonClick(sender, e)
    End Sub

End Class
