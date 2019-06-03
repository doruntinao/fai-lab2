<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="FAI_lab2.Views.Klienti.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <div class="row">
            <asp:Label ID="TitlePageLabel" Text="Regjistro Klientin" runat="server" class="col-md-3 control-label" Style="color: #337ab7; font-weight: bold;"></asp:Label>
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
                    <asp:Label ID="nNameLabel" Text="Emri i Klientit*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="EmriTextBox" CssClass="form-control" runat="server" Placeholder="Emri i Klientit"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="NameHelpBlockLabel" Text="Shkruani emrin e Klientit" runat="server" CssClass="help-block"></asp:Label>
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
                    <asp:Label ID="NumriTelefonitLabel" Text="NumriTelefonit*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="NumriTelefonitTextBox" CssClass="form-control" runat="server" Placeholder="NumriTelefonit"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="NumriTelefonitHelpBlockLabel" Text="Shkruani Numrin e telefonit" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="Label1" Text="Email*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="EmailTextBox" CssClass="form-control" runat="server" Placeholder="Email"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="Label2" Text="Shkruani Email" runat="server" CssClass="help-block"></asp:Label>
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

    </div>
</asp:Content>
