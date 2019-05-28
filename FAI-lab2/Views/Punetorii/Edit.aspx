<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="FAI_lab2.Views.Punetorii.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
   
    <div class="form-horizontal">
        <div class="row">
            <asp:Label ID="TitlePageLabel" Text="Regjistro Punetorin" runat="server" class="col-md-3 control-label" Style="color: #337ab7; font-weight: bold;"></asp:Label>
        </div>
        <div class="form-body">
            <div class="form-group">
                <label class="text-center" style="width: 100%;">
                    <br />
                    <asp:Label ID="lblError" runat="server" Text="Fushat e shenjuara me (*) duhet të plotësohen!" Visible="False" CssClass="col-md-12 alert alert-danger"></asp:Label></label>
                <br />
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="nNameLabel" Text="Emri i Punetorit*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="EmriTextBox" CssClass="form-control" runat="server" Placeholder="Emri i Punetorit"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="NameHelpBlockLabel" Text="Shkruani emrin e Punetorit" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="MbiemriLabel" Text="Mbiemri*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="MbiemriTextBox" CssClass="form-control" runat="server" Placeholder="Mbiemri"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="MbiemriHelpBlockLabel" Text="Shkruani Mbiemrin" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="GjiniaLabel" Text="Gjinia*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="GjiniaTextBox" CssClass="form-control" runat="server" Placeholder="Gjinia"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="GjiniaHelpBlockLabel" Text="Shkruani gjin" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
             <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="RoliLabel" Text="Roli*" runat="server"></asp:Label>
                </label>
                <asp:DropDownList ID="RoliDropDownList" DataTextField="Roli" 
                    DataValueField="RoliID" runat="server">
                </asp:DropDownList> 
            </div>
            <div class="form-actions">
                <div class="row">
                    <div class="pull-right mr-1">

                   
                        <asp:Button ID="CancelButton" type="button" runat="server" OnClick="CancelButton_Click" class="btn default" Text="Anulo" />
                        <asp:Button ID="SaveButton" type="button" runat="server" OnClick="SaveButton_Click" class="btn btn-primary" Text="Ruaj" />
                   
                        </div>
                </div>
            </div>
        </div>

    </div>
</asp:Content>
