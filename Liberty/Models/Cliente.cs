﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Liberty.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }
        
        public DadosCliente Segurado { get; set; }

        public DadosCliente Condutor { get; set; }

        public QuestionarioRisco Questionario { get; set; }

        public Veiculo Veiculo { get; set; }

        public string EnviarFormulario { get; set; }
    }

    public class DadosCliente
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Cep { get; set; }
        public Veiculo Veiculo { get; set; }
        public string Cpf { get; set; }
        public string DataNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string CepResidencial { get; set; }
        public string Documento { get; set; }
    }

    public class Veiculo
    {
        public string Marca { get; set; }
        public string Ano { get; set; }
        public string Modelo { get; set; }
        public string ZeroKm { get; set; }
        public string PossuiAlarme { get; set; }

    }

    public class QuestionarioRisco
    {
        public string TempoHabilitacao { get; set; }
        public string ResideEm { get; set; }
        public string CepPernoiteVeiculo { get; set; }
        public string GaragemResidencial { get; set; }
        public string GaragemComercial { get; set; }
        public string DistanciaResidenciaTrabalho { get; set; }
        public string GaragemCursos { get; set; }
        public string ResidePessoas { get; set; }
    }
}
