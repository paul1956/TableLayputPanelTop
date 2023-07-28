' Licensed to the .NET Foundation under one or more agreements.
' The .NET Foundation licenses this file to you under the MIT license.
' See the LICENSE file in the project root for more information.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TableLayoutPanelTopEx1 = New TableLayputPanelTop.TableLayoutPanelTopEx()
        Me.SuspendLayout()
        ' 
        ' TableLayoutPanelTopEx1
        ' 
        Me.TableLayoutPanelTopEx1.AutoSize = True
        Me.TableLayoutPanelTopEx1.AutoSizeMode = AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanelTopEx1.ButtonText = "Return To Summary Tab"
        Me.TableLayoutPanelTopEx1.CellBorderStyle = TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TableLayoutPanelTopEx1.ColumnCount = 2
        Me.TableLayoutPanelTopEx1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        Me.TableLayoutPanelTopEx1.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        Me.TableLayoutPanelTopEx1.Dock = DockStyle.Fill
        Me.TableLayoutPanelTopEx1.LabelText = "Help"
        Me.TableLayoutPanelTopEx1.Location = New Point(0, 0)
        Me.TableLayoutPanelTopEx1.Name = "TableLayoutPanelTopEx1"
        Me.TableLayoutPanelTopEx1.RowCount = 2
        Me.TableLayoutPanelTopEx1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        Me.TableLayoutPanelTopEx1.RowStyles.Add(New RowStyle(SizeType.Percent, 50F))
        Me.TableLayoutPanelTopEx1.Size = New Size(800, 450)
        Me.TableLayoutPanelTopEx1.TabIndex = 1
        ' 
        ' Form1
        ' 
        Me.AutoScaleDimensions = New SizeF(7F, 15F)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanelTopEx1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents TableLayoutPanelTopEx1 As TableLayputPanelTop.TableLayoutPanelTopEx
End Class
