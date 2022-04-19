﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarUsuario.aspx.cs" Inherits="ProyectoSitios.Pages.AgregarUsuario" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Agregar usuario</title>
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
                        <a class="navbar-link" style="color: #ee8133;" href="../Pages/PanelAdministrativo.aspx">Panel de administración
                        </a>
                    </div>
                    <div class="navbar-end">
                          <a class="navbar-link" style="color:#ee8133;" href="../Pages/tendencias.aspx">Tendencias
                        </a>
                    </div>
                    <div class="navbar-end">
                        <a class="navbar-link" style="color: #ee8133;" href="../Pages/solicitudestramitar.aspx">Solicitudes
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
               

        <br />
        <br />

        <div class="contenedor">
            <div  class="GraficosContenedor">
                <div class="PanelAD">
                                 <div class="Grafico">
                  
                     <div class="grafico1" style="border-radius: 0%;">
                         <br />
                         <br />
                         <div style="width: 90%; text-align: center; align-items: center; margin-left: auto; margin-right: auto;">
      <div class="cardLogin" style="text-align:center;color:white;font-weight: bold;">
      <div class="card-content" style="text-align:center">
              <div>
                  
                  
                <h1 style="font-size:35px; color:#ee8133; font-weight:bold">Agregar usuario</h1>

                  <h1 style="font-size:15px; color:transparent">2020Banco NAV. Todos los derechos reservhghghhhhghghghados. 2020Banco NAV. Todos los derechos reservados. 2020Bsdsdsdsdsd</h1>

                  <p class="p1" style="display:inline"> <img style="width:40px;height:auto;display:inline" src="../img/usuario.png"/> 
                      <asp:TextBox runat="server" style="width:70%;height:auto;" class="input is-rounded" type="text" placeholder="Nombre de usuario(identificación)" id="txtUser"/> </p>

                  <br />
                  <br />

                  <p class="p1" style="display:inline"> <img style="width:50px;height:auto;display:inline" src="../img/nombre.png"/> 
                      <asp:TextBox runat="server" style="width:70%;height:auto;" class="input is-rounded" type="text" placeholder="Nombre completo" ID="txtNom"/> </p>
                  <br />

                       <p class="p1" style="display:inline"> <img style="width:50px;height:auto;display:inline" src="../img/nacionalidad.png"/> 
                      <asp:TextBox runat="server" style="width:70%;height:auto;" class="input is-rounded" type="text" placeholder="Nacionalidad" ID="txtNacionalidad"/> </p>
                  <br />

                       <p class="p1" style="display:inline"> <img style="width:50px;height:auto;display:inline" src="../img/telefono.png"/> 
                      <asp:TextBox runat="server" style="width:70%;height:auto;" class="input is-rounded" type="text" placeholder="Teléfono" ID="txtTel"/> </p>
                  <br />

                       <p class="p1" style="display:inline"> <img style="width:50px;height:auto;display:inline" src="../img/correo2.png"/> 
                      <asp:TextBox runat="server" style="width:70%;height:auto;" class="input is-rounded" type="text" placeholder="Correo electronico" ID="txtCorreo"/> </p>
                  <br />

                       <p class="p1" style="display:inline"> <img style="width:50px;height:auto;display:inline" src="../img/direccion.png"/> 
                      <asp:TextBox runat="server" style="width:70%;height:auto;" class="input is-rounded" type="text" placeholder="Dirreción" ID="txtDirec"/> </p>
                  <br />

                       <p class="p1" style="display:inline"> <img style="width:50px;height:auto;display:inline" src="../img/pass.png"/> 
                      <asp:TextBox runat="server" style="width:70%;height:auto;" class="input is-rounded" type="password" placeholder="Contraseña" ID="txtpass1"/> </p>
                  <br />

                      <p class="p1" style="display:inline"> <img style="width:50px;height:auto;display:inline" src="../img/pass.png"/> 
                      <asp:TextBox runat="server" style="width:70%;height:auto;" class="input is-rounded" type="password" placeholder="Escribir nuevamente la contraseña" ID="txtpass2"/> </p>
                  <br />
                  <asp:DropDownList ID="ddltipo" runat="server" CssClass="input is-rounded" Width="354px" OnSelectedIndexChanged="ddltipo_SelectedIndexChanged" Font-Size="Large">
                        <asp:ListItem>--Selecciona un rol--</asp:ListItem>
                    </asp:DropDownList>
                      
                  <br />
                        
                  

                  <asp:Button class="button is-info is-outlined" style="width: 30%;height:auto" ID="btnagregar" runat="server" Text="Agregar" OnClick="btnagregar_Click" />

                      <br />
                      <br />

                      <asp:Label class="message-header" style="width:90%; height: auto; background-color:#F46363; text-align:center; font-size: 15px;margin-left:5%;margin-right:5%;" ID="lblerror" runat="server"></asp:Label>
  
                  
              </div>



                   </div>
          </div>
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

