Namespace AccordionControl_ex
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.listBoxControl1 = New DevExpress.XtraEditors.ListBoxControl()
            DirectCast(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' listBoxControl1
            ' 
            Me.listBoxControl1.Cursor = System.Windows.Forms.Cursors.Default
            Me.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Right
            Me.listBoxControl1.Location = New System.Drawing.Point(483, 0)
            Me.listBoxControl1.Name = "listBoxControl1"
            Me.listBoxControl1.Size = New System.Drawing.Size(209, 391)
            Me.listBoxControl1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(692, 391)
            Me.Controls.Add(Me.listBoxControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.listBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private listBoxControl1 As DevExpress.XtraEditors.ListBoxControl
    End Class
End Namespace

