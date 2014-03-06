using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows.Markup;
using Infragistics;
using System.Windows;
using System.Security;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle(AssemblyRef.AssemblyName + AssemblyRef.ProductTitleSuffix)]
[assembly: AssemblyDescription(AssemblyRef.AssemblyDescriptionBase + " - " + AssemblyRef.Configuration + " Version")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Infragistics, Inc.")]
[assembly: AssemblyProduct(AssemblyRef.AssemblyProduct + AssemblyRef.ProductTitleSuffix)]
[assembly: AssemblyCopyright("Copyright © Infragistics, Inc. 2008 - " + AssemblyVersion.EndCopyrightYear)]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: StringResourceLocation("Infragistics.Controls.Menus.Strings")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("a81930f5-c581-4efc-a86f-29bc3c17de95")]


[assembly: AssemblyVersion(AssemblyVersion.Version)]
[assembly: AssemblyFileVersion(AssemblyVersion.Version)]
[assembly: SatelliteContractVersion(AssemblyVersion.SatelliteContractVersion)]

[assembly: XmlnsPrefix("http://schemas.infragistics.com/xaml", "ig")]
[assembly: XmlnsDefinition("http://schemas.infragistics.com/xaml", "Infragistics.Controls.Menus")]



[assembly: ThemeInfo(
    ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
    //(used if a resource is not found in the page, 
    // or application resource dictionaries)
    ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
    //(used if a resource is not found in the page, 
    // app, or any theme specific resource dictionaries)
)]

[assembly: AllowPartiallyTrustedCallers()]
[assembly: SecurityRules(SecurityRuleSet.Level1)]



[assembly: CLSCompliant(true)]
[assembly: NeutralResourcesLanguage("en-US")]
#pragma warning disable 436
class AssemblyRef
{
    internal const string AssemblyName = AssemblyRef.AssemblyNamePrefix + ".Controls.Menus.XamTagCloud" + AssemblyRef.AssemblyNameSuffix;


    internal const string AssemblyProduct = "Infragistics NetAdvantage for WPF";
    internal const string AssemblyDescriptionBase = "Infragistics XamTagCloud for WPF";





    internal const string Configuration = AssemblyVersion.Configuration;


    internal const string ProductTitleSuffix = "";







	internal const string AssemblyNamePrefix = "InfragisticsWPF4";





    internal const string AssemblyNameSuffix = ".v" + AssemblyVersion.MajorMinor;
}
#pragma warning restore 436
#region Copyright (c) 2001-2012 Infragistics, Inc. All Rights Reserved
/* ---------------------------------------------------------------------*
*                           Infragistics, Inc.                          *
*              Copyright (c) 2001-2012 All Rights reserved               *
*                                                                       *
*                                                                       *
* This file and its contents are protected by United States and         *
* International copyright laws.  Unauthorized reproduction and/or       *
* distribution of all or any portion of the code contained herein       *
* is strictly prohibited and will result in severe civil and criminal   *
* penalties.  Any violations of this copyright will be prosecuted       *
* to the fullest extent possible under law.                             *
*                                                                       *
* THE SOURCE CODE CONTAINED HEREIN AND IN RELATED FILES IS PROVIDED     *
* TO THE REGISTERED DEVELOPER FOR THE PURPOSES OF EDUCATION AND         *
* TROUBLESHOOTING. UNDER NO CIRCUMSTANCES MAY ANY PORTION OF THE SOURCE *
* CODE BE DISTRIBUTED, DISCLOSED OR OTHERWISE MADE AVAILABLE TO ANY     *
* THIRD PARTY WITHOUT THE EXPRESS WRITTEN CONSENT OF INFRAGISTICS, INC. *
*                                                                       *
* UNDER NO CIRCUMSTANCES MAY THE SOURCE CODE BE USED IN WHOLE OR IN     *
* PART, AS THE BASIS FOR CREATING A PRODUCT THAT PROVIDES THE SAME, OR  *
* SUBSTANTIALLY THE SAME, FUNCTIONALITY AS ANY INFRAGISTICS PRODUCT.    *
*                                                                       *
* THE REGISTERED DEVELOPER ACKNOWLEDGES THAT THIS SOURCE CODE           *
* CONTAINS VALUABLE AND PROPRIETARY TRADE SECRETS OF INFRAGISTICS,      *
* INC.  THE REGISTERED DEVELOPER AGREES TO EXPEND EVERY EFFORT TO       *
* INSURE ITS CONFIDENTIALITY.                                           *
*                                                                       *
* THE END USER LICENSE AGREEMENT (EULA) ACCOMPANYING THE PRODUCT        *
* PERMITS THE REGISTERED DEVELOPER TO REDISTRIBUTE THE PRODUCT IN       *
* EXECUTABLE FORM ONLY IN SUPPORT OF APPLICATIONS WRITTEN USING         *
* THE PRODUCT.  IT DOES NOT PROVIDE ANY RIGHTS REGARDING THE            *
* SOURCE CODE CONTAINED HEREIN.                                         *
*                                                                       *
* THIS COPYRIGHT NOTICE MAY NOT BE REMOVED FROM THIS FILE.              *
* --------------------------------------------------------------------- *
*/
#endregion Copyright (c) 2001-2012 Infragistics, Inc. All Rights Reserved