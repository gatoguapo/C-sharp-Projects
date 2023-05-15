using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_GUI_EmpleadosNomina
{
    public class Nomina
    {
        private int clave;
        private int diasLaborados;
        private int horasExtras;
        private int faltas;
        private double impuestos;
        private double totalBruto;
        private double totalNeto;
        private DateTime fechaNomina;

        public Nomina(){}

        public Nomina(int clave, int diasLaborados, int horasExtras, int faltas)
        {
            this.diasLaborados = diasLaborados;
            this.horasExtras = horasExtras;
            this.faltas = faltas;
            this.clave = clave;
        }

        public int pClave
        {
            get => clave;
            set => clave = value;
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

        public double pImpuestos
        {
            get => impuestos;
            set => impuestos = value;
        }

        public double pTotalBruto
        {
            get => totalBruto;
            set => totalBruto = value;
        }

        public double pTotalNeto
        {
            get => totalNeto;
            set => totalNeto = value;
        }

        public DateTime pFechaNomina
        {
            get => fechaNomina;
            set => fechaNomina = value;
        }
    }
}
