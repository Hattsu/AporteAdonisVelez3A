class ProfesorContrato : Profesor , ISueldo
{
    double sueldobasico = 400.25;
    public int hextras { get; set; }
    double precioh = 2.25;
    double htotal;
    double total;
    public void DatosSueldo()
    {
        this.hextras = hextras;

    }
    public double CalcularSueldo()
    {
        htotal = this.precioh*this.hextras;
        total = this.sueldobasico+htotal;
        return total;
    }
    public void Imprimir()
    {
         Console.WriteLine("---- Profesor por Contrato ----");
        Console.WriteLine("Nombre: "+this.nombre);
        Console.WriteLine("Apellido: "+this.apellido);
        Console.WriteLine("Direccion: "+this.direccion);
        Console.WriteLine("Numero de identidad "+this.id);
        Console.WriteLine("El suledo a recibir es de: "+CalcularSueldo()+" $");
    }
}