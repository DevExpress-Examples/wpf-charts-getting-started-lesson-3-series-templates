'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18408
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Namespace DXCharts_Lesson3.Properties

    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")>
    Friend NotInheritable Partial Class Settings
        Inherits Global.System.Configuration.ApplicationSettingsBase

        Private Shared defaultInstance As DXCharts_Lesson3.Properties.Settings = CType((Global.System.Configuration.ApplicationSettingsBase.Synchronized(New DXCharts_Lesson3.Properties.Settings())), DXCharts_Lesson3.Properties.Settings)

        Public Shared ReadOnly Property [Default] As Settings
            Get
                Return DXCharts_Lesson3.Properties.Settings.defaultInstance
            End Get
        End Property

        <Global.System.Configuration.ApplicationScopedSettingAttribute()>
        <Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>
        <Global.System.Configuration.SpecialSettingAttribute(Global.System.Configuration.SpecialSetting.ConnectionString)>
        <Global.System.Configuration.DefaultSettingValueAttribute("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\gsp.mdb;Persist Secu" & "rity Info=True")>
        Public ReadOnly Property gspConnectionString As String
            Get
                Return(CStr((Me("gspConnectionString"))))
            End Get
        End Property
    End Class
End Namespace
