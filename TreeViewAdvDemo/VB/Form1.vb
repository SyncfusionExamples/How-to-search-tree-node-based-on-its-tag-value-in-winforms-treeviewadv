Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools

Namespace TreeViewCustomControl
    Partial Public Class Form1
        Inherits Form

#Region "Constructor"

        Public Sub New()
            InitializeComponent()
            Me.treeViewAdv1.Nodes(0).CustomControl = Me.comboBoxAdv1
            Me.treeViewAdv1.Nodes(2).Nodes(0).CustomControl = Me.comboBoxAdv3

            Me.treeViewAdv1.Nodes(0).Tag = "Search node"
            Me.treeViewAdv1.Nodes(1).Tag = "Search node"
            Me.treeViewAdv1.Nodes(2).Tag = "Search node"
            Me.treeViewAdv1.Nodes(2).Nodes(0).Tag = "Search node"

            'To search all nodes
            nodes = treeViewAdv1.SearchTree().Where(Function(n) n.Tag = "Search node").ToList()
        End Sub

#End Region

        Private nodes As List(Of TreeNodeAdv)

        Private Sub textBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles textBox1.TextChanged
            Me.listBox1.Items.Clear()
            If Me.textBox1.Text = "Search node" Then
                For Each item As TreeNodeAdv In nodes
                    Me.listBox1.Items.Add(item.Text & " :" & "Tag : " & item.Tag)
                Next item
            End If
        End Sub
    End Class

    Public Module SOExtension
        <System.Runtime.CompilerServices.Extension()>
        Public Function SearchTree(ByVal treeView As TreeViewAdv) As IEnumerable(Of TreeNodeAdv)
            Return SearchTree(treeView.Nodes)
        End Function

        <System.Runtime.CompilerServices.Extension()>
        Public Function SearchTree(ByVal coll As TreeNodeAdvCollection) As IEnumerable(Of TreeNodeAdv)
            Return coll.Cast(Of TreeNodeAdv)().Concat(coll.Cast(Of TreeNodeAdv)().SelectMany(Function(x) SearchTree(x.Nodes)))
        End Function
    End Module
End Namespace