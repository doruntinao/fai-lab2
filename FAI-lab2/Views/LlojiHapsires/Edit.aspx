﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="FAI_lab2.Views.LlojiHapsires.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <div class="row">
            <asp:Label ID="TitlePageLabel" Text="Regjistro LLojin E Hapsires" runat="server" class="col-md-3 control-label" Style="color: #337ab7; font-weight: bold;"></asp:Label>
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
                    <asp:Label ID="LlojiHapsiresLabel" Text="LlojiID*" runat="server"></asp:Label>
                </label>
                <asp:DropDownList ID="LlojiHapsiresDropDownList" DataTextField="LlojiID" 
                    DataValueField="LlojiID" runat="server">
                </asp:DropDownList> 
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="LlojiLabel" Text="Lloji*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="LlojiTextBox" CssClass="form-control" runat="server" Placeholder="Lloji"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="LlojiHelpBlockLabel" Text="Shkruani Llojin e Hapsires" runat="server" CssClass="help-block"></asp:Label>
                </div>
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