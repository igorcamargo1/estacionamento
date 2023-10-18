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
}