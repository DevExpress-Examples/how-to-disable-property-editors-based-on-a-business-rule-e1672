Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports DevExpress.ExpressApp.Web

Namespace EditorStateExample.Web
    Partial Public Class EditorStateExampleAspNetApplication
        Inherits WebApplication
        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule
        Private module3 As EditorStateExample.Module.EditorStateExampleModule

        Private module6 As DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule
        Private sqlConnection1 As System.Data.SqlClient.SqlConnection
        Private conditionalEditorStateAspNetModule1 As DevExpress.ExpressApp.ConditionalEditorState.Web.ConditionalEditorStateAspNetModule
        Private conditionalEditorStateModuleBase1 As DevExpress.ExpressApp.ConditionalEditorState.ConditionalEditorStateModuleBase
        Private module5 As DevExpress.ExpressApp.Validation.ValidationModule

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub EditorStateExampleAspNetApplication_DatabaseVersionMismatch(ByVal sender As Object, ByVal e As DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs) Handles MyBase.DatabaseVersionMismatch
            e.Updater.Update()
            e.Handled = True
        End Sub

        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Web.SystemModule.SystemAspNetModule()
            Me.module3 = New EditorStateExample.Module.EditorStateExampleModule()

            Me.module5 = New DevExpress.ExpressApp.Validation.ValidationModule()
            Me.module6 = New DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule()
            Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
            Me.conditionalEditorStateAspNetModule1 = New DevExpress.ExpressApp.ConditionalEditorState.Web.ConditionalEditorStateAspNetModule()
            Me.conditionalEditorStateModuleBase1 = New DevExpress.ExpressApp.ConditionalEditorState.ConditionalEditorStateModuleBase()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' module5
            ' 
            Me.module5.AllowValidationDetailsAccess = True
            ' 
            ' sqlConnection1
            ' 
            Me.sqlConnection1.ConnectionString = "Data Source=(local);Initial Catalog=EditorStateExample;Integrated Security=SSPI;P" & "ooling=false"
            Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
            ' 
            ' EditorStateExampleAspNetApplication
            ' 
            Me.ApplicationName = "EditorStateExample"
            Me.Connection = Me.sqlConnection1
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module6)
            Me.Modules.Add(Me.module3)

            Me.Modules.Add(Me.module5)
            Me.Modules.Add(Me.conditionalEditorStateModuleBase1)
            Me.Modules.Add(Me.conditionalEditorStateAspNetModule1)
'            Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.EditorStateExampleAspNetApplication_DatabaseVersionMismatch);
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
    End Class
End Namespace