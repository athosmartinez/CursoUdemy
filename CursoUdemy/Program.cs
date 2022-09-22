﻿using System;
using System.Collections.Generic;
using CursoUdemy.FUNDAMENTOS;
using CursoUdemy.ESTRUTURASDECONTROLE;
namespace CursoCSharp

{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroProgramaCurso.Executar},
                {"Comentarios Programa - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes Programa - Fundamentos", VariaveisEConstantes.Executar},
                {"Interferenica Programa - Fundamentos", Interferencia.Executar},
                {"Interpolação Programa - Fundamentos", InterporlaçãoDeStrings.Executar},
                {"Notacao de Ponto Programa - Fundamentos", NotacaoPonto.Executar},
                {"lendo Dados do Console - Fundamentos", LendoDadosDoConsole.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Converção - Fundamentos", Converçao.Executar},
                {"Operadores Aritimeticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternarios - Fundamentos", OperadoresTernarios.Executar},
                // Estruturas de Controle 
                {"Estrura If -  Estruturas de Controle", EstruturaIf.Executar},
                {"Estrura Switch -  Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrura While -  Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrura do While -  Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrura do For -  Estruturas de Controle", For.Executar},
                {"Estrura do ForEach -  Estruturas de Controle", ForEach.Executar},
                {"Estrura do Break -  Estruturas de Controle", Break.Executar},
                {"Estrura do Continue -  Estruturas de Controle", Continue.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}