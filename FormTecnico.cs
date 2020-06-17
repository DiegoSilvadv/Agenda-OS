﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_OS
{
    public partial class FormTecnico : Form
    {
        private Usuario tecnico;

        private string action;
        private string Action
        {
            get { return this.action; }
            set
            {
                this.action = value;
                SetForm();
            }
        }
        
        public FormTecnico(Usuario tecnico, string action)
        {
            InitializeComponent();
            this.tecnico = tecnico;
            this.Action = action;
        }

        private void SetForm()
        {
            if (this.Action == "New")
            {
                cmbSexo.SelectedIndex = 0;
                txtLogin.Enabled = true;
                txtSenha.Enabled = true;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = true;
                btnSalvar.Text = "Cadastrar";
            }
            else if (this.Action == "Show")
            {
                ShowUsuario();
                txtLogin.Enabled = false;
                txtSenha.Enabled = false;
                txtNome.Enabled = false;
                dtpNasc.Enabled = false;
                cmbSexo.Enabled = false;
                mtbRG.Enabled = false;
                mtbCPF.Enabled = false;
                mtbCNH.Enabled = false;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = true;
                btnSalvar.Enabled = false;
                btnSalvar.Text = "Salvar";
                btnEditar.Text = "Editar";
            }
            else if (this.Action == "Edit")
            {
                ShowUsuario();
                txtLogin.Enabled = false;
                txtSenha.Enabled = false;
                txtNome.Enabled = true;
                dtpNasc.Enabled = true;
                cmbSexo.Enabled = true;
                mtbRG.Enabled = true;
                mtbCPF.Enabled = true;
                mtbCNH.Enabled = true;
                btnEditar.Enabled = true;
                btnExcluir.Enabled = false;
                btnSalvar.Enabled = true;
                btnSalvar.Text = "Salvar";
                btnEditar.Text = "Cancelar";
            }
        }

        private void SetUsuario()
        {
            this.tecnico.Login = txtLogin.Text;
            this.tecnico.Senha = txtSenha.Text;
            this.tecnico.Nome = txtNome.Text;
            this.tecnico.Nasc = dtpNasc.Value;
            this.tecnico.Sexo = cmbSexo.Text;
            this.tecnico.RG = rtnNoMask(mtbRG);
            this.tecnico.CPF = rtnNoMask(mtbCPF);
            this.tecnico.CNH = rtnNoMask(mtbCNH);
        }

        private void ShowUsuario()
        {
            labCOD.Text = this.tecnico.ID.ToString();
            txtLogin.Text = this.tecnico.Login;
            txtSenha.Text = this.tecnico.Senha;
            txtNome.Text = this.tecnico.Nome;
            if (this.tecnico.Sexo == "")
            {
                cmbSexo.SelectedIndex = 0;
            }
            else
            {
                cmbSexo.Text = this.tecnico.Sexo;
            }
            
            dtpNasc.Value = this.tecnico.Nasc;
            mtbRG.Text = this.tecnico.RG;
            mtbCPF.Text = this.tecnico.CPF;
            mtbCNH.Text = this.tecnico.CNH;
        }

        private string rtnNoMask(MaskedTextBox mtb)
        {
            mtb.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string rtn = mtb.Text;
            mtb.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return rtn;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            SetUsuario();
            if (this.tecnico.VerificarLogin() == 0 || this.tecnico.VerificarLogin() == 0)
            {
                if (this.tecnico.SalvarUsuario(this.Action))
                {
                    this.Action = "Show";
                }
                else
                {
                    MessageBox.Show(Conexao.msg);
                    btnSalvar.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Login não disponivel.\n Escolha outro para continuar o cadastro.");
                btnSalvar.Enabled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.Action == "Edit")
            {
                this.Action = "Show";
            }
            else
            {
                this.Action = "Edit";
            }
        }

        private void frmTecnico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (btnEditar.Text == "Cancelar")
                {
                    btnEditar.PerformClick();
                }
                else
                {
                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.F2 && btnEditar.Text == "Editar")
            {
                btnEditar.PerformClick();
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnSalvar.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnExcluir.PerformClick();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("btnExcluir");
        }

        private void labResetarLoginSenha_Click(object sender, EventArgs e)
        {
            txtSenha.Text = "";
        }
    }
}
