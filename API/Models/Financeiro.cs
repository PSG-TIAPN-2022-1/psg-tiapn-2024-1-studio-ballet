﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace APIJessicaOliveira2.Models;

public partial class Financeiro
{
    public int Id;
    public decimal ValorBoleto { get; set; }

    public DateOnly DataBoleto { get; set; }

    public string Cpf { get; set; }

    public string SituacaoPagamento { get; set; }

    [JsonIgnore]
    public virtual Aluno Cpfs { get; set; }
}