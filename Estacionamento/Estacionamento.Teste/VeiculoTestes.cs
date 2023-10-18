using Estacionamento.Models;

namespace Estacionamento.Teste;

public class VeiculoTestes
{
    [Fact(DisplayName ="Teste N� 1")]
    [Trait("Funcionalidade","Acelerar")]
    public void TesteVeiucloAcelerar()
    {
        //Arrange
        var veiculo = new Veiculo();
        //Act
        veiculo.Acelerar(10);
        //Assert
        Assert.Equal(100, veiculo.VelocidadeAtual);
    }

    [Fact(DisplayName = "Teste N� 2")]
    [Trait("Funcionalidade", "Frear")]
    public void TesteVeiculoFrear()
    {
        //Arrange
        var veiculo = new Veiculo();
        //Act
        veiculo.Frear(10);
        //Assert
        Assert.Equal(-150, veiculo.VelocidadeAtual);
    }

    [Fact(DisplayName ="Teste N�3",Skip ="Teste ainda n�o implementado")]
    public void ValidaNomeProprietario()
    {

    }

    [Fact]
    public void DadosVeiculo()
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
        Assert.Contains("Ficha do Ve�culo:",dados);
    }
}