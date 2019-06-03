  <%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="FAI_lab2.Views.Mirembajtje.Create" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <head>
        <link rel="stylesheet" href="//code.jquery.com/ui/1.12.1/themes/base/jquery-ui.css">
  <script src="https://code.jquery.com/jquery-1.12.4.js"></script>
  <script src="https://code.jquery.com/ui/1.12.1/jquery-ui.js"></script>
    <script type="text/javascript">
        $(function () {
            $('#<%= ContactTextBox.ClientID %>').autocomplete({
                source: function (request, response) {
                    $.ajax({
                        url: "PunetoriService.asmx/GetPunetoriNames",
                        data: "{ 'emriMbiemri': '" + request.term + "' }",
                        type: "POST",
                        dataType: "json",
                        contentType: "application/json;charset=utf-8",
                        success: function (data) {
                            response(data.d);
                        },
                        error: function (result) {
                            alert('There is a problem processing your request');
                        }
                    });
                },
                minLength: 0
            });
        });
    </script>
    </head>
    <div class="form-horizontal">
        <div class="row">
            <asp:Label ID="TitlePageLabel" Text="Send Notification" runat="server" class="col-md-3 control-label" Style="color: #337ab7; font-weight: bold;"></asp:Label>
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
                    <asp:Label ID="ContactLabel" Text="To:" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="ContactTextBox" CssClass="form-control" runat="server" Placeholder="Contact" Width="190px"></asp:TextBox>
                    <div class="form-control-focus"></div>
                </div>
            </div>
            <div class="form-group form-md-line-input">
                <label class="col-md-3 control-label" for="form_control">
                    <asp:Label ID="MessageLabel" Text="Message:" runat="server"></asp:Label>
                </label>
                <div class="col-md-9">
                    <asp:TextBox ID="MessageTextBox" CssClass="form-control" runat="server" Placeholder="Message" Height="88px" Width="414px"></asp:TextBox>
                    <div class="form-control-focus"></div>
                </div>
            </div>
            <div class="portlet-body flip-scroll">
            <asp:GridView
                ID="ListGridView"
                runat="server"
                CssClass="table table-bordered table-striped table-condensed flip-content"
                AllowPaging="True"
                PageSize="51"
                AllowSorting="True"
                AutoGenerateColumns="False"
                Width="100%"
                EditIndex="1"
                EnableViewState="False">

                <PagerSettings PageButtonCount="20" FirstPageText="Fillimi" LastPageText="Fundi" />
                <Columns>
                    <asp:TemplateField HeaderText="Emri" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="EmriLabel" runat="server" Text='<%# Bind("Emri") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Pershkrimi" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="PershkrimiLabel" runat="server" Text='<%# Bind("Pershkrimi") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Prodhuesi" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="ProdhuesiLabel" runat="server" Text='<%# Bind("Prodhuesi") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Modeli" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="ModeliLabel" runat="server" Text='<%# Bind("Modeli") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Jetegjatesia" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="JetegjatesiaLabel" runat="server" Text='<%# Bind("Jetegjatesia") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Asset" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="AssetLabel" runat="server" Text='<%# Bind("Lloji") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Grupi" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="GrupiLabel" runat="server" Text='<%# Bind("GrupiID") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Statusi" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="StatusiLabel" runat="server" Text='<%# Bind("Statusi") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="NrSerik" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="NrSerikLabel" runat="server" Text='<%# Bind("NrSerik") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="salvageValue" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="salvageValueLabel" runat="server" Text='<%# Bind("salvageValue") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Cmimi" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="CmimiLabel" runat="server" Text='<%# Bind("Cmimi") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Data" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="DataLabel" runat="server" Text='<%# Bind("Data1") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="" InsertVisible="False">
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        </div>
    </div>
    <div class="pull-right mr-1">
         <asp:Button ID="CancelButton" type="button" runat="server" OnClick="CancelButton_Click" class="btn default" Text="Anulo" />
         <asp:Button ID="SaveButton" type="button" runat="server" OnClick="SaveButton_Click" class="btn btn-primary" Text="Ruaj" />
    </div>
</asp:Content>
