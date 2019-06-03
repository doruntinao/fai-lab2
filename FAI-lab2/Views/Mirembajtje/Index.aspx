<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FAI_lab2.Views.Mirembajtje.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="portlet box green">
        <div class="portlet-title">
            <div class="caption">
                Produkti
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
                EnableViewState="False"
                OnPageIndexChanging="ListGridView_PageIndexChanging"
                OnRowCommand="ListGridView_RowCommand"
                OnRowDataBound="ListGridView_RowDataBound">

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
                    <ItemTemplate>
                             <asp:LinkButton ID="NotifyButton"
                                runat="server"
                                CommandName="NotifyCommandName"
                                CommandArgument='<%# Bind("ProduktiID") %>'
                                class="btn btn-primary btn-xs">
                                  Notify
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
