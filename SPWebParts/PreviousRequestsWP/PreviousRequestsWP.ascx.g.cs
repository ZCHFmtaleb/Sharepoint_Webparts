//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SPWebParts.PreviousRequestsWP {
    using System.Web.UI.WebControls.Expressions;
    using System.Web.UI.HtmlControls;
    using System.Collections;
    using System.Text;
    using System.Web.UI;
    using System.Collections.Generic;
    using System.Linq;
    using System.Xml.Linq;
    using Microsoft.SharePoint.WebPartPages;
    using System.Web.SessionState;
    using System.Configuration;
    using Microsoft.SharePoint;
    using System.Web;
    using System.Web.DynamicData;
    using System.Web.Caching;
    using System.Web.Profile;
    using System.ComponentModel.DataAnnotations;
    using System.Web.UI.WebControls;
    using System.Web.Security;
    using System;
    using Microsoft.SharePoint.Utilities;
    using System.Text.RegularExpressions;
    using System.Collections.Specialized;
    using System.Web.UI.WebControls.WebParts;
    using Microsoft.SharePoint.WebControls;
    using System.CodeDom.Compiler;
    
    
    public partial class PreviousRequestsWP {
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        protected global::System.Web.UI.WebControls.GridView grdPreviousRequests;
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebPartCodeGenerator", "15.0.0.0")]
        public static implicit operator global::System.Web.UI.TemplateControl(PreviousRequestsWP target) 
        {
            return target == null ? null : target.TemplateControl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control2(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Right;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control3(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = global::System.Drawing.Color.White;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control6(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(100D, global::System.Web.UI.WebControls.UnitType.Pixel);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control5() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "ID";
            @__ctrl.HeaderText = "معرف الطلب";
            this.@__BuildControl__control6(@__ctrl.HeaderStyle);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control8(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Center;
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(250D, global::System.Web.UI.WebControls.UnitType.Pixel);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control9(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Center;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control7() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "_x0627__x0644__x0625__x0633__x06";
            @__ctrl.HeaderText = "الاسم العربى";
            @__ctrl.ItemStyle.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Center;
            @__ctrl.HeaderStyle.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Center;
            this.@__BuildControl__control8(@__ctrl.HeaderStyle);
            this.@__BuildControl__control9(@__ctrl.ItemStyle);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control11(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Center;
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(150D, global::System.Web.UI.WebControls.UnitType.Pixel);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control10() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "EIDCardNumber";
            @__ctrl.HeaderText = "رقم الهوية";
            this.@__BuildControl__control11(@__ctrl.HeaderStyle);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control13(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(150D, global::System.Web.UI.WebControls.UnitType.Pixel);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control12() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "Created";
            @__ctrl.HeaderText = "تاريخ الإنشاء";
            @__ctrl.DataFormatString = "{0: dd/MMM/yyyy}";
            this.@__BuildControl__control13(@__ctrl.HeaderStyle);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control15(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(150D, global::System.Web.UI.WebControls.UnitType.Pixel);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.BoundField @__BuildControl__control14() {
            global::System.Web.UI.WebControls.BoundField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.BoundField();
            @__ctrl.DataField = "NewColumn1";
            @__ctrl.HeaderText = "حالة الطلب";
            this.@__BuildControl__control15(@__ctrl.HeaderStyle);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control17(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.Width = new System.Web.UI.WebControls.Unit(150D, global::System.Web.UI.WebControls.UnitType.Pixel);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.HyperLinkField @__BuildControl__control16() {
            global::System.Web.UI.WebControls.HyperLinkField @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.HyperLinkField();
            @__ctrl.Target = "_blank";
            @__ctrl.Text = "عرض السجل الكامل";
            @__ctrl.DataNavigateUrlFields = new string[] {
                    "ID"};
            @__ctrl.DataNavigateUrlFormatString = "http://zf-sp/orgchart/ProgramsDepartment/Lists/AidRequests/Item/displayifs.aspx?I" +
                "D={0}";
            this.@__BuildControl__control17(@__ctrl.HeaderStyle);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control4(System.Web.UI.WebControls.DataControlFieldCollection @__ctrl) {
            global::System.Web.UI.WebControls.BoundField @__ctrl1;
            @__ctrl1 = this.@__BuildControl__control5();
            @__ctrl.Add(@__ctrl1);
            global::System.Web.UI.WebControls.BoundField @__ctrl2;
            @__ctrl2 = this.@__BuildControl__control7();
            @__ctrl.Add(@__ctrl2);
            global::System.Web.UI.WebControls.BoundField @__ctrl3;
            @__ctrl3 = this.@__BuildControl__control10();
            @__ctrl.Add(@__ctrl3);
            global::System.Web.UI.WebControls.BoundField @__ctrl4;
            @__ctrl4 = this.@__BuildControl__control12();
            @__ctrl.Add(@__ctrl4);
            global::System.Web.UI.WebControls.BoundField @__ctrl5;
            @__ctrl5 = this.@__BuildControl__control14();
            @__ctrl.Add(@__ctrl5);
            global::System.Web.UI.WebControls.HyperLinkField @__ctrl6;
            @__ctrl6 = this.@__BuildControl__control16();
            @__ctrl.Add(@__ctrl6);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control18(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(36, 97, 191)));
            @__ctrl.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Center;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control19(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(80, 124, 209)));
            @__ctrl.Font.Bold = true;
            @__ctrl.ForeColor = global::System.Drawing.Color.White;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control20(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(80, 124, 209)));
            @__ctrl.Font.Bold = true;
            @__ctrl.ForeColor = global::System.Drawing.Color.White;
            @__ctrl.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Center;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control21(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(36, 97, 191)));
            @__ctrl.ForeColor = global::System.Drawing.Color.White;
            @__ctrl.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Center;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control22(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(239, 243, 251)));
            @__ctrl.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Center;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control23(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(209, 221, 241)));
            @__ctrl.Font.Bold = true;
            @__ctrl.ForeColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(51, 51, 51)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control24(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(245, 247, 251)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control25(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(109, 149, 225)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control26(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(233, 235, 239)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControl__control27(System.Web.UI.WebControls.TableItemStyle @__ctrl) {
            @__ctrl.BackColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(72, 112, 190)));
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private global::System.Web.UI.WebControls.GridView @__BuildControlgrdPreviousRequests() {
            global::System.Web.UI.WebControls.GridView @__ctrl;
            @__ctrl = new global::System.Web.UI.WebControls.GridView();
            this.grdPreviousRequests = @__ctrl;
            @__ctrl.ApplyStyleSheetSkin(this.Page);
            @__ctrl.ID = "grdPreviousRequests";
            @__ctrl.CellPadding = 4;
            @__ctrl.ForeColor = ((System.Drawing.Color)(global::System.Drawing.Color.FromArgb(51, 51, 51)));
            @__ctrl.AutoGenerateColumns = false;
            @__ctrl.HorizontalAlign = global::System.Web.UI.WebControls.HorizontalAlign.Center;
            @__ctrl.HeaderStyle.CssClass = "centerHeaderText";
            this.@__BuildControl__control2(@__ctrl.HeaderStyle);
            this.@__BuildControl__control20(@__ctrl.HeaderStyle);
            this.@__BuildControl__control3(@__ctrl.AlternatingRowStyle);
            this.@__BuildControl__control4(@__ctrl.Columns);
            this.@__BuildControl__control18(@__ctrl.EditRowStyle);
            this.@__BuildControl__control19(@__ctrl.FooterStyle);
            this.@__BuildControl__control21(@__ctrl.PagerStyle);
            this.@__BuildControl__control22(@__ctrl.RowStyle);
            this.@__BuildControl__control23(@__ctrl.SelectedRowStyle);
            this.@__BuildControl__control24(@__ctrl.SortedAscendingCellStyle);
            this.@__BuildControl__control25(@__ctrl.SortedAscendingHeaderStyle);
            this.@__BuildControl__control26(@__ctrl.SortedDescendingCellStyle);
            this.@__BuildControl__control27(@__ctrl.SortedDescendingHeaderStyle);
            return @__ctrl;
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void @__BuildControlTree(global::SPWebParts.PreviousRequestsWP.PreviousRequestsWP @__ctrl) {
            System.Web.UI.IParserAccessor @__parser = ((System.Web.UI.IParserAccessor)(@__ctrl));
            @__parser.AddParsedSubObject(new System.Web.UI.LiteralControl(@"

<script type=""text/javascript"">
    $(document).ready(function () {
        $('div.row').hide();
    });
</script>

<style type=""text/css"">
    .s4-breadcrumb ul {
        display: none !important;
    }
    .centerHeaderText th {
        text-align: center;
    }
</style>

"));
            global::System.Web.UI.WebControls.GridView @__ctrl1;
            @__ctrl1 = this.@__BuildControlgrdPreviousRequests();
            @__parser.AddParsedSubObject(@__ctrl1);
        }
        
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        private void InitializeControl() {
            this.@__BuildControlTree(this);
            this.Load += new global::System.EventHandler(this.Page_Load);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        protected virtual object Eval(string expression) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression);
        }
        
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
        [GeneratedCodeAttribute("Microsoft.VisualStudio.SharePoint.ProjectExtensions.CodeGenerators.SharePointWebP" +
            "artCodeGenerator", "15.0.0.0")]
        protected virtual string Eval(string expression, string format) {
            return global::System.Web.UI.DataBinder.Eval(this.Page.GetDataItem(), expression, format);
        }
    }
}
