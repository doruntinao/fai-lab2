<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="FAI_lab2.Views.Produktet.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-horizontal">
        <div class="row">
            <asp:Label ID="TitlePageLabel" Text="Regjistro Produktët" runat="server" class="col-md-3 control-label" Style="color: #337ab7; font-weight: bold;"></asp:Label>
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
                    <asp:Label ID="EmriLabel" Text="Emri i Produktit*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="EmriTextBox" CssClass="form-control" runat="server" Placeholder="Emri i Produktit"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="NameHelpBlockLabel" Text="Shkruani emrin e Produktit" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="ProdhuesiLabel" Text="Prodhuesi*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="ProdhuesiTextBox" CssClass="form-control" runat="server" Placeholder="Prodhuesi"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="ProdhuesiHelpBlockLabel" Text="Shkruani Prodhuesin" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="ModeliLabel" Text="Modeli*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="ModeliTextBox" CssClass="form-control" runat="server" Placeholder="Modeli"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="ModeliHelpBlockLabel" Text="Shkruani Modelin" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="DataLabel" Text="Data*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="DataTextBox" CssClass="form-control" runat="server" Placeholder="Data" Width="114px"></asp:TextBox>
                    <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Views/Images/calendar.png" OnClick="ImageButton1_Click" />
                    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" OnDayRender="Calendar1_DayRender"></asp:Calendar>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="DataHelpBlockLabel" Text="Caktoni Daten" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="PershkrimiLabel" Text="Pershkrimi*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="PershkrimiTextBox" CssClass="form-control" runat="server" Placeholder="Pershkrimi"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="PershkrimiHelpBlockLabel" Text="Shkruani Modelin" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="JetegjatesiaLabel" Text="Jetegjatesia*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="JetegjatesiaTextBox" CssClass="form-control" runat="server" Placeholder="Jetegjatesia"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="JetegjatesiaHelpBlockLabel" Text="Shkruani Jetegjatesine" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="CmimiLabel" Text="Cmimi*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="CmimiTextBox" CssClass="form-control" runat="server" Placeholder="Cmimi"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="CmimiHelpBlockLabel" Text="Shkruani Cmimin" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="LlojiLabel" Text="Asset*" runat="server"></asp:Label>
                </label>
                <asp:RadioButtonList ID="llojiProduktit" runat="server">
                <asp:ListItem id="aset" Text="Aset" Value="Aset" />
                <asp:ListItem id="inventor" Text="Inventor" Value="Inventor" />
                </asp:RadioButtonList>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="Label1" Text="Grupi*" runat="server"></asp:Label>
                </label>
                <asp:DropDownList ID="GrupiDropDownList" DataTextField="Grupi" 
                    DataValueField="GrupiID" runat="server">
                </asp:DropDownList> 
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="StatusiLabel" Text="Statusi*" runat="server"></asp:Label>
                </label>
                 <asp:CheckBox ID="StatusiCheckBox" Text="A është duke u përdorur?"  runat="server" />
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="NrSerikLabel" Text="NrSerik*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="NrSerikTextBox" CssClass="form-control" runat="server" Placeholder="NrSerik"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="NrSerikHelpBlockLabel" Text="Shkruani salvage value të produktit" runat="server" CssClass="help-block"></asp:Label>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="salvageValueLabel" Text="salvageValue*" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="salvageValueTextBox" CssClass="form-control" runat="server" Placeholder="salvageValue"></asp:TextBox>
                    <div class="form-control-focus"></div>
                    <asp:Label ID="SalvageValueHelpBlockLabel" Text="Shkruani salvage value të produktit" runat="server" CssClass="help-block"></asp:Label>
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
