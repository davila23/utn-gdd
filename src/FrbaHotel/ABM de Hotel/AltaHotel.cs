using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class AltaHotel : Form
    {
        DateTime fechaActualSistema = Convert.ToDateTime(ConfigurationSettings.AppSettings["fecha"]);
        UsuarioLogueado usuario;
        List<TextBox> boxes = new List<TextBox>();
        public AltaHotel(UsuarioLogueado user)
        {
            InitializeComponent();
            usuario = user;
            DataTable regim = user.getConexion().consulta("SELECT Regimen_Desc FROM HOTEL_CUATRIVAGOS.REGIMENES_ESTADIA");
            foreach (DataRow row in regim.Rows) {
                lBRegim.Items.Add(row["Regimen_Desc"].ToString());
            }
            dateTimePicker1.Value = Convert.ToDateTime(ConfigurationSettings.AppSettings["fecha"]);
            this.generarBoxes();
        }
        private void generarBoxes()
        {
            boxes.Add(txtNom);
            boxes.Add(txtMail);
            boxes.Add(txtTelefono);
            boxes.Add(txtPais);
            boxes.Add(txtNroCalle);
            boxes.Add(txtDom);
            boxes.Add(txtCiudad);
            boxes.Add(txtEstrellas);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            string iD;
            if (lBRegim.SelectedIndex != -1)
            {
                foreach (var texto in boxes)
                {
                    if (String.IsNullOrEmpty(texto.Text))
                    {
                        MessageBox.Show("Complete todos los campos");
                        break;
                    }
                }
                string queryHotel = " declare @Id numeric(18,0) exec HOTEL_CUATRIVAGOS.alta_hotel '" + txtNom.Text + "','" + txtMail.Text + "'," + txtTelefono.Text + ",'"
                + txtDom.Text + "'," + txtNroCalle.Text + ",'" + txtCiudad.Text + "','" + txtPais.Text + "','" + dateTimePicker1.Value.ToString("yyyyMMdd") + "'," + txtEstrellas.Text + ",10,@Id";
                try
                {
                    usuario.getConexion().executeOnly(queryHotel);
                    DataTable idH = usuario.getConexion().consulta("SELECT max(Hotel_Id) FROM HOTEL_CUATRIVAGOS.HOTELES");
                    iD = idH.Rows[0].ItemArray[0].ToString();
                    foreach (var item in lBRegim.SelectedItems) {
                        DataTable iDR = usuario.getConexion().consulta("SELECT Regimen_Id FROM HOTEL_CUATRIVAGOS.REGIMENES_ESTADIA WHERE Regimen_Desc = '"+item.ToString()+"'");
                        string idRegimen = iDR.Rows[0].ItemArray[0].ToString();
                        usuario.getConexion().executeOnly("INSERT INTO HOTEL_CUATRIVAGOS.REGIMEN_X_HOTEL (Hotel_Id,Regimen_Id) VALUES ("+iD+","+idRegimen+")");
                    }
                    MessageBox.Show("Hotel registrado con exito");
                    this.Hide();
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.Message);

                }
            }
            else { MessageBox.Show("Complete todos los campos"); }
        }
    }
}
