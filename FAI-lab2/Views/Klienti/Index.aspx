<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FAI_lab2.Views.Klientet.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
       <div class="portlet box green">
        <div class="portlet-title">
            <div class="caption">
              kLIENTET
            </div>
            <div class="caption pull-right">
                <ul>
                    <li>
                        <i class="fa fa-plus"></i>
                        <asp:HyperLink ID="ShtoHyperLink" runat="server" Text="Shto Klientin" NavigateUrl="~/Views/Klientet/Create.aspx" CssClass="btn-link"></asp:HyperLink>
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
                    <asp:TemplateField HeaderText="Emri" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="EmriLabel" runat="server" Text='<%# Bind("Emri") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Mbiemri" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="MbiemriLabel" runat="server" Text='<%# Bind("Mbiemri") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="NumriTelefonit" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="NumriTelefonitLabel" runat="server" Text='<%# Bind("NumriTelefonit") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Email" InsertVisible="False">
                        <ItemTemplate>
                            <asp:Label ID="EmailLabel" runat="server" Text='<%# Bind("Email") %>' />
                        </ItemTemplate>
                    </asp:TemplateField>

                     <asp:TemplateField HeaderText="" InsertVisible="False">
                    <ItemTemplate>
                             <asp:LinkButton ID="EditButton"
                                runat="server"
                                CommandName="EditCommandName"
                                CommandArgument='<%# Bind("KlientiID") %>'
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
                                CommandArgument='<%# Bind("KlientiID") %>'
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
