<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="solicitudestramitar.aspx.cs" Inherits="ProyectoSitios.Pages.solicitudestramitar" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Banco NAV</title>
    <link rel="preconnect" href="https://fonts.googleapis.com" />
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin />
    <link href="https://fonts.googleapis.com/css2?family=Josefin+Sans:wght@500&display=swap" rel="stylesheet" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/bulma/0.7.1/css/bulma.min.css" />
    <link href="https://fonts.googleapis.com/css2?family=Syne+Mono&display=swap" rel="stylesheet" />
    <link href="https://fonts.googleapis.com/icon?family=Material+Icons" rel="stylesheet" />
    <link href="../css/bulma2.css" rel="stylesheet" />
    <style>
        .auto-style1 {
            height: 57px;
        }
    </style>
</head>

<body style="width: 100%; margin-left: auto; margin-right: auto;">
    <form id="form1" runat="server">
        <div>
            <button class="buttonmenu" style="background-color: transparent;" type="button"
                onclick="location.href='https://www.facebook.com'">
                <img style="width: 7%; height: 70px; left: 25px; top: 28px; position: absolute; z-index: 101; display: flex; margin-top: 4px;"
                    src="../img/iconoblanco.png" />
            </button>
        </div>
        <div>
            <nav class="navbar" style="z-index: 100; top: 35px; background-color: #061738; color: white" role="navigation" aria-label="dropdown navigation">
                <div class="navbar-menu" style="color: #ee8133;">

                    <div class="navbar-end" style="color: white;">
                        <a class="navbar-link" style="color: #ee8133;" href="../Pages/PanelAdministrativoTramitador.aspx">Panel de administración
                        </a>
                    </div>
                    <div class="navbar-end">
                        <a class="navbar-link" style="color: #ee8133;" href="../Pages/tendencias.aspx">Tendencias
                        </a>
                    </div>
                    <div class="navbar-end">
                        <a class="navbar-link" style="color: #ee8133;" href="../Pages/Solicitudes.aspx">Solicitudes
                        </a>
                    </div>
                    <div class="navbar-end">
                        <a class="navbar-link" style="color: #ee8133;" href="../Pages/ConfiguracionRoles.aspx">Configuracion Roles
                        </a>
                    </div>
                    <div class="navbar-end">
                        <a class="navbar-link" style="color: #ee8133;" href="../Pages/GraficoIndicadores.aspx">Gráficos
                        </a>
                    </div>
                </div>
            </nav>
        </div>
        <br />
        <br />
        <br />

        <div style="margin-left: auto; margin-right: auto;">
            <h1 style="text-align: center; color: #061738; font-size: 50px; font-weight: bold;">Envío de solicitudes para tramitar</h1>
            <br />
            <br />
            <div class="HeaderTable" style="font-size: xx-large;">
                <p style="display: inline; color: #ee8133; text-align: center; margin-left: 2%">Filtrar por tipo de préstamo solicitado: 
                    <asp:DropDownList ID="ddltipo" runat="server" CssClass="input is-rounded" Width="354px" OnSelectedIndexChanged="ddltipo_SelectedIndexChanged" Font-Size="Large">
                        <asp:ListItem>--Selecciona un préstamo--</asp:ListItem>
                    </asp:DropDownList>
                    <p style="display: inline; color: #ee8133; text-align: center;">
                        <asp:Button ID="btnBuscar" runat="server" Text=" Buscar " CssClass="RolesButton" OnClick="btnBuscar_Click1" Font-Size="X-Large" />
                    </p>
                   <p style="display: inline; color: #ee8133; text-align: center; margin-left: 2%">
                   Número de solicitud:
              <asp:TextBox ID="txtTramitar" runat="server" CssClass="btnRoles" OnTextChanged="txtTramitar_TextChanged" Font-Size="X-Large" Width="148px"></asp:TextBox>
                    <p style="display: inline; color: #ee8133; text-align: center;">
                        <asp:Button ID="btnTramitar" runat="server" Text="Enviar solicitud a tramitar " CssClass="RolesButton" OnClick="btntramitar_Click1" Font-Size="X-Large" />
                    </p>

                </p>
                </p>


            </div>
        </div>
        <br />
        <br />

        <div class="contenedor">
            <div class="GraficosContenedor">
                <div class="PanelAD">
                    <div class="Grafico">

                        <div class="grafico1" style="border-radius: 0%;">
                            <br />
                            <br />
                            <div style="width: 90%; text-align: center; align-items: center; margin-left: auto; margin-right: auto;">
                                <asp:Table ID="TablaSolicitudes" runat="server" CssClass="table is-striped" ForeColor="#0B0550" HorizontalAlign="Center" Width="100%" Height="50px" Font-Size="X-Large">
                                    <asp:TableHeaderRow ID="Table1HeaderRow" Style="color: white;" CssClass="CabezaTabla"
                                        ForeColor="white"
                                        BackColor="#061738"
                                        runat="server">

                                        <asp:TableHeaderCell ForeColor="#ee8133" Font-Size="X-Large"
                                            Scope="Column"
                                            Text="Número Solicitud" />
                                        <asp:TableHeaderCell ForeColor="#ee8133" Font-Size="X-Large"
                                            Scope="Column"
                                            Text="Identificación" />
                                        <asp:TableHeaderCell ForeColor="#ee8133" Font-Size="X-Large"
                                            Scope="Column"
                                            Text="Tipo de préstamo" />
                                        <asp:TableHeaderCell ForeColor="#ee8133" Font-Size="X-Large"
                                            Scope="Column"
                                            Text="Monto Solicitado" />
                                        <asp:TableHeaderCell ForeColor="#ee8133" Font-Size="X-Large"
                                            Scope="Column"
                                            Text="Fecha de solicitud" />
                                    </asp:TableHeaderRow>

                                </asp:Table>
                                <br />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <%-- fin nuevo --%>


        <br />
        <br />
        <footer class="footer1">
            <div class="content has-text-centered">
                <div>
                    <p style="text-align: center; font-size: 10px; float: left;">
                        <p class="p1" style="margin: 10px 10px; display: inline">
                            <img style="width: 20px; height: auto; display: inline" src="../img/c.png" />
                            2020 Banco NAV. Todos los derechos reservados.
                        </p>
                        <p class="p1" style="margin: 10px 10px; display: inline">
                            <img style="width: 20px; height: auto; display: inline" src="../img/correo.png" />
                            Contáctenos: bancona@gmail.com
                        </p>
                        <p class="p1" style="margin: 10px 10px; display: inline">
                            <img style="width: 20px; height: auto; display: inline" src="../img/tel.png" />
                            Teléfono: 2211-1135
                        </p>
                    </p>
                </div>

            </div>
        </footer>
    </form>
</body>
</html>
