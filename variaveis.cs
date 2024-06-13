using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace autoMestreJuan
{
    public static class variaveis
    {
        //Estrutura FTP

        public static string enderecoServidorFtp = "ftp://127.0.0.1/admin/";
        public static string usuarioFtp = "ti22";
        public static string senhaFtp = "123";

        //Fim Estrutura FTP

        //Geral
        public static string funcao;
        public static int linhaSelecionada;

        //Menu
        public static string usuario, senha, especialidade;
        public static int tentativa;

        //Serviço
        public static string nomeServico;

        //Veículo
        public static string marcaVeiculo, modeloVeiculo, placaVeiculo;
        public static DateTime dataServicoVeiculo;

        //Cliente
        public static int codigoCliente;
        public static string nomeCliente, enderecoCliente, telefoneCliente, emailCliente, senhaCliente, fotoCliente, altCliente, atFotoCliente, caminhoFotoCliente, statusCliente;
        public static DateTime dataCadCliente;

        //Agenda
        public static int codigoAgenda, codigoServico, codigoVeiculo, codigoMecanico, kmVeiculoAgenda;
        public static string descricaoAgenda, statusAgenda;
        public static double valorServicoAgenda;
        public static DateTime dataAgenda;

        //Mecânico
        public static string nomeMecanico;
    }
}
