using Estacionamento.Models;

namespace Estacionamento.Teste;

public class VeiculoTestes : IDisposable
{
    private Veiculo veiculo;
    public VeiculoTestes()
    {
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

    [Fact(Skip ="Teste ainda não implementado")]
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
        Assert.Contains("Ficha do Veículo:",dados);
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}