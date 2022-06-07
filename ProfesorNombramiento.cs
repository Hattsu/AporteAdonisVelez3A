class ProfesorNombramiento : Profesor , ISueldo
{
    double sueldofijo = 1000;
    double total;
    public void DatosSueldo()
    {
        this.sueldofijo = sueldofijo;
    }
    public double CalcularSueldo()
    {
        total = sueldofijo;
        return total;
    }
    public void Imprimir()
    {
        Console.WriteLine("---- Profesor con Nombramiento ----");
        Console.WriteLine("Nombre: "+this.nombre);
        Console.WriteLine("Apellido: "+this.apellido);
        Console.WriteLine("Direccion: "+this.direccion);
        Console.WriteLine("Numero de identidad "+this.id);
        Console.WriteLine("El suledo a recibir es de: "+CalcularSueldo()+" $");
    }
}