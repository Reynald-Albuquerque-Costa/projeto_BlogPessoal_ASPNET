﻿using BlogAPI.Src.Modelos;
using System.Threading.Tasks;

namespace BlogAPI.Src.Servicos
{

    /// <summary>
    /// <para>Resumo: Interface Responsavel por representar ações deautenticação</para>
    /// <para>Criado por: Reynald</para>
    /// <para>Versão: 1.0</para>
    /// <para>Data: 16/08/2022</para>
    /// </summary>
    public interface IAutenticacao
    {
        string CodificarSenha(string senha);
        Task CriarUsuarioSemDuplicarAsync(Usuario usuario);
        string GerarToken(Usuario usuario);
    }
}
