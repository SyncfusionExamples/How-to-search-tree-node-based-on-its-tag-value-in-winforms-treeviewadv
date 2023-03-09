Imports Microsoft.VisualBasic
Imports System.Windows.Forms
Namespace TreeViewCustomControl
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
            Dim treeNodeAdv1 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv2 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv3 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodeAdv4 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Dim treeNodePrimitive1 As New Syncfusion.Windows.Forms.Tools.TreeNodePrimitive()
            Dim treeNodeAdv5 As New Syncfusion.Windows.Forms.Tools.TreeNodeAdv()
            Me.comboBoxAdv2 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
            Me.treeViewAdv1 = New Syncfusion.Windows.Forms.Tools.TreeViewAdv()
            Me.comboBoxAdv1 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
            Me.comboBoxAdv3 = New Syncfusion.Windows.Forms.Tools.ComboBoxAdv()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.label1 = New System.Windows.Forms.Label()
            Me.listBox1 = New System.Windows.Forms.ListBox()
            Me.label2 = New System.Windows.Forms.Label()
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.comboBoxAdv3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' comboBoxAdv2
            ' 
            Me.comboBoxAdv2.BackColor = System.Drawing.Color.White
            Me.comboBoxAdv2.BeforeTouchSize = New System.Drawing.Size(121, 21)
            Me.comboBoxAdv2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.comboBoxAdv2.Location = New System.Drawing.Point(143, 105)
            Me.comboBoxAdv2.Name = "comboBoxAdv2"
            Me.comboBoxAdv2.Size = New System.Drawing.Size(121, 21)
            Me.comboBoxAdv2.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
            Me.comboBoxAdv2.TabIndex = 3
            Me.comboBoxAdv2.Text = "comboBoxAdv2"
            ' 
            ' treeViewAdv1
            ' 
            Me.treeViewAdv1.BackColor = System.Drawing.Color.White
            Me.treeViewAdv1.BeforeTouchSize = New System.Drawing.Size(243, 199)
            Me.treeViewAdv1.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat
            Me.treeViewAdv1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv1.CanSelectDisabledNode = False
            Me.treeViewAdv1.GutterSpace = 5
            ' 
            ' 
            ' 
            Me.treeViewAdv1.HelpTextControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv1.HelpTextControl.Location = New System.Drawing.Point(0, 0)
            Me.treeViewAdv1.HelpTextControl.Name = "helpText"
            Me.treeViewAdv1.HelpTextControl.Size = New System.Drawing.Size(49, 15)
            Me.treeViewAdv1.HelpTextControl.TabIndex = 0
            Me.treeViewAdv1.HelpTextControl.Text = "help text"
            Me.treeViewAdv1.ItemHeight = 26
            Me.treeViewAdv1.Location = New System.Drawing.Point(33, 76)
            Me.treeViewAdv1.MetroColor = System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220))))))
            Me.treeViewAdv1.Name = "treeViewAdv1"
            treeNodeAdv1.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv1.EnsureDefaultOptionedChild = True
            treeNodeAdv1.MultiLine = True
            treeNodeAdv1.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv1.ShowLine = True
            treeNodeAdv1.Text = "ComboBoxAdv"
            treeNodeAdv2.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv2.EnsureDefaultOptionedChild = True
            treeNodeAdv2.MultiLine = True
            treeNodeAdv2.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv2.ShowLine = True
            treeNodeAdv2.Text = "TextBoxExt"
            treeNodeAdv3.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv3.EnsureDefaultOptionedChild = True
            treeNodeAdv3.Expanded = True
            treeNodeAdv3.MultiLine = True
            treeNodeAdv4.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv4.EnsureDefaultOptionedChild = True
            treeNodeAdv4.MultiLine = True
            treeNodeAdv4.Optioned = True
            treeNodeAdv4.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodePrimitive1.Index = 0
            treeNodePrimitive1.PrimitiveType = Syncfusion.Windows.Forms.Tools.PredefinedPrimitiveTypes.CustomControl
            treeNodeAdv4.Primitives.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodePrimitive() {treeNodePrimitive1})
            treeNodeAdv4.ShowLine = True
            treeNodeAdv4.Text = "ComboBoxAdv"
            treeNodeAdv3.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {treeNodeAdv4})
            treeNodeAdv3.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv3.ShowLine = True
            treeNodeAdv3.Text = "TreeViewAdv1"
            treeNodeAdv5.ChildStyle.EnsureDefaultOptionedChild = True
            treeNodeAdv5.EnsureDefaultOptionedChild = True
            treeNodeAdv5.MultiLine = True
            treeNodeAdv5.PlusMinusSize = New System.Drawing.Size(9, 9)
            treeNodeAdv5.ShowLine = True
            treeNodeAdv5.Text = "Node0"
            Me.treeViewAdv1.Nodes.AddRange(New Syncfusion.Windows.Forms.Tools.TreeNodeAdv() {treeNodeAdv1, treeNodeAdv2, treeNodeAdv3, treeNodeAdv5})
            Me.treeViewAdv1.SelectedNodeBackground = New Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb((CInt(Fix((CByte(22))))), (CInt(Fix((CByte(165))))), (CInt(Fix((CByte(220)))))))
            Me.treeViewAdv1.ShowFocusRect = False
            Me.treeViewAdv1.Size = New System.Drawing.Size(243, 199)
            Me.treeViewAdv1.Style = Syncfusion.Windows.Forms.Tools.TreeStyle.Metro
            Me.treeViewAdv1.TabIndex = 0
            Me.treeViewAdv1.Text = "treeViewAdv1"
            ' 
            ' 
            ' 
            Me.treeViewAdv1.ToolTipControl.BackColor = System.Drawing.SystemColors.Info
            Me.treeViewAdv1.ToolTipControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.treeViewAdv1.ToolTipControl.Location = New System.Drawing.Point(0, 0)
            Me.treeViewAdv1.ToolTipControl.Name = "toolTip"
            Me.treeViewAdv1.ToolTipControl.Size = New System.Drawing.Size(41, 15)
            Me.treeViewAdv1.ToolTipControl.TabIndex = 1
            Me.treeViewAdv1.ToolTipControl.Text = "toolTip"
            ' 
            ' comboBoxAdv1
            ' 
            Me.comboBoxAdv1.BackColor = System.Drawing.Color.White
            Me.comboBoxAdv1.BeforeTouchSize = New System.Drawing.Size(121, 21)
            Me.comboBoxAdv1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.comboBoxAdv1.Location = New System.Drawing.Point(33, 324)
            Me.comboBoxAdv1.Name = "comboBoxAdv1"
            Me.comboBoxAdv1.Size = New System.Drawing.Size(121, 21)
            Me.comboBoxAdv1.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
            Me.comboBoxAdv1.TabIndex = 2
            Me.comboBoxAdv1.Text = "comboBoxAdv1"
            ' 
            ' comboBoxAdv3
            ' 
            Me.comboBoxAdv3.BackColor = System.Drawing.Color.White
            Me.comboBoxAdv3.BeforeTouchSize = New System.Drawing.Size(121, 21)
            Me.comboBoxAdv3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.comboBoxAdv3.Location = New System.Drawing.Point(179, 324)
            Me.comboBoxAdv3.Name = "comboBoxAdv3"
            Me.comboBoxAdv3.Size = New System.Drawing.Size(121, 21)
            Me.comboBoxAdv3.Style = Syncfusion.Windows.Forms.VisualStyle.Metro
            Me.comboBoxAdv3.TabIndex = 4
            Me.comboBoxAdv3.Text = "comboBoxAdv3"
            ' 
            ' textBox1
            ' 
            Me.textBox1.Location = New System.Drawing.Point(155, 28)
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(121, 20)
            Me.textBox1.TabIndex = 5
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(33, 31)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(92, 13)
            Me.label1.TabIndex = 6
            Me.label1.Text = "Search Tag name"
            ' 
            ' listBox1
            ' 
            Me.listBox1.FormattingEnabled = True
            Me.listBox1.Location = New System.Drawing.Point(338, 76)
            Me.listBox1.Name = "listBox1"
            Me.listBox1.Size = New System.Drawing.Size(210, 199)
            Me.listBox1.TabIndex = 7
            ' 
            ' label2
            ' 
            Me.label2.AutoSize = True
            Me.label2.Location = New System.Drawing.Point(335, 28)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(103, 13)
            Me.label2.TabIndex = 8
            Me.label2.Text = "Matched Treenodes"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0F, 13.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(580, 377)
            Me.Controls.Add(Me.label2)
            Me.Controls.Add(Me.listBox1)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.textBox1)
            Me.Controls.Add(Me.treeViewAdv1)
            Me.Controls.Add(Me.comboBoxAdv3)
            Me.Controls.Add(Me.comboBoxAdv2)
            Me.Controls.Add(Me.comboBoxAdv1)
            Me.Name = "Form1"
            Me.Text = "TreeViewAdv"
            CType(Me.comboBoxAdv2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.treeViewAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxAdv1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.comboBoxAdv3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

#End Region

        Private treeViewAdv1 As Syncfusion.Windows.Forms.Tools.TreeViewAdv
        Private comboBoxAdv1 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Private comboBoxAdv2 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Private comboBoxAdv3 As Syncfusion.Windows.Forms.Tools.ComboBoxAdv
        Private WithEvents textBox1 As TextBox
        Private label1 As Label
        Private listBox1 As ListBox
        Private label2 As Label
    End Class
End Namespace