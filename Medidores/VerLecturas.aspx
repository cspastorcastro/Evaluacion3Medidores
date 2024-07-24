<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerLecturas.aspx.cs" Inherits="Medidores.VerLecturas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Lecturas</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="medidorCmb">Filtrar por Medidor:</label>
                        <asp:DropDownList runat="server" ID="medidorCmb" AutoPostBack="true" OnSelectedIndexChanged="medidorCmb_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                    <asp:GridView runat="server" ID="grillaLectura" EmptyDataText="No hay lecturas" ShowHeader="true" CssClass="table table-hover table-bordered" AutoGenerateColumns="false" OnRowCommand="grillaLectura_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="Id" HeaderText="ID Lectura"/>
                            <asp:BoundField DataField="FechaLectura" HeaderText="Fecha Lectura"/>
                            <asp:BoundField DataField="Consumo" HeaderText="Consumo"/>
                            <asp:BoundField DataField="Medidor" HeaderText="Medidor"/>
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button CommandName="eliminar" CommandArgument='<%# Eval("Id") %>' runat="server" CssClass="btn btn-danger" Text="Eliminar Lectura" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>