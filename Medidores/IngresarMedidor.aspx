<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarMedidor.aspx.cs" Inherits="Medidores.IngresarMedidor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-warning text-white">
                    <h3>Ingresar Medidor</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="idTxt">Número de Serie</label>
                        <asp:TextBox ID="idTxt" CssClass="form-control" runat="server" type="number"></asp:TextBox>
                        <asp:CustomValidator ID="idValidator" ControlToValidate="idTxt" Display="Static" ErrorMessage="¡Número de serie ya existe!" runat="server" OnServerValidate="idValidator_ServerValidate"></asp:CustomValidator>
                        <asp:CustomValidator ID="idLengthValidator" ValidationGroup="form" ControlToValidate="idTxt" Display="Static" ErrorMessage="Número de serie debe contener 4 caracteres." runat="server" OnServerValidate="idLengthValidator_ServerValidate"></asp:CustomValidator>
                        <asp:RequiredFieldValidator ValidationGroup="form" ControlToValidate="idTxt" Display="Static" ErrorMessage="Ingrese número de serie del medidor" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="direccionTxt">Dirección</label>
                         <asp:TextBox ID="direccionTxt" CssClass="form-control" runat="server"></asp:TextBox>
                         <asp:RequiredFieldValidator ValidationGroup="form" ControlToValidate="idTxt" Display="Static" ErrorMessage="Ingrese dirección del medidor" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="detalleTxt">Detalle</label>
                        <asp:TextBox ID="detalleTxt" CssClass="form-control" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ValidationGroup="form" ControlToValidate="detalleTxt" Display="Static" ErrorMessage="Ingrese detalle del medidor" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="sectorCmb">Tipo</label>
                        <asp:DropDownList runat="server" ID="tipoCmb" CssClass="form-select">
                            <asp:ListItem Value="0" Text="Análogo" />
                            <asp:ListItem Value="1" Text="Digital" />
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ValidationGroup="form" ControlToValidate="tipoCmb" Display="Static" ErrorMessage="Ingrese tipo del medidor" runat="server"></asp:RequiredFieldValidator>

                    </div>
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn"
                            Text="Guardar" CssClass="btn btn-success btn-lg" ValidationGroup="form" OnClick="agregarBtn_Click"/>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
