using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_GUI_EmpleadosNomina
{
    public class ManejaRegistroLaboral
    {
        private List<Nomina> listReg = new List<Nomina>();

        public void agregaRegistroLaboral(int clave, int diasLaborados, int horasExtras, int faltas)
        {
            listReg.Add(new Nomina(clave, diasLaborados, horasExtras, faltas));
        }
        
        public List<Nomina> getRegistroDatos()
        {
            return listReg;
        }

        public bool claveDuplicada(int clave)
        {
            return listReg.Exists(cve => cve.Equals(clave));
        }

        public void borraRegistro(int clave)
        {
            if (listReg.Count.Equals(1)) //Si solo existe un registro en la coleccion, la vacia.
            {
                listReg.Clear();
            } 
            else //Si existe mas de uno, guarda los elementos que no cumplan con la condicion en una lista nueva.
            {
                List<Nomina> listAux = listReg.Where(cve => !cve.pClave.Equals(clave)).ToList();

                listReg = listAux; //Y reemplazamos el contenido de la lista nueva en la lista original.
            }
        }

        public void setNomina(int clave, double totalBruto, double impuestos, double totalNeto, DateTime fechaNomina)
        {
            foreach (Nomina nom in listReg)
            {
                if (nom.pClave.Equals(clave))
                {
                    nom.pTotalBruto = totalBruto;
                    nom.pImpuestos = impuestos;
                    nom.pTotalNeto = totalNeto;
                    nom.pFechaNomina = fechaNomina;
                }
            }
        }

        public void borrarNominas()
        {
            foreach (Nomina nom in listReg)
            {
                nom.pTotalBruto = 0;
                nom.pImpuestos = 0;
                nom.pTotalNeto = 0;
                nom.pFechaNomina = new DateTime();
            }
        }

        public void borrarNomina(int clave)
        {
            foreach (Nomina nom in listReg)
            {
                if (nom.pClave.Equals(clave))
                {
                    nom.pTotalBruto = 0;
                    nom.pImpuestos = 0;
                    nom.pTotalNeto = 0;
                    nom.pFechaNomina = new DateTime();
                }
            }
        }
    }
}
