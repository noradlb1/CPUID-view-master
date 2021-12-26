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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.AevionLabel2 = New TutoCPUID.AevionLabel()
        Me.AevionButton1 = New TutoCPUID.AevionButton()
        Me.AevionLabel1 = New TutoCPUID.AevionLabel()
        Me.AevionForm1 = New TutoCPUID.AevionForm()
        Me.SuspendLayout()
        '
        'AevionLabel2
        '
        Me.AevionLabel2.AutoSize = True
        Me.AevionLabel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.AevionLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AevionLabel2.ForeColor = System.Drawing.Color.White
        Me.AevionLabel2.Location = New System.Drawing.Point(211, 96)
        Me.AevionLabel2.Name = "AevionLabel2"
        Me.AevionLabel2.Size = New System.Drawing.Size(45, 15)
        Me.AevionLabel2.TabIndex = 3
        Me.AevionLabel2.Text = "ABOUT"
        '
        'AevionButton1
        '
        Me.AevionButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.AevionButton1.ButtonStyle = TutoCPUID.AevionButton.Style.DefaultStyle
        Me.AevionButton1.ImagePath = Nothing
        Me.AevionButton1.Location = New System.Drawing.Point(181, 0)
        Me.AevionButton1.Name = "AevionButton1"
        Me.AevionButton1.ShowIcon = False
        Me.AevionButton1.Size = New System.Drawing.Size(75, 23)
        Me.AevionButton1.TabIndex = 2
        Me.AevionButton1.Text = "X"
        Me.AevionButton1.UseVisualStyleBackColor = False
        '
        'AevionLabel1
        '
        Me.AevionLabel1.AutoSize = True
        Me.AevionLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.AevionLabel1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AevionLabel1.ForeColor = System.Drawing.Color.White
        Me.AevionLabel1.Location = New System.Drawing.Point(24, 49)
        Me.AevionLabel1.Name = "AevionLabel1"
        Me.AevionLabel1.Size = New System.Drawing.Size(37, 30)
        Me.AevionLabel1.TabIndex = 1
        Me.AevionLabel1.Text = "...."
        '
        'AevionForm1
        '
        Me.AevionForm1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.AevionForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AevionForm1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.AevionForm1.ForeColor = System.Drawing.Color.White
        Me.AevionForm1.Location = New System.Drawing.Point(0, 0)
        Me.AevionForm1.Name = "AevionForm1"
        Me.AevionForm1.Size = New System.Drawing.Size(258, 113)
        Me.AevionForm1.TabIndex = 0
        Me.AevionForm1.Text = "AevionForm1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(258, 113)
        Me.Controls.Add(Me.AevionLabel2)
        Me.Controls.Add(Me.AevionButton1)
        Me.Controls.Add(Me.AevionLabel1)
        Me.Controls.Add(Me.AevionForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "TutoCPUID"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AevionForm1 As AevionForm
    Friend WithEvents AevionLabel1 As AevionLabel
    Friend WithEvents AevionButton1 As AevionButton
    Friend WithEvents AevionLabel2 As AevionLabel
End Class
