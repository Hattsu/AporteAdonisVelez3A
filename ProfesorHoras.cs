class ProfesorHoras : Profesor , ISueldo
{
     double precioh = 2.25;
    public int htrabajadas { get; set; }
    double total;
    public void DatosSueldo()
    {
        this.precioh = precioh;
        this.htrabajadas = htrabajadas;
    }
    public double CalcularSueldo()
    {
        total = this.precioh*this.htrabajadas;
        return total;
    }
    public void Imprimir()
    {
        Console.WriteLine("---- Profesor por Horas ----");
        Console.WriteLine("Nombre: "+this.nombre);
        Console.WriteLine("Apellido: "+this.apellido);
        Console.WriteLine("Direccion: "+this.direccion);
        Console.WriteLine("Numero de identidad "+this.id);
        Console.WriteLine("El sueldo a recibir es de: "+CalcularSueldo()+" $");
    }
}