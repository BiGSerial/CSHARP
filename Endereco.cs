﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicativo_CRUD;
using MySql.Data.MySqlClient;

namespace ClientesApp2
{
    internal class Endereco
    {
        public int id_endereco;
        public string logradouro;
        public string numero;
        public string complemento;
        public string bairro;
        public string municipio;
        public string uf;
        public string cep;
        private ConexaoBD banco;

        public Endereco() 
        {
            this.id_endereco = 0;
            this.logradouro = "";
            this.numero = "";
            this.complemento = "";
            this.bairro = "";
            this.municipio = "";
            this.uf = "";
            this.cep = "";
            this.banco = new ConexaoBD();
        }

        public void setId_endereco(int novo) { this.id_endereco = novo; }
        public void setLogradouro(string novo) { this.logradouro = novo; }
        public void setNumero(string novo) { this.numero = novo; }
        public void setComplemento(string novo) { this.complemento = novo; }
        public void setBairro(string novo) { this.bairro = novo; }
        public void setMunicipio(string novo) { this.municipio = novo; }
        public void setUf(string novo) { this.uf = novo; }
        public void setCep(string novo) { this.cep = novo; }


        public int getId_endereco() { return this.id_endereco; }
        public string getLogradouro() { return this.logradouro; }
        public string getNumero() { return this.numero; }
        public string getComplemento() { return this.complemento; }
        public string getBairro() { return this.bairro; }
        public string getMunicipio() { return this.municipio; }
        public string getUf() { return this.uf; }
        public string getCep() { return this.cep; }

        public void cadastrarEndereco()
        {
            MySqlDataReader reader;
            this.banco.conectar();
            this.banco.nonQuery("insert into endereco (logradouro,numero,complemento,bairro,municipio,uf,cep)  values " +
                "('" + this.getLogradouro() + "', '" +
                this.getNumero() + "','" +
                this.getComplemento() + "','" +
                this.getBairro() + "','" +
                this.getMunicipio() + "','" +
                this.getUf() + "','" +
                this.getCep() + "')");
            reader = this.banco.Query("select id_endereco from endereco where" +
                " logradouro='" + this.getLogradouro() +
                "' and numero='" + this.getNumero() +
                "' and complemento='" + this.getComplemento() +
                "' and bairro='" + this.getBairro() +
                "' and municipio='" + this.getMunicipio() +
                "' and uf='" + this.getUf() +
                "' and CEP='" + this.getCep() + "';");
            reader.Read();
            int endereco = reader.GetInt32(0);
            this.setId_endereco(endereco);
            this.banco.close();
        }

        public void alterarEndereco()
        {
            this.banco.conectar();
            this.banco.nonQuery("UPDATE `basedados_pacientes`.`endereco` SET " +
                "`Logradouro` = '" + this.getLogradouro() +
                "', `Numero` = '" + this.getNumero() +
                "', `complemento` = '" + this.getComplemento() +
                "', `Bairro` = '" + this.getBairro() +
                "', `municipio` = '" + this.getMunicipio() +
                "', `UF` = '" + this.getUf() +
                "', `CEP` = '" + this.getCep() +
                "' WHERE (`id_endereco` = '" + this.getId_endereco() + "')");
            this.banco.close();
        }

        public void excluirEndereco()
        {
            this.banco.conectar();
            this.banco.nonQuery("Delete from endereco where id_endereco = '" + this.getId_endereco() + "';");
            this.banco.close();
        }
    }


}
