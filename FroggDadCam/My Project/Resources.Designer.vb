﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.34209
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    'à l'aide d'un outil, tel que ResGen ou Visual Studio.
    'Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    'avec l'option /str ou régénérez votre projet VS.
    '''<summary>
    '''  Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("DadCam.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Remplace la propriété CurrentUICulture du thread actuel pour toutes
        '''  les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Byte[].
        '''</summary>
        Friend ReadOnly Property AxInterop_WMPLib() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("AxInterop_WMPLib", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property d() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("d", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        '''&lt;lang&gt;
        '''    &lt;Configuration&gt;
        '''        &lt;ConfPathDialDesc&gt;Select video download path&lt;/ConfPathDialDesc&gt;
        '''        &lt;ConfOk&gt;Configuration saved&lt;/ConfOk&gt;
        '''        &lt;ConfErr&gt;Please check the informations filled&lt;/ConfErr&gt;
        '''        &lt;ConfConnErr&gt;Unable to connect to camera, please check filled information&lt;/ConfConnErr&gt;
        '''        &lt;ConfModelErr&gt;Camera model is empty&lt;/ConfModelErr&gt;
        '''        &lt;ConfUrlErr&gt;Camera address is invalid&lt;/ConfUrlErr&gt;
        '''        &lt;ConfPassErr&gt;Password is empty&lt;/C [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property EN() As String
            Get
                Return ResourceManager.GetString("EN", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot; ?&gt;
        '''&lt;lang&gt;
        '''    &lt;Configuration&gt;
        '''        &lt;ConfPathDialDesc&gt;Sélectionnez un répertoire de téléchargement des vidéos&lt;/ConfPathDialDesc&gt;
        '''        &lt;ConfOk&gt;Configuration sauvegardée&lt;/ConfOk&gt;
        '''        &lt;ConfErr&gt;Merci de corriger votre saisie&lt;/ConfErr&gt;
        '''        &lt;ConfConnErr&gt;Impossible de se connecter à la caméra, merci de vérifier les informations saisies&lt;/ConfConnErr&gt;
        '''        &lt;ConfModelErr&gt;Vous n&apos;avez pas saisi de model de caméra&lt;/ConfModelErr&gt;
        '''        &lt;ConfUrlErr&gt;L&apos;adresse d [le reste de la chaîne a été tronqué]&quot;;.
        '''</summary>
        Friend ReadOnly Property FR() As String
            Get
                Return ResourceManager.GetString("FR", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property frogglogo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("frogglogo", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Byte[].
        '''</summary>
        Friend ReadOnly Property Interop_WMPLib() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("Interop_WMPLib", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property l() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("l", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property r() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("r", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une ressource localisée de type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property u() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("u", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace