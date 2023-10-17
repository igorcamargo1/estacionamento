using Estacionamento.Models;

namespace Estacionamento.Teste;

public class VeiculoTestes
{
    [Fact]
    public void TesteVeiucloAcelerar()
    {
        var veiculo = new Veiculo();
        veiculo.Acelerar(10);

        Assert.Equal(100, veiculo.VelocidadeAtual);
    }

    [Fact]
    public void TesteVeiculoFrear()
    {
        var veiculo = new Veiculo();
        veiculo.Frear(10);

        Assert.Equal(-150, veiculo.VelocidadeAtual);
    }
}