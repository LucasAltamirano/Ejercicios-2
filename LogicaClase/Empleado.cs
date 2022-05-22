using System.Text;

namespace Logica
{
    public class Empleado : Usuarios

    {
        public Empleado(int dni, string nombreUsuario, string pass, bool esAdministrador) : base(dni, nombreUsuario, pass, esAdministrador)
        {


        }




        public override string MostrarInfo()
        {

            StringBuilder stringbuilder = new StringBuilder();

            stringbuilder.AppendLine("TIPO DE USUARIO: EMPLEADO");
            stringbuilder.AppendLine($"{ base.MostrarInfo()}");

            return stringbuilder.ToString();
        }


    }
}
