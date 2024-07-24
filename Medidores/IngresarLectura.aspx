<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="IngresarLectura.aspx.cs" Inherits="Medidores.IngresarLectura" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="mensajes">
                <asp:Label runat="server" ID="mensajeLbl" CssClass="text-success"></asp:Label>
            </div>
            <div class="card">
                <div class="card-header bg-warning text-white">
                    <h3>Ingresar Lectura</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="medidorCmb">Medidor</label>
                        <asp:DropDownList runat="server" ID="medidorCmb" CssClass="form-select">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ControlToValidate="medidorCmb" Display="Static" ErrorMessage="Seleccione el medidor" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group">
                        <label for="fechaCal">Fecha Lectura</label>
                        <asp:Calendar ID="fechaCal" runat="server">

                        </asp:Calendar>
                    </div>
                    <div class="form-group">
                        <label for="horaTxt">Lectura (Hora)</label>
                        <asp:TextBox ID="horaTxt" CssClass="form-control" runat="server" type="number"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="horaTxt" Display="Static" ErrorMessage="Ingrese la hora de lectura" runat="server"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ControlToValidate="horaTxt" MinimumValue="0" MaximumValue="23" Type="Integer" Text="Ingrese un valor entre 0 y 23" runat="server"></asp:RangeValidator>
                    </div>
                    <div class="form-group">
                        <label for="minutosTxt">Lectura (Minutos)</label>
                        <asp:TextBox ID="minutosTxt" CssClass="form-control" runat="server" type="number"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="minutosTxt" Display="Static" ErrorMessage="Ingrese el minuto de lectura" runat="server"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ControlToValidate="minutosTxt" MinimumValue="0" MaximumValue="59" Type="Integer" Text="Ingrese un valor entre 0 y 59" runat="server"></asp:RangeValidator>
                    </div>
                    <div class="form-group">
                        <label for="consumoTxt">Valor de Consumo</label>
                         <asp:TextBox ID="consumoTxt" CssClass="form-control" runat="server" type="number"></asp:TextBox>
                         <asp:RequiredFieldValidator ControlToValidate="consumoTxt" Display="Static" ErrorMessage="Ingrese el valor de consumo" runat="server"></asp:RequiredFieldValidator>
                    </div>
                    
                    <div class="form-group">
                        <asp:Button runat="server" ID="agregarBtn"
                            Text="Guardar" CssClass="btn btn-success btn-lg" OnClick="agregarBtn_Click"/>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
