using System.Text;

namespace Logica
{
    
    public abstract class Usuarios
    {
       
        protected int id;
        protected string nombreUsuario;
        protected string pass;
        protected bool esAdministrador;


        #region Constructores
        protected Usuarios(int id, string nombreUsuario, string pass, bool esAdministrador)
        {
            this.id = id;
            this.nombreUsuario = nombreUsuario;
            this.pass = pass;
            this.esAdministrador = esAdministrador;
        }
        #endregion


        #region Propiedades
        public string NombreUsuario
        {
            get { return nombreUsuario; }
        }
        private string Pass
        {
            get { return pass; }
        }

        public bool EsAdministrador
        {
            get
            { return esAdministrador; }
        }

        #endregion


        #region Metodos
        public virtual string MostrarInfo()
        {
            StringBuilder stringbuilder = new StringBuilder();
            stringbuilder.AppendLine($"NOMBRE DE USUARIO :{nombreUsuario} ");
            stringbuilder.AppendLine($"ID DE USUARIO :{id}");

            return stringbuilder.ToString();
        }

        public static bool LogueoDeUsuario(string usuario, string pass)
        {
            bool resultado = false;
            foreach (var usuarioRegistrado in Bar.ListaUsuarios)
            {
                if (usuarioRegistrado.NombreUsuario == usuario && usuarioRegistrado.Pass == pass)
                {

                    resultado = true;
                }
            }

            return resultado;
        }


        public static Usuarios GuardarUsuario(string usuario, string pass)
        {

            foreach (var usuarioRegistrado in Bar.ListaUsuarios)
            {
                if (usuarioRegistrado.NombreUsuario == usuario && usuarioRegistrado.Pass == pass)
                {

                    return usuarioRegistrado;
                }
            }

            return null;
        }



        /// <summary>
        ///  Devolvera true si el usuario es del tipo administrador o false si es de tipo empleado.
        /// </summary>
        /// <param name="user"> tipo Usuario </param>
        /// <returns></returns>
        public static bool TipoUsuario(Usuarios user)
        {
            bool retorno = false;

            if (user.EsAdministrador)
            {
                return true;
            }

            return retorno;

        }


        #endregion



    }//end class
}//end namespace
