using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Infragistics.Controls.Grids.Primitives
{
	/// <summary>
	/// A cell that represents a particular column in the footer of the <see cref="XamGrid"/>
	/// </summary>
	public class FooterCell : CellBase
	{
		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="FooterCell"/> class.
		/// </summary>
		/// <param propertyName="row">The <see cref="FooterRow"/> object that owns the <see cref="FooterCell"/></param>
		/// <param propertyName="column">The <see cref="Column"/> object that the <see cref="FooterCell"/> represents.</param>
		protected internal FooterCell(RowBase row, Column column)
			: base(row, column)
		{

		}

		#endregion // Constructor

		#region Overrides

		#region EnsureCurrentState

		/// <summary>
		/// Ensures that <see cref="FooterCell"/> is in the correct state.
		/// </summary>
		protected internal override void EnsureCurrentState()
		{
			if (this.Control != null)
			{
				Column col = this.Column;

				if (col != null)
				{
					if (!(col.IsFixed == FixedState.NotFixed))
						this.Control.GoToState("Fixed", false);
					else
						this.Control.GoToState("Unfixed", false);
				}
			}
			base.EnsureCurrentState();
		}
		#endregion // EnsureCurrentState

		#region ResolveStyle

		/// <summary>
		/// Gets the Style that should be applied to the <see cref="FooterCellControl"/> when it's attached.
		/// </summary>
		protected override Style ResolveStyle
		{
			get
			{
				if (this.Style == null)
					return this.Column.FooterStyleResolved;
				else
					return this.Style;
			}
		}

		#endregion // ResolveStyle

		#region RecyclingElementType
		/// <summary>
		/// Gets the Type of control that should be created for the <see cref="FooterCell"/>.
		/// </summary>
		protected override Type RecyclingElementType
		{
			get
			{
                return null;
			}
		}
		#endregion // RecyclingElementType

        #region RecyclingIdentifier

        /// <summary>
        /// If a <see cref="RecyclingElementType"/> isn't specified, this property can be used to offer another way of identifying 
        /// a reyclable element.
        /// </summary>
        protected override string RecyclingIdentifier
        {
            get
            {
                return this.Row.RowType.ToString() + "_" + this.Column.Key + "_" + this.Column.ColumnLayout.Key;
            }
        }
        #endregion // RecyclingIdentifier

		#region CreateInstanceOfRecyclingElement

		/// <summary>
		/// Creates a new instance of a <see cref="FooterCellControl"/> for the <see cref="FooterCell"/>.
		/// </summary>
		/// <returns>A new <see cref="FooterCellControl"/></returns>
		/// <remarks>This method should only be used by the <see cref="Infragistics.RecyclingManager"/></remarks>
		protected override CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new FooterCellControl();
		}

		#endregion // CreateInstanceOfRecyclingElement

		#endregion // Overrides
	}
}

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