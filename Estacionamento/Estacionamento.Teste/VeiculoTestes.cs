using Estacionamento.Models;
using Microsoft.VisualStudio.TestPlatform.Utilities;
using Xunit.Abstractions;

namespace Estacionamento.Teste;

public class VeiculoTestes : IDisposable
{
    private Veiculo veiculo;
    public ITestOutputHelper Output { get; }
    public VeiculoTestes(ITestOutputHelper output)
    {
        Output = output;
        Output.WriteLine("Execu��o do Construtor");
        veiculo = new Veiculo();
    }
    [Fact]
    public void TesteVeiucloAcelerarComParametro10()
    {
        //Arrange
        //var veiculo = new Veiculo();
        //Act
        veiculo.Acelerar(10);
        //Assert
        Assert.Equal(100, veiculo.VelocidadeAtual);
    }

    [Fact]
    public void TesteVeiculoFrearComParametro10()
    {
        //Arrange
        //var veiculo = new Veiculo();
        //Act
        veiculo.Frear(10);
        //Assert
        Assert.Equal(-150, veiculo.VelocidadeAtual);
    }

    [Fact(Skip ="Teste ainda n�o implementado")]
    public void ValidaNomeProprietarioDoVeiculo()
    {

    }

    [Fact]
    public void ImprimiDadosVeiculo()
    {
        //Arrange
        //var carro = new Veiculo();
        veiculo.Proprietario = "Igor Camargo";
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Modelo = "Fusca";
        veiculo.Cor = "Azul";
        veiculo.Placa = "asd-8788";
        //Act
        string dados = veiculo.ToString();
        //Assert
        Assert.Contains("Ficha do Ve�culo:",dados);
    }

    [Fact]
    public void TesteNomeProprietarioVeiculoComMenosDeTresCatacteres()
    {
        //Arrange
        string nomeProprietario = "Ab";

        
        //Assert
        Assert.Throws<System.FormatException>(
            //Act
            () => new Veiculo(nomeProprietario)
            );

        
    }

    [Fact]
    public void TesteMensagemDeExcecaoQuartoCaractereDaPlaca()
    {
        //Arrange
        string placa = "ASDF8888";

        //Assert
        var mensagem = Assert.Throws<System.FormatException>(
            //Act
            () => new Veiculo().Placa = placa
            );

        //Assert
        Assert.Equal("O 4� caractere deve ser um h�fen", mensagem.Message);
    }

    public void Dispose()
    {
        Output.WriteLine("Execu��o do Cleanup");
    }
}