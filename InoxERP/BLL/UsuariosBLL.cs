﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using InoxERP.DAL;
using InoxERP.Modelos;
using System.Windows.Forms;

namespace InoxERP.BLL
{
    public class UsuariosBLL
    {
        public void Incluir(UsuariosInformation usuarios)
        {
            //O usuário é obrigatório
            if (usuarios.Usuario == "")
            {
                MessageBox.Show("O NOME do Usuário é obrigatório");
                return;
            }

            //A senha é obrigatória
            if (usuarios.Senha.Trim().Length == 0)
            {
                MessageBox.Show("A SENHA do Usuário é obrigatória");
                return;
            }

            //A tipo é obrigatório
            if (usuarios.Tipo.Trim().Length == 0)
            {
                MessageBox.Show("O TIPO do Usuário é obrigatório");
                return;
            } 
            else if(usuarios.Tipo == "Administrador" || usuarios.Tipo == "Usuário")
            {
                //Se tudo está Ok, chama a rotina de inserção.
                UsuariosDAL obj = new UsuariosDAL();
                obj.Incluir(usuarios);
                return;
            }
            else
            {
                MessageBox.Show("O Tipo deve ser Administrador ou Usuário, selecione uma das duas opções por favor");
                return;
            }            
        }

        public void Alterar(UsuariosInformation usuarios)
        {
            UsuariosDAL obj = new UsuariosDAL();
            obj.Alterar(usuarios);
        }

        public void Excluir(int idLogin)
        {
            if (idLogin < 1)
            {
                throw new Exception("Selecione um usuario antes de excluílo.");
            }
            if (DialogResult.Yes == MessageBox.Show("Tem certeza que deseja apagar o registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2))
            {
                UsuariosDAL obj = new UsuariosDAL();
                obj.Excluir(idLogin);
                MessageBox.Show("O usuario foi excluído com sucesso!");
            }
            else
                MessageBox.Show("Exclusão Cancelada");
        }

        public DataTable Listagem()
        {
            UsuariosDAL obj = new UsuariosDAL();
            return obj.Listagem();
        }

        public UsuariosList ConsultaID(UsuariosInformation user)
        {
            UsuariosDAL obj = new UsuariosDAL();
            return obj.ConsultaUser(user);
        }
    }
}
