<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DollarB = New System.Windows.Forms.Button()
        Me.QuarterB = New System.Windows.Forms.Button()
        Me.DimeB = New System.Windows.Forms.Button()
        Me.NickelB = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(620, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'DollarB
        '
        Me.DollarB.Location = New System.Drawing.Point(51, 197)
        Me.DollarB.Name = "DollarB"
        Me.DollarB.Size = New System.Drawing.Size(75, 23)
        Me.DollarB.TabIndex = 1
        Me.DollarB.Text = "Dollar"
        Me.DollarB.UseVisualStyleBackColor = True
        '
        'QuarterB
        '
        Me.QuarterB.Location = New System.Drawing.Point(216, 197)
        Me.QuarterB.Name = "QuarterB"
        Me.QuarterB.Size = New System.Drawing.Size(75, 23)
        Me.QuarterB.TabIndex = 2
        Me.QuarterB.Text = "Qaurter"
        Me.QuarterB.UseVisualStyleBackColor = True
        '
        'DimeB
        '
        Me.DimeB.Location = New System.Drawing.Point(351, 173)
        Me.DimeB.Name = "DimeB"
        Me.DimeB.Size = New System.Drawing.Size(118, 120)
        Me.DimeB.TabIndex = 3
        Me.DimeB.Text = "Dime"
        Me.DimeB.UseVisualStyleBackColor = True
        '
        'NickelB
        '
        Me.NickelB.Location = New System.Drawing.Point(543, 185)
        Me.NickelB.Name = "NickelB"
        Me.NickelB.Size = New System.Drawing.Size(75, 23)
        Me.NickelB.TabIndex = 4
        Me.NickelB.Text = "Nickel"
        Me.NickelB.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.NickelB)
        Me.Controls.Add(Me.DimeB)
        Me.Controls.Add(Me.QuarterB)
        Me.Controls.Add(Me.DollarB)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DollarB As Button
    Friend WithEvents QuarterB As Button
    Friend WithEvents DimeB As Button
    Friend WithEvents NickelB As Button
End Class
