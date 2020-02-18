using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaHotel.Sistema;

namespace FrbaHotel.Menu_Principal
{
    class CargaMenu
    {
        public CargaMenu(UsuarioLogueado usuario)
        {
            switch (usuario.getRolAsignado())
            {
                case "Administrador":
                    MenuAdmin levantarAdmin = new MenuAdmin(usuario);
                    levantarAdmin.ShowDialog();
                    break;
                case "Administrador General":
                    MegaAdmin levantarMega = new MegaAdmin(usuario);
                    levantarMega.ShowDialog();
                    break;
                case "Recepcionista":
                    MenuRecepcionista levantarRecepcion = new MenuRecepcionista(usuario);
                    levantarRecepcion.ShowDialog();
                    break;
                case "Guest":
                    MenuGuest levantarGuest = new MenuGuest(usuario.getConexion());
                    levantarGuest.ShowDialog();
                    break;
            }
        }
    }
}
