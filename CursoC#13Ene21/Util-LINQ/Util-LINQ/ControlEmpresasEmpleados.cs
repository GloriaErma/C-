using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util_LINQ
{
    class ControlEmpresasEmpleados
    {
        public List<Empresa> ListaEmpresas;
        public List<Empleado> ListaEmpleados;

        public ControlEmpresasEmpleados()
        {
            ListaEmpresas = new List<Empresa>();
            ListaEmpleados = new List<Empleado>();
            ListaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google" });
            ListaEmpresas.Add(new Empresa { Id = 2, Nombre = "Píldoras Informáticas" });
            ListaEmpleados.Add(new Empleado { Id = 1, Nombre = "Ricardo López", Cargo = "CEO", EmpresaID = 1, Salario = 3000 });
            ListaEmpleados.Add(new Empleado { Id = 2, Nombre = "Juan Díaz", Cargo = "ZEO", EmpresaID = 1, Salario = 1000 });
            ListaEmpleados.Add(new Empleado { Id = 1, Nombre = "Angela López", Cargo = "CEO", EmpresaID = 2, Salario = 4000 });
            ListaEmpleados.Add(new Empleado { Id = 2, Nombre = "Natalia París", Cargo = "ZEO", EmpresaID = 2, Salario = 2000 });
        }
        public void getCEO()
        {
            IEnumerable<Empleado> Ceos = from e in ListaEmpleados where e.Cargo == "CEO" select e;
            foreach (Empleado item in Ceos)
            {
                item.getDatos();
            }
        }
        public void getEmplOrden()
        {
            //IEnumerable<Empleado> Emp = from e in ListaEmpleados orderby e.Nombre select e;
            IEnumerable<Empleado> Emp = from e in ListaEmpleados orderby e.Nombre descending  select e;
            foreach (Empleado item in Emp)
            {
                item.getDatos();
            }
        }
        public void getEmplCeo()
        {
            //IEnumerable<Empleado> Emp = from e in ListaEmpleados orderby e.Nombre select e;
            IEnumerable<Empleado> EmpCeo = from e in ListaEmpleados 
                                        join E in ListaEmpresas 
                                        on e.EmpresaID equals E.Id
                                        where E.Nombre == "Google"
                                           select e;
            foreach (Empleado item in EmpCeo)
            {
                item.getDatos();
            }
        }
        public void getEmplParam(int ID)
        {
            //IEnumerable<Empleado> Emp = from e in ListaEmpleados orderby e.Nombre select e;
            IEnumerable<Empleado> EmpCeo = from e in ListaEmpleados
                                           join E in ListaEmpresas
                                           on e.EmpresaID equals E.Id
                                           where E.Id == ID
                                           select e;
            foreach (Empleado item in EmpCeo)
            {
                item.getDatos();
            }
        }
    }
}
