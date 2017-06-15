using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arbol
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        Estructura_Arbol arbol = new Estructura_Arbol();
        Nodo nuevo;        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nuevo = new Nodo();
            nuevo.dato = int.Parse(txtDato.Text);
            arbol.agregar(nuevo);

            txtDato.Text = "";
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            txtInOrden.Text = arbol.InOrden();
            txtPreOrden.Text = arbol.PreOrden();
            txtPosOrden.Text = arbol.PosOrden();
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            lblResPos.Text += " ";
            lblResPre.Text += " ";
        }

        private void btnhIzquierdo_Click(object sender, EventArgs e)
        {

        }

        private void btnIDerecho_Click(object sender, EventArgs e)
        {

        }

        NodoExpresion n1;

        private void btnAgreAExpre_Click(object sender, EventArgs e)
        {           
            //txtExpresion.Text += txtExpresionDato.Text + " ";
            //n1 = new NodoExpresion();
            //n1.dato = txtExpresionDato.Text;
            //arbol.agregarAExpre(n1);
            //txtExpresionDato.Text = "";
        }
    }
}
