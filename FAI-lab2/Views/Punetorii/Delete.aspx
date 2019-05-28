<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="FAI_lab2.Views.Punetorii.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">.

       <div class="form-horizontal">
        <div class="form-body">
            <div class="form-group">
                <label class="text-center" style="width: 100%;">
                    <asp:Label ID="lblError" runat="server" Text="A jeni i sigurt se dëshironi ta fshini këtë entitet?" Visible="False" CssClass="col-md-12 alert alert-danger"></asp:Label></label>
                <br />
            </div>
        </div>
        <div class="form-actions">
            <div class="row">
                <div class="col-md-4 col-md-offset-5">
                    <asp:Button ID="btnCancel" runat="server" Text="Anulo" OnClick="btnCancel_Click" CssClass="btn default" />&nbsp;
                    <asp:Button ID="btnOK" runat="server" Text="Fshije" OnClick="btnOK_Click" CssClass="btn btn-danger" />
                </div>
            </div>
        </div>
    </div>

</asp:Content>
