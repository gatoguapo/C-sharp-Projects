using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_GUI_EmpleadosNomina
{
    public class ManejaDepartamentos
    {
        private List<Departamento> listDepartamentos = new List<Departamento>();

        public void agregaDepartamento(int claveDep, string nombreDep, string nombreJefeDep, string estatus)
        {
            listDepartamentos.Add(new Departamento(claveDep, nombreDep, nombreJefeDep, estatus));
        }

        //Metodo para validar que no este duplicada la clave
        public bool buscaClave(int clave)
        {
            return listDepartamentos.Exists(dep => dep.pClaveDepto.Equals(clave)); //El exists devuelve un true si la condicion dep.pClaveDepto.Equals(clave) se cumple y un false si no.
        }

        //Metodo para validar que no este repetido el nombre del departamento.
        public bool buscaNombreDep(string depNombre)
        {
            return listDepartamentos.Exists(dep => dep.pNombreDepto.Equals(depNombre));
        }

        public List<Departamento> getDepartamentos()
        {
            return listDepartamentos;
        }

        public List<Departamento> getDepartamentosActivos()
        {
            //FindAll devuelve la coleccion donde se cumpla la condicion dep.pEstatus.Equals("Activo")
            return listDepartamentos.FindAll(dep => dep.pEstatus.Equals("Activo")); 
        }

        public Departamento RetornaDepto(int clave)
        {
            return listDepartamentos.Find(dep => dep.pClaveDepto.Equals(clave)); //Find busca el elemento que cumpla la condicion dep.pClaveDepto.Equals(clave) y devuelve el objeto si lo encuentra.
        }
    }
}
