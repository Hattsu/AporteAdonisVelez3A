class Profesor
{
    public string nombre {get; set;}
    public string apellido { get; set;}
    public string direccion { get; set;}
    public int id { get; set;}
    public void PedirDatos(string nombre, string apellido, string direccion,int id)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.direccion = direccion;
        this.id = id;
    }
}
