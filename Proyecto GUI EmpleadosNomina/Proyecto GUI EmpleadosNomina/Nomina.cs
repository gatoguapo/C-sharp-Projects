using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_GUI_EmpleadosNomina
{
    public class Nomina
    {
        private int diasLaborados;
        private int horasExtras;
        private int faltas;
        private int impuestos;
        private int totalNeto;
        private string fechaNomina;

        public Nomina(int diasLaborados, int horasExtras, int faltas, int impuestos, int totalNeto, string fechaNomina)
        {
            this.diasLaborados = diasLaborados;
            this.horasExtras = horasExtras;
            this.faltas = faltas;
            this.impuestos = impuestos;
            this.totalNeto = totalNeto;
            this.fechaNomina = fechaNomina;
        }

        public int pDiasLaborados
        {
            get => diasLaborados;
            set => diasLaborados = value;
        }

        public int pHorasExtras
        {
            get => horasExtras;
            set => horasExtras = value;
        }

        public int pFaltas
        {
            get => faltas;
            set => faltas = value;
        }

        public int pImpuestos
        {
            get => impuestos;
            set => impuestos = value;
        }

        public int pTotalNeto
        {
            get => totalNeto;
            set => totalNeto = value;
        }

        public string pFechaNomina
        {
            get => fechaNomina;
            set => fechaNomina = value;
        }
    }
}
