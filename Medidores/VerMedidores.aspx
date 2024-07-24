<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerMedidores.aspx.cs" Inherits="Medidores.VerMedidores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Medidores</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="sectorCmb">Filtrar por Sector:</label>
                        <asp:DropDownList runat="server" ID="tipoCmb" AutoPostBack="true" OnSelectedIndexChanged="tipoCmb_SelectedIndexChanged">
                            <asp:ListItem Value="-1" Text="Todos" />
                            <asp:ListItem Value="0" Text="Análogo" />
                            <asp:ListItem Value="1" Text="Digital" />
                        </asp:DropDownList>
                    </div>
                    <asp:GridView runat="server" ID="grillaMedidores" EmptyDataText="No hay medidores" ShowHeader="true" CssClass="table table-hover table-bordered" AutoGenerateColumns="false" OnRowCommand="GrillaMedidores_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="ID Medidor"/>
                            <asp:BoundField DataField="Direccion" HeaderText="Dirección"/>
                            <asp:BoundField DataField="Detalle" HeaderText="Detalle"/>
                            <asp:BoundField DataField="Tipo" HeaderText="Tipo"/>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button CommandName="eliminar" CommandArgument='<%# Eval("Id") %>' runat="server" CssClass="btn btn-danger" Text="Eliminar Medidor" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
