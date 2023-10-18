using Estacionamento.Models;

namespace Estacionamento.Teste;

public class VeiculoTestes
{
    [Fact]
    public void TesteVeiucloAcelerarComParametro10()
    {
        //Arrange
        var veiculo = new Veiculo();
        //Act
        veiculo.Acelerar(10);
        //Assert
        Assert.Equal(100, veiculo.VelocidadeAtual);
    }

    [Fact]
    public void TesteVeiculoFrearComParametro10()
    {
        //Arrange
        var veiculo = new Veiculo();
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
        var carro = new Veiculo();
        carro.Proprietario = "Igor Camargo";
        carro.Tipo = TipoVeiculo.Automovel;
        carro.Modelo = "Fusca";
        carro.Cor = "Azul";
        carro.Placa = "asd-8788";
        //Act
        string dados = carro.ToString();
        //Assert
        Assert.Contains("Ficha do Veículo:",dados);
    }
}