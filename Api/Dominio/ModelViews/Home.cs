namespace MinimalApi.Dominio.ModelViews;

public struct Home
{
    public string Mensagem { get => "Bem vindo a API de veículos - MinimalApi"; }
    public string Documentacao { get => "/swagger"; }
}