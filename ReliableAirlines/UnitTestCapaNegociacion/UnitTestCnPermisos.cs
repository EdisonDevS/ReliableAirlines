using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CapaNegociacion;

namespace UnitTestCapaNegociacion
{
    [TestClass]
    public class UnitTestCnPermisos
    {
        [TestMethod]
        public void traducirPermisosDeberiaRetornarUnaListaIgual()
        {
            string cadena = "@A";
            List<string> esperaba = new List<string>();

            esperaba.Add("01000000");
            esperaba.Add("01000001");


            CnPermisos permiso = new CnPermisos();
            List<string> lista = permiso.traducirPermisos(cadena);

            CollectionAssert.AreEqual(lista, esperaba);
        }

        [TestMethod]
        public void traducirPermisosDeberiaRetornarUnaListaIgual2()
        {
            string cadena = " A";
            List<string> esperaba = new List<string>();

            esperaba.Add("00100000");
            esperaba.Add("01000001");


            CnPermisos permiso = new CnPermisos();
            List<string> lista = permiso.traducirPermisos(cadena);

            CollectionAssert.AreEqual(lista, esperaba);
        }

    }
}
