using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private int x;
        private int y;

        public Form1()
        {
            InitializeComponent();
        }

       


        private void ConsultaTabla()
        {
            LineaTitulos();
            LineaDeConsulta();

        }

        private void LineaTitulos()
        {
            this.x = 25;
            this.y = 58;
            this.CreacionLabel("lblNombre", "NOMBRE");
            this.x += 200;
            this.CreacionLabel("lblApellido","APELLIDO");
            this.x += 200;
            this.CreacionLabel("lblDomicilio","DOMICILIO");
            this.x += 200;
            this.CreacionLabel("lblFecha", "FECHA");
        }

        private void LineaDeConsulta()
        {
            DesarrolloAcciones DesarrollodeAcciones = new DesarrolloAcciones();
            ArrayList DatoTabla = DesarrollodeAcciones.ObtenerDatos();
            foreach (Datos datos in DatoTabla)
            {
                this.x = 25;
                this.y += 40;
                this.CuerpodeConsulta(datos);
            }
        }

        private void CuerpodeConsulta(Datos datos)
        {
            this.CreacionLabel("lblNombre" + datos.id, datos.nombre);
            this.x += 200;
            this.CreacionLabel("lblApellido" + datos.id,  datos.apellido);
            this.x += 200;
            this.CreacionLabel("lblDomicilio" + datos.id,  datos.domicilio);
            this.x += 200;
            this.CreacionLabel("lblFecha" + datos.id,datos.fecha );
            this.x += 200;
        }


        private void CreacionLabel(string NombreLabel, string Texto)
        {
          Label label  = new  Label();

          label.AutoSize = true;
          label.Location = new System.Drawing.Point(x, y);
          label.Name = NombreLabel;
          label.Size = new System.Drawing.Size(30, 13);
          label.TabIndex = 1;
          label.Text = Texto;
         
          Controls.Add(label);
           // System.Windows.Forms.Label NombreLa;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            ConsultaTabla();
        }
    }
}
