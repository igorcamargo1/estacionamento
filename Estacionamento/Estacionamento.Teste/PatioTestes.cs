namespace Estacionamento.Teste;

public class PatioTestes
{
    [Fact]
    public void ValidaFaturamento()
    {
        //Arrange
        var estacionamento = new Patio();
        var veiculo = new Veiculo();
        veiculo.Proprietario = "Igor Camargo";
        veiculo.Tipo = TipoVeiculo.Automovel;
        veiculo.Modelo = "Fusca";
        veiculo.Cor = "Azul";
        veiculo.Placa = "asd-8788";
        estacionamento.RegistrarEntradaVeiculo(veiculo);
        estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);

        //Act
        double faturamento = estacionamento.TotalFaturado();

        //Assert
        Assert.Equal(2, faturamento);
    }

    [Theory]
    [InlineData("André Silva", "ASD-1458", "Branco", "Golf")]
    [InlineData("Igor Camargo", "FFF-1458","Preto", "Corolla")]
    [InlineData("Marta Souza", "ABC-1234", "Prata", "Palio")]
    public void ValidaFaturamentoComVariosVeiculos(string proprietario,
                                  string placa,
                                  string cor,
                                  string modelo)
    {
        //Arrange
        var estacionamento = new Patio();
        var veiculo = new Veiculo();
        veiculo.Proprietario = proprietario;
        veiculo.Placa= placa;
        veiculo.Cor = cor;
        veiculo.Modelo = modelo;
        estacionamento.RegistrarEntradaVeiculo(veiculo);
        estacionamento.RegistrarSaidaVeiculo(veiculo.Placa);
        //Act
        double faturamento = estacionamento.TotalFaturado();
        //Assert
        Assert.Equal(2, faturamento);
    }

}
