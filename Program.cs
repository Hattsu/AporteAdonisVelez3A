using System;
namespace AporteAdonis3A
{
    class Program
    {
        public static void Main(String[] args)
        {
            ProfesorContrato pcontrato = new ProfesorContrato{hextras = 5};
            pcontrato.PedirDatos("Elsa", "Vera" , "Manta", 1316457657);
            pcontrato.Imprimir();

            ProfesorHoras phoras = new ProfesorHoras{htrabajadas = 15};
            phoras.PedirDatos("Walter", "Garcia","Tarqui",1312457842);
            phoras.Imprimir();

            ProfesorNombramiento pnombramiento = new ProfesorNombramiento();
            pnombramiento.PedirDatos("Jose", "Arteaga","Leonidas Proaño",1315637584);
            pnombramiento.Imprimir();

        }
    }
    
}
