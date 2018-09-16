using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;

namespace CapaNegociacion
{
    public class CnAeronaves
    {
        CdAeronaves aeronave = new CdAeronaves();

        public void CrearAeronave(string id, string tipo, int pclase, int claset, string prov, int equi, string adquisicion)
        {
            CnFechas fecha = new CnFechas();
            adquisicion = fecha.convertirAFormatoSQL(adquisicion);
            aeronave.CrearAeronaves(id, tipo, pclase, claset, prov, equi, adquisicion);
        }

        public DataTable ConsultarMatriculas()
        {
            return aeronave.ConsultarMatriculas();
        }

        public DataTable ConsultaPorMatricula(string matricula)
        {
            return aeronave.ConsultaPorMatricula(matricula);
        }

        public void ActualizarDatos(string id, string tipo, int pclase, int claset, string prov, int equi, string adquisicion)
        {
            CnFechas fecha = new CnFechas();
            adquisicion = fecha.convertirAFormatoSQL(adquisicion);
            aeronave.ActualizarDatos(id, tipo, pclase, claset, prov, equi, adquisicion);
        }
    }
}
