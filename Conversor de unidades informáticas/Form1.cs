using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conversor_de_unidades_informáticas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtdigite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;

            if (char.IsSymbol(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == (char)Keys.Return)
            {
                cmbexpresado.Focus();
            }
        }

        private void cmbexpresado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                cmbconvertir.Focus();
            }
        }

        private void cmbconvertir_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Return)
            {
                if (txtdigite.Text == "")
                {
                    MessageBox.Show("Ingrese valor a convertir", "Conversor de unidades informáticas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtdigite.Focus();
                    
                }

                else


                    if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 0))
                    {
                        txtresultado.Text = (double.Parse(txtdigite.Text) / 8).ToString();
                        lblnombre.Text = "Byte";
                    }
                    else
                        if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 1))
                        {
                            txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024).ToString();
                            lblnombre.Text = "Kilobyte";
                        }
                        else
                            if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 2))
                            {
                                txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024).ToString();
                                lblnombre.Text = "Megabyte";
                            }
                            else
                                if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 3))
                                {
                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024).ToString();
                                    lblnombre.Text = "Gigabyte";
                                }
                                else
                                    if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 4))
                                    {
                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024).ToString();
                                        lblnombre.Text = "Terabyte";
                                    }
                                    else
                                        if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 5))
                                        {
                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                            lblnombre.Text = "Petabyte";
                                        }
                                        else
                                            if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 6))
                                            {
                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                lblnombre.Text = "exabyte";
                                            }
                                            else
                                                if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 7))
                                                {
                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                    lblnombre.Text = "zettabyte";
                                                }
                                                else
                                                    if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 8))
                                                    {
                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                        lblnombre.Text = "yottabyte";
                                                    }
                                                    else
                                                        if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 9))
                                                        {
                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                            lblnombre.Text = "brontobyte";
                                                        }
                                                        else
                                                            if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 10))
                                                            {
                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                lblnombre.Text = "geopbyte";
                                                            }
                                                            //comienza byte
                                                            else


                                                                if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 0))
                                                                {
                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 8).ToString();
                                                                    lblnombre.Text = "Bit";
                                                                }
                                                                else
                                                                    if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 1))
                                                                    {
                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                        lblnombre.Text = "Kilobyte";
                                                                    }
                                                                    else
                                                                        if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 2))
                                                                        {
                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                            lblnombre.Text = "Megabyte";
                                                                        }
                                                                        else
                                                                            if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 3))
                                                                            {
                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                lblnombre.Text = "Gigabyte";
                                                                            }
                                                                            else
                                                                                if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 4))
                                                                                {
                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                    lblnombre.Text = "Terabyte";
                                                                                }
                                                                                else
                                                                                    if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 5))
                                                                                    {
                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                        lblnombre.Text = "Petabyte";
                                                                                    }
                                                                                    else
                                                                                        if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 6))
                                                                                        {
                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                            lblnombre.Text = "exabyte";
                                                                                        }
                                                                                        else
                                                                                            if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 7))
                                                                                            {
                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                lblnombre.Text = "zettabyte";
                                                                                            }
                                                                                            else
                                                                                                if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 8))
                                                                                                {
                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                    lblnombre.Text = "yottabyte";
                                                                                                }
                                                                                                else
                                                                                                    if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 9))
                                                                                                    {
                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                        lblnombre.Text = "brontobyte";
                                                                                                    }
                                                                                                    else
                                                                                                        if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 10))
                                                                                                        {
                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                            lblnombre.Text = "geopbyte";
                                                                                                        }
                                                                                                        //comienza kilobyte
                                                                                                        else


                                                                                                            if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 0))
                                                                                                            {
                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 8).ToString();
                                                                                                                lblnombre.Text = "Bit";
                                                                                                            }
                                                                                                            else
                                                                                                                if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                {
                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                    lblnombre.Text = "Byte";
                                                                                                                }
                                                                                                                else
                                                                                                                    if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                    {
                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                        lblnombre.Text = "Megabyte";
                                                                                                                    }
                                                                                                                    else
                                                                                                                        if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                        {
                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                            lblnombre.Text = "Gigabyte";
                                                                                                                        }
                                                                                                                        else
                                                                                                                            if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                            {
                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                lblnombre.Text = "Terabyte";
                                                                                                                            }
                                                                                                                            else
                                                                                                                                if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                {
                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                    lblnombre.Text = "Petabyte";
                                                                                                                                }
                                                                                                                                else
                                                                                                                                    if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                    {
                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                        lblnombre.Text = "exabyte";
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                        if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                        {
                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                            lblnombre.Text = "zettabyte";
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                            if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                            {
                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                lblnombre.Text = "yottabyte";
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                                if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                {
                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                    lblnombre.Text = "brontobyte";
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                    {
                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                        lblnombre.Text = "geopbyte";
                                                                                                                                                    }
                                                                                                                                                    //comienza megabyte
                                                                                                                                                    else


                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                        {
                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 8).ToString();
                                                                                                                                                            lblnombre.Text = "Bit";
                                                                                                                                                        }
                                                                                                                                                        else
                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                            {
                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                lblnombre.Text = "Byte";
                                                                                                                                                            }
                                                                                                                                                            else
                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                {
                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                    lblnombre.Text = "Kilobyte";
                                                                                                                                                                }
                                                                                                                                                                else
                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                    {
                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                        lblnombre.Text = "Gigabyte";
                                                                                                                                                                    }
                                                                                                                                                                    else
                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                        {
                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                            lblnombre.Text = "Terabyte";
                                                                                                                                                                        }
                                                                                                                                                                        else
                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                            {
                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                lblnombre.Text = "Petabyte";
                                                                                                                                                                            }
                                                                                                                                                                            else
                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                {
                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                    lblnombre.Text = "exabyte";
                                                                                                                                                                                }
                                                                                                                                                                                else
                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                    {
                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                        lblnombre.Text = "zettabyte";
                                                                                                                                                                                    }
                                                                                                                                                                                    else
                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                        {
                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                            lblnombre.Text = "yottabyte";
                                                                                                                                                                                        }
                                                                                                                                                                                        else
                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                            {
                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                lblnombre.Text = "brontobyte";
                                                                                                                                                                                            }
                                                                                                                                                                                            else
                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                {
                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                    lblnombre.Text = "geopbyte";
                                                                                                                                                                                                }
                                                                                                                                                                                                //comienza gigabyte 
                                                                                                                                                                                                else


                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                    {
                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                        lblnombre.Text = "Bit";
                                                                                                                                                                                                    }
                                                                                                                                                                                                    else
                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                        {
                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                            lblnombre.Text = "Byte";
                                                                                                                                                                                                        }
                                                                                                                                                                                                        else
                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                            {
                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                            }
                                                                                                                                                                                                            else
                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                    lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                }
                                                                                                                                                                                                                else
                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                        lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                    else
                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                            lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                        else
                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                lblnombre.Text = "exabyte";
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                    lblnombre.Text = "zettabyte";
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                        lblnombre.Text = "yottabyte";
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                            lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                            //comienza terabyte 
                                                                                                                                                                                                                                            else


                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                    lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                        lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                            lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                    lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                        lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                            lblnombre.Text = "exabyte";
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                lblnombre.Text = "zettabyte";
                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                    lblnombre.Text = "yottabyte";
                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                        lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                            lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                        //comienza petabyte
                                                                                                                                                                                                                                                                                        else


                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "exabyte";
                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "zettabyte";
                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "yottabyte";
                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                    //comienza exabyte
                                                                                                                                                                                                                                                                                                                                    else


                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "zettabyte";
                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "yottabyte";
                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                //comienza zettabyte 
                                                                                                                                                                                                                                                                                                                                                                                else


                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Exabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "yottabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                            //comienza yottabyte
                                                                                                                                                                                                                                                                                                                                                                                                                            else


                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Exabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Zettabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        //comienza brontobyte
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else


                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Exabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Zettabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Yottabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    //comienza geopbyte
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Exabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Zettabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Yottabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Brontobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                {
                    btnnuevo.Focus();
                }














































































































































































































































































































































































































































































            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas salir de la aplicación", "Conversor de unidades informaticas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseas salir de la aplicación", "Conversor de unidades informaticas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtdigite.Text = "";
            txtresultado.Text = "";
            txtdigite.Focus();

        }

        private void cmbexpresado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((cmbexpresado.SelectedIndex == 0))
            {
                cmbconvertir.Enabled = true;
                cmbconvertir.Items.Clear();
                cmbconvertir.Items.Add("byte");
                cmbconvertir.Items.Add("kilobyte");
                cmbconvertir.Items.Add("megabyte");
                cmbconvertir.Items.Add("gigabyte");
                cmbconvertir.Items.Add("terabyte");
                cmbconvertir.Items.Add("petabyte");
                cmbconvertir.Items.Add("exabyte");
                cmbconvertir.Items.Add("zettabyte");
                cmbconvertir.Items.Add("yottabyte");
                cmbconvertir.Items.Add("brontobyte");
                cmbconvertir.Items.Add("geopbyte");
            }
            else
             if ((cmbexpresado.SelectedIndex == 1))
            {
                cmbconvertir.Enabled = true;
                cmbconvertir.Items.Clear();
                cmbconvertir.Items.Add("bit");
                cmbconvertir.Items.Add("kilobyte");
                cmbconvertir.Items.Add("megabyte");
                cmbconvertir.Items.Add("gigabyte");
                cmbconvertir.Items.Add("terabyte");
                cmbconvertir.Items.Add("petabyte");
                cmbconvertir.Items.Add("exabyte");
                cmbconvertir.Items.Add("zettabyte");
                cmbconvertir.Items.Add("yottabyte");
                cmbconvertir.Items.Add("brontobyte");
                cmbconvertir.Items.Add("geopbyte");
             }
             else
              if ((cmbexpresado.SelectedIndex == 2))
             {
                 cmbconvertir.Enabled = true;
                 cmbconvertir.Items.Clear();
                 cmbconvertir.Items.Add("bit");
                 cmbconvertir.Items.Add("byte");
                 cmbconvertir.Items.Add("megabyte");
                 cmbconvertir.Items.Add("gigabyte");
                 cmbconvertir.Items.Add("terabyte");
                 cmbconvertir.Items.Add("petabyte");
                cmbconvertir.Items.Add("exabyte");
                cmbconvertir.Items.Add("zettabyte");
                cmbconvertir.Items.Add("yottabyte");
                cmbconvertir.Items.Add("brontobyte");
                cmbconvertir.Items.Add("geopbyte");
             }
              else
                  if ((cmbexpresado.SelectedIndex == 3))
                  {
                  cmbconvertir.Enabled = true;
                  cmbconvertir.Items.Clear();
                  cmbconvertir.Items.Add("bit");
                  cmbconvertir.Items.Add("byte");
                  cmbconvertir.Items.Add("kilobyte");
                  cmbconvertir.Items.Add("gigabyte");
                  cmbconvertir.Items.Add("terabyte");
                cmbconvertir.Items.Add("petabyte");
                cmbconvertir.Items.Add("exabyte");
                cmbconvertir.Items.Add("zettabyte");
                cmbconvertir.Items.Add("yottabyte");
                cmbconvertir.Items.Add("brontobyte");
                cmbconvertir.Items.Add("geopbyte");
                  }
                  else
                   if ((cmbexpresado.SelectedIndex == 4))
                  {
                  cmbconvertir.Enabled = true;
                  cmbconvertir.Items.Clear();
                  cmbconvertir.Items.Add("bit");
                  cmbconvertir.Items.Add("byte");
                  cmbconvertir.Items.Add("kilobyte");
                  cmbconvertir.Items.Add("megabyte");
                  cmbconvertir.Items.Add("terabyte");
                  cmbconvertir.Items.Add("petabyte");
                  cmbconvertir.Items.Add("exabyte");
                  cmbconvertir.Items.Add("zettabyte");
                  cmbconvertir.Items.Add("yottabyte");
                  cmbconvertir.Items.Add("brontobyte");
                  cmbconvertir.Items.Add("geopbyte");
                  }
                  else
                   if ((cmbexpresado.SelectedIndex == 5))
                  {
                  cmbconvertir.Enabled = true;
                  cmbconvertir.Items.Clear();
                  cmbconvertir.Items.Add("bit");
                  cmbconvertir.Items.Add("byte");
                  cmbconvertir.Items.Add("kilobyte");
                  cmbconvertir.Items.Add("megabyte");
                  cmbconvertir.Items.Add("gigabyte");
                  cmbconvertir.Items.Add("petabyte");
                  cmbconvertir.Items.Add("exabyte");
                  cmbconvertir.Items.Add("zettabyte");
                  cmbconvertir.Items.Add("yottabyte");
                  }
                   else
                   if ((cmbexpresado.SelectedIndex == 6))
                  {
                  cmbconvertir.Enabled = true;
                  cmbconvertir.Items.Clear();
                  cmbconvertir.Items.Add("bit");
                  cmbconvertir.Items.Add("byte");
                  cmbconvertir.Items.Add("kilobyte");
                  cmbconvertir.Items.Add("megabyte");
                  cmbconvertir.Items.Add("gigabyte");
                  cmbconvertir.Items.Add("terabyte");
                  cmbconvertir.Items.Add("exabyte");
                  cmbconvertir.Items.Add("zettabyte");
                  cmbconvertir.Items.Add("yottabyte");
                  cmbconvertir.Items.Add("brontobyte");
                  cmbconvertir.Items.Add("geopbyte");
                  }
                   else
                   if ((cmbexpresado.SelectedIndex == 7))
                  {
                  cmbconvertir.Enabled = true;
                  cmbconvertir.Items.Clear();
                  cmbconvertir.Items.Add("bit");
                  cmbconvertir.Items.Add("byte");
                  cmbconvertir.Items.Add("kilobyte");
                  cmbconvertir.Items.Add("megabyte");
                  cmbconvertir.Items.Add("gigabyte");
                  cmbconvertir.Items.Add("terabyte");
                  cmbconvertir.Items.Add("petabyte");
                  cmbconvertir.Items.Add("zettabyte");
                  cmbconvertir.Items.Add("yottabyte");
                  cmbconvertir.Items.Add("brontobyte");
                  cmbconvertir.Items.Add("geopbyte");
                  }
                   else
                   if ((cmbexpresado.SelectedIndex == 8))
                  {
                  cmbconvertir.Enabled = true;
                  cmbconvertir.Items.Clear();
                  cmbconvertir.Items.Add("bit");
                  cmbconvertir.Items.Add("byte");
                  cmbconvertir.Items.Add("kilobyte");
                  cmbconvertir.Items.Add("megabyte");
                  cmbconvertir.Items.Add("gigabyte");
                  cmbconvertir.Items.Add("terabyte");
                  cmbconvertir.Items.Add("petabyte");
                  cmbconvertir.Items.Add("exabyte");
                  cmbconvertir.Items.Add("yottabyte");
                  cmbconvertir.Items.Add("brontobyte");
                  cmbconvertir.Items.Add("geopbyte");
                  }
                   else
                  if ((cmbexpresado.SelectedIndex == 9))
                  {
                  cmbconvertir.Enabled = true;
                  cmbconvertir.Items.Clear();
                  cmbconvertir.Items.Add("bit");
                  cmbconvertir.Items.Add("byte");
                  cmbconvertir.Items.Add("kilobyte");
                  cmbconvertir.Items.Add("megabyte");
                  cmbconvertir.Items.Add("gigabyte");
                  cmbconvertir.Items.Add("terabyte");
                  cmbconvertir.Items.Add("petabyte");
                  cmbconvertir.Items.Add("exabyte");
                  cmbconvertir.Items.Add("zettabyte");
                  cmbconvertir.Items.Add("brontobyte");
                  cmbconvertir.Items.Add("geopbyte");
                  }
                  else
                  if ((cmbexpresado.SelectedIndex == 10))
                  {
                  cmbconvertir.Enabled = true;
                  cmbconvertir.Items.Clear();
                  cmbconvertir.Items.Add("bit");
                  cmbconvertir.Items.Add("byte");
                  cmbconvertir.Items.Add("kilobyte");
                  cmbconvertir.Items.Add("megabyte");
                  cmbconvertir.Items.Add("gigabyte");
                  cmbconvertir.Items.Add("terabyte");
                  cmbconvertir.Items.Add("petabyte");
                  cmbconvertir.Items.Add("exabyte");
                  cmbconvertir.Items.Add("zettabyte");
                  cmbconvertir.Items.Add("yottabyte");
                  cmbconvertir.Items.Add("geopbyte");
                  }
                  else
                  if ((cmbexpresado.SelectedIndex == 11))
                  {
                  cmbconvertir.Enabled = true;
                  cmbconvertir.Items.Clear();
                  cmbconvertir.Items.Add("bit");
                  cmbconvertir.Items.Add("byte");
                  cmbconvertir.Items.Add("kilobyte");
                  cmbconvertir.Items.Add("megabyte");
                  cmbconvertir.Items.Add("gigabyte");
                  cmbconvertir.Items.Add("terabyte");
                  cmbconvertir.Items.Add("petabyte");
                  cmbconvertir.Items.Add("exabyte");
                  cmbconvertir.Items.Add("zettabyte");
                  cmbconvertir.Items.Add("yottabyte");
                  cmbconvertir.Items.Add("brontobyte");
                  }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                if (txtdigite.Text == "")
                {
                    MessageBox.Show("Ingrese valor a convertir", "Conversor de unidades informáticas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdigite.Focus();
                }

                else


                    if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 0))
                    {
                        txtresultado.Text = (double.Parse(txtdigite.Text) / 8).ToString();
                        lblnombre.Text = "Byte";
                    }
                    else
                        if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 1))
                        {
                            txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024).ToString();
                            lblnombre.Text = "Kilobyte";
                        }
                        else
                            if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 2))
                            {
                                txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024).ToString();
                                lblnombre.Text = "Megabyte";
                            }
                            else
                                if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 3))
                                {
                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024).ToString();
                                    lblnombre.Text = "Gigabyte";
                                }
                                else
                                    if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 4))
                                    {
                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024).ToString();
                                        lblnombre.Text = "Terabyte";
                                    }
                                    else
                                        if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 5))
                                        {
                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                            lblnombre.Text = "Petabyte";
                                        }
                                        else
                                            if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 6))
                                            {
                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                lblnombre.Text = "exabyte";
                                            }
                                            else
                                                if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 7))
                                                {
                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                    lblnombre.Text = "zettabyte";
                                                }
                                                else
                                                    if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 8))
                                                    {
                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                        lblnombre.Text = "yottabyte";
                                                    }
                                                    else
                                                        if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 9))
                                                        {
                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                            lblnombre.Text = "brontobyte";
                                                        }
                                                        else
                                                            if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 10))
                                                            {
                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                lblnombre.Text = "geopbyte";
                                                            }
                                                            //comienza byte
                                                            else


                                                                if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 0))
                                                                {
                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 8).ToString();
                                                                    lblnombre.Text = "Bit";
                                                                }
                                                                else
                                                                    if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 1))
                                                                    {
                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                        lblnombre.Text = "Kilobyte";
                                                                    }
                                                                    else
                                                                        if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 2))
                                                                        {
                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                            lblnombre.Text = "Megabyte";
                                                                        }
                                                                        else
                                                                            if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 3))
                                                                            {
                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                lblnombre.Text = "Gigabyte";
                                                                            }
                                                                            else
                                                                                if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 4))
                                                                                {
                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                    lblnombre.Text = "Terabyte";
                                                                                }
                                                                                else
                                                                                    if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 5))
                                                                                    {
                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                        lblnombre.Text = "Petabyte";
                                                                                    }
                                                                                    else
                                                                                        if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 6))
                                                                                        {
                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                            lblnombre.Text = "exabyte";
                                                                                        }
                                                                                        else
                                                                                            if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 7))
                                                                                            {
                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                lblnombre.Text = "zettabyte";
                                                                                            }
                                                                                            else
                                                                                                if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 8))
                                                                                                {
                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                    lblnombre.Text = "yottabyte";
                                                                                                }
                                                                                                else
                                                                                                    if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 9))
                                                                                                    {
                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                        lblnombre.Text = "brontobyte";
                                                                                                    }
                                                                                                    else
                                                                                                        if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 10))
                                                                                                        {
                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                            lblnombre.Text = "geopbyte";
                                                                                                        }
                                                                                                        //comienza kilobyte
                                                                                                        else


                                                                                                            if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 0))
                                                                                                            {
                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 8).ToString();
                                                                                                                lblnombre.Text = "Bit";
                                                                                                            }
                                                                                                            else
                                                                                                                if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                {
                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                    lblnombre.Text = "Byte";
                                                                                                                }
                                                                                                                else
                                                                                                                    if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                    {
                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                        lblnombre.Text = "Megabyte";
                                                                                                                    }
                                                                                                                    else
                                                                                                                        if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                        {
                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                            lblnombre.Text = "Gigabyte";
                                                                                                                        }
                                                                                                                        else
                                                                                                                            if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                            {
                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                lblnombre.Text = "Terabyte";
                                                                                                                            }
                                                                                                                            else
                                                                                                                                if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                {
                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                    lblnombre.Text = "Petabyte";
                                                                                                                                }
                                                                                                                                else
                                                                                                                                    if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                    {
                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                        lblnombre.Text = "exabyte";
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                        if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                        {
                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                            lblnombre.Text = "zettabyte";
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                            if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                            {
                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                lblnombre.Text = "yottabyte";
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                                if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                {
                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                    lblnombre.Text = "brontobyte";
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                    {
                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                        lblnombre.Text = "geopbyte";
                                                                                                                                                    }
                                                                                                                                                    //comienza megabyte
                                                                                                                                                    else


                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                        {
                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 8).ToString();
                                                                                                                                                            lblnombre.Text = "Bit";
                                                                                                                                                        }
                                                                                                                                                        else
                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                            {
                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                lblnombre.Text = "Byte";
                                                                                                                                                            }
                                                                                                                                                            else
                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                {
                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                    lblnombre.Text = "Kilobyte";
                                                                                                                                                                }
                                                                                                                                                                else
                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                    {
                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                        lblnombre.Text = "Gigabyte";
                                                                                                                                                                    }
                                                                                                                                                                    else
                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                        {
                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                            lblnombre.Text = "Terabyte";
                                                                                                                                                                        }
                                                                                                                                                                        else
                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                            {
                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                lblnombre.Text = "Petabyte";
                                                                                                                                                                            }
                                                                                                                                                                            else
                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                {
                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                    lblnombre.Text = "exabyte";
                                                                                                                                                                                }
                                                                                                                                                                                else
                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                    {
                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                        lblnombre.Text = "zettabyte";
                                                                                                                                                                                    }
                                                                                                                                                                                    else
                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                        {
                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                            lblnombre.Text = "yottabyte";
                                                                                                                                                                                        }
                                                                                                                                                                                        else
                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                            {
                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                lblnombre.Text = "brontobyte";
                                                                                                                                                                                            }
                                                                                                                                                                                            else
                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                {
                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                    lblnombre.Text = "geopbyte";
                                                                                                                                                                                                }
                                                                                                                                                                                                //comienza gigabyte 
                                                                                                                                                                                                else


                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                    {
                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                        lblnombre.Text = "Bit";
                                                                                                                                                                                                    }
                                                                                                                                                                                                    else
                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                        {
                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                            lblnombre.Text = "Byte";
                                                                                                                                                                                                        }
                                                                                                                                                                                                        else
                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                            {
                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                            }
                                                                                                                                                                                                            else
                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                    lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                }
                                                                                                                                                                                                                else
                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                        lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                    else
                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                            lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                        else
                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                lblnombre.Text = "exabyte";
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                    lblnombre.Text = "zettabyte";
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                        lblnombre.Text = "yottabyte";
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                            lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                            //comienza terabyte 
                                                                                                                                                                                                                                            else


                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                    lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                        lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                            lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                    lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                        lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                            lblnombre.Text = "exabyte";
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                lblnombre.Text = "zettabyte";
                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                    lblnombre.Text = "yottabyte";
                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                        lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                            lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                        //comienza petabyte
                                                                                                                                                                                                                                                                                        else


                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "exabyte";
                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "zettabyte";
                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "yottabyte";
                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                    //comienza exabyte
                                                                                                                                                                                                                                                                                                                                    else


                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "zettabyte";
                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "yottabyte";
                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                //comienza zettabyte 
                                                                                                                                                                                                                                                                                                                                                                                else


                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Exabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "yottabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                            //comienza yottabyte
                                                                                                                                                                                                                                                                                                                                                                                                                            else


                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Exabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Zettabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        //comienza brontobyte
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else


                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Exabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Zettabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Yottabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    //comienza geopbyte
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Exabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Zettabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Yottabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Brontobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }














































































































































































































































































































































































































































































            
        }

        private void cálcularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
                if (txtdigite.Text == "")
                {
                    MessageBox.Show("Ingrese valor a convertir", "Conversor de unidades informáticas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtdigite.Focus();
                }

                else


                    if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 0))
                    {
                        txtresultado.Text = (double.Parse(txtdigite.Text) / 8).ToString();
                        lblnombre.Text = "Byte";
                    }
                    else
                        if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 1))
                        {
                            txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024).ToString();
                            lblnombre.Text = "Kilobyte";
                        }
                        else
                            if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 2))
                            {
                                txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024).ToString();
                                lblnombre.Text = "Megabyte";
                            }
                            else
                                if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 3))
                                {
                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024).ToString();
                                    lblnombre.Text = "Gigabyte";
                                }
                                else
                                    if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 4))
                                    {
                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024).ToString();
                                        lblnombre.Text = "Terabyte";
                                    }
                                    else
                                        if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 5))
                                        {
                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                            lblnombre.Text = "Petabyte";
                                        }
                                        else
                                            if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 6))
                                            {
                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                lblnombre.Text = "exabyte";
                                            }
                                            else
                                                if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 7))
                                                {
                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                    lblnombre.Text = "zettabyte";
                                                }
                                                else
                                                    if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 8))
                                                    {
                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                        lblnombre.Text = "yottabyte";
                                                    }
                                                    else
                                                        if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 9))
                                                        {
                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                            lblnombre.Text = "brontobyte";
                                                        }
                                                        else
                                                            if ((cmbexpresado.SelectedIndex == 0) & (cmbconvertir.SelectedIndex == 10))
                                                            {
                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 8 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                lblnombre.Text = "geopbyte";
                                                            }
                                                            //comienza byte
                                                            else


                                                                if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 0))
                                                                {
                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 8).ToString();
                                                                    lblnombre.Text = "Bit";
                                                                }
                                                                else
                                                                    if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 1))
                                                                    {
                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                        lblnombre.Text = "Kilobyte";
                                                                    }
                                                                    else
                                                                        if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 2))
                                                                        {
                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                            lblnombre.Text = "Megabyte";
                                                                        }
                                                                        else
                                                                            if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 3))
                                                                            {
                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                lblnombre.Text = "Gigabyte";
                                                                            }
                                                                            else
                                                                                if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 4))
                                                                                {
                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                    lblnombre.Text = "Terabyte";
                                                                                }
                                                                                else
                                                                                    if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 5))
                                                                                    {
                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                        lblnombre.Text = "Petabyte";
                                                                                    }
                                                                                    else
                                                                                        if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 6))
                                                                                        {
                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                            lblnombre.Text = "exabyte";
                                                                                        }
                                                                                        else
                                                                                            if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 7))
                                                                                            {
                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                lblnombre.Text = "zettabyte";
                                                                                            }
                                                                                            else
                                                                                                if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 8))
                                                                                                {
                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                    lblnombre.Text = "yottabyte";
                                                                                                }
                                                                                                else
                                                                                                    if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 9))
                                                                                                    {
                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                        lblnombre.Text = "brontobyte";
                                                                                                    }
                                                                                                    else
                                                                                                        if ((cmbexpresado.SelectedIndex == 1) & (cmbconvertir.SelectedIndex == 10))
                                                                                                        {
                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                            lblnombre.Text = "geopbyte";
                                                                                                        }
                                                                                                        //comienza kilobyte
                                                                                                        else


                                                                                                            if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 0))
                                                                                                            {
                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 8).ToString();
                                                                                                                lblnombre.Text = "Bit";
                                                                                                            }
                                                                                                            else
                                                                                                                if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                {
                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                    lblnombre.Text = "Byte";
                                                                                                                }
                                                                                                                else
                                                                                                                    if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                    {
                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                        lblnombre.Text = "Megabyte";
                                                                                                                    }
                                                                                                                    else
                                                                                                                        if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                        {
                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                            lblnombre.Text = "Gigabyte";
                                                                                                                        }
                                                                                                                        else
                                                                                                                            if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                            {
                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                lblnombre.Text = "Terabyte";
                                                                                                                            }
                                                                                                                            else
                                                                                                                                if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                {
                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                    lblnombre.Text = "Petabyte";
                                                                                                                                }
                                                                                                                                else
                                                                                                                                    if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                    {
                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                        lblnombre.Text = "exabyte";
                                                                                                                                    }
                                                                                                                                    else
                                                                                                                                        if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                        {
                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                            lblnombre.Text = "zettabyte";
                                                                                                                                        }
                                                                                                                                        else
                                                                                                                                            if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                            {
                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                lblnombre.Text = "yottabyte";
                                                                                                                                            }
                                                                                                                                            else
                                                                                                                                                if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                {
                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                    lblnombre.Text = "brontobyte";
                                                                                                                                                }
                                                                                                                                                else
                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 2) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                    {
                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                        lblnombre.Text = "geopbyte";
                                                                                                                                                    }
                                                                                                                                                    //comienza megabyte
                                                                                                                                                    else


                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                        {
                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 8).ToString();
                                                                                                                                                            lblnombre.Text = "Bit";
                                                                                                                                                        }
                                                                                                                                                        else
                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                            {
                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                lblnombre.Text = "Byte";
                                                                                                                                                            }
                                                                                                                                                            else
                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                {
                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                    lblnombre.Text = "Kilobyte";
                                                                                                                                                                }
                                                                                                                                                                else
                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                    {
                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                        lblnombre.Text = "Gigabyte";
                                                                                                                                                                    }
                                                                                                                                                                    else
                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                        {
                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                            lblnombre.Text = "Terabyte";
                                                                                                                                                                        }
                                                                                                                                                                        else
                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                            {
                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                lblnombre.Text = "Petabyte";
                                                                                                                                                                            }
                                                                                                                                                                            else
                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                {
                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                    lblnombre.Text = "exabyte";
                                                                                                                                                                                }
                                                                                                                                                                                else
                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                    {
                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                        lblnombre.Text = "zettabyte";
                                                                                                                                                                                    }
                                                                                                                                                                                    else
                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                        {
                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                            lblnombre.Text = "yottabyte";
                                                                                                                                                                                        }
                                                                                                                                                                                        else
                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                            {
                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                lblnombre.Text = "brontobyte";
                                                                                                                                                                                            }
                                                                                                                                                                                            else
                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 3) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                {
                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                    lblnombre.Text = "geopbyte";
                                                                                                                                                                                                }
                                                                                                                                                                                                //comienza gigabyte 
                                                                                                                                                                                                else


                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                    {
                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                        lblnombre.Text = "Bit";
                                                                                                                                                                                                    }
                                                                                                                                                                                                    else
                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                        {
                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                            lblnombre.Text = "Byte";
                                                                                                                                                                                                        }
                                                                                                                                                                                                        else
                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                            {
                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                            }
                                                                                                                                                                                                            else
                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                {
                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                    lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                }
                                                                                                                                                                                                                else
                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                    {
                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                        lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                    }
                                                                                                                                                                                                                    else
                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                        {
                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                            lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                        }
                                                                                                                                                                                                                        else
                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                lblnombre.Text = "exabyte";
                                                                                                                                                                                                                            }
                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                    lblnombre.Text = "zettabyte";
                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                        lblnombre.Text = "yottabyte";
                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                            lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 4) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                            //comienza terabyte 
                                                                                                                                                                                                                                            else


                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                    lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                        lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                            lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                    lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                        lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                            lblnombre.Text = "exabyte";
                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                lblnombre.Text = "zettabyte";
                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                    lblnombre.Text = "yottabyte";
                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                        lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 5) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                            lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                        //comienza petabyte
                                                                                                                                                                                                                                                                                        else


                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "exabyte";
                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "zettabyte";
                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "yottabyte";
                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 6) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                    //comienza exabyte
                                                                                                                                                                                                                                                                                                                                    else


                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "zettabyte";
                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "yottabyte";
                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 7) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                //comienza zettabyte 
                                                                                                                                                                                                                                                                                                                                                                                else


                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Exabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "yottabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 8) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                            //comienza yottabyte
                                                                                                                                                                                                                                                                                                                                                                                                                            else


                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Exabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Zettabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "brontobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 9) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) / 1024 / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        //comienza brontobyte
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else


                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Exabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Zettabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Yottabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 10) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) / 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "geopbyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    //comienza geopbyte
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else


                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 0))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 8).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Bit";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 1))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Byte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 2))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Kilobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 3))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Megabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 4))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Gigabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 5))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Terabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 6))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Petabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 7))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        lblnombre.Text = "Exabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 8))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            lblnombre.Text = "Zettabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 9))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                txtresultado.Text = (double.Parse(txtdigite.Text) * 1024 * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                lblnombre.Text = "Yottabyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            }
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            else
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                if ((cmbexpresado.SelectedIndex == 11) & (cmbconvertir.SelectedIndex == 10))
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    txtresultado.Text = (double.Parse(txtdigite.Text) * 1024).ToString();
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    lblnombre.Text = "Brontobyte";
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                }

                { btnnuevo.Focus(); }














































































































































































































































































































































































































































































            
        }

        private void nuevoCálculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtdigite.Text = "";
            txtresultado.Text = "";
            txtdigite.Focus();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Creado por: Gilson Jefferson Ponce Briones", "Acerca de",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
