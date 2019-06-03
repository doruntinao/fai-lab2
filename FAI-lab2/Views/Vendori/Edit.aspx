<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="FAI_lab2.Views.Vendori.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <div class="form-horizontal">
        <div class="row">
            <asp:Label ID="TitlePageLabel" Text="Regjistro Vendorin" runat="server" class="col-md-3 control-label" Style="color: #337ab7; font-weight: bold;"></asp:Label>
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
                    <asp:Label ID="nNameLabel" Text="Emri i Vendorit*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="EmriTextBox" CssClass="form-control" runat="server" Placeholder="Emri i Vendorit"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="NameHelpBlockLabel" Text="Shkruani emrin e Vendorit" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="LokacioniLabel" Text="Lokacioni*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="LokacioniTextBox" CssClass="form-control" runat="server" Placeholder="Lokacioni"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="LokacioniHelpBlockLabel" Text="Shkruani Lokacionin" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="NrKontaktuesLabel" Text="NrKontaktues*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="NrKontaktuesTextBox" CssClass="form-control" runat="server" Placeholder="NrKontaktues"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="NrKontaktuesHelpBlockLabel" Text="Shkruani Numrin e telefonit" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="Label1" Text="BankAccount*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="BankAccountTextBox" CssClass="form-control" runat="server" Placeholder="BankAccount"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="Label2" Text="Shkruani BankAccount" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>            <div class="form-actions">
                <div class="row">
                    <div class="pull-right mr-1">

                   
                        <asp:Button ID="CancelButton" type="button" runat="server" OnClick="CancelButton_Click" class="btn default" Text="Anulo" />
                        <asp:Button ID="SaveButton" type="button" runat="server" OnClick="SaveButton_Click" class="btn btn-primary" Text="Ruaj" />
                   
                        </div>
                </div>
            </div>
        </div>

    </div>s
</asp:Content>
