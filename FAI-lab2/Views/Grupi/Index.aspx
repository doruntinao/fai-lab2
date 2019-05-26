<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FAI_lab2.Views.Grupi.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
      <div class="portlet box green">
        <div class="portlet-title">
            <div class="caption">
                Produkti
            </div>
            <div class="caption pull-right">
                <ul>
                    <li>
                        <i class="fa fa-plus"></i>
                        <asp:HyperLink ID="ShtoHyperLink" runat="server" Text="Shto Grupin" NavigateUrl="~/Views/Grupi/Create.aspx" CssClass="btn-link"></asp:HyperLink>
                    </li>
                </ul>
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
                    <asp:TemplateField HeaderText="Grupi" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="GrupiLabel" runat="server" Text='<%# Bind("emriGrupit") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Kategoria" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="KategoriaLabel" runat="server" Text='<%# Bind("KategoriaID") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="" InsertVisible="False">
                    <ItemTemplate>
                             <asp:LinkButton ID="EditButton"
                                runat="server"
                                CommandName="EditCommandName"
                                CommandArgument='<%# Bind("GrupiID") %>'
                                class="btn btn-primary btn-xs">
                                  Ndrysho
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField InsertVisible="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="DeleteButton"
                                runat="server"
                                CommandName="DeleteCommandName"
                                CommandArgument='<%# Bind("GrupiID") %>'
                                class="btn red-mint btn-xs">
                                  Fshije
                            </asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
