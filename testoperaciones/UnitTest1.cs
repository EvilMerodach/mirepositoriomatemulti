namespace testoperaciones;

public class UnitTest1
{
    [Theory]
    [InlineData(2, 3, 6)]
    [InlineData(11, 4, 44)]
    [InlineData(4, 1, 4)]
    [InlineData(8, 2, 16)]
    [InlineData(11, 2, 22)]
    public void testmultiplicacion(int a, int b, int resultadoesperado)
    {
        ///AAA Arange Act Assert
        ///Arange
        int resultadoreal;
        ///Act
        resultadoreal=operacionesbasicas.multiplicacion(a,b);
        ///Assert
        Assert.Equal(resultadoesperado, resultadoreal)

    }
}
